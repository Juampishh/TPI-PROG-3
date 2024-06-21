using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PasswordChangeForm : Form
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = textBoxNewPassword.Text;

            // Guardar la nueva contraseña en un archivo JSON
            var userData = new { username = "usuario", password = newPassword };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(userData, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("user_data.json", json);

            MessageBox.Show("Contraseña cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mostrar el formulario de inicio de sesión
            var loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
