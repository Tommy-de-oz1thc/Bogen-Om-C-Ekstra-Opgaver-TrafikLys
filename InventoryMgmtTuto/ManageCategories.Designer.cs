namespace InventoryMgmtTuto
{
    partial class ManageCategories
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
            panel2 = new Panel();
            label2 = new Label();
            txtCategoryName = new TextBox();
            labelName = new Label();
            txtCategoriesId = new TextBox();
            label5 = new Label();
            dataGridViewCategories = new DataGridView();
            btnHome = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 33);
            label1.TabIndex = 1;
            label1.Text = "Manage Categories";
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
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 541);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 12);
            panel2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(29, 293);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 10);
            label2.TabIndex = 27;
            label2.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCategoryName
            // 
            txtCategoryName.BackColor = SystemColors.Control;
            txtCategoryName.BorderStyle = BorderStyle.None;
            txtCategoryName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoryName.ForeColor = Color.BlueViolet;
            txtCategoryName.Location = new Point(29, 259);
            txtCategoryName.Margin = new Padding(4, 3, 4, 3);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "CategoryName";
            txtCategoryName.Size = new Size(226, 32);
            txtCategoryName.TabIndex = 26;
            txtCategoryName.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.BlueViolet;
            labelName.Font = new Font("Segoe UI", 5F);
            labelName.ForeColor = Color.BlueViolet;
            labelName.Location = new Point(29, 220);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(229, 10);
            labelName.TabIndex = 25;
            labelName.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCategoriesId
            // 
            txtCategoriesId.BackColor = SystemColors.Control;
            txtCategoriesId.BorderStyle = BorderStyle.None;
            txtCategoriesId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoriesId.ForeColor = Color.BlueViolet;
            txtCategoriesId.Location = new Point(29, 186);
            txtCategoriesId.Margin = new Padding(4, 3, 4, 3);
            txtCategoriesId.Name = "txtCategoriesId";
            txtCategoriesId.PlaceholderText = "CategoriesId";
            txtCategoriesId.Size = new Size(226, 32);
            txtCategoriesId.TabIndex = 24;
            txtCategoriesId.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(509, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(226, 33);
            label5.TabIndex = 28;
            label5.Text = "CATEGORIES LIST";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCategories.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(355, 186);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategories.Size = new Size(545, 309);
            dataGridViewCategories.TabIndex = 29;
            dataGridViewCategories.Click += dataGridViewUser_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Crimson;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(121, 459);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 36);
            btnHome.TabIndex = 33;
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
            btnDelete.Location = new Point(211, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 32;
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
            btnEdit.Location = new Point(121, 401);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(77, 36);
            btnEdit.TabIndex = 31;
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
            btnAdd.Location = new Point(30, 401);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 36);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 553);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(dataGridViewCategories);
            Controls.Add(label2);
            Controls.Add(txtCategoryName);
            Controls.Add(labelName);
            Controls.Add(txtCategoriesId);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += ManageCustomers_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelManageUser;
        private Panel panel2;
        private Label label2;
        private TextBox txtCategoryName;
        private Label labelName;
        private TextBox txtCategoriesId;
        private Label label5;
        private DataGridView dataGridViewCategories;
        private Button btnHome;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}