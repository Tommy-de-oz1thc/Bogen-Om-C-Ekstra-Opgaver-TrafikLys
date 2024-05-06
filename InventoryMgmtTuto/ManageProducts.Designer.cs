namespace InventoryMgmtTuto
{
    partial class ManageProducts
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
            label4 = new Label();
            txtProductPrice = new TextBox();
            label3 = new Label();
            txtProductQty = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            labelName = new Label();
            txtProductId = new TextBox();
            panel2 = new Panel();
            btnHome = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label5 = new Label();
            dataGridViewProduct = new DataGridView();
            label6 = new Label();
            txtProductDescription = new TextBox();
            comboBoxCategory = new ComboBox();
            comboBoxSeach = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 1;
            label1.Text = "Manage Products";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.BlueViolet;
            label4.Font = new Font("Segoe UI", 5F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(26, 399);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 10);
            label4.TabIndex = 25;
            label4.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtProductPrice
            // 
            txtProductPrice.BackColor = SystemColors.Control;
            txtProductPrice.BorderStyle = BorderStyle.None;
            txtProductPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductPrice.ForeColor = Color.BlueViolet;
            txtProductPrice.Location = new Point(26, 365);
            txtProductPrice.Margin = new Padding(4, 3, 4, 3);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.PlaceholderText = "ProductPrice";
            txtProductPrice.Size = new Size(226, 32);
            txtProductPrice.TabIndex = 24;
            txtProductPrice.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BlueViolet;
            label3.Font = new Font("Segoe UI", 5F);
            label3.ForeColor = Color.BlueViolet;
            label3.Location = new Point(26, 326);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 10);
            label3.TabIndex = 23;
            label3.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtProductQty
            // 
            txtProductQty.BackColor = SystemColors.Control;
            txtProductQty.BorderStyle = BorderStyle.None;
            txtProductQty.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductQty.ForeColor = Color.BlueViolet;
            txtProductQty.Location = new Point(26, 292);
            txtProductQty.Margin = new Padding(4, 3, 4, 3);
            txtProductQty.Name = "txtProductQty";
            txtProductQty.PlaceholderText = "ProductQty";
            txtProductQty.Size = new Size(226, 32);
            txtProductQty.TabIndex = 22;
            txtProductQty.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(26, 251);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 10);
            label2.TabIndex = 21;
            label2.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Control;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.ForeColor = Color.BlueViolet;
            txtProductName.Location = new Point(26, 217);
            txtProductName.Margin = new Padding(4, 3, 4, 3);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "ProductName";
            txtProductName.Size = new Size(226, 32);
            txtProductName.TabIndex = 20;
            txtProductName.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.BlueViolet;
            labelName.Font = new Font("Segoe UI", 5F);
            labelName.ForeColor = Color.BlueViolet;
            labelName.Location = new Point(26, 178);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(229, 10);
            labelName.TabIndex = 19;
            labelName.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtProductId
            // 
            txtProductId.BackColor = SystemColors.Control;
            txtProductId.BorderStyle = BorderStyle.None;
            txtProductId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductId.ForeColor = Color.BlueViolet;
            txtProductId.Location = new Point(26, 144);
            txtProductId.Margin = new Padding(4, 3, 4, 3);
            txtProductId.Name = "txtProductId";
            txtProductId.PlaceholderText = "ProductId";
            txtProductId.Size = new Size(226, 32);
            txtProductId.TabIndex = 18;
            txtProductId.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 732);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 12);
            panel2.TabIndex = 26;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Crimson;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(113, 654);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 36);
            btnHome.TabIndex = 30;
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
            btnDelete.Location = new Point(203, 596);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 36);
            btnDelete.TabIndex = 29;
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
            btnEdit.Location = new Point(113, 596);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(77, 36);
            btnEdit.TabIndex = 28;
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
            btnAdd.Location = new Point(22, 596);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 36);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(513, 133);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(202, 33);
            label5.TabIndex = 31;
            label5.Text = "PRODUCTS LIST";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Crimson;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(366, 204);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Crimson;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(545, 417);
            dataGridViewProduct.TabIndex = 32;
            dataGridViewProduct.Click += dataGridViewUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.BlueViolet;
            label6.Font = new Font("Segoe UI", 5F);
            label6.ForeColor = Color.BlueViolet;
            label6.Location = new Point(26, 471);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(229, 10);
            label6.TabIndex = 34;
            label6.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtProductDescription
            // 
            txtProductDescription.BackColor = SystemColors.Control;
            txtProductDescription.BorderStyle = BorderStyle.None;
            txtProductDescription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductDescription.ForeColor = Color.BlueViolet;
            txtProductDescription.Location = new Point(26, 437);
            txtProductDescription.Margin = new Padding(4, 3, 4, 3);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.PlaceholderText = "ProductDescription";
            txtProductDescription.Size = new Size(226, 32);
            txtProductDescription.TabIndex = 33;
            txtProductDescription.TabStop = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategory.ForeColor = Color.Crimson;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(25, 503);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(229, 29);
            comboBoxCategory.TabIndex = 35;
            comboBoxCategory.Text = "Product Category";
            // 
            // comboBoxSeach
            // 
            comboBoxSeach.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxSeach.ForeColor = Color.Crimson;
            comboBoxSeach.FormattingEnabled = true;
            comboBoxSeach.Location = new Point(503, 169);
            comboBoxSeach.Name = "comboBoxSeach";
            comboBoxSeach.Size = new Size(229, 29);
            comboBoxSeach.TabIndex = 36;
            comboBoxSeach.Text = "Select Category";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Crimson;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(729, 169);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 29);
            btnSearch.TabIndex = 37;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Crimson;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(803, 169);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(77, 29);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 744);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxSeach);
            Controls.Add(comboBoxCategory);
            Controls.Add(label6);
            Controls.Add(txtProductDescription);
            Controls.Add(label5);
            Controls.Add(dataGridViewProduct);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductQty);
            Controls.Add(label3);
            Controls.Add(txtProductId);
            Controls.Add(labelName);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += ManageProducts_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelManageUser;
        private Label label4;
        private TextBox txtProductPrice;
        private Label label3;
        private TextBox txtProductQty;
        private Label label2;
        private TextBox txtProductName;
        private Label labelName;
        private TextBox txtProductId;
        private Panel panel2;
        private Button btnHome;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label5;
        private DataGridView dataGridViewProduct;
        private Label label6;
        private TextBox txtProductDescription;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxSeach;
        private Button btnSearch;
        private Button btnRefresh;
    }
}