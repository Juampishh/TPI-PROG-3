using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Mesas;

namespace WinFormsApp1
{
    public partial class PrevisualizacionForm : Form
    {
        private List<ControlState> estadoControles;
        public PrevisualizacionForm(ref List<ControlState> estadoControles)
        {
            InitializeComponent();


            this.estadoControles = estadoControles; // Recibe los controles de la lista

            CargarControles();

        }
        private void CargarControles()
        {
            panelPlano.Controls.Clear();

            foreach (ControlState estado in estadoControles)
            {
                Control control = null;
                if (estado.Tipo == nameof(Pared))
                {
                    control = new Pared
                    {
                        Location = new Point(estado.X, estado.Y),
                        Width = estado.Ancho,
                        Height = estado.Alto,
                        BackColor = Color.FromName(estado.ColorFondo)
                    };
                }
                else if (estado.Tipo == nameof(Mesa_para_2))
                {
                    control = new Mesa_para_2
                    {
                        Location = new Point(estado.X, estado.Y)
                    };
                }
                else if (estado.Tipo == nameof(Mesa_para_4))
                {
                    control = new Mesa_para_4
                    {
                        Location = new Point(estado.X, estado.Y)
                    };
                }
                else if (estado.Tipo == nameof(Mesa_para_6))
                {
                    control = new Mesa_para_6
                    {
                        Location = new Point(estado.X, estado.Y)
                    };
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
                if (control is Pared pared)
                {
                    pared.ModoPrevisualizacion();
                }
            }
        }


        private void VolverButtom_Click(object sender, EventArgs e)
        {
            Menuop menuop = new Menuop();
            menuop.Show();
            this.Hide();
        }

        private void PrevisualizacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menuop menuop = new Menuop();
            menuop.Show();
            this.Hide();
        }
    }
}
