namespace Library_s_Lending_Administration.Admin
{
    partial class AdminDVDMoviesForm
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
            this.btnDeleteDVDMovies = new System.Windows.Forms.Button();
            this.btnUpdateDVDMovies = new System.Windows.Forms.Button();
            this.btnCreateDVDMovies = new System.Windows.Forms.Button();
            this.listBoxShowDVDMovies = new System.Windows.Forms.ListBox();
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
            this.txtDVDMovieId = new System.Windows.Forms.TextBox();
            this.labelAdminDVDMoviesId = new System.Windows.Forms.Label();
            this.labelAdminDVDMovies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPayment.Location = new System.Drawing.Point(652, 220);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(107, 55);
            this.btnPayment.TabIndex = 90;
            this.btnPayment.Text = "Update Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDeleteDVDMovies
            // 
            this.btnDeleteDVDMovies.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDVDMovies.Enabled = false;
            this.btnDeleteDVDMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteDVDMovies.Location = new System.Drawing.Point(271, 308);
            this.btnDeleteDVDMovies.Name = "btnDeleteDVDMovies";
            this.btnDeleteDVDMovies.Size = new System.Drawing.Size(160, 30);
            this.btnDeleteDVDMovies.TabIndex = 89;
            this.btnDeleteDVDMovies.Text = "Delete DVD";
            this.btnDeleteDVDMovies.UseVisualStyleBackColor = false;
            this.btnDeleteDVDMovies.Click += new System.EventHandler(this.btnDeleteDVDMovies_Click);
            // 
            // btnUpdateDVDMovies
            // 
            this.btnUpdateDVDMovies.BackColor = System.Drawing.Color.Red;
            this.btnUpdateDVDMovies.Enabled = false;
            this.btnUpdateDVDMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateDVDMovies.Location = new System.Drawing.Point(437, 308);
            this.btnUpdateDVDMovies.Name = "btnUpdateDVDMovies";
            this.btnUpdateDVDMovies.Size = new System.Drawing.Size(160, 30);
            this.btnUpdateDVDMovies.TabIndex = 88;
            this.btnUpdateDVDMovies.Text = "Update DVD";
            this.btnUpdateDVDMovies.UseVisualStyleBackColor = false;
            this.btnUpdateDVDMovies.Click += new System.EventHandler(this.btnUpdateDVDMovies_Click);
            // 
            // btnCreateDVDMovies
            // 
            this.btnCreateDVDMovies.BackColor = System.Drawing.Color.Red;
            this.btnCreateDVDMovies.Enabled = false;
            this.btnCreateDVDMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateDVDMovies.Location = new System.Drawing.Point(603, 308);
            this.btnCreateDVDMovies.Name = "btnCreateDVDMovies";
            this.btnCreateDVDMovies.Size = new System.Drawing.Size(160, 30);
            this.btnCreateDVDMovies.TabIndex = 87;
            this.btnCreateDVDMovies.Text = "Create new DVD";
            this.btnCreateDVDMovies.UseVisualStyleBackColor = false;
            this.btnCreateDVDMovies.Click += new System.EventHandler(this.btnCreateDVDMovies_Click);
            // 
            // listBoxShowDVDMovies
            // 
            this.listBoxShowDVDMovies.FormattingEnabled = true;
            this.listBoxShowDVDMovies.Location = new System.Drawing.Point(37, 371);
            this.listBoxShowDVDMovies.Name = "listBoxShowDVDMovies";
            this.listBoxShowDVDMovies.Size = new System.Drawing.Size(722, 199);
            this.listBoxShowDVDMovies.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(592, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(473, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(366, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(284, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "$";
            // 
            // txtDaysLong
            // 
            this.txtDaysLong.Location = new System.Drawing.Point(536, 255);
            this.txtDaysLong.Name = "txtDaysLong";
            this.txtDaysLong.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLong.TabIndex = 81;
            this.txtDaysLong.Text = "60";
            // 
            // labelDaysLong
            // 
            this.labelDaysLong.AutoSize = true;
            this.labelDaysLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLong.Location = new System.Drawing.Point(533, 235);
            this.labelDaysLong.Name = "labelDaysLong";
            this.labelDaysLong.Size = new System.Drawing.Size(76, 17);
            this.labelDaysLong.TabIndex = 80;
            this.labelDaysLong.Text = "DaysLong:";
            // 
            // txtDaysLate
            // 
            this.txtDaysLate.Location = new System.Drawing.Point(417, 256);
            this.txtDaysLate.Name = "txtDaysLate";
            this.txtDaysLate.Size = new System.Drawing.Size(50, 20);
            this.txtDaysLate.TabIndex = 79;
            this.txtDaysLate.Text = "7";
            // 
            // labelDaysLate
            // 
            this.labelDaysLate.AutoSize = true;
            this.labelDaysLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDaysLate.Location = new System.Drawing.Point(414, 235);
            this.labelDaysLate.Name = "labelDaysLate";
            this.labelDaysLate.Size = new System.Drawing.Size(72, 17);
            this.labelDaysLate.TabIndex = 78;
            this.labelDaysLate.Text = "DaysLate:";
            // 
            // txtToLateLong
            // 
            this.txtToLateLong.Location = new System.Drawing.Point(310, 256);
            this.txtToLateLong.Name = "txtToLateLong";
            this.txtToLateLong.Size = new System.Drawing.Size(50, 20);
            this.txtToLateLong.TabIndex = 77;
            this.txtToLateLong.Text = "100";
            // 
            // labelToLateLong
            // 
            this.labelToLateLong.AutoSize = true;
            this.labelToLateLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLateLong.Location = new System.Drawing.Point(307, 235);
            this.labelToLateLong.Name = "labelToLateLong";
            this.labelToLateLong.Size = new System.Drawing.Size(89, 17);
            this.labelToLateLong.TabIndex = 76;
            this.labelToLateLong.Text = "ToLateLong:";
            // 
            // txtToLate
            // 
            this.txtToLate.Location = new System.Drawing.Point(228, 256);
            this.txtToLate.Name = "txtToLate";
            this.txtToLate.Size = new System.Drawing.Size(50, 20);
            this.txtToLate.TabIndex = 75;
            this.txtToLate.Text = "20";
            // 
            // labelToLate
            // 
            this.labelToLate.AutoSize = true;
            this.labelToLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelToLate.Location = new System.Drawing.Point(225, 235);
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
            "DVDMovies"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(44, 260);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxPaymentType.TabIndex = 73;
            this.comboBoxPaymentType.Text = "DVDMovies";
            // 
            // labelPaymentYpe
            // 
            this.labelPaymentYpe.AutoSize = true;
            this.labelPaymentYpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentYpe.Location = new System.Drawing.Point(38, 235);
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
            this.comboBoxStatusType.Location = new System.Drawing.Point(599, 170);
            this.comboBoxStatusType.Name = "comboBoxStatusType";
            this.comboBoxStatusType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxStatusType.TabIndex = 71;
            this.comboBoxStatusType.Text = "Home";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStatus.Location = new System.Drawing.Point(541, 172);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 70;
            this.labelStatus.Text = "Status:";
            this.labelStatus.Visible = false;
            // 
            // txtRendingDate
            // 
            this.txtRendingDate.Location = new System.Drawing.Point(646, 144);
            this.txtRendingDate.Name = "txtRendingDate";
            this.txtRendingDate.Size = new System.Drawing.Size(113, 20);
            this.txtRendingDate.TabIndex = 69;
            // 
            // labelRendingDate
            // 
            this.labelRendingDate.AutoSize = true;
            this.labelRendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRendingDate.Location = new System.Drawing.Point(541, 144);
            this.labelRendingDate.Name = "labelRendingDate";
            this.labelRendingDate.Size = new System.Drawing.Size(99, 17);
            this.labelRendingDate.TabIndex = 68;
            this.labelRendingDate.Text = "Rending Date:";
            // 
            // txtMax_Days_for_Lending
            // 
            this.txtMax_Days_for_Lending.Location = new System.Drawing.Point(709, 112);
            this.txtMax_Days_for_Lending.Name = "txtMax_Days_for_Lending";
            this.txtMax_Days_for_Lending.Size = new System.Drawing.Size(50, 20);
            this.txtMax_Days_for_Lending.TabIndex = 67;
            this.txtMax_Days_for_Lending.Text = "30";
            // 
            // labelMax_Days_for_Lendin
            // 
            this.labelMax_Days_for_Lendin.AutoSize = true;
            this.labelMax_Days_for_Lendin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMax_Days_for_Lendin.Location = new System.Drawing.Point(541, 112);
            this.labelMax_Days_for_Lendin.Name = "labelMax_Days_for_Lendin";
            this.labelMax_Days_for_Lendin.Size = new System.Drawing.Size(149, 17);
            this.labelMax_Days_for_Lendin.TabIndex = 66;
            this.labelMax_Days_for_Lendin.Text = "Max Days for Lending:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(37, 188);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(154, 20);
            this.txtAuthor.TabIndex = 65;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(34, 157);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 17);
            this.labelAuthor.TabIndex = 64;
            this.labelAuthor.Text = "Author:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(228, 114);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 94);
            this.txtDescription.TabIndex = 63;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(37, 114);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 20);
            this.txtTitle.TabIndex = 62;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecription.Location = new System.Drawing.Point(225, 84);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(83, 17);
            this.labelDecription.TabIndex = 61;
            this.labelDecription.Text = "Description:";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTittle.Location = new System.Drawing.Point(34, 84);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(39, 17);
            this.labelTittle.TabIndex = 60;
            this.labelTittle.Text = "Title:";
            // 
            // txtDVDMovieId
            // 
            this.txtDVDMovieId.Enabled = false;
            this.txtDVDMovieId.Location = new System.Drawing.Point(380, 34);
            this.txtDVDMovieId.Name = "txtDVDMovieId";
            this.txtDVDMovieId.Size = new System.Drawing.Size(379, 20);
            this.txtDVDMovieId.TabIndex = 59;
            this.txtDVDMovieId.Visible = false;
            // 
            // labelAdminDVDMoviesId
            // 
            this.labelAdminDVDMoviesId.AutoSize = true;
            this.labelAdminDVDMoviesId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAdminDVDMoviesId.Location = new System.Drawing.Point(377, 6);
            this.labelAdminDVDMoviesId.Name = "labelAdminDVDMoviesId";
            this.labelAdminDVDMoviesId.Size = new System.Drawing.Size(104, 17);
            this.labelAdminDVDMoviesId.TabIndex = 58;
            this.labelAdminDVDMoviesId.Text = "DVD Movies Id:";
            this.labelAdminDVDMoviesId.Visible = false;
            // 
            // labelAdminDVDMovies
            // 
            this.labelAdminDVDMovies.AutoSize = true;
            this.labelAdminDVDMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminDVDMovies.Location = new System.Drawing.Point(32, 25);
            this.labelAdminDVDMovies.Name = "labelAdminDVDMovies";
            this.labelAdminDVDMovies.Size = new System.Drawing.Size(235, 29);
            this.labelAdminDVDMovies.TabIndex = 57;
            this.labelAdminDVDMovies.Text = "Admin DVD Movies";
            // 
            // AdminDVDMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnDeleteDVDMovies);
            this.Controls.Add(this.btnUpdateDVDMovies);
            this.Controls.Add(this.btnCreateDVDMovies);
            this.Controls.Add(this.listBoxShowDVDMovies);
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
            this.Controls.Add(this.txtDVDMovieId);
            this.Controls.Add(this.labelAdminDVDMoviesId);
            this.Controls.Add(this.labelAdminDVDMovies);
            this.Name = "AdminDVDMoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDeleteDVDMovies;
        private System.Windows.Forms.Button btnUpdateDVDMovies;
        private System.Windows.Forms.Button btnCreateDVDMovies;
        private System.Windows.Forms.ListBox listBoxShowDVDMovies;
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
        private System.Windows.Forms.TextBox txtDVDMovieId;
        private System.Windows.Forms.Label labelAdminDVDMoviesId;
        private System.Windows.Forms.Label labelAdminDVDMovies;
    }
}