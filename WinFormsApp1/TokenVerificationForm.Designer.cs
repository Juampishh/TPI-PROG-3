namespace WinFormsApp1
{
    partial class TokenVerificationForm
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
            textBoxToken = new TextBox();
            buttonVerifyToken = new Button();
            labelToken = new Label();
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
            labelTitle.Location = new Point(250, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(310, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Verificar Token";
            // 
            // textBoxToken
            // 
            textBoxToken.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxToken.Location = new Point(250, 250);
            textBoxToken.Margin = new Padding(3, 4, 3, 4);
            textBoxToken.Name = "textBoxToken";
            textBoxToken.Size = new Size(300, 36);
            textBoxToken.TabIndex = 1;
            // 
            // buttonVerifyToken
            // 
            buttonVerifyToken.BackColor = Color.Firebrick;
            buttonVerifyToken.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVerifyToken.ForeColor = Color.White;
            buttonVerifyToken.Location = new Point(300, 375);
            buttonVerifyToken.Margin = new Padding(3, 4, 3, 4);
            buttonVerifyToken.Name = "buttonVerifyToken";
            buttonVerifyToken.Size = new Size(200, 62);
            buttonVerifyToken.TabIndex = 2;
            buttonVerifyToken.Text = "Verificar Token";
            buttonVerifyToken.UseVisualStyleBackColor = false;
            buttonVerifyToken.Click += buttonVerifyToken_Click;
            // 
            // labelToken
            // 
            labelToken.AutoSize = true;
            labelToken.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelToken.Location = new Point(250, 200);
            labelToken.Name = "labelToken";
            labelToken.Size = new Size(194, 27);
            labelToken.TabIndex = 3;
            labelToken.Text = "Ingresa el Token";
            // 
            // TokenVerificationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(labelToken);
            Controls.Add(buttonVerifyToken);
            Controls.Add(textBoxToken);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TokenVerificationForm";
            Text = "TokenVerificationForm";
         
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Button buttonVerifyToken;
        private System.Windows.Forms.Label labelToken;
    }
}
