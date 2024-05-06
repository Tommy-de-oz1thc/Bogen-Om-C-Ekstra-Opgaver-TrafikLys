namespace InventoryMgmtTuto
{
    partial class ManageCustomers
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
            label3 = new Label();
            txtCustomerPhone = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            labelName = new Label();
            txtCustomerId = new TextBox();
            label5 = new Label();
            dataGridViewCustomer = new DataGridView();
            btnHome = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            labelLastOrderDate = new Label();
            label8 = new Label();
            panel4 = new Panel();
            labelOrdersAmount = new Label();
            label6 = new Label();
            panel3 = new Panel();
            labelOrdersCount = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 33);
            label1.TabIndex = 1;
            label1.Text = "Manage Customers";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BlueViolet;
            label3.Font = new Font("Segoe UI", 5F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(13, 338);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 10);
            label3.TabIndex = 15;
            label3.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.BackColor = SystemColors.Control;
            txtCustomerPhone.BorderStyle = BorderStyle.None;
            txtCustomerPhone.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerPhone.ForeColor = Color.BlueViolet;
            txtCustomerPhone.Location = new Point(13, 304);
            txtCustomerPhone.Margin = new Padding(4, 3, 4, 3);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.PasswordChar = '*';
            txtCustomerPhone.PlaceholderText = "CustomerPhone";
            txtCustomerPhone.Size = new Size(226, 32);
            txtCustomerPhone.TabIndex = 14;
            txtCustomerPhone.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(13, 263);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 10);
            label2.TabIndex = 13;
            label2.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = SystemColors.Control;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.ForeColor = Color.BlueViolet;
            txtCustomerName.Location = new Point(13, 229);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "CustomerName";
            txtCustomerName.Size = new Size(226, 32);
            txtCustomerName.TabIndex = 12;
            txtCustomerName.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.BlueViolet;
            labelName.Font = new Font("Segoe UI", 5F);
            labelName.ForeColor = Color.BlueViolet;
            labelName.Location = new Point(13, 190);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(229, 10);
            labelName.TabIndex = 11;
            labelName.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = SystemColors.Control;
            txtCustomerId.BorderStyle = BorderStyle.None;
            txtCustomerId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerId.ForeColor = Color.BlueViolet;
            txtCustomerId.Location = new Point(13, 156);
            txtCustomerId.Margin = new Padding(4, 3, 4, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.PlaceholderText = "CustomerId";
            txtCustomerId.Size = new Size(226, 32);
            txtCustomerId.TabIndex = 10;
            txtCustomerId.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(491, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(218, 33);
            label5.TabIndex = 16;
            label5.Text = "CUSTOMERS LIST";
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(344, 178);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomer.Size = new Size(545, 322);
            dataGridViewCustomer.TabIndex = 17;
            dataGridViewCustomer.Click += dataGridViewUser_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Crimson;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(105, 464);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 36);
            btnHome.TabIndex = 21;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 14F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(195, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Crimson;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14F);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(105, 406);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(77, 36);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Crimson;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 36);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 12);
            panel2.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Controls.Add(labelLastOrderDate);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(594, 525);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 89);
            panel5.TabIndex = 39;
            // 
            // labelLastOrderDate
            // 
            labelLastOrderDate.AutoSize = true;
            labelLastOrderDate.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            labelLastOrderDate.ForeColor = Color.White;
            labelLastOrderDate.Location = new Point(60, 36);
            labelLastOrderDate.Name = "labelLastOrderDate";
            labelLastOrderDate.Size = new Size(70, 35);
            labelLastOrderDate.TabIndex = 1;
            labelLastOrderDate.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 0;
            label8.Text = "Last Order Date";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(labelOrdersAmount);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(344, 525);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 89);
            panel4.TabIndex = 38;
            // 
            // labelOrdersAmount
            // 
            labelOrdersAmount.AutoSize = true;
            labelOrdersAmount.Font = new Font("Segoe UI", 18.25F, FontStyle.Bold);
            labelOrdersAmount.ForeColor = Color.White;
            labelOrdersAmount.Location = new Point(32, 36);
            labelOrdersAmount.Name = "labelOrdersAmount";
            labelOrdersAmount.Size = new Size(111, 35);
            labelOrdersAmount.TabIndex = 1;
            labelOrdersAmount.Text = "Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 0;
            label6.Text = "Orders Amount";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(labelOrdersCount);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(86, 525);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 89);
            panel3.TabIndex = 37;
            // 
            // labelOrdersCount
            // 
            labelOrdersCount.AutoSize = true;
            labelOrdersCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrdersCount.ForeColor = Color.White;
            labelOrdersCount.Location = new Point(52, 36);
            labelOrdersCount.Name = "labelOrdersCount";
            labelOrdersCount.Size = new Size(91, 32);
            labelOrdersCount.TabIndex = 1;
            labelOrdersCount.Text = "Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 0;
            label4.Text = "Orders Count";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 632);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(label3);
            Controls.Add(txtCustomerPhone);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(labelName);
            Controls.Add(txtCustomerId);
            Controls.Add(panel1);
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += ManageCustomers_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelManageUser;
        private Label label3;
        private TextBox txtCustomerPhone;
        private Label label2;
        private TextBox txtCustomerName;
        private Label labelName;
        private TextBox txtCustomerId;
        private Label label5;
        private DataGridView dataGridViewCustomer;
        private Button btnHome;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel2;
        private Panel panel5;
        private Label labelLastOrderDate;
        private Label label8;
        private Panel panel4;
        private Label labelOrdersAmount;
        private Label label6;
        private Panel panel3;
        private Label labelOrdersCount;
        private Label label4;
    }
}