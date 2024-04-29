namespace Library_s_Lending_Administration.Shared
{
    partial class ShowForm
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
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.labelPaymentYpe = new System.Windows.Forms.Label();
            this.txtRendingDate = new System.Windows.Forms.TextBox();
            this.labelRendingDate = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelDecription = new System.Windows.Forms.Label();
            this.labelTittle = new System.Windows.Forms.Label();
            this.txtAdultBookId = new System.Windows.Forms.TextBox();
            this.labelAdminAdultBookId = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxShow
            // 
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.ItemHeight = 20;
            this.listBoxShow.Location = new System.Drawing.Point(60, 406);
            this.listBoxShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(1081, 464);
            this.listBoxShow.TabIndex = 86;
            this.listBoxShow.Click += new System.EventHandler(this.listBoxShow_Click);
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Adult Books"});
            this.comboBoxPaymentType.Enabled = false;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "AdultBooks"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(974, 257);
            this.comboBoxPaymentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(162, 28);
            this.comboBoxPaymentType.TabIndex = 73;
            this.comboBoxPaymentType.Text = "AdultBooks";
            // 
            // labelPaymentYpe
            // 
            this.labelPaymentYpe.AutoSize = true;
            this.labelPaymentYpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPaymentYpe.Location = new System.Drawing.Point(816, 257);
            this.labelPaymentYpe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPaymentYpe.Name = "labelPaymentYpe";
            this.labelPaymentYpe.Size = new System.Drawing.Size(103, 17);
            this.labelPaymentYpe.TabIndex = 72;
            this.labelPaymentYpe.Text = "Payment Type:";
            // 
            // txtRendingDate
            // 
            this.txtRendingDate.Location = new System.Drawing.Point(974, 217);
            this.txtRendingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRendingDate.Name = "txtRendingDate";
            this.txtRendingDate.Size = new System.Drawing.Size(168, 26);
            this.txtRendingDate.TabIndex = 69;
            // 
            // labelRendingDate
            // 
            this.labelRendingDate.AutoSize = true;
            this.labelRendingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRendingDate.Location = new System.Drawing.Point(816, 217);
            this.labelRendingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRendingDate.Name = "labelRendingDate";
            this.labelRendingDate.Size = new System.Drawing.Size(99, 17);
            this.labelRendingDate.TabIndex = 68;
            this.labelRendingDate.Text = "Rending Date:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(60, 285);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(229, 26);
            this.txtAuthor.TabIndex = 65;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAuthor.Location = new System.Drawing.Point(56, 237);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(54, 17);
            this.labelAuthor.TabIndex = 64;
            this.labelAuthor.Text = "Author:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(346, 171);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(403, 142);
            this.txtDescription.TabIndex = 63;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 171);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 26);
            this.txtTitle.TabIndex = 62;
            // 
            // labelDecription
            // 
            this.labelDecription.AutoSize = true;
            this.labelDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDecription.Location = new System.Drawing.Point(342, 125);
            this.labelDecription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecription.Name = "labelDecription";
            this.labelDecription.Size = new System.Drawing.Size(83, 17);
            this.labelDecription.TabIndex = 61;
            this.labelDecription.Text = "Description:";
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTittle.Location = new System.Drawing.Point(56, 125);
            this.labelTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(39, 17);
            this.labelTittle.TabIndex = 60;
            this.labelTittle.Text = "Title:";
            // 
            // txtAdultBookId
            // 
            this.txtAdultBookId.Enabled = false;
            this.txtAdultBookId.Location = new System.Drawing.Point(574, 48);
            this.txtAdultBookId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdultBookId.Name = "txtAdultBookId";
            this.txtAdultBookId.Size = new System.Drawing.Size(566, 26);
            this.txtAdultBookId.TabIndex = 59;
            this.txtAdultBookId.Visible = false;
            // 
            // labelAdminAdultBookId
            // 
            this.labelAdminAdultBookId.AutoSize = true;
            this.labelAdminAdultBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAdminAdultBookId.Location = new System.Drawing.Point(570, 5);
            this.labelAdminAdultBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdminAdultBookId.Name = "labelAdminAdultBookId";
            this.labelAdminAdultBookId.Size = new System.Drawing.Size(95, 17);
            this.labelAdminAdultBookId.TabIndex = 58;
            this.labelAdminAdultBookId.Text = "Adult Book Id:";
            this.labelAdminAdultBookId.Visible = false;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(52, 34);
            this.labelShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(229, 29);
            this.labelShow.TabIndex = 57;
            this.labelShow.Text = "Show All Lendings";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUser.Location = new System.Drawing.Point(56, 348);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(42, 17);
            this.labelUser.TabIndex = 87;
            this.labelUser.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(122, 348);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(272, 26);
            this.txtUser.TabIndex = 88;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReturn.Location = new System.Drawing.Point(974, 308);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 66);
            this.btnReturn.TabIndex = 89;
            this.btnReturn.Text = "Return Item";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 922);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.listBoxShow);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.labelPaymentYpe);
            this.Controls.Add(this.txtRendingDate);
            this.Controls.Add(this.labelRendingDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelDecription);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.txtAdultBookId);
            this.Controls.Add(this.labelAdminAdultBookId);
            this.Controls.Add(this.labelShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label labelPaymentYpe;
        private System.Windows.Forms.TextBox txtRendingDate;
        private System.Windows.Forms.Label labelRendingDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelDecription;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.TextBox txtAdultBookId;
        private System.Windows.Forms.Label labelAdminAdultBookId;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnReturn;
    }
}