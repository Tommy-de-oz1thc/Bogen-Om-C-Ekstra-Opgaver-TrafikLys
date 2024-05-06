namespace InventoryMgmtTuto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnLogin = new Button();
            labelClear = new Label();
            checkBoxShowPassword = new CheckBox();
            labelPassword = new Label();
            txtPassword = new TextBox();
            labelName = new Label();
            txtName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(labelClear);
            panel1.Controls.Add(checkBoxShowPassword);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 5F);
            panel1.Location = new Point(663, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 501);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Crimson;
            btnLogin.Location = new Point(96, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(242, 47);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Segoe UI", 12F);
            labelClear.ForeColor = Color.Crimson;
            labelClear.Location = new Point(98, 450);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(46, 21);
            labelClear.TabIndex = 9;
            labelClear.Text = "Clear";
            labelClear.Click += labelClear_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Font = new Font("Segoe UI", 12F);
            checkBoxShowPassword.ForeColor = Color.Crimson;
            checkBoxShowPassword.Location = new Point(204, 450);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(134, 25);
            checkBoxShowPassword.TabIndex = 8;
            checkBoxShowPassword.Text = "ShowPassword";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckStateChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.White;
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(97, 368);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(241, 10);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "12323678901234567890123456789012345678901234567890123456789";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F);
            txtPassword.ForeColor = Color.Crimson;
            txtPassword.Location = new Point(98, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(240, 39);
            txtPassword.TabIndex = 6;
            txtPassword.TabStop = false;
            txtPassword.MouseLeave += txtPassword_MouseLeave;
            txtPassword.MouseHover += txtPassword_MouseHover;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.White;
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(97, 294);
            labelName.Name = "labelName";
            labelName.Size = new Size(241, 10);
            labelName.TabIndex = 3;
            labelName.Text = "12123678901234567890123456789012345678901234567890123456789";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F);
            txtName.ForeColor = Color.Crimson;
            txtName.Location = new Point(98, 252);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Username";
            txtName.Size = new Size(240, 39);
            txtName.TabIndex = 2;
            txtName.TabStop = false;
            txtName.MouseLeave += txtName_MouseLeave;
            txtName.MouseHover += txtName_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(150, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 119);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 33);
            label1.Name = "label1";
            label1.Size = new Size(112, 47);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 761);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
