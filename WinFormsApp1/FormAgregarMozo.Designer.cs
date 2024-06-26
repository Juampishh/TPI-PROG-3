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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCrearMozo
            // 
            lblCrearMozo.Anchor = AnchorStyles.None;
            lblCrearMozo.AutoSize = true;
            lblCrearMozo.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline);
            lblCrearMozo.ForeColor = Color.SaddleBrown;
            lblCrearMozo.Location = new Point(12, 22);
            lblCrearMozo.Name = "lblCrearMozo";
            lblCrearMozo.Size = new Size(205, 38);
            lblCrearMozo.TabIndex = 2;
            lblCrearMozo.Text = "Crear Mozo:";
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.LightSalmon;
            btAceptar.FlatStyle = FlatStyle.Popup;
            btAceptar.Location = new Point(282, 200);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(97, 23);
            btAceptar.TabIndex = 3;
            btAceptar.Text = "Crear Mozo";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.LightSalmon;
            btCancelar.FlatStyle = FlatStyle.Popup;
            btCancelar.Location = new Point(397, 200);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(97, 23);
            btCancelar.TabIndex = 4;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(220, 122);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(262, 23);
            tbNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(12, 122);
            label1.Name = "label1";
            label1.Size = new Size(202, 19);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el nombre del mozo:";
            // 
            // FormAgregarMozo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(518, 238);
            Controls.Add(label1);
            Controls.Add(tbNombre);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Controls.Add(lblCrearMozo);
            Name = "FormAgregarMozo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarMozo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearMozo;
        private Button btAceptar;
        private Button btCancelar;
        private Label label1;
        public TextBox tbNombre;
    }
}