namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnBarra = new Button();
            btnBaño = new Button();
            pictureBox2 = new PictureBox();
            btnAddPared = new Button();
            agregarMesaButton = new Button();
            panel2 = new Panel();
            btnGuardar = new Button();
            VolverButtom = new Button();
            btnSalir = new Button();
            panelPlano = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnBarra);
            panel1.Controls.Add(btnBaño);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAddPared);
            panel1.Controls.Add(agregarMesaButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 613);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 100);
            panel1.TabIndex = 0;
            // 
            // btnBarra
            // 
            btnBarra.Location = new Point(736, 17);
            btnBarra.Margin = new Padding(5, 6, 5, 6);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(129, 45);
            btnBarra.TabIndex = 6;
            btnBarra.Text = "Agregar Barra";
            btnBarra.UseVisualStyleBackColor = true;
            btnBarra.Click += btnBarra_Click;
            // 
            // btnBaño
            // 
            btnBaño.Location = new Point(513, 17);
            btnBaño.Margin = new Padding(5, 6, 5, 6);
            btnBaño.Name = "btnBaño";
            btnBaño.Size = new Size(133, 45);
            btnBaño.TabIndex = 5;
            btnBaño.Text = "Agregar Baño";
            btnBaño.UseVisualStyleBackColor = true;
            btnBaño.Click += btnBaño_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(925, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 100);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnAddPared
            // 
            btnAddPared.Location = new Point(280, 17);
            btnAddPared.Name = "btnAddPared";
            btnAddPared.Size = new Size(133, 45);
            btnAddPared.TabIndex = 4;
            btnAddPared.Text = "Agregar Pared";
            btnAddPared.UseVisualStyleBackColor = true;
            btnAddPared.Click += btnAddPared_Click;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Location = new Point(60, 17);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(132, 45);
            agregarMesaButton.TabIndex = 3;
            agregarMesaButton.Text = "Agregar Mesa";
            agregarMesaButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(VolverButtom);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(922, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 613);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 63);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(111, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // VolverButtom
            // 
            VolverButtom.Location = new Point(3, 22);
            VolverButtom.Margin = new Padding(3, 2, 3, 2);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(111, 22);
            VolverButtom.TabIndex = 3;
            VolverButtom.Text = "Volver";
            VolverButtom.UseVisualStyleBackColor = true;
            VolverButtom.Click += VolverButtom_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Location = new Point(6, 546);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Cerrar aplicacion";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelPlano
            // 
            panelPlano.BackColor = Color.Bisque;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(922, 613);
            panelPlano.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 713);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelPlano;
        private Button btnSalir;
        private Button agregarMesaButton;
        private PictureBox pictureBox1;
        private Button btnAddPared;
        private Button VolverButtom;
        private PictureBox pictureBox2;
        private Button btnGuardar;
        private Button btnBarra;
        private Button btnBaño;
    }
}
