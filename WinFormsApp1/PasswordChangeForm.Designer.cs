namespace WinFormsApp1
{
    partial class PasswordChangeForm
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
            textBoxNewPassword = new TextBox();
            buttonChangePassword = new Button();
            labelNewPassword = new Label();
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
            labelTitle.Location = new Point(150, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(427, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Cambiar Contraseña";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(250, 250);
            textBoxNewPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(300, 36);
            textBoxNewPassword.TabIndex = 1;
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.BackColor = Color.Firebrick;
            buttonChangePassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangePassword.ForeColor = Color.White;
            buttonChangePassword.Location = new Point(300, 375);
            buttonChangePassword.Margin = new Padding(3, 4, 3, 4);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(200, 62);
            buttonChangePassword.TabIndex = 2;
            buttonChangePassword.Text = "Cambiar";
            buttonChangePassword.UseVisualStyleBackColor = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewPassword.Location = new Point(250, 200);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(228, 27);
            labelNewPassword.TabIndex = 3;
            labelNewPassword.Text = "Nueva Contraseña";
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(labelNewPassword);
            Controls.Add(buttonChangePassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            Load += PasswordChangeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label labelNewPassword;
    }
}
