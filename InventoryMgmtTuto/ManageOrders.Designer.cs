namespace InventoryMgmtTuto
{
    partial class ManageOrders
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            labelManageUser = new Label();
            panel2 = new Panel();
            label5 = new Label();
            dataGridViewCustomer = new DataGridView();
            txtOrderId = new TextBox();
            labelName = new Label();
            txtCustomerId = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBoxOrderDate = new TextBox();
            comboBoxCategory = new ComboBox();
            dataGridViewProduct = new DataGridView();
            txtQty = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            dataGridViewOrder = new DataGridView();
            txtCustomerName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            labelTotAmount = new Label();
            btnInsertOrder = new Button();
            btnViewOrder = new Button();
            label9 = new Label();
            btnHome = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
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
            panel1.Size = new Size(981, 110);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(331, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 1;
            label1.Text = "Manage Orders";
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
            panel2.Location = new Point(0, 732);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 12);
            panel2.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(88, 119);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 32;
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
            dataGridViewCustomer.Location = new Point(12, 148);
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
            dataGridViewCustomer.Size = new Size(332, 184);
            dataGridViewCustomer.TabIndex = 33;
            dataGridViewCustomer.Click += dataGridViewCustomer_Click;
            // 
            // txtOrderId
            // 
            txtOrderId.BackColor = SystemColors.Control;
            txtOrderId.BorderStyle = BorderStyle.None;
            txtOrderId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderId.ForeColor = Color.BlueViolet;
            txtOrderId.Location = new Point(13, 356);
            txtOrderId.Margin = new Padding(4, 3, 4, 3);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.PlaceholderText = "OrderId";
            txtOrderId.Size = new Size(226, 32);
            txtOrderId.TabIndex = 34;
            txtOrderId.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.BlueViolet;
            labelName.Font = new Font("Segoe UI", 5F);
            labelName.ForeColor = Color.BlueViolet;
            labelName.Location = new Point(13, 390);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(229, 10);
            labelName.TabIndex = 35;
            labelName.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = SystemColors.Control;
            txtCustomerId.BorderStyle = BorderStyle.None;
            txtCustomerId.Enabled = false;
            txtCustomerId.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerId.ForeColor = Color.BlueViolet;
            txtCustomerId.Location = new Point(13, 423);
            txtCustomerId.Margin = new Padding(4, 3, 4, 3);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.PlaceholderText = "CustomerId";
            txtCustomerId.Size = new Size(226, 32);
            txtCustomerId.TabIndex = 36;
            txtCustomerId.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BlueViolet;
            label2.Font = new Font("Segoe UI", 5F);
            label2.ForeColor = Color.BlueViolet;
            label2.Location = new Point(13, 457);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 10);
            label2.TabIndex = 37;
            label2.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = Color.Crimson;
            dateTimePicker1.CalendarTitleBackColor = Color.Crimson;
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(11, 585);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 32);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(30, 559);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 39;
            label3.Text = "Order Date";
            // 
            // textBoxOrderDate
            // 
            textBoxOrderDate.BackColor = Color.Crimson;
            textBoxOrderDate.Font = new Font("Segoe UI", 14F);
            textBoxOrderDate.ForeColor = Color.White;
            textBoxOrderDate.Location = new Point(11, 585);
            textBoxOrderDate.Multiline = true;
            textBoxOrderDate.Name = "textBoxOrderDate";
            textBoxOrderDate.Size = new Size(228, 33);
            textBoxOrderDate.TabIndex = 40;
            textBoxOrderDate.Click += TextBoxOrderDate_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategory.ForeColor = Color.Crimson;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(448, 113);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(229, 29);
            comboBoxCategory.TabIndex = 44;
            comboBoxCategory.Text = "Select Category";
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Crimson;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(350, 148);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(619, 223);
            dataGridViewProduct.TabIndex = 43;
            dataGridViewProduct.Click += dataGridViewProduct_Click;
            // 
            // txtQty
            // 
            txtQty.BackColor = SystemColors.Control;
            txtQty.BorderStyle = BorderStyle.None;
            txtQty.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.ForeColor = Color.BlueViolet;
            txtQty.Location = new Point(451, 390);
            txtQty.Margin = new Padding(4, 3, 4, 3);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(226, 32);
            txtQty.TabIndex = 45;
            txtQty.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.BlueViolet;
            label4.Font = new Font("Segoe UI", 5F);
            label4.ForeColor = Color.BlueViolet;
            label4.Location = new Point(451, 424);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(229, 10);
            label4.TabIndex = 46;
            label4.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(350, 399);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 47;
            label6.Text = "Quantity";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Crimson;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(674, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 36);
            btnAdd.TabIndex = 48;
            btnAdd.Text = "Add to Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.BackgroundColor = Color.White;
            dataGridViewOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Crimson;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Location = new Point(350, 457);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Crimson;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 20F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrder.Size = new Size(619, 238);
            dataGridViewOrder.TabIndex = 49;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = SystemColors.Control;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Enabled = false;
            txtCustomerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.ForeColor = Color.BlueViolet;
            txtCustomerName.Location = new Point(14, 493);
            txtCustomerName.Margin = new Padding(4, 3, 4, 3);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "CustomerName";
            txtCustomerName.Size = new Size(226, 32);
            txtCustomerName.TabIndex = 50;
            txtCustomerName.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.BlueViolet;
            label7.Font = new Font("Segoe UI", 5F);
            label7.ForeColor = Color.BlueViolet;
            label7.Location = new Point(14, 527);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(229, 10);
            label7.TabIndex = 51;
            label7.Text = "01234567890123456789012345678901234567890123456789012345";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(498, 706);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 23);
            label8.TabIndex = 52;
            label8.Text = "Total Amount";
            // 
            // labelTotAmount
            // 
            labelTotAmount.AutoSize = true;
            labelTotAmount.BackColor = SystemColors.Control;
            labelTotAmount.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotAmount.ForeColor = Color.Black;
            labelTotAmount.Location = new Point(664, 706);
            labelTotAmount.Margin = new Padding(4, 0, 4, 0);
            labelTotAmount.Name = "labelTotAmount";
            labelTotAmount.Size = new Size(29, 23);
            labelTotAmount.TabIndex = 53;
            labelTotAmount.Text = "Rs";
            // 
            // btnInsertOrder
            // 
            btnInsertOrder.BackColor = Color.Crimson;
            btnInsertOrder.FlatAppearance.BorderSize = 0;
            btnInsertOrder.FlatStyle = FlatStyle.Flat;
            btnInsertOrder.Font = new Font("Segoe UI", 14F);
            btnInsertOrder.ForeColor = Color.White;
            btnInsertOrder.Location = new Point(14, 637);
            btnInsertOrder.Name = "btnInsertOrder";
            btnInsertOrder.Size = new Size(132, 36);
            btnInsertOrder.TabIndex = 54;
            btnInsertOrder.Text = "Insert Order";
            btnInsertOrder.UseVisualStyleBackColor = false;
            btnInsertOrder.Click += btnInsertOrder_Click;
            // 
            // btnViewOrder
            // 
            btnViewOrder.BackColor = Color.Crimson;
            btnViewOrder.FlatAppearance.BorderSize = 0;
            btnViewOrder.FlatStyle = FlatStyle.Flat;
            btnViewOrder.Font = new Font("Segoe UI", 14F);
            btnViewOrder.ForeColor = Color.White;
            btnViewOrder.Location = new Point(162, 637);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(129, 36);
            btnViewOrder.TabIndex = 55;
            btnViewOrder.Text = "View Orders";
            btnViewOrder.UseVisualStyleBackColor = false;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(637, 706);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(29, 23);
            label9.TabIndex = 56;
            label9.Text = "Rs";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Crimson;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(14, 690);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(77, 36);
            btnHome.TabIndex = 57;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 744);
            Controls.Add(btnHome);
            Controls.Add(label9);
            Controls.Add(btnViewOrder);
            Controls.Add(btnInsertOrder);
            Controls.Add(labelTotAmount);
            Controls.Add(label8);
            Controls.Add(txtCustomerName);
            Controls.Add(label7);
            Controls.Add(dataGridViewOrder);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtQty);
            Controls.Add(label4);
            Controls.Add(comboBoxCategory);
            Controls.Add(dataGridViewProduct);
            Controls.Add(textBoxOrderDate);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtCustomerId);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(labelName);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += ManageOrders_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelManageUser;
        private Panel panel2;
        private Label label5;
        private DataGridView dataGridViewCustomer;
        private TextBox txtOrderId;
        private Label labelName;
        private TextBox txtCustomerId;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBoxOrderDate;
        private ComboBox comboBoxCategory;
        private DataGridView dataGridViewProduct;
        private TextBox txtQty;
        private Label label4;
        private Label label6;
        private Button btnAdd;
        private DataGridView dataGridViewOrder;
        private TextBox txtCustomerName;
        private Label label7;
        private Label label8;
        private Label labelTotAmount;
        private Button btnInsertOrder;
        private Button btnViewOrder;
        private Label label9;
        private Button btnHome;
    }
}