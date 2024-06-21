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
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 517);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(423, 46);
            label1.Name = "label1";
            label1.Size = new Size(151, 49);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // Ingresar
            // 
            Ingresar.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ingresar.Location = new Point(384, 337);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(208, 40);
            Ingresar.TabIndex = 3;
            Ingresar.Text = "INGRESAR";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += Ingresar_Click;
            // 
            // Usuario
            // 
            Usuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.Location = new Point(346, 147);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(295, 36);
            Usuario.TabIndex = 6;
            Usuario.Text = "Usuario";
            Usuario.MouseEnter += Usuario_MouseEnter;
            Usuario.MouseLeave += Usuario_MouseLeave;
            // 
            // Contraseña
            // 
            Contraseña.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(346, 210);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(295, 36);
            Contraseña.TabIndex = 7;
            Contraseña.Text = "Contraseña";
            Contraseña.MouseEnter += Contraseña_MouseEnter;
            Contraseña.MouseLeave += Contraseña_MouseLeave;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(393, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ha olvidado su contraseña?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(770, 517);
            Controls.Add(linkLabel1);
            Controls.Add(Contraseña);
            Controls.Add(Usuario);
            Controls.Add(Ingresar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            Opacity = 0.9D;
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