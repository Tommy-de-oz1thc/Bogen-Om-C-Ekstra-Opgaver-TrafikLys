namespace Library_s_Lending_Administration.Admin
{
    partial class AdminAdultBooksForm
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
            this.labelAdminAdultBooks = new System.Windows.Forms.Label();
            this.txtAdultBookId = new System.Windows.Forms.TextBox();
            this.labelAdminAdultBookId = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelDecription = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelMax_Days_for_Lendin = new System.Windows.Forms.Label();
            this.txtMax_Days_for_Lending = new System.Windows.Forms.TextBox();
            this.labelRendingDate = new System.Windows.Forms.Label();
            this.txtRendingDate = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatusType = new System.Windows.Forms.ComboBox();
            this.labelPaymentYpe = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.labelToLate = new System.Windows.Forms.Label();
            this.txtToLate = new System.Windows.Forms.TextBox();
            this.labelToLateLong = new System.Windows.Forms.Label();
            this.txtToLateLong = new System.Windows.Forms.TextBox();
            this.labelDaysLate = new System.Windows.Forms.Label();
            this.txtDaysLate = new System.Windows.Forms.TextBox();
            this.labelDaysLong = new System.Windows.Forms.Label();
            this.txtDaysLong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxShowAdminAdultBooks = new System.Windows.Forms.ListBox();
            this.btnDeleteAdultBooks = new System.Windows.Forms.Button();
            this.btnUpdateAdultBooks = new System.Windows.Forms.Button();
            this.btnCreateAdultBooks = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminAdultBooks
            // 
            this.labelAdminAdultBooks.AutoSize = true;
            this.labelAdminAdultBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminAdultBooks.Location = new System.Drawing.Point(33, 28);
            this.labelAdminAdultBooks.Name = "labelAdminAdultBooks";
            this.labelAdminAdultBooks.Size = new System.Drawing.Size(232, 29);
            this.labelAdminAdultBooks.TabIndex = 0;
            this.labelAdminAdultBooks.Text = "Admin Adult Books";
            // 
            // txtAdultBookId
            // 
            this.txtAdultBookId.Enabled = false;
            this.txtAdultBookId.Location = new System.Drawing.Point(381, 37);
            this.txtAdultBookId.Name = "txtAdultBookId";
            this.txtAdultBookId.Size = new System.Drawing.Size(379, 20);
            this.txtAdultBookId.TabIndex = 25;
            this.txtAdultBookId.Visible = false;
            // 
            // labelAdminAdultBookId
            // 
            this.labelAdminAdultBookId.AutoSize = true;
            this.labelAdminAdultBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAdminAdultBookId.Location = new System.Drawing.Point(378, 9);
            this.labelAdminAdultBookId.Name = "labelAdminAdultBookId";
            this.labelAdminAdultBookId.Size = new System.Drawing.Size(95, 17);
            this.labelAdminAdultBookId.TabIndex = 24;
            this.labelAdminAdultBookId.Text = "Adult Book Id:";
            this.labelAdminAdultBookId.Visible = false;
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTittle.Location = new System.Drawing.Point(35, 87);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(39, 17);
            this.labelTittle.TabIndex = 26;
            this.labelTittle.Text = "Title:";
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecription.Location = new System.Drawing.Point(226, 87);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(83, 17);
            this.labelDecription.TabIndex = 27;
            this.labelDecription.Text = "Description:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(38, 117);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 20);
            this.txtTitle.TabIndex = 28;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(229, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 94);
            this.txtDescription.TabIndex = 29;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(35, 160);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 17);
            this.labelAuthor.TabIndex = 30;
            this.labelAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(38, 191);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(154, 20);
            this.txtAuthor.TabIndex = 31;
            // 
            // labelMax_Days_for_Lendin
            // 
            this.labelMax_Days_for_Lendin.AutoSize = true;
            this.labelMax_Days_for_Lendin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMax_Days_for_Lendin.Location = new System.Drawing.Point(542, 115);
            this.labelMax_Days_for_Lendin.Name = "labelMax_Days_for_Lendin";
            this.labelMax_Days_for_Lendin.Size = new System.Drawing.Size(149, 17);
            this.labelMax_Days_for_Lendin.TabIndex = 32;
            this.labelMax_Days_for_Lendin.Text = "Max Days for Lending:";
            // 
            // txtMax_Days_for_Lending
            // 
            this.txtMax_Days_for_Lending.Location = new System.Drawing.Point(710, 115);
            this.txtMax_Days_for_Lending.Name = "txtMax_Days_for_Lending";
            this.txtMax_Days_for_Lending.Size = new System.Drawing.Size(50, 20);
            this.txtMax_Days_for_Lending.TabIndex = 33;
            this.txtMax_Days_for_Lending.Text = "30";
            // 
            // labelRendingDate
            // 
            this.labelRendingDate.AutoSize = true;
            this.labelRendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRendingDate.Location = new System.Drawing.Point(542, 147);
            this.labelRendingDate.Name = "labelRendingDate";
            this.labelRendingDate.Size = new System.Drawing.Size(99, 17);
            this.labelRendingDate.TabIndex = 34;
            this.labelRendingDate.Text = "Rending Date:";
            // 
            // txtRendingDate
            // 
            this.txtRendingDate.Location = new System.Drawing.Point(647, 147);
            this.txtRendingDate.Name = "txtRendingDate";
            this.txtRendingDate.Size = new System.Drawing.Size(113, 20);
            this.txtRendingDate.TabIndex = 35;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStatus.Location = new System.Drawing.Point(542, 175);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 36;
            this.labelStatus.Text = "Status:";
            // 
            // comboBoxStatusType
            // 
            this.comboBoxStatusType.FormattingEnabled = true;
            this.comboBoxStatusType.Items.AddRange(new object[] {
            "Home",
            "Out of House"});
            this.comboBoxStatusType.Location = new System.Drawing.Point(600, 173);
            this.comboBoxStatusType.Name = "comboBoxStatusType";
            this.comboBoxStatusType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxStatusType.TabIndex = 37;
            this.comboBoxStatusType.Text = "Home";
            this.comboBoxStatusType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
            // 
            // labelPaymentYpe
            // 
            this.labelPaymentYpe.AutoSize = true;
            this.labelPaymentYpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentYpe.Location = new System.Drawing.Point(39, 238);
            this.labelPaymentYpe.Name = "labelPaymentYpe";
            this.labelPaymentYpe.Size = new System.Drawing.Size(103, 17);
            this.labelPaymentYpe.TabIndex = 38;
            this.labelPaymentYpe.Text = "Payment Type:";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Adult Books"});
            this.comboBoxPaymentType.Enabled = false;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "AdultBooks"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(42, 258);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPaymentType.TabIndex = 39;
            this.comboBoxPaymentType.Text = "AdultBooks";
            // 
            // labelToLate
            // 
            this.labelToLate.AutoSize = true;
            this.labelToLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLate.Location = new System.Drawing.Point(226, 238);
            this.labelToLate.Name = "labelToLate";
            this.labelToLate.Size = new System.Drawing.Size(57, 17);
            this.labelToLate.TabIndex = 40;
            this.labelToLate.Text = "ToLate:";
            // 
            // txtToLate
            // 
            this.txtToLate.Location = new System.Drawing.Point(229, 259);
            this.txtToLate.Name = "txtToLate";
            this.txtToLate.Size = new System.Drawing.Size(50, 20);
            this.txtToLate.TabIndex = 41;
            this.txtToLate.Text = "20";
            // 
            // labelToLateLong
            // 
            this.labelToLateLong.AutoSize = true;
            this.labelToLateLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLateLong.Location = new System.Drawing.Point(308, 238);
            this.labelToLateLong.Name = "labelToLateLong";
            this.labelToLateLong.Size = new System.Drawing.Size(89, 17);
            this.labelToLateLong.TabIndex = 42;
            this.labelToLateLong.Text = "ToLateLong:";
            // 
            // txtToLateLong
            // 
            this.txtToLateLong.Location = new System.Drawing.Point(311, 259);
            this.txtToLateLong.Name = "txtToLateLong";
            this.txtToLateLong.Size = new System.Drawing.Size(50, 20);
            this.txtToLateLong.TabIndex = 43;
            this.txtToLateLong.Text = "100";
            // 
            // labelDaysLate
            // 
            this.labelDaysLate.AutoSize = true;
            this.labelDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLate.Location = new System.Drawing.Point(415, 238);
            this.labelDaysLate.Name = "labelDaysLate";
            this.labelDaysLate.Size = new System.Drawing.Size(72, 17);
            this.labelDaysLate.TabIndex = 44;
            this.labelDaysLate.Text = "DaysLate:";
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Location = new System.Drawing.Point(418, 259);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLate.TabIndex = 45;
            this.txtDaysLate.Text = "7";
            // 
            // labelDaysLong
            // 
            this.labelDaysLong.AutoSize = true;
            this.labelDaysLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLong.Location = new System.Drawing.Point(534, 238);
            this.labelDaysLong.Name = "labelDaysLong";
            this.labelDaysLong.Size = new System.Drawing.Size(76, 17);
            this.labelDaysLong.TabIndex = 46;
            this.labelDaysLong.Text = "DaysLong:";
            // 
            // txtDaysLong
            // 
            this.txtDaysLong.Location = new System.Drawing.Point(537, 258);
            this.txtDaysLong.Name = "txtDaysLong";
            this.txtDaysLong.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLong.TabIndex = 47;
            this.txtDaysLong.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(285, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(367, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(474, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(593, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Days";
            // 
            // listBoxShowAdminAdultBooks
            // 
            this.listBoxShowAdminAdultBooks.FormattingEnabled = true;
            this.listBoxShowAdminAdultBooks.Location = new System.Drawing.Point(38, 374);
            this.listBoxShowAdminAdultBooks.Name = "listBoxShowAdminAdultBooks";
            this.listBoxShowAdminAdultBooks.Size = new System.Drawing.Size(722, 199);
            this.listBoxShowAdminAdultBooks.TabIndex = 52;
            // 
            // btnDeleteAdultBooks
            // 
            this.btnDeleteAdultBooks.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAdultBooks.Enabled = false;
            this.btnDeleteAdultBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteAdultBooks.Location = new System.Drawing.Point(272, 311);
            this.btnDeleteAdultBooks.Name = "btnDeleteAdultBooks";
            this.btnDeleteAdultBooks.Size = new System.Drawing.Size(160, 30);
            this.btnDeleteAdultBooks.TabIndex = 55;
            this.btnDeleteAdultBooks.Text = "Delete Book";
            this.btnDeleteAdultBooks.UseVisualStyleBackColor = false;
            this.btnDeleteAdultBooks.Click += new System.EventHandler(this.btnDeleteAdultBooks_Click);
            // 
            // btnUpdateAdultBooks
            // 
            this.btnUpdateAdultBooks.BackColor = System.Drawing.Color.Red;
            this.btnUpdateAdultBooks.Enabled = false;
            this.btnUpdateAdultBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateAdultBooks.Location = new System.Drawing.Point(438, 311);
            this.btnUpdateAdultBooks.Name = "btnUpdateAdultBooks";
            this.btnUpdateAdultBooks.Size = new System.Drawing.Size(160, 30);
            this.btnUpdateAdultBooks.TabIndex = 54;
            this.btnUpdateAdultBooks.Text = "Update Book";
            this.btnUpdateAdultBooks.UseVisualStyleBackColor = false;
            this.btnUpdateAdultBooks.Click += new System.EventHandler(this.btnUpdateAdultBooks_Click);
            // 
            // btnCreateAdultBooks
            // 
            this.btnCreateAdultBooks.BackColor = System.Drawing.Color.Red;
            this.btnCreateAdultBooks.Enabled = false;
            this.btnCreateAdultBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateAdultBooks.Location = new System.Drawing.Point(604, 311);
            this.btnCreateAdultBooks.Name = "btnCreateAdultBooks";
            this.btnCreateAdultBooks.Size = new System.Drawing.Size(160, 30);
            this.btnCreateAdultBooks.TabIndex = 53;
            this.btnCreateAdultBooks.Text = "Create new Book";
            this.btnCreateAdultBooks.UseVisualStyleBackColor = false;
            this.btnCreateAdultBooks.Click += new System.EventHandler(this.btnCreateAdultBooks_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPayment.Location = new System.Drawing.Point(653, 223);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(107, 55);
            this.btnPayment.TabIndex = 56;
            this.btnPayment.Text = "Update Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // AdminAdultBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnDeleteAdultBooks);
            this.Controls.Add(this.btnUpdateAdultBooks);
            this.Controls.Add(this.btnCreateAdultBooks);
            this.Controls.Add(this.listBoxShowAdminAdultBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDaysLong);
            this.Controls.Add(this.labelDaysLong);
            this.Controls.Add(this.txtDaysLate);
            this.Controls.Add(this.labelDaysLate);
            this.Controls.Add(this.txtToLateLong);
            this.Controls.Add(this.labelToLateLong);
            this.Controls.Add(this.txtToLate);
            this.Controls.Add(this.labelToLate);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.labelPaymentYpe);
            this.Controls.Add(this.comboBoxStatusType);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtRendingDate);
            this.Controls.Add(this.labelRendingDate);
            this.Controls.Add(this.txtMax_Days_for_Lending);
            this.Controls.Add(this.labelMax_Days_for_Lendin);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelDecription);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.txtAdultBookId);
            this.Controls.Add(this.labelAdminAdultBookId);
            this.Controls.Add(this.labelAdminAdultBooks);
            this.Name = "AdminAdultBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminAdultBooks;
        private System.Windows.Forms.TextBox txtAdultBookId;
        private System.Windows.Forms.Label labelAdminAdultBookId;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labelMax_Days_for_Lendin;
        private System.Windows.Forms.TextBox txtMax_Days_for_Lending;
        private System.Windows.Forms.Label labelRendingDate;
        private System.Windows.Forms.TextBox txtRendingDate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatusType;
        private System.Windows.Forms.Label labelPaymentYpe;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label labelToLate;
        private System.Windows.Forms.TextBox txtToLate;
        private System.Windows.Forms.Label labelToLateLong;
        private System.Windows.Forms.TextBox txtToLateLong;
        private System.Windows.Forms.Label labelDaysLate;
        private System.Windows.Forms.TextBox txtDaysLate;
        private System.Windows.Forms.Label labelDaysLong;
        private System.Windows.Forms.TextBox txtDaysLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxShowAdminAdultBooks;
        private System.Windows.Forms.Button btnDeleteAdultBooks;
        private System.Windows.Forms.Button btnUpdateAdultBooks;
        private System.Windows.Forms.Button btnCreateAdultBooks;
        private System.Windows.Forms.Button btnPayment;
    }
}