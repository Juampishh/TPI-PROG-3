﻿using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private const string CredentialsFilePath = "credentials.json";
        private Credentials credentials;
        public Menuop menu;

        public Login()
        {
            InitializeComponent();
            LoadCredentials();
            menu = new Menuop();
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void OnPasswordChanged(object sender, EventArgs e)
        {
            SaveCredentials();
        }

        private void Usuario_MouseEnter(object sender, EventArgs e)
        {
            if (Usuario.Text == "Usuario")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Color.Black;
            }
        }

        private void Usuario_MouseLeave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "Usuario";
                Usuario.ForeColor = Color.Silver;
            }
        }

        private void Contraseña_MouseEnter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "Contraseña")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Color.Black;
            }
        }

        private void Contraseña_MouseLeave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "Contraseña";
                Contraseña.ForeColor = Color.Silver;
            }
        }

        public void Ingresar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text == credentials.Username && Contraseña.Text == credentials.Password)
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CambioContraseña contraseñanueva = new CambioContraseña())
            {
                contraseñanueva.OnPasswordChanged += credentials => {
                    this.credentials = credentials; // Actualizar las credenciales
                };

                if (contraseñanueva.ShowDialog() == DialogResult.OK)
                {
                    // No es necesario volver a cargar las credenciales aquí
                }
            }
        }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
