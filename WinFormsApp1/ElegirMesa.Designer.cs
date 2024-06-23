namespace WinFormsApp1
{
    partial class ElegirMesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirMesa));
            label1 = new Label();
            PBCuatro = new PictureBox();
            label2 = new Label();
            PBDos = new PictureBox();
            PBSeis = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            BTCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)PBCuatro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBSeis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Agregar mesa para:";
            // 
            // PBCuatro
            // 
            PBCuatro.BackgroundImageLayout = ImageLayout.None;
            PBCuatro.BorderStyle = BorderStyle.Fixed3D;
            PBCuatro.Image = (Image)resources.GetObject("PBCuatro.Image");
            PBCuatro.Location = new Point(196, 86);
            PBCuatro.Name = "PBCuatro";
            PBCuatro.Size = new Size(114, 59);
            PBCuatro.SizeMode = PictureBoxSizeMode.Zoom;
            PBCuatro.TabIndex = 1;
            PBCuatro.TabStop = false;
            PBCuatro.Click += pbCuatroP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 148);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Cuatro personas";
            // 
            // PBDos
            // 
            PBDos.BackgroundImageLayout = ImageLayout.None;
            PBDos.BorderStyle = BorderStyle.Fixed3D;
            PBDos.Image = (Image)resources.GetObject("PBDos.Image");
            PBDos.Location = new Point(12, 86);
            PBDos.Name = "PBDos";
            PBDos.Size = new Size(114, 59);
            PBDos.SizeMode = PictureBoxSizeMode.Zoom;
            PBDos.TabIndex = 3;
            PBDos.TabStop = false;
            PBDos.Click += PBDos_Click;
            // 
            // PBSeis
            // 
            PBSeis.BackgroundImageLayout = ImageLayout.None;
            PBSeis.BorderStyle = BorderStyle.Fixed3D;
            PBSeis.Image = (Image)resources.GetObject("PBSeis.Image");
            PBSeis.Location = new Point(373, 86);
            PBSeis.Name = "PBSeis";
            PBSeis.Size = new Size(114, 59);
            PBSeis.SizeMode = PictureBoxSizeMode.Zoom;
            PBSeis.TabIndex = 4;
            PBSeis.TabStop = false;
            PBSeis.Click += PBSeis_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 148);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Dos personas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 148);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 6;
            label4.Text = "Seis personas";
            // 
            // BTCancelar
            // 
            BTCancelar.Location = new Point(391, 208);
            BTCancelar.Name = "BTCancelar";
            BTCancelar.Size = new Size(75, 23);
            BTCancelar.TabIndex = 7;
            BTCancelar.Text = "Cancelar";
            BTCancelar.UseVisualStyleBackColor = true;
            BTCancelar.Click += BTCancelar_Click;
            // 
            // ElegirMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(499, 243);
            Controls.Add(BTCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PBSeis);
            Controls.Add(PBDos);
            Controls.Add(label2);
            Controls.Add(PBCuatro);
            Controls.Add(label1);
            Name = "ElegirMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElegirMesa";
            ((System.ComponentModel.ISupportInitialize)PBCuatro).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBSeis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox PBCuatro;
        private Label label2;
        private PictureBox PBDos;
        private PictureBox PBSeis;
        private Label label3;
        private Label label4;
        private Button BTCancelar;
    }
}