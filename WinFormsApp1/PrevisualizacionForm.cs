using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Clases;
using WinFormsApp1.Mesas;

namespace WinFormsApp1
{
    public partial class PrevisualizacionForm : Form
    {
        private List<ControlState> estadoControles;
        public List<Mozo> mozos;
        public PrevisualizacionForm(ref List<ControlState> estadoControles)
        {
            InitializeComponent();


            this.estadoControles = estadoControles; // Recibe los controles de la lista
            mozos = new List<Mozo>();
            RefrescarListMozos();

        }

        private void agregarMozo_Click(object sender, EventArgs e)
        {
            AgregarMozo();
        }
        private void AgregarMozo()
        {
            FormAgregarMozo formAgregarMozo = new FormAgregarMozo();
            DialogResult dialogResult = formAgregarMozo.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                mozos.Add(new Mozo(formAgregarMozo.tbNombre.Text));
                RefrescarListMozos();
            }


        }
        private void RefrescarListMozos()
        {
            listMozos.DataSource = null;
            listMozos.DataSource = mozos;

        }
        public void ActualizarControles(List<ControlState> nuevosControles)
        {
            estadoControles = new List<ControlState>(nuevosControles);
            CargarControles();
        }
        public void CargarControles()
        {
            panelPlano.Controls.Clear();

            foreach (ControlState estado in estadoControles)
            {
                Control control = null;
                if (estado.Tipo == nameof(Pared))
                {
                    control = new Pared();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;
                    control.BackColor = Color.FromName(estado.Color);


                }
                else if (estado.Tipo == nameof(Mesa_para_2))
                {
                    Mesa_para_2 mesa = new Mesa_para_2();

                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos;
                    mesa.montoFinal = estado.Monto;

                    panelPlano.Controls.Add(mesa);


                }
                else if (estado.Tipo == nameof(Mesa_para_4))
                {
                    Mesa_para_4 mesa = new Mesa_para_4();
                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos;
                    mesa.montoFinal = estado.Monto;

                    panelPlano.Controls.Add(mesa);

                }
                else if (estado.Tipo == nameof(Mesa_para_6))
                {
                    Mesa_para_6 mesa = new Mesa_para_6();
                    mesa.Location = new Point(estado.X, estado.Y);
                    mesa.CambiarColorMesa(estado.Color);
                    mesa.mesaNumber = estado.Numero;
                    mesa.pedidos = estado.Pedidos;
                    mesa.montoFinal = estado.Monto;

                    panelPlano.Controls.Add(mesa);
                }
                else if (estado.Tipo == nameof(Baño))
                {
                    control = new Baño();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;

                }
                else if (estado.Tipo == nameof(Barra))
                {
                    control = new Barra();
                    control.Location = new Point(estado.X, estado.Y);
                    control.Width = estado.Ancho;
                    control.Height = estado.Alto;
                }

                if (control != null)
                {
                    panelPlano.Controls.Add(control);

                }

            }

            foreach (Control control in panelPlano.Controls)
            {
                if (control is IEventos eventos)
                {
                    eventos.ModoPrevisualizacion();
                }
            }
        }

        private void GuardarControles()
        {
            List<ControlState> nuevosControles = new List<ControlState>();
            foreach (Control control in panelPlano.Controls)
            {
                if (control is Pared pared)
                {
                    ControlState estado = ControlState.SerilizarPared(pared);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_2 mesa2)
                {
                    ControlState estado = ControlState.SerializarMesa2(mesa2);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_4 mesa4)
                {
                    ControlState estado = ControlState.SerializarMesa4(mesa4);
                    nuevosControles.Add(estado);
                }
                else if (control is Mesa_para_6 mesa6)
                {
                    ControlState estado = ControlState.SerializarMesa6(mesa6);
                    nuevosControles.Add(estado);
                }
                else if (control is Barra barra)
                {
                    ControlState estado = ControlState.SerilizarBarra(barra);
                    nuevosControles.Add(estado);
                }
                else if (control is Baño baño)
                {
                    ControlState estado = ControlState.SerilizarBaño(baño);
                    nuevosControles.Add(estado);
                }
            }

            estadoControles = nuevosControles;
            ((Menuop)this.Owner).ActualizarEstadoControles(estadoControles);
        }

        private void VolverButtom_Click(object sender, EventArgs e)
        {
            GuardarControles();
            this.Hide();
        }

        private void PrevisualizacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
        }

        private void btAsignarMozo_Click(object sender, EventArgs e)
        {
            if (mozos.Count > 0)
            {
                FormSeleccionarMozo formSeleccionarMozo = new FormSeleccionarMozo(mozos);
                DialogResult dialogResult = formSeleccionarMozo.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    mozos = formSeleccionarMozo.mozos;
                    RefrescarListMozos();

                }
            }
            else
            {
                MessageBox.Show("No hay mozos disponibles");
            }
        }

        private void btEliminarMozo_Click(object sender, EventArgs e)
        {
            if (listMozos.SelectedItems != null)
            {
                Mozo mozoAux = (Mozo)listMozos.SelectedItem;

                foreach (Mozo mozo in mozos)
                {
                    if (mozo.Nombre == mozoAux.Nombre)
                    {
                        mozos.Remove(mozo);
                        RefrescarListMozos();
                        return;
                    }
                }
            }
        }
    }
}
