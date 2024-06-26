namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            Ingresar = new Button();
            Usuario = new TextBox();
            Contraseña = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 388);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 34);
            label1.Name = "label1";
            label1.Size = new Size(118, 38);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(344, 253);
            Ingresar.Margin = new Padding(3, 2, 3, 2);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(182, 36);
            Ingresar.TabIndex = 3;
            Ingresar.Text = "INGRESAR";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // Usuario
            // 
            Usuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.Location = new Point(303, 110);
            Usuario.Margin = new Padding(3, 2, 3, 2);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(259, 30);
            Usuario.TabIndex = 6;
            Usuario.Text = "Usuario";
            Usuario.TextChanged += Usuario_TextChanged;
            Usuario.MouseEnter += Usuario_MouseEnter;
            Usuario.MouseLeave += Usuario_MouseLeave;
            // 
            // Contraseña
            // 
            Contraseña.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(303, 158);
            Contraseña.Margin = new Padding(3, 2, 3, 2);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(259, 30);
            Contraseña.TabIndex = 7;
            Contraseña.Text = "Contraseña";
            Contraseña.UseSystemPasswordChar = true;
            Contraseña.MouseEnter += Contraseña_MouseEnter;
            Contraseña.MouseLeave += Contraseña_MouseLeave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(370, 302);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cambiar Contraseña";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(674, 388);
            Controls.Add(linkLabel1);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Controls.Add(Ingresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Ingresar;
        private TextBox Usuario;
        private TextBox Contraseña;
        private LinkLabel linkLabel1;
    }
}