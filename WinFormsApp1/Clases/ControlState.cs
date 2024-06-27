using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Mesas;

namespace WinFormsApp1.Clases
{
    public class ControlState
    {
        public string Tipo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public string Color { get; set; }
        public int Numero { get; set; }
        public int ColorFondoArgb { get; set; }
        public string Texto {  get; set; }
        public decimal Monto { get; set; }
        public List<Pedidos> Pedidos { get; set; } = new List<Pedidos>();
        public ControlState() { }

        public static ControlState SerializarMesa2(Mesa_para_2 mesa2)
        {

            ControlState estado = new ControlState();
            estado.Tipo = nameof(Mesa_para_2);
            estado.X = mesa2.Location.X;
            estado.Y = mesa2.Location.Y;
            estado.Numero = mesa2.mesaNumber;
            estado.Color = mesa2.color;
            estado.Monto = mesa2.montoFinal;
            estado.Pedidos = mesa2.pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();


            return estado;
        }

        public static ControlState SerializarMesa4(Mesa_para_4 mesa4)
        {

            ControlState estado = new ControlState();
            estado.Tipo = nameof(Mesa_para_4);
            estado.X = mesa4.Location.X;
            estado.Y = mesa4.Location.Y;
            estado.Numero = mesa4.mesaNumber;
            estado.Color = mesa4.color;
            estado.Monto = mesa4.montoFinal;
            estado.Pedidos = mesa4.pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();


            return estado;
        }

        public static ControlState SerializarMesa6(Mesa_para_6 mesa6)
        {

            ControlState estado = new ControlState();
            estado.Tipo = nameof(Mesa_para_6);
            estado.X = mesa6.Location.X;
            estado.Y = mesa6.Location.Y;
            estado.Numero = mesa6.mesaNumber;
            estado.Color = mesa6.color;
            estado.Monto = mesa6.montoFinal;
            estado.Pedidos = mesa6.pedidos.Select(p => new Pedidos(p.Producto, p.Cantidad, p.PrecioUnitario, p.Categoria) { Pagado = p.Pagado }).ToList();

            return estado;
        }

        public static ControlState SerilizarPared(Pared pared)
        {

            ControlState estado = new ControlState();

            estado.Tipo = nameof(Pared);
            estado.X = pared.Location.X;
            estado.Y = pared.Location.Y;
            estado.Alto = pared.Height;
            estado.Ancho = pared.Width;
            estado.ColorFondoArgb = pared.BackColor.ToArgb();
            estado.Texto = pared.Text;

            return estado;
        }

        public static ControlState SerilizarBarra(Barra barra)
        {
            ControlState estado = new ControlState();
            estado.Tipo = nameof(Barra);
            estado.X = barra.Location.X;
            estado.Y = barra.Location.Y;
            estado.Alto = barra.Height;
            estado.Ancho = barra.Width;

            return estado;
        }

        public static ControlState SerilizarBaño(Baño baño)
        {
            ControlState estado = new ControlState();
            estado.Tipo = nameof(Baño);
            estado.X = baño.Location.X;
            estado.Y = baño.Location.Y;
            estado.Alto = baño.Height;
            estado.Ancho = baño.Width;
            return estado;
        }


    }
}
