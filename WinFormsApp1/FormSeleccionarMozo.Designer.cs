namespace WinFormsApp1
{
    partial class FormSeleccionarMozo
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
            panel1 = new Panel();
            panel2 = new Panel();
            btCancelar = new Button();
            btAceptar = new Button();
            btAsignarMesa = new Button();
            label1 = new Label();
            tbNumeroMesa = new TextBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCrearMozo
            // 
            lblCrearMozo.Anchor = AnchorStyles.None;
            lblCrearMozo.AutoSize = true;
            lblCrearMozo.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline);
            lblCrearMozo.ForeColor = Color.SaddleBrown;
            lblCrearMozo.Location = new Point(20, 9);
            lblCrearMozo.Name = "lblCrearMozo";
            lblCrearMozo.Size = new Size(329, 38);
            lblCrearMozo.TabIndex = 3;
            lblCrearMozo.Text = "Seleccione el mozo:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCrearMozo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 75);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(btCancelar);
            panel2.Controls.Add(btAceptar);
            panel2.Controls.Add(btAsignarMesa);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbNumeroMesa);
            panel2.Controls.Add(listBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 148);
            panel2.TabIndex = 5;
            // 
            // btCancelar
            // 
            btCancelar.FlatStyle = FlatStyle.Popup;
            btCancelar.Location = new Point(401, 113);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(75, 23);
            btCancelar.TabIndex = 5;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btAceptar
            // 
            btAceptar.FlatStyle = FlatStyle.Popup;
            btAceptar.Location = new Point(320, 113);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(75, 23);
            btAceptar.TabIndex = 4;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            btAceptar.Click += btAceptar_Click;
            // 
            // btAsignarMesa
            // 
            btAsignarMesa.FlatStyle = FlatStyle.Popup;
            btAsignarMesa.Font = new Font("Consolas", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btAsignarMesa.Location = new Point(239, 35);
            btAsignarMesa.Name = "btAsignarMesa";
            btAsignarMesa.Size = new Size(237, 23);
            btAsignarMesa.TabIndex = 3;
            btAsignarMesa.Text = "Asignar Mesa";
            btAsignarMesa.UseVisualStyleBackColor = true;
            btAsignarMesa.Click += btAsignarMesa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9.5F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 16);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el numero de mesa";
            // 
            // tbNumeroMesa
            // 
            tbNumeroMesa.Location = new Point(409, 6);
            tbNumeroMesa.Name = "tbNumeroMesa";
            tbNumeroMesa.Size = new Size(67, 23);
            tbNumeroMesa.TabIndex = 1;
            tbNumeroMesa.KeyPress += textBoxNumerico_KeyPress;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Lucida Sans", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 137);
            listBox1.TabIndex = 0;
            // 
            // FormSeleccionarMozo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(488, 223);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(508, 266);
            Name = "FormSeleccionarMozo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeleccionarMozo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCrearMozo;
        private Panel panel1;
        private Panel panel2;
        private ListBox listBox1;
        private Button btCancelar;
        private Button btAceptar;
        private Button btAsignarMesa;
        private Label label1;
        private TextBox tbNumeroMesa;
    }
}