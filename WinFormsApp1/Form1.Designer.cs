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
            button2 = new Button();
            btnModificar = new Button();
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
            panel1.Location = new Point(0, 986);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1872, 213);
            panel1.TabIndex = 0;
            // 
            // btnBarra
            // 
            //btnBarra.BackgroundImage = (Image)resources.GetObject("btnBarra.BackgroundImage");
            //btnBarra.BackgroundImageLayout = ImageLayout.Stretch;
            btnBarra.Location = new Point(858, 36);
            btnBarra.Margin = new Padding(9, 13, 9, 13);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(240, 96);
            btnBarra.TabIndex = 6;
            btnBarra.Text = "Agregar Barra";
            btnBarra.UseVisualStyleBackColor = true;
            btnBarra.Click += btnBarra_Click;
            // 
            // btnBaño
            // 
            //btnBaño.BackgroundImage = (Image)resources.GetObject("btnBaño.BackgroundImage");
            //btnBaño.BackgroundImageLayout = ImageLayout.Stretch;
            btnBaño.Location = new Point(571, 36);
            btnBaño.Margin = new Padding(9, 13, 9, 13);
            btnBaño.Name = "btnBaño";
            btnBaño.Size = new Size(247, 97);
            btnBaño.TabIndex = 5;
            btnBaño.Text = "Agregar Baño";
            btnBaño.UseVisualStyleBackColor = true;
            btnBaño.Click += btnBaño_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1655, 0);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 213);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnAddPared
            // 
            btnAddPared.Location = new Point(297, 36);
            btnAddPared.Margin = new Padding(6);
            btnAddPared.Name = "btnAddPared";
            btnAddPared.Size = new Size(247, 96);
            btnAddPared.TabIndex = 4;
            btnAddPared.Text = "Agregar Pared";
            btnAddPared.UseVisualStyleBackColor = true;
            btnAddPared.Click += btnAddPared_Click;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Location = new Point(22, 36);
            agregarMesaButton.Margin = new Padding(6);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(245, 96);
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnModificar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1649, 0);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 986);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(11, 286);
            btnGuardar.Margin = new Padding(6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(206, 49);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // VolverButtom
            // 
            VolverButtom.Location = new Point(11, 201);
            VolverButtom.Margin = new Padding(6, 4, 6, 4);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(206, 47);
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
            btnSalir.Location = new Point(41, 1165);
            btnSalir.Margin = new Padding(6);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 62);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 113);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(206, 49);
            button2.TabIndex = 1;
            button2.Text = "Cancelar reservas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(6, 26);
            btnModificar.Margin = new Padding(6);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(206, 49);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panelPlano
            // 
            panelPlano.BackColor = Color.Bisque;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Margin = new Padding(6);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(1649, 986);
            panelPlano.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1872, 1199);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(6);
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
        private Button button2;
        private Button btnModificar;
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
