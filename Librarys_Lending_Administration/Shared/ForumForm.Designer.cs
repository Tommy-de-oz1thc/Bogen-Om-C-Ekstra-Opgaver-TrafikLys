namespace Library_s_Lending_Administration.Shared
{
    partial class ForumForm
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
            this.labelForum = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxReadPost = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.checkBoxReadPost = new System.Windows.Forms.CheckBox();
            this.comboBoxIdValue = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelForum
            // 
            this.labelForum.AutoSize = true;
            this.labelForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForum.Location = new System.Drawing.Point(27, 18);
            this.labelForum.Name = "labelForum";
            this.labelForum.Size = new System.Drawing.Size(88, 29);
            this.labelForum.TabIndex = 58;
            this.labelForum.Text = "Forum";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(32, 110);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(735, 294);
            this.txtText.TabIndex = 59;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(76, 426);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(139, 20);
            this.txtAuthor.TabIndex = 60;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(29, 429);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 61;
            this.labelAuthor.Text = "Author:";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnWrite.Location = new System.Drawing.Point(620, 415);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(147, 41);
            this.btnWrite.TabIndex = 62;
            this.btnWrite.Text = "Write new Post";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Visible = false;
            this.btnWrite.Click += new System.EventHandler(this.btnForumCreate_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(35, 94);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(31, 13);
            this.labelText.TabIndex = 63;
            this.labelText.Text = "Text:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(99, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(261, 20);
            this.txtTitle.TabIndex = 64;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(35, 62);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 65;
            this.labelTitle.Text = "Title:";
            // 
            // comboBoxReadPost
            // 
            this.comboBoxReadPost.FormattingEnabled = true;
            this.comboBoxReadPost.Location = new System.Drawing.Point(466, 57);
            this.comboBoxReadPost.Name = "comboBoxReadPost";
            this.comboBoxReadPost.Size = new System.Drawing.Size(301, 21);
            this.comboBoxReadPost.TabIndex = 67;
            this.comboBoxReadPost.Text = "Select a Item";
            this.comboBoxReadPost.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(485, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 41);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear Post";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(249, 433);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 69;
            this.labelDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(288, 429);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 20);
            this.txtDate.TabIndex = 70;
            // 
            // checkBoxReadPost
            // 
            this.checkBoxReadPost.AutoSize = true;
            this.checkBoxReadPost.Checked = true;
            this.checkBoxReadPost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReadPost.Location = new System.Drawing.Point(466, 34);
            this.checkBoxReadPost.Name = "checkBoxReadPost";
            this.checkBoxReadPost.Size = new System.Drawing.Size(246, 17);
            this.checkBoxReadPost.TabIndex = 71;
            this.checkBoxReadPost.Text = "unheckBox To Write a Post and get auto Date";
            this.checkBoxReadPost.UseVisualStyleBackColor = true;
            this.checkBoxReadPost.CheckedChanged += new System.EventHandler(this.checkBoxReadPost_CheckedChanged);
            // 
            // comboBoxIdValue
            // 
            this.comboBoxIdValue.Enabled = false;
            this.comboBoxIdValue.FormattingEnabled = true;
            this.comboBoxIdValue.Location = new System.Drawing.Point(466, 7);
            this.comboBoxIdValue.Name = "comboBoxIdValue";
            this.comboBoxIdValue.Size = new System.Drawing.Size(301, 21);
            this.comboBoxIdValue.TabIndex = 72;
            this.comboBoxIdValue.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(213, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 41);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete Post";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Enabled = false;
            this.checkBoxDelete.Location = new System.Drawing.Point(466, 7);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(237, 17);
            this.checkBoxDelete.TabIndex = 74;
            this.checkBoxDelete.Text = "checkBox To Delete Post and get auto Date";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.Visible = false;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxIdValue);
            this.Controls.Add(this.checkBoxReadPost);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboBoxReadPost);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.labelForum);
            this.Name = "ForumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library\'s Lending Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForum;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxReadPost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.CheckBox checkBoxReadPost;
        private System.Windows.Forms.ComboBox comboBoxIdValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBoxDelete;
    }
}