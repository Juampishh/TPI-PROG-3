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
            panel1.Location = new Point(0, 798);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 153);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(956, 153);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // btnBarra
            // 
            btnBarra.Dock = DockStyle.Fill;
            btnBarra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBarra.Location = new Point(719, 3);
            btnBarra.Name = "btnBarra";
            btnBarra.Size = new Size(234, 147);
            btnBarra.TabIndex = 6;
            btnBarra.Text = "Agregar Barra";
            btnBarra.UseVisualStyleBackColor = true;
            btnBarra.Click += btnBarra_Click;
            // 
            // btnBaño
            // 
            btnBaño.Dock = DockStyle.Fill;
            btnBaño.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaño.Location = new Point(481, 3);
            btnBaño.Name = "btnBaño";
            btnBaño.Size = new Size(232, 147);
            btnBaño.TabIndex = 5;
            btnBaño.Text = "Agregar Baño";
            btnBaño.UseVisualStyleBackColor = true;
            btnBaño.Click += btnBaño_Click;
            // 
            // btnAddPared
            // 
            btnAddPared.Dock = DockStyle.Fill;
            btnAddPared.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPared.Location = new Point(242, 3);
            btnAddPared.Name = "btnAddPared";
            btnAddPared.Size = new Size(233, 147);
            btnAddPared.TabIndex = 4;
            btnAddPared.Text = "Agregar Pared";
            btnAddPared.UseVisualStyleBackColor = true;
            btnAddPared.Click += btnAddPared_Click;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Dock = DockStyle.Fill;
            agregarMesaButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agregarMesaButton.Location = new Point(3, 3);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(233, 147);
            agregarMesaButton.TabIndex = 3;
            agregarMesaButton.Text = "Agregar Mesa";
            agregarMesaButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(956, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(235, 153);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(VolverButtom);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(956, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 798);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(7, 65);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 50);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            btnGuardar.MouseClick += btnGuardar_MouseClick;
            // 
            // VolverButtom
            // 
            VolverButtom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VolverButtom.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VolverButtom.Location = new Point(7, 12);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(220, 46);
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
            btnSalir.Location = new Point(11, 726);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(216, 55);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Cerrar ";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelPlano
            // 
            panelPlano.BackColor = Color.Bisque;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Margin = new Padding(3, 4, 3, 4);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(956, 798);
            panelPlano.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 951);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        private PictureBox pictureBox2;
        private Button btnGuardar;
        private Button btnBarra;
        private Button btnBaño;
        private TableLayoutPanel tableLayoutPanel1;
    }
}