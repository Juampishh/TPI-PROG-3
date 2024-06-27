namespace WinFormsApp1
{
    partial class FormVerPedidos
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
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            btCancelar = new Button();
            btSalir = new Button();
            panel2 = new Panel();
            lblBienvenida = new Label();
            panel3 = new Panel();
            btPagar = new Button();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btCancelar);
            panel1.Controls.Add(btSalir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(6, 237);
            label5.Name = "label5";
            label5.Size = new Size(62, 19);
            label5.TabIndex = 4;
            label5.Text = "Fecha:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(3, 190);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 2;
            label3.Text = "Mesa N°:";
            // 
            // btCancelar
            // 
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Location = new Point(22, 382);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(157, 26);
            btCancelar.TabIndex = 1;
            btCancelar.Text = "Cancelar pedido";
            btCancelar.UseVisualStyleBackColor = true;
            btCancelar.Click += btCancelar_Click;
            // 
            // btSalir
            // 
            btSalir.FlatStyle = FlatStyle.Flat;
            btSalir.Location = new Point(22, 421);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(157, 26);
            btSalir.TabIndex = 0;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btAceptar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblBienvenida);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 69);
            panel2.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline);
            lblBienvenida.ForeColor = Color.SaddleBrown;
            lblBienvenida.Location = new Point(12, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(263, 38);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Lista de pedido:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btPagar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 382);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 68);
            panel3.TabIndex = 2;
            // 
            // btPagar
            // 
            btPagar.BackColor = Color.ForestGreen;
            btPagar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btPagar.ForeColor = Color.White;
            btPagar.Location = new Point(388, 12);
            btPagar.Margin = new Padding(3, 2, 3, 2);
            btPagar.Name = "btPagar";
            btPagar.Size = new Size(192, 38);
            btPagar.TabIndex = 5;
            btPagar.Text = "Pagar";
            btPagar.UseVisualStyleBackColor = false;
            btPagar.Click += btPagar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(216, 12);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 2;
            label2.Text = "$0.00";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 1;
            label1.Text = "Monto final:";
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 313);
            panel4.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(600, 313);
            listBox1.TabIndex = 0;
            // 
            // FormVerPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "FormVerPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVerPedidos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btCancelar;
        private Button btSalir;
        private Label lblBienvenida;
        private Label label1;
        public ListBox listBox1;
        public Label label2;
        public Label label5;
        public Label label3;
        private Button btPagar;
    }
}