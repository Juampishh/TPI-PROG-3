using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TokenVerificationForm : Form
    {
        private string sentToken;

        public TokenVerificationForm(string token)
        {
            InitializeComponent();
            sentToken = token;
        }

        private void buttonVerifyToken_Click(object sender, EventArgs e)
        {
            if (textBoxToken.Text == sentToken)
            {
                MessageBox.Show("Token verificado correctamente. Ahora puedes cambiar tu contraseña.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var passwordChangeForm = new PasswordChangeForm();
                passwordChangeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Token incorrecto. Inténtalo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
