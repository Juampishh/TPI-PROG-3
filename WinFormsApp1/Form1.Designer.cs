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
            agregarMesaButton = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1123 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(agregarMesaButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 581);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 100);
            panel1.TabIndex = 0;
            // 
            // agregarMesaButton
            // 
            agregarMesaButton.Location = new Point(374, 35);
            agregarMesaButton.Name = "agregarMesaButton";
            agregarMesaButton.Size = new Size(111, 23);
            agregarMesaButton.TabIndex = 3;
            agregarMesaButton.Text = "Agregar Mesa";
            agregarMesaButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1123);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(888, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(120, 581);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(6, 349);
            button3.Name = "button3";
            button3.Size = new Size(111, 23);
            button3.TabIndex = 2;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 284);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar reservas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1123
            // 
            button1123.Location = new Point(6, 222);
            button1123.Name = "button1123";
            button1123.Size = new Size(111, 23);
            button1123.TabIndex = 0;
            button1123.Text = "Modificar";
            button1123.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 581);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(260, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(832, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(114, 388);
            button7.Name = "button7";
            button7.Size = new Size(112, 64);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(114, 282);
            button6.Name = "button6";
            button6.Size = new Size(112, 64);
            button6.TabIndex = 2;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(114, 169);
            button5.Name = "button5";
            button5.Size = new Size(112, 64);
            button5.TabIndex = 1;
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(114, 52);
            button1.Name = "button1";
            button1.Size = new Size(112, 64);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 681);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1123;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button1;
        private Button agregarMesaButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
