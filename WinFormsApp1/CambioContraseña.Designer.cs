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
            txtUsuario.Location = new Point(50, 62);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(300, 32);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseñaActual.Location = new Point(50, 125);
            txtContraseñaActual.Margin = new Padding(3, 4, 3, 4);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(300, 32);
            txtContraseñaActual.TabIndex = 1;
            txtContraseñaActual.UseSystemPasswordChar = true;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNuevaContraseña.Location = new Point(50, 188);
            txtNuevaContraseña.Margin = new Padding(3, 4, 3, 4);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(300, 32);
            txtNuevaContraseña.TabIndex = 2;
            txtNuevaContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarContraseña.Location = new Point(50, 250);
            txtConfirmarContraseña.Margin = new Padding(3, 4, 3, 4);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(300, 32);
            txtConfirmarContraseña.TabIndex = 3;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarContraseña.Location = new Point(50, 338);
            btnCambiarContraseña.Margin = new Padding(3, 4, 3, 4);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(300, 50);
            btnCambiarContraseña.TabIndex = 4;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += BtnCambiarContraseña_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(50, 400);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(300, 50);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CambioContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(400, 500);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseñaActual);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CambioContraseña";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de Contraseña";
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