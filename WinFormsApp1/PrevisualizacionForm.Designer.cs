namespace WinFormsApp1
{
    partial class PrevisualizacionForm
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
            panel2 = new Panel();
            VolverButtom = new Button();
            button2 = new Button();
            panelPlano = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(VolverButtom);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(952, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 611);
            panel2.TabIndex = 2;
            // 
            // VolverButtom
            // 
            VolverButtom.Location = new Point(3, 27);
            VolverButtom.Margin = new Padding(3, 2, 3, 2);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(111, 22);
            VolverButtom.TabIndex = 3;
            VolverButtom.Text = "Volver";
            VolverButtom.UseVisualStyleBackColor = true;
            VolverButtom.Click += VolverButtom_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 76);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar reservas";
            button2.UseVisualStyleBackColor = true;
            // 
            // panelPlano
            // 
            panelPlano.BackColor = Color.Bisque;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(952, 611);
            panelPlano.TabIndex = 4;
            // 
            // PrevisualizacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 611);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Name = "PrevisualizacionForm";
            Text = "Previsualizacion";
            WindowState = FormWindowState.Maximized;
            
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button VolverButtom;
        private Button button2;
        private Panel panelPlano;
    }
}