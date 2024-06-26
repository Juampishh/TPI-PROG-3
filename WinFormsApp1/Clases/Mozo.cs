using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Clases
{
    public class Mozo
    {
        public string Nombre;
        public List<int> mesas;

        public Mozo() { }
        public Mozo(string nombre) 
        {
            Nombre = nombre; 
            mesas = new List<int>();
        }

        public override string ToString()
        {
            string mesasStr = string.Join(", ", mesas);
            return $"Mozo: {Nombre}, \tMesas: [{mesasStr}]";
        }
    }
}
