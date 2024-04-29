namespace Library_s_Lending_Administration.User
{
    partial class UserChildrenBooksForm
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
            this.listBoxLentBooks = new System.Windows.Forms.ListBox();
            this.labelLentBooks = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.comboBoxIdValue = new System.Windows.Forms.ComboBox();
            this.comboBoxReadPost = new System.Windows.Forms.ComboBox();
            this.labelUserChildrenBooks = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxLentBooks
            // 
            this.listBoxLentBooks.FormattingEnabled = true;
            this.listBoxLentBooks.Location = new System.Drawing.Point(22, 347);
            this.listBoxLentBooks.Name = "listBoxLentBooks";
            this.listBoxLentBooks.Size = new System.Drawing.Size(734, 121);
            this.listBoxLentBooks.TabIndex = 106;
            // 
            // labelLentBooks
            // 
            this.labelLentBooks.AutoSize = true;
            this.labelLentBooks.Location = new System.Drawing.Point(20, 324);
            this.labelLentBooks.Name = "labelLentBooks";
            this.labelLentBooks.Size = new System.Drawing.Size(73, 13);
            this.labelLentBooks.TabIndex = 105;
            this.labelLentBooks.Text = "Lentet Books:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(274, 290);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 20);
            this.txtDate.TabIndex = 104;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(235, 294);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 103;
            this.labelDate.Text = "Date:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(471, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 41);
            this.btnClear.TabIndex = 102;
            this.btnClear.Text = "Clear Post";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(20, 77);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 101;
            this.labelTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(84, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(261, 20);
            this.txtTitle.TabIndex = 100;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(20, 109);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(60, 13);
            this.labelText.TabIndex = 99;
            this.labelText.Text = "Desciption:";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWrite.Location = new System.Drawing.Point(606, 276);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 41);
            this.btnWrite.TabIndex = 98;
            this.btnWrite.Text = "Lent Book";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Visible = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(15, 290);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 97;
            this.labelAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(62, 287);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(139, 20);
            this.txtAuthor.TabIndex = 96;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(17, 125);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(735, 122);
            this.txtText.TabIndex = 95;
            // 
            // comboBoxIdValue
            // 
            this.comboBoxIdValue.Enabled = false;
            this.comboBoxIdValue.FormattingEnabled = true;
            this.comboBoxIdValue.Location = new System.Drawing.Point(456, 58);
            this.comboBoxIdValue.Name = "comboBoxIdValue";
            this.comboBoxIdValue.Size = new System.Drawing.Size(301, 21);
            this.comboBoxIdValue.TabIndex = 94;
            this.comboBoxIdValue.Visible = false;
            // 
            // comboBoxReadPost
            // 
            this.comboBoxReadPost.FormattingEnabled = true;
            this.comboBoxReadPost.Location = new System.Drawing.Point(456, 88);
            this.comboBoxReadPost.Name = "comboBoxReadPost";
            this.comboBoxReadPost.Size = new System.Drawing.Size(301, 21);
            this.comboBoxReadPost.TabIndex = 93;
            this.comboBoxReadPost.Text = "Select a Item";
            // 
            // labelUserChildrenBooks
            // 
            this.labelUserChildrenBooks.AutoSize = true;
            this.labelUserChildrenBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserChildrenBooks.Location = new System.Drawing.Point(12, 22);
            this.labelUserChildrenBooks.Name = "labelUserChildrenBooks";
            this.labelUserChildrenBooks.Size = new System.Drawing.Size(284, 29);
            this.labelUserChildrenBooks.TabIndex = 92;
            this.labelUserChildrenBooks.Text = "User Childdren Boooks";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(467, 7);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(186, 48);
            this.labelInfo.TabIndex = 107;
            this.labelInfo.Text = "Choose  from the List\r\nto show the Data";
            // 
            // UserChildrenBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxLentBooks);
            this.Controls.Add(this.labelLentBooks);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.comboBoxIdValue);
            this.Controls.Add(this.comboBoxReadPost);
            this.Controls.Add(this.labelUserChildrenBooks);
            this.Name = "UserChildrenBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLentBooks;
        private System.Windows.Forms.Label labelLentBooks;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ComboBox comboBoxIdValue;
        private System.Windows.Forms.ComboBox comboBoxReadPost;
        private System.Windows.Forms.Label labelUserChildrenBooks;
        private System.Windows.Forms.Label labelInfo;
    }
}