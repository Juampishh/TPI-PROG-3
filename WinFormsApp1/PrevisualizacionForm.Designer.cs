﻿namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrevisualizacionForm));
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            btEliminarMozo = new Button();
            agregarMozo = new Button();
            VolverButtom = new Button();
            listMozos = new ListBox();
            panelPlano = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            btAsignarMozo = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(952, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 611);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 511);
            panel3.Name = "panel3";
            panel3.Size = new Size(120, 100);
            panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 100);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btEliminarMozo);
            panel1.Controls.Add(agregarMozo);
            panel1.Controls.Add(VolverButtom);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 117);
            panel1.TabIndex = 9;
            // 
            // btEliminarMozo
            // 
            btEliminarMozo.Location = new Point(6, 91);
            btEliminarMozo.Name = "btEliminarMozo";
            btEliminarMozo.Size = new Size(111, 23);
            btEliminarMozo.TabIndex = 9;
            btEliminarMozo.Text = "Eliminar mozo";
            btEliminarMozo.UseVisualStyleBackColor = true;
            btEliminarMozo.Click += btEliminarMozo_Click;
            // 
            // agregarMozo
            // 
            agregarMozo.Location = new Point(6, 51);
            agregarMozo.Name = "agregarMozo";
            agregarMozo.Size = new Size(111, 23);
            agregarMozo.TabIndex = 8;
            agregarMozo.Text = "Agregar mozo";
            agregarMozo.UseVisualStyleBackColor = true;
            agregarMozo.Click += agregarMozo_Click;
            // 
            // VolverButtom
            // 
            VolverButtom.Location = new Point(6, 11);
            VolverButtom.Margin = new Padding(3, 2, 3, 2);
            VolverButtom.Name = "VolverButtom";
            VolverButtom.Size = new Size(111, 22);
            VolverButtom.TabIndex = 3;
            VolverButtom.Text = "Volver";
            VolverButtom.UseVisualStyleBackColor = true;
            VolverButtom.Click += VolverButtom_Click;
            // 
            // listMozos
            // 
            listMozos.BackColor = Color.MistyRose;
            listMozos.BorderStyle = BorderStyle.FixedSingle;
            listMozos.Dock = DockStyle.Fill;
            listMozos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listMozos.ForeColor = Color.Brown;
            listMozos.FormattingEnabled = true;
            listMozos.Location = new Point(0, 0);
            listMozos.Name = "listMozos";
            listMozos.Size = new Size(952, 100);
            listMozos.TabIndex = 11;
            // 
            // panelPlano
            // 
            panelPlano.AutoScroll = true;
            panelPlano.AutoSize = true;
            panelPlano.BackColor = Color.WhiteSmoke;
            panelPlano.BorderStyle = BorderStyle.FixedSingle;
            panelPlano.Dock = DockStyle.Fill;
            panelPlano.Location = new Point(0, 0);
            panelPlano.Name = "panelPlano";
            panelPlano.Size = new Size(952, 611);
            panelPlano.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGray;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(listMozos);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 511);
            panel4.Name = "panel4";
            panel4.Size = new Size(952, 100);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Controls.Add(btAsignarMozo);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(736, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(216, 100);
            panel5.TabIndex = 12;
            // 
            // btAsignarMozo
            // 
            btAsignarMozo.FlatStyle = FlatStyle.System;
            btAsignarMozo.Location = new Point(35, 15);
            btAsignarMozo.Name = "btAsignarMozo";
            btAsignarMozo.Size = new Size(147, 73);
            btAsignarMozo.TabIndex = 0;
            btAsignarMozo.Text = "Asignar mesa al mozo";
            btAsignarMozo.UseVisualStyleBackColor = true;
            btAsignarMozo.Click += btAsignarMozo_Click;
            // 
            // PrevisualizacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 611);
            Controls.Add(panel4);
            Controls.Add(panelPlano);
            Controls.Add(panel2);
            Name = "PrevisualizacionForm";
            Text = "Previsualizacion";
            WindowState = FormWindowState.Maximized;
            FormClosing += PrevisualizacionForm_FormClosing;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button VolverButtom;
        private Panel panelPlano;
        private PictureBox pictureBox2;
        private Button agregarMozo;
        private ListBox listMozos;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Button btAsignarMozo;
        private Button btEliminarMozo;
    }
}