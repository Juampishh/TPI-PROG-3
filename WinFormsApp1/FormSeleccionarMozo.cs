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

namespace WinFormsApp1
{
    public partial class FormSeleccionarMozo : Form
    {
        public PrevisualizacionForm prev;
        public List<Mozo> mozos;
        public FormSeleccionarMozo(List<Mozo> m)
        {
            this.mozos = m;
            InitializeComponent();
            refrescar();

        }
        public void refrescar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = mozos;
        }

        private void btAsignarMesa_Click(object sender, EventArgs e)
        {
            
                if (listBox1.SelectedItems != null)
                {
                    Mozo mozoAux = (Mozo)listBox1.SelectedItem;
                    if (int.Parse(tbNumeroMesa.Text) > 0)
                    {
                        mozoAux.mesas.Add(int.Parse(tbNumeroMesa.Text));
                        foreach (Mozo mozo in mozos)
                        {
                            if (mozo.Nombre == mozoAux.Nombre)
                            {
                                mozo.mesas = mozoAux.mesas;
                                break;
                            }
                        }
                    tbNumeroMesa.Text = "";
                    }
                    refrescar();
                }
        }

        private void textBoxNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número y no es la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la pulsación de tecla
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
