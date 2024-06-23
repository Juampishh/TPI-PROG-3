namespace WinFormsApp1
{
    partial class Menuop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuop));
            panelEdicion = new Panel();
            Edicion = new Button();
            btnEdicion = new Button();
            labelEdicion = new Label();
            panelPrevisualizacion = new Panel();
            ingresoPrev = new Button();
            btnPrevisualizacion = new Button();
            labelPrevisualizacion = new Label();
            panelEdicion.SuspendLayout();
            panelPrevisualizacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelEdicion
            // 
            panelEdicion.BackColor = Color.WhiteSmoke;
            panelEdicion.Controls.Add(Edicion);
            panelEdicion.Cursor = Cursors.Hand;
            panelEdicion.Location = new Point(20, 20);
            panelEdicion.Name = "panelEdicion";
            panelEdicion.Size = new Size(300, 450);
            panelEdicion.TabIndex = 0;
            panelEdicion.Paint += panelEdicion_Paint;
            panelEdicion.MouseEnter += panelEdicion_MouseEnter;
            panelEdicion.MouseLeave += panelEdicion_MouseLeave;
            // 
            // Edicion
            // 
            Edicion.FlatStyle = FlatStyle.Popup;
            Edicion.Image = (Image)resources.GetObject("Edicion.Image");
            Edicion.Location = new Point(0, 0);
            Edicion.Name = "Edicion";
            Edicion.Size = new Size(300, 450);
            Edicion.TabIndex = 0;
            Edicion.UseVisualStyleBackColor = true;
            Edicion.Click += Edicion_Click;
            // 
            // btnEdicion
            // 
            btnEdicion.BackColor = Color.DodgerBlue;
            btnEdicion.FlatStyle = FlatStyle.Flat;
            btnEdicion.ForeColor = Color.White;
            btnEdicion.Location = new Point(75, 200);
            btnEdicion.Name = "btnEdicion";
            btnEdicion.Size = new Size(150, 50);
            btnEdicion.TabIndex = 0;
            btnEdicion.Text = "Ir a Edición";
            btnEdicion.UseVisualStyleBackColor = false;
            btnEdicion.Click += btnEdicion_Click;
            // 
            // labelEdicion
            // 
            labelEdicion.AutoSize = true;
            labelEdicion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdicion.Location = new Point(90, 480);
            labelEdicion.Name = "labelEdicion";
            labelEdicion.Size = new Size(123, 37);
            labelEdicion.TabIndex = 1;
            labelEdicion.Text = "Edición";
            // 
            // panelPrevisualizacion
            // 
            panelPrevisualizacion.BackColor = Color.WhiteSmoke;
            panelPrevisualizacion.Controls.Add(ingresoPrev);
            panelPrevisualizacion.Cursor = Cursors.Hand;
            panelPrevisualizacion.Location = new Point(340, 20);
            panelPrevisualizacion.Name = "panelPrevisualizacion";
            panelPrevisualizacion.Size = new Size(300, 450);
            panelPrevisualizacion.TabIndex = 2;
            panelPrevisualizacion.Paint += panelPrevisualizacion_Paint;
            panelPrevisualizacion.MouseEnter += panelPrevisualizacion_MouseEnter;
            panelPrevisualizacion.MouseLeave += panelPrevisualizacion_MouseLeave;
            // 
            // ingresoPrev
            // 
            ingresoPrev.FlatStyle = FlatStyle.Popup;
            ingresoPrev.Image = (Image)resources.GetObject("ingresoPrev.Image");
            ingresoPrev.Location = new Point(0, 0);
            ingresoPrev.Name = "ingresoPrev";
            ingresoPrev.Size = new Size(300, 450);
            ingresoPrev.TabIndex = 0;
            ingresoPrev.UseVisualStyleBackColor = true;
            ingresoPrev.Click += ingresoPrev_Click;
            // 
            // btnPrevisualizacion
            // 
            btnPrevisualizacion.BackColor = Color.MediumSeaGreen;
            btnPrevisualizacion.FlatStyle = FlatStyle.Flat;
            btnPrevisualizacion.ForeColor = Color.White;
            btnPrevisualizacion.Location = new Point(75, 200);
            btnPrevisualizacion.Name = "btnPrevisualizacion";
            btnPrevisualizacion.Size = new Size(150, 50);
            btnPrevisualizacion.TabIndex = 0;
            btnPrevisualizacion.Text = "Ir a Previsualización";
            btnPrevisualizacion.UseVisualStyleBackColor = false;
            btnPrevisualizacion.Click += btnPrevisualizacion_Click;
            // 
            // labelPrevisualizacion
            // 
            labelPrevisualizacion.AutoSize = true;
            labelPrevisualizacion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrevisualizacion.Location = new Point(370, 480);
            labelPrevisualizacion.Name = "labelPrevisualizacion";
            labelPrevisualizacion.Size = new Size(249, 37);
            labelPrevisualizacion.TabIndex = 3;
            labelPrevisualizacion.Text = "Previsualización";
            // 
            // Menuop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(672, 540);
            Controls.Add(labelPrevisualizacion);
            Controls.Add(panelPrevisualizacion);
            Controls.Add(labelEdicion);
            Controls.Add(panelEdicion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menuop";
            Opacity = 0.9D;
            Text = "Menú de Opciones";
            Load += Menuop_Load;
            panelEdicion.ResumeLayout(false);
            panelPrevisualizacion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelEdicion;
        private Label labelEdicion;
        private Panel panelPrevisualizacion;
        private Label labelPrevisualizacion;
        private Button btnEdicion;
        private Button btnPrevisualizacion;
        private Button ingresoPrev;
        private Button Edicion;
    }
}
