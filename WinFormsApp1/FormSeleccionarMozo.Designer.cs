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
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblCrearMozo
            // 
            lblCrearMozo.Anchor = AnchorStyles.None;
            lblCrearMozo.AutoSize = true;
            lblCrearMozo.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline);
            lblCrearMozo.ForeColor = Color.SaddleBrown;
            lblCrearMozo.Location = new Point(12, 9);
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
            panel1.Size = new Size(473, 75);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 148);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(449, 105);
            dataGridView1.TabIndex = 0;
            // 
            // FormSeleccionarMozo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(473, 223);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormSeleccionarMozo";
            Text = "FormSeleccionarMozo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCrearMozo;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}