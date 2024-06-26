namespace WinFormsApp1
{
    partial class CambioContraseña
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContraseñaActual = new TextBox();
            txtNuevaContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            btnCambiarContraseña = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(44, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(263, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaActual.Location = new Point(44, 94);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(263, 27);
            txtContraseñaActual.TabIndex = 1;
            txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuevaContraseña.Location = new Point(44, 141);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(263, 27);
            txtNuevaContraseña.TabIndex = 2;
            txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarContraseña.Location = new Point(44, 188);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(263, 27);
            txtConfirmarContraseña.TabIndex = 3;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarContraseña.Location = new Point(44, 254);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(262, 38);
            btnCambiarContraseña.TabIndex = 4;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += BtnCambiarContraseña_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(44, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(262, 38);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // CambioContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(350, 375);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseñaActual);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(btnCancelar);
            Name = "CambioContraseña";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de Contraseña";
            FormClosing += CambioContraseña_FormClosing;
            Load += CambioContraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnCancelar;
    }
}