using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormVerPedidos : Form
    {
        public FormVerPedidos()
        {
            InitializeComponent();

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            listBox1.Items.Clear();
            label2.Text = $"$0.00";
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        
    }
}
