namespace WinFormsApp1
{
    partial class FormAgregarMozo
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
            lblCrearMozo = new Label();
            btAceptar = new Button();
            btCancelar = new Button();
            tbNombre = new TextBox();
            SuspendLayout();
            // 
            // lblCrearMozo
            // 
            lblCrearMozo.Anchor = AnchorStyles.None;
            lblCrearMozo.AutoSize = true;
            lblCrearMozo.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCrearMozo.ForeColor = Color.Snow;
            lblCrearMozo.Location = new Point(37, 57);
            lblCrearMozo.Name = "lblCrearMozo";
            lblCrearMozo.Size = new Size(238, 44);
            lblCrearMozo.TabIndex = 2;
            lblCrearMozo.Text = "Crear Mozo:";
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.DimGray;
            btAceptar.FlatStyle = FlatStyle.Popup;
            btAceptar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAceptar.ForeColor = Color.Snow;
            btAceptar.Location = new Point(304, 222);
            btAceptar.Margin = new Padding(3, 4, 3, 4);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(111, 31);
            btAceptar.TabIndex = 3;
            btAceptar.Text = "Crear Mozo";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.DimGray;
            btCancelar.FlatStyle = FlatStyle.Popup;
            btCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.ForeColor = Color.Snow;
            btCancelar.Location = new Point(435, 222);
            btCancelar.Margin = new Padding(3, 4, 3, 4);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(111, 31);
            btCancelar.TabIndex = 4;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(37, 133);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(509, 27);
            tbNombre.TabIndex = 5;
            // 
            // FormAgregarMozo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(590, 307);
            Controls.Add(tbNombre);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Controls.Add(lblCrearMozo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(608, 354);
            MinimizeBox = false;
            MinimumSize = new Size(608, 354);
            Name = "FormAgregarMozo";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarMozo";
            Load += FormAgregarMozo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearMozo;
        private Button btAceptar;
        private Button btCancelar;
        public TextBox tbNombre;
    }
}