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
    public partial class FormAgregarMozo : Form
    {
        public FormAgregarMozo()
        {
            InitializeComponent();

            // Agregar el texto predeterminado al TextBox
            tbNombre.Text = "Ingresar nombre de mozo";
            tbNombre.ForeColor = Color.Gray;

            // Asociar eventos al TextBox
            tbNombre.Enter += TbNombre_Enter;
            tbNombre.Leave += TbNombre_Leave;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "Ingresar nombre de mozo")
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarMozo_Load(object sender, EventArgs e)
        {

        }

        private void TbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text == "Ingresar nombre de mozo")
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = SystemColors.ControlText;
            }
        }

        private void TbNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                tbNombre.Text = "Ingresar nombre de mozo";
                tbNombre.ForeColor = Color.Gray;
            }
        }
    }
}