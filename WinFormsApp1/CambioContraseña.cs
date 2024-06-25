using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class CambioContraseña : Form
    {
        private const string CredentialsFilePath = "credentials.json";
        private Credentials credentials;

        public CambioContraseña()
        {
            InitializeComponent();
            ConfigureForm();
            LoadCredentials();
        }

        private void ConfigureForm()
        {
            this.Text = "Cambio de Contraseña";
            this.BackColor = Color.FromArgb(240, 240, 240);

            SetupTextBox(txtUsuario, "Usuario");
            SetupTextBox(txtContraseñaActual, "Contraseña actual");
            SetupTextBox(txtNuevaContraseña, "Nueva contraseña");
            SetupTextBox(txtConfirmarContraseña, "Confirmar nueva contraseña");

            btnCambiarContraseña.Click += BtnCambiarContraseña_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void LoadCredentials()
        {
            if (File.Exists(CredentialsFilePath))
            {
                var json = File.ReadAllText(CredentialsFilePath);
                credentials = JsonConvert.DeserializeObject<Credentials>(json);
            }
            else
            {
                credentials = new Credentials { Username = "usuario", Password = "contraseña" };
                SaveCredentials();
            }
        }

        private void SaveCredentials()
        {
            var json = JsonConvert.SerializeObject(credentials);
            File.WriteAllText(CredentialsFilePath, json);
        }

        // (Los métodos de TextBox_Enter, TextBox_Leave, etc. permanecen iguales)

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (ChangePassword())
                {
                    MessageBox.Show("Contraseña cambiada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Volver al formulario de Login
                    Login loginForm = new Login();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo cambiar la contraseña. Verifique sus credenciales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInputs()
        {
            if (txtUsuario.Text == "Usuario" || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtContraseñaActual.Text == "Contraseña actual" || string.IsNullOrWhiteSpace(txtContraseñaActual.Text))
            {
                MessageBox.Show("Por favor, ingrese su contraseña actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNuevaContraseña.Text == "Nueva contraseña" || string.IsNullOrWhiteSpace(txtNuevaContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese su nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtConfirmarContraseña.Text == "Confirmar nueva contraseña" || string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show("Por favor, confirme su nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNuevaContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las nuevas contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool ChangePassword()
        {
            if (txtUsuario.Text == credentials.Username && txtContraseñaActual.Text == credentials.Password)
            {
                credentials.Password = txtNuevaContraseña.Text;
                SaveCredentials();
                return true;
            }
            return false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            // Volver al formulario de Login
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {

        }
        private void SetupTextBox(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Silver;
            textBox.MouseEnter += TextBox_MouseEnter;
            textBox.MouseLeave += TextBox_MouseLeave;
            textBox.Tag = placeholderText;

            if (placeholderText.Contains("Contraseña"))
            {
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox.Tag.ToString().Contains("Contraseña"))
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.Silver;
                if (textBox.Tag.ToString().Contains("Contraseña"))
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }
    }
}