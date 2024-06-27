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
        public event Action<Credentials> OnPasswordChanged; // Evento para notificar cambios de contraseña

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

            SetupTextBox(txtUsuario, "Usuario", false);
            SetupTextBox(txtContraseñaActual, "Contraseña actual", true);
            SetupTextBox(txtNuevaContraseña, "Nueva contraseña", true);
            SetupTextBox(txtConfirmarContraseña, "Confirmar nueva contraseña", true);

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

        private void BtnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (ChangePassword())
                {
                    MessageBox.Show("Contraseña cambiada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnPasswordChanged?.Invoke(credentials); // Notificar el cambio de contraseña
                    DialogResult = DialogResult.OK;
                    return; // Asegurar que no se muestra el mensaje de error después del éxito
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
            DialogResult = DialogResult.Cancel;
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {
        }

        private void SetupTextBox(TextBox textBox, string placeholderText, bool isPassword)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (s, e) => TextBox_Enter(textBox, placeholderText, isPassword);
            textBox.Leave += (s, e) => TextBox_Leave(textBox, placeholderText, isPassword);
            textBox.Tag = placeholderText;

            if (isPassword)
            {
                textBox.UseSystemPasswordChar = false;
            }
        }

        private void TextBox_Enter(TextBox textBox, string placeholderText, bool isPassword)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (isPassword)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }

        private void TextBox_Leave(TextBox textBox, string placeholderText, bool isPassword)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
                if (isPassword)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void CambioContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
