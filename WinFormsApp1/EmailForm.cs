using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmailForm : Form
    {
        private string generatedToken;

        public EmailForm()
        {
            InitializeComponent();
        }

        private void buttonSendToken_Click(object sender, EventArgs e)
        {
            // Generar token
            generatedToken = Guid.NewGuid().ToString().Substring(0, 6);

            // Enviar correo electrónico con el token
            string email = textBoxEmail.Text;
            SendTokenEmail(email, generatedToken);

            MessageBox.Show("Token enviado al correo proporcionado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir formulario de verificación de token
            var tokenForm = new TokenVerificationForm(generatedToken);
            tokenForm.Show();
            this.Hide();
        }

        private void SendTokenEmail(string email, string token)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.example.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("lautarosanche@gmail.com", "your-password"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("lautarosanche@gmail.com", "43932639pasajealem"),
                    Subject = "Token de recuperación de contraseña",
                    Body = $"Tu token de recuperación es: {token}",
                    IsBodyHtml = false,
                };

                mailMessage.To.Add(email);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
