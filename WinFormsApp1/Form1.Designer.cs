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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBarra = new Button();
            btnBaño = new Button();
            btnAddPared = new Button();
            agregarMesaButton = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnGuardar = new Button();
            VolverButtom = new Button();
            btnSalir = new Button();
            panelPlano = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 115);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.SlateGray;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnBarra, 3, 0);
            tableLayoutPanel1.Controls.Add(btnBaño, 2, 0);
            tableLayoutPanel1.Controls.Add(btnAddPared, 1, 0);
            tableLayoutPanel1.Controls.Add(agregarMesaButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(836, 115);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // btnBarra
            // 
            btnBarra.Dock = DockStyle.Fill;
            btnBarra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarra.Location = new Point(630, 2);
            btnBarra.Margin = new Padding(3, 2, 3, 2);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(203, 111);
            btnBarra.TabIndex = 6;
            btnBarra.Text = "Agregar Barra";
            btnBarra.UseVisualStyleBackColor = true;
            btnBarra.Click += btnBarra_Click;
            // 
            // btnBaño
            // 
            btnBaño.Dock = DockStyle.Fill;
            btnBaño.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaño.Location = new Point(421, 2);
            btnBaño.Margin = new Padding(3, 2, 3, 2);
            btnBaño.Name = "btnBaño";
            btnBaño.Size = new Size(203, 111);
            btnBaño.TabIndex = 5;
            btnBaño.Text = "Agregar Baño";
            btnBaño.UseVisualStyleBackColor = true;
            btnBaño.Click += btnBaño_Click;
            // 
            // btnAddPared
            // 
            btnAddPared.Dock = DockStyle.Fill;
            btnAddPared.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPared.Location = new Point(212, 2);
            btnAddPared.Margin = new Padding(3, 2, 3, 2);
            btnAddPared.Name = "btnAddPared";
            btnAddPared.Size = new Size(203, 111);
            btnAddPared.TabIndex = 4;
            btnAddPared.Text = "Agregar Pared";
            btnAddPared.UseVisualStyleBackColor = true;
            btnAddPared.Click += btnAddPared_Click;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Dock = DockStyle.Fill;
            agregarMesaButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agregarMesaButton.Location = new Point(3, 2);
            agregarMesaButton.Margin = new Padding(3, 2, 3, 2);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(203, 111);
            agregarMesaButton.TabIndex = 3;
            agregarMesaButton.Text = "Agregar Mesa";
            agregarMesaButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(836, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 115);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(VolverButtom);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(836, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 447);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(6, 49);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 38);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // VolverButtom
            // 
            VolverButtom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VolverButtom.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VolverButtom.Location = new Point(6, 9);
            VolverButtom.Margin = new Padding(3, 2, 3, 2);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(192, 34);
            VolverButtom.TabIndex = 3;
            VolverButtom.Text = "Volver";
            VolverButtom.UseVisualStyleBackColor = true;
            VolverButtom.Click += VolverButtom_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.BackColor = Color.Red;
            btnSalir.BackgroundImageLayout = ImageLayout.Center;
            btnSalir.Cursor = Cursors.HSplit;
            btnSalir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(10, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(189, 41);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Cerrar aplicacion";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelPlano
            // 
            panelPlano.AutoScroll = true;
            panelPlano.BackColor = Color.Snow;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(836, 447);
            panelPlano.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 562);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing_1;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private Button btnGuardar;
        private Button btnBarra;
        private Button btnBaño;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
    }
}