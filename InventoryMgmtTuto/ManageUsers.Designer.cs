namespace InventoryMgmtTuto
{
    partial class ManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            labelManageUser = new Label();
            labelName = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            dataGridViewUser = new DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelManageUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 110);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 33);
            label1.TabIndex = 1;
            label1.Text = "Manage Users";
            // 
            // labelManageUser
            // 
            labelManageUser.AutoSize = true;
            labelManageUser.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelManageUser.ForeColor = Color.White;
            labelManageUser.Location = new Point(173, 9);
            labelManageUser.Margin = new Padding(4, 0, 4, 0);
            labelManageUser.Name = "labelManageUser";
            labelManageUser.Size = new Size(504, 39);
            labelManageUser.TabIndex = 0;
            labelManageUser.Text = "Inventory Management System";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.BlueViolet;
            labelName.Font = new Font("Segoe UI", 5F);
            labelName.ForeColor = Color.BlueViolet;
            labelName.Location = new Point(20, 196);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(229, 10);
            labelName.TabIndex = 5;
            labelName.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.BlueViolet;
            txtUserName.Location = new Point(20, 162);
            txtUserName.Margin = new Padding(4, 3, 4, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(226, 32);
            txtUserName.TabIndex = 4;
            txtUserName.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(20, 269);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 10);
            label2.TabIndex = 7;
            label2.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Control;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.BlueViolet;
            txtFullName.Location = new Point(20, 235);
            txtFullName.Margin = new Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(226, 32);
            txtFullName.TabIndex = 6;
            txtFullName.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BlueViolet;
            label3.Font = new Font("Segoe UI", 5F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(20, 344);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 10);
            label3.TabIndex = 9;
            label3.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.BlueViolet;
            txtPassword.Location = new Point(20, 310);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(226, 32);
            txtPassword.TabIndex = 8;
            txtPassword.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Crimson;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(21, 482);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 36);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Crimson;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(112, 482);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(77, 36);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(202, 482);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Crimson;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(112, 540);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 36);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BackgroundColor = Color.White;
            dataGridViewUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(350, 179);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.Size = new Size(545, 420);
            dataGridViewUser.TabIndex = 14;
            dataGridViewUser.Click += dataGridViewUser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 12);
            panel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.BlueViolet;
            label4.Font = new Font("Segoe UI", 5F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(20, 417);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 10);
            label4.TabIndex = 17;
            label4.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Control;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.BlueViolet;
            txtPhone.Location = new Point(20, 383);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "TelePhone";
            txtPhone.Size = new Size(226, 32);
            txtPhone.TabIndex = 16;
            txtPhone.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(497, 134);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 33);
            label5.TabIndex = 2;
            label5.Text = " USERS LIST";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(933, 632);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(panel2);
            Controls.Add(dataGridViewUser);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(labelName);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += ManageUsers_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelManageUser;
        private Label label1;
        private Label labelName;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtPassword;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnHome;
        private DataGridView dataGridViewUser;
        private Panel panel2;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
    }
}