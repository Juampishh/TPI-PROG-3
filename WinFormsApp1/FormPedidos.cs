using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Clases;

namespace WinFormsApp1
{
    public partial class FormPedidos : Form
    {
        private List<Pedidos> menuCompleto;
        private List<Pedidos> pedidoActual = new List<Pedidos>();
        private decimal montoTotal = 0;

        public FormPedidos()
        {
            InitializeComponent();
            menuCompleto = Pedidos.ObtenerMenuCompleto();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            // Llenar la lista de categorías
            listaCategorias.Items.AddRange(menuCompleto.Select(p => p.Categoria).Distinct().ToArray());

            // Eventos
            listaCategorias.SelectedIndexChanged += ListaCategorias_SelectedIndexChanged;
            btnAgregar.Click += BtnAgregar_Click;
        }

        private void ListaCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaCategorias.SelectedItem != null)
            {
                string categoriaSeleccionada = listaCategorias.SelectedItem.ToString();
                listaProductos.Items.Clear();
                listaProductos.Items.AddRange(
                    menuCompleto.Where(p => p.Categoria == categoriaSeleccionada)
                                .Select(p => $"{p.Producto} - ${p.PrecioUnitario}")
                                .ToArray());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (listaProductos.SelectedItem != null)
            {
                string productoSeleccionado = listaProductos.SelectedItem.ToString().Split('-')[0].Trim();
                Pedidos pedidoSeleccionado = menuCompleto.First(p => p.Producto == productoSeleccionado);

                Pedidos pedidoExistente = pedidoActual.FirstOrDefault(p => p.Producto == productoSeleccionado);
                if (pedidoExistente != null)
                {
                    pedidoExistente.Cantidad++;
                }
                else
                {
                    pedidoActual.Add(new Pedidos(pedidoSeleccionado.Producto, 1, pedidoSeleccionado.PrecioUnitario, pedidoSeleccionado.Categoria));
                }

                montoTotal += pedidoSeleccionado.PrecioUnitario;
                ActualizarListaPedido();
            }
        }

        private void ActualizarListaPedido()
        {
            listaPedido.Items.Clear();
            foreach (var pedido in pedidoActual)
            {
                listaPedido.Items.Add($"{pedido.Producto} x{pedido.Cantidad} - ${pedido.PrecioUnitario * pedido.Cantidad}");
            }
            lblMontoTotal.Text = $"Monto Total: ${montoTotal:F2}";
        }
    }
}