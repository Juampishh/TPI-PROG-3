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
            pictureBox2 = new PictureBox();
            btnAddPared = new Button();
            agregarMesaButton = new Button();
            panel2 = new Panel();
            VolverButtom = new Button();
            btnSalir = new Button();
            button2 = new Button();
            btnModificar = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnAddPared);
            panel1.Controls.Add(agregarMesaButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 462);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(891, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 100);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnAddPared
            // 
            btnAddPared.Location = new Point(160, 17);
            btnAddPared.Name = "btnAddPared";
            btnAddPared.Size = new Size(133, 45);
            btnAddPared.TabIndex = 4;
            btnAddPared.Text = "Agregar Pared";
            btnAddPared.UseVisualStyleBackColor = true;
            btnAddPared.Click += btnAddPared_Click;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Location = new Point(12, 17);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(132, 45);
            agregarMesaButton.TabIndex = 3;
            agregarMesaButton.Text = "Agregar Mesa";
            agregarMesaButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(VolverButtom);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnModificar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(888, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 462);
            panel2.TabIndex = 1;
            // 
            // VolverButtom
            // 
            VolverButtom.Location = new Point(6, 94);
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
            btnSalir.Location = new Point(22, 546);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(77, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 53);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar reservas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(3, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(111, 23);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 462);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 562);
            Controls.Add(panel3);
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
        private Panel panel3;
        private Button btnSalir;
        private Button button2;
        private Button btnModificar;
        private Button agregarMesaButton;
        private PictureBox pictureBox1;
        private Button btnAddPared;
        private Button VolverButtom;
        private PictureBox pictureBox2;
    }
}
