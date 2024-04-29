namespace Library_s_Lending_Administration.Admin
{
    partial class AdminUserForm
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
            this.components = new System.ComponentModel.Container();
            this.labelAdminUser = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.labelUserType = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserShow = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.listBoxShowAdminUser = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.labelUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminUser
            // 
            this.labelAdminUser.AutoSize = true;
            this.labelAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUser.Location = new System.Drawing.Point(24, 20);
            this.labelAdminUser.Name = "labelAdminUser";
            this.labelAdminUser.Size = new System.Drawing.Size(321, 29);
            this.labelAdminUser.TabIndex = 10;
            this.labelAdminUser.Text = "Admin User Administration";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(29, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(269, 20);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(336, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBoxUserType.Location = new System.Drawing.Point(597, 97);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxUserType.TabIndex = 14;
            this.comboBoxUserType.Text = "User";
            // 
            // labelUserType
            // 
            this.labelUserType.AutoSize = true;
            this.labelUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserType.Location = new System.Drawing.Point(594, 69);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(78, 17);
            this.labelUserType.TabIndex = 15;
            this.labelUserType.Text = "User Type:";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserPassword.Location = new System.Drawing.Point(333, 69);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(107, 17);
            this.labelUserPassword.TabIndex = 16;
            this.labelUserPassword.Text = "User Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUsername.Location = new System.Drawing.Point(26, 69);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 17);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "User Name:";
            // 
            // labelUserShow
            // 
            this.labelUserShow.AutoSize = true;
            this.labelUserShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserShow.Location = new System.Drawing.Point(26, 162);
            this.labelUserShow.Name = "labelUserShow";
            this.labelUserShow.Size = new System.Drawing.Size(87, 17);
            this.labelUserShow.TabIndex = 18;
            this.labelUserShow.Text = "Show Users:";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.Red;
            this.btnCreateUser.Enabled = false;
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateUser.Location = new System.Drawing.Point(597, 149);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(160, 30);
            this.btnCreateUser.TabIndex = 19;
            this.btnCreateUser.Text = "Create new User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // listBoxShowAdminUser
            // 
            this.listBoxShowAdminUser.ContextMenuStrip = this.contextMenuStrip2;
            this.listBoxShowAdminUser.FormattingEnabled = true;
            this.listBoxShowAdminUser.Location = new System.Drawing.Point(34, 208);
            this.listBoxShowAdminUser.Name = "listBoxShowAdminUser";
            this.listBoxShowAdminUser.Size = new System.Drawing.Size(722, 199);
            this.listBoxShowAdminUser.TabIndex = 20;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Red;
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateUser.Location = new System.Drawing.Point(431, 149);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(160, 30);
            this.btnUpdateUser.TabIndex = 21;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserId.Location = new System.Drawing.Point(374, 9);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(57, 17);
            this.labelUserId.TabIndex = 22;
            this.labelUserId.Text = "User Id:";
            this.labelUserId.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(377, 29);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(379, 20);
            this.txtUserId.TabIndex = 23;
            this.txtUserId.Visible = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteUser.Location = new System.Drawing.Point(265, 149);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(160, 30);
            this.btnDeleteUser.TabIndex = 24;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.listBoxShowAdminUser);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.labelUserShow);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserType);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelAdminUser);
            this.Name = "AdminUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label labelUserType;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserShow;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ListBox listBoxShowAdminUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}