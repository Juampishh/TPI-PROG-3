using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class ControlState
    {
        public string Tipo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public string ColorFondo { get; set; }

        public ControlState() { }
        public ControlState(string tipo, int x, int y)
        {
            Tipo = tipo;
            X = x;
            Y = y;

        }
        public ControlState(string tipo, int x, int y, int alto, int ancho)
        {
            Tipo = tipo;
            X = x;
            Y = y;
            Alto = alto;
            Ancho = ancho;

        }
        public ControlState(string tipo, int x, int y, int alto, int ancho, string colorFondo)
        {
            Tipo = tipo;
            X = x;
            Y = y;
            Alto = alto;
            Ancho = ancho;
            ColorFondo = colorFondo;
        }


    }
}
