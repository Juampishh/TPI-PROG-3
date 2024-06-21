namespace WinFormsApp1
{
    partial class EmailForm
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
            panel1 = new Panel();
            labelTitle = new Label();
            textBoxEmail = new TextBox();
            buttonSendToken = new Button();
            labelEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(300, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(221, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "EmailForm";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(250, 250);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 36);
            textBoxEmail.TabIndex = 1;
            // 
            // buttonSendToken
            // 
            buttonSendToken.BackColor = Color.Firebrick;
            buttonSendToken.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSendToken.ForeColor = Color.White;
            buttonSendToken.Location = new Point(300, 375);
            buttonSendToken.Margin = new Padding(3, 4, 3, 4);
            buttonSendToken.Name = "buttonSendToken";
            buttonSendToken.Size = new Size(200, 62);
            buttonSendToken.TabIndex = 2;
            buttonSendToken.Text = "Enviar Token";
            buttonSendToken.UseVisualStyleBackColor = false;
            buttonSendToken.Click += buttonSendToken_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(250, 200);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(224, 27);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Correo Electrónico";
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(labelEmail);
            Controls.Add(buttonSendToken);
            Controls.Add(textBoxEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmailForm";
            Text = "EmailForm";
            Load += EmailForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendToken;
        private System.Windows.Forms.Label labelEmail;
    }
}
