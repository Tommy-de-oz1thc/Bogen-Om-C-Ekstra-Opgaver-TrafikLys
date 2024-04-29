namespace Library_s_Lending_Administration.User
{
    partial class UserDataForm
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
            this.labelUserData = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserType = new System.Windows.Forms.Label();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserData.Location = new System.Drawing.Point(40, 28);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(128, 29);
            this.labelUserData.TabIndex = 0;
            this.labelUserData.Text = "User Data";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(45, 370);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(379, 20);
            this.txtUserId.TabIndex = 32;
            this.txtUserId.Visible = false;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserId.Location = new System.Drawing.Point(47, 350);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(57, 17);
            this.labelUserId.TabIndex = 31;
            this.labelUserId.Text = "User Id:";
            this.labelUserId.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsername.Location = new System.Drawing.Point(42, 99);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 17);
            this.labelUsername.TabIndex = 30;
            this.labelUsername.Text = "User Name:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(42, 168);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(107, 17);
            this.labelUserPassword.TabIndex = 29;
            this.labelUserPassword.Text = "User Password:";
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserType.Location = new System.Drawing.Point(47, 231);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(78, 17);
            this.labelUserType.TabIndex = 28;
            this.labelUserType.Text = "User Type:";
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.Enabled = false;
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxUserType.Location = new System.Drawing.Point(45, 251);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxUserType.TabIndex = 27;
            this.comboBoxUserType.Text = "User";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(45, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(45, 123);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(269, 20);
            this.txtUsername.TabIndex = 25;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Green;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateUser.Location = new System.Drawing.Point(45, 299);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(160, 30);
            this.btnUpdateUser.TabIndex = 33;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // UserDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(474, 415);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelUserData);
            this.Name = "UserDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserData;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdateUser;
    }
}