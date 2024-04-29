namespace Library_s_Lending_Administration.Admin
{
    partial class AdminCDsForm
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDeleteCDs = new System.Windows.Forms.Button();
            this.btnUpdateCDs = new System.Windows.Forms.Button();
            this.btnCreateCDs = new System.Windows.Forms.Button();
            this.listBoxShowAdminCDs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaysLong = new System.Windows.Forms.TextBox();
            this.labelDaysLong = new System.Windows.Forms.Label();
            this.txtDaysLate = new System.Windows.Forms.TextBox();
            this.labelDaysLate = new System.Windows.Forms.Label();
            this.txtToLateLong = new System.Windows.Forms.TextBox();
            this.labelToLateLong = new System.Windows.Forms.Label();
            this.txtToLate = new System.Windows.Forms.TextBox();
            this.labelToLate = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.labelPaymentYpe = new System.Windows.Forms.Label();
            this.comboBoxStatusType = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtRendingDate = new System.Windows.Forms.TextBox();
            this.labelRendingDate = new System.Windows.Forms.Label();
            this.txtMax_Days_for_Lending = new System.Windows.Forms.TextBox();
            this.labelMax_Days_for_Lendin = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelDecription = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.txtCDId = new System.Windows.Forms.TextBox();
            this.labelAdminCDId = new System.Windows.Forms.Label();
            this.labelAdminCDs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPayment.Location = new System.Drawing.Point(648, 221);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(107, 55);
            this.btnPayment.TabIndex = 90;
            this.btnPayment.Text = "Update Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDeleteCDs
            // 
            this.btnDeleteCDs.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCDs.Enabled = false;
            this.btnDeleteCDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteCDs.Location = new System.Drawing.Point(267, 309);
            this.btnDeleteCDs.Name = "btnDeleteCDs";
            this.btnDeleteCDs.Size = new System.Drawing.Size(160, 30);
            this.btnDeleteCDs.TabIndex = 89;
            this.btnDeleteCDs.Text = "Delete CD";
            this.btnDeleteCDs.UseVisualStyleBackColor = false;
            this.btnDeleteCDs.Click += new System.EventHandler(this.btnDeleteCDs_Click);
            // 
            // btnUpdateCDs
            // 
            this.btnUpdateCDs.BackColor = System.Drawing.Color.Red;
            this.btnUpdateCDs.Enabled = false;
            this.btnUpdateCDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateCDs.Location = new System.Drawing.Point(433, 309);
            this.btnUpdateCDs.Name = "btnUpdateCDs";
            this.btnUpdateCDs.Size = new System.Drawing.Size(160, 30);
            this.btnUpdateCDs.TabIndex = 88;
            this.btnUpdateCDs.Text = "Update CD";
            this.btnUpdateCDs.UseVisualStyleBackColor = false;
            this.btnUpdateCDs.Click += new System.EventHandler(this.btnUpdateCDs_Click);
            // 
            // btnCreateCDs
            // 
            this.btnCreateCDs.BackColor = System.Drawing.Color.Red;
            this.btnCreateCDs.Enabled = false;
            this.btnCreateCDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateCDs.Location = new System.Drawing.Point(599, 309);
            this.btnCreateCDs.Name = "btnCreateCDs";
            this.btnCreateCDs.Size = new System.Drawing.Size(160, 30);
            this.btnCreateCDs.TabIndex = 87;
            this.btnCreateCDs.Text = "Create new CD";
            this.btnCreateCDs.UseVisualStyleBackColor = false;
            this.btnCreateCDs.Click += new System.EventHandler(this.btnCreateCDs_Click);
            // 
            // listBoxShowAdminCDs
            // 
            this.listBoxShowAdminCDs.FormattingEnabled = true;
            this.listBoxShowAdminCDs.Location = new System.Drawing.Point(33, 372);
            this.listBoxShowAdminCDs.Name = "listBoxShowAdminCDs";
            this.listBoxShowAdminCDs.Size = new System.Drawing.Size(722, 199);
            this.listBoxShowAdminCDs.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(588, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(469, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(362, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(280, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "$";
            // 
            // txtDaysLong
            // 
            this.txtDaysLong.Location = new System.Drawing.Point(532, 256);
            this.txtDaysLong.Name = "txtDaysLong";
            this.txtDaysLong.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLong.TabIndex = 81;
            this.txtDaysLong.Text = "60";
            // 
            // labelDaysLong
            // 
            this.labelDaysLong.AutoSize = true;
            this.labelDaysLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLong.Location = new System.Drawing.Point(529, 236);
            this.labelDaysLong.Name = "labelDaysLong";
            this.labelDaysLong.Size = new System.Drawing.Size(76, 17);
            this.labelDaysLong.TabIndex = 80;
            this.labelDaysLong.Text = "DaysLong:";
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Location = new System.Drawing.Point(413, 257);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLate.TabIndex = 79;
            this.txtDaysLate.Text = "7";
            // 
            // labelDaysLate
            // 
            this.labelDaysLate.AutoSize = true;
            this.labelDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLate.Location = new System.Drawing.Point(410, 236);
            this.labelDaysLate.Name = "labelDaysLate";
            this.labelDaysLate.Size = new System.Drawing.Size(72, 17);
            this.labelDaysLate.TabIndex = 78;
            this.labelDaysLate.Text = "DaysLate:";
            // 
            // txtToLateLong
            // 
            this.txtToLateLong.Location = new System.Drawing.Point(306, 257);
            this.txtToLateLong.Name = "txtToLateLong";
            this.txtToLateLong.Size = new System.Drawing.Size(50, 20);
            this.txtToLateLong.TabIndex = 77;
            this.txtToLateLong.Text = "100";
            // 
            // labelToLateLong
            // 
            this.labelToLateLong.AutoSize = true;
            this.labelToLateLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLateLong.Location = new System.Drawing.Point(303, 236);
            this.labelToLateLong.Name = "labelToLateLong";
            this.labelToLateLong.Size = new System.Drawing.Size(89, 17);
            this.labelToLateLong.TabIndex = 76;
            this.labelToLateLong.Text = "ToLateLong:";
            // 
            // txtToLate
            // 
            this.txtToLate.Location = new System.Drawing.Point(224, 257);
            this.txtToLate.Name = "txtToLate";
            this.txtToLate.Size = new System.Drawing.Size(50, 20);
            this.txtToLate.TabIndex = 75;
            this.txtToLate.Text = "20";
            // 
            // labelToLate
            // 
            this.labelToLate.AutoSize = true;
            this.labelToLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLate.Location = new System.Drawing.Point(221, 236);
            this.labelToLate.Name = "labelToLate";
            this.labelToLate.Size = new System.Drawing.Size(57, 17);
            this.labelToLate.TabIndex = 74;
            this.labelToLate.Text = "ToLate:";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Adult Books"});
            this.comboBoxPaymentType.Enabled = false;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "CDs"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(37, 257);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPaymentType.TabIndex = 73;
            this.comboBoxPaymentType.Text = "AdultBooks";
            // 
            // labelPaymentYpe
            // 
            this.labelPaymentYpe.AutoSize = true;
            this.labelPaymentYpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentYpe.Location = new System.Drawing.Point(34, 236);
            this.labelPaymentYpe.Name = "labelPaymentYpe";
            this.labelPaymentYpe.Size = new System.Drawing.Size(103, 17);
            this.labelPaymentYpe.TabIndex = 72;
            this.labelPaymentYpe.Text = "Payment Type:";
            // 
            // comboBoxStatusType
            // 
            this.comboBoxStatusType.FormattingEnabled = true;
            this.comboBoxStatusType.Items.AddRange(new object[] {
            "Home",
            "Out of House"});
            this.comboBoxStatusType.Location = new System.Drawing.Point(595, 171);
            this.comboBoxStatusType.Name = "comboBoxStatusType";
            this.comboBoxStatusType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxStatusType.TabIndex = 71;
            this.comboBoxStatusType.Text = "Home";
            this.comboBoxStatusType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserType_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStatus.Location = new System.Drawing.Point(537, 173);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 70;
            this.labelStatus.Text = "Status:";
            // 
            // txtRendingDate
            // 
            this.txtRendingDate.Location = new System.Drawing.Point(642, 145);
            this.txtRendingDate.Name = "txtRendingDate";
            this.txtRendingDate.Size = new System.Drawing.Size(113, 20);
            this.txtRendingDate.TabIndex = 69;
            // 
            // labelRendingDate
            // 
            this.labelRendingDate.AutoSize = true;
            this.labelRendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRendingDate.Location = new System.Drawing.Point(537, 145);
            this.labelRendingDate.Name = "labelRendingDate";
            this.labelRendingDate.Size = new System.Drawing.Size(99, 17);
            this.labelRendingDate.TabIndex = 68;
            this.labelRendingDate.Text = "Rending Date:";
            // 
            // txtMax_Days_for_Lending
            // 
            this.txtMax_Days_for_Lending.Location = new System.Drawing.Point(705, 113);
            this.txtMax_Days_for_Lending.Name = "txtMax_Days_for_Lending";
            this.txtMax_Days_for_Lending.Size = new System.Drawing.Size(50, 20);
            this.txtMax_Days_for_Lending.TabIndex = 67;
            this.txtMax_Days_for_Lending.Text = "7";
            // 
            // labelMax_Days_for_Lendin
            // 
            this.labelMax_Days_for_Lendin.AutoSize = true;
            this.labelMax_Days_for_Lendin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMax_Days_for_Lendin.Location = new System.Drawing.Point(537, 113);
            this.labelMax_Days_for_Lendin.Name = "labelMax_Days_for_Lendin";
            this.labelMax_Days_for_Lendin.Size = new System.Drawing.Size(149, 17);
            this.labelMax_Days_for_Lendin.TabIndex = 66;
            this.labelMax_Days_for_Lendin.Text = "Max Days for Lending:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(33, 189);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(154, 20);
            this.txtAuthor.TabIndex = 65;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(30, 158);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 17);
            this.labelAuthor.TabIndex = 64;
            this.labelAuthor.Text = "Author:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(224, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 94);
            this.txtDescription.TabIndex = 63;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(33, 115);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 20);
            this.txtTitle.TabIndex = 62;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecription.Location = new System.Drawing.Point(221, 85);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(83, 17);
            this.labelDecription.TabIndex = 61;
            this.labelDecription.Text = "Description:";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTittle.Location = new System.Drawing.Point(30, 85);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(39, 17);
            this.labelTittle.TabIndex = 60;
            this.labelTittle.Text = "Title:";
            // 
            // txtCDId
            // 
            this.txtCDId.Enabled = false;
            this.txtCDId.Location = new System.Drawing.Point(376, 35);
            this.txtCDId.Name = "txtCDId";
            this.txtCDId.Size = new System.Drawing.Size(379, 20);
            this.txtCDId.TabIndex = 59;
            this.txtCDId.Visible = false;
            // 
            // labelAdminCDId
            // 
            this.labelAdminCDId.AutoSize = true;
            this.labelAdminCDId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAdminCDId.Location = new System.Drawing.Point(373, 7);
            this.labelAdminCDId.Name = "labelAdminCDId";
            this.labelAdminCDId.Size = new System.Drawing.Size(46, 17);
            this.labelAdminCDId.TabIndex = 58;
            this.labelAdminCDId.Text = "CD Id:";
            this.labelAdminCDId.Visible = false;
            // 
            // labelAdminCDs
            // 
            this.labelAdminCDs.AutoSize = true;
            this.labelAdminCDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminCDs.Location = new System.Drawing.Point(28, 26);
            this.labelAdminCDs.Name = "labelAdminCDs";
            this.labelAdminCDs.Size = new System.Drawing.Size(142, 29);
            this.labelAdminCDs.TabIndex = 57;
            this.labelAdminCDs.Text = "Admin CDs";
            // 
            // AdminCDsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnDeleteCDs);
            this.Controls.Add(this.btnUpdateCDs);
            this.Controls.Add(this.btnCreateCDs);
            this.Controls.Add(this.listBoxShowAdminCDs);
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
            this.Controls.Add(this.txtCDId);
            this.Controls.Add(this.labelAdminCDId);
            this.Controls.Add(this.labelAdminCDs);
            this.Name = "AdminCDsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDeleteCDs;
        private System.Windows.Forms.Button btnUpdateCDs;
        private System.Windows.Forms.Button btnCreateCDs;
        private System.Windows.Forms.ListBox listBoxShowAdminCDs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDaysLong;
        private System.Windows.Forms.Label labelDaysLong;
        private System.Windows.Forms.TextBox txtDaysLate;
        private System.Windows.Forms.Label labelDaysLate;
        private System.Windows.Forms.TextBox txtToLateLong;
        private System.Windows.Forms.Label labelToLateLong;
        private System.Windows.Forms.TextBox txtToLate;
        private System.Windows.Forms.Label labelToLate;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label labelPaymentYpe;
        private System.Windows.Forms.ComboBox comboBoxStatusType;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtRendingDate;
        private System.Windows.Forms.Label labelRendingDate;
        private System.Windows.Forms.TextBox txtMax_Days_for_Lending;
        private System.Windows.Forms.Label labelMax_Days_for_Lendin;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.TextBox txtCDId;
        private System.Windows.Forms.Label labelAdminCDId;
        private System.Windows.Forms.Label labelAdminCDs;
    }
}