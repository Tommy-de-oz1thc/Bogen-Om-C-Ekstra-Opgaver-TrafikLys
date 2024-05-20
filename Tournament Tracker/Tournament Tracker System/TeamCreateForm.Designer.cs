namespace Tournament_Tracker
{
    partial class TeamCreateForm
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
            HeaderLB = new Label();
            TeamNameLB = new Label();
            TeamNameTB = new TextBox();
            SelectTeamLB = new Label();
            SelectTeamMembercomboBox = new ComboBox();
            AddMember = new Button();
            memberGroupBox = new GroupBox();
            CreateMemberBTN = new Button();
            CellphoneTB = new TextBox();
            EmailTB = new TextBox();
            LastNameTB = new TextBox();
            FirstNameTB = new TextBox();
            CellphoneLB = new Label();
            EmailLB = new Label();
            LastNameLB = new Label();
            FirstNameLB = new Label();
            teamMembersListBox = new ListBox();
            CreateTeamBTN = new Button();
            RemoveBNT = new Button();
            memberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLB.Location = new Point(32, 24);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(118, 25);
            HeaderLB.TabIndex = 0;
            HeaderLB.Text = "Create Team";
            // 
            // TeamNameLB
            // 
            TeamNameLB.AutoSize = true;
            TeamNameLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamNameLB.Location = new Point(32, 68);
            TeamNameLB.Name = "TeamNameLB";
            TeamNameLB.Size = new Size(95, 21);
            TeamNameLB.TabIndex = 1;
            TeamNameLB.Text = "Team Name";
            // 
            // TeamNameTB
            // 
            TeamNameTB.Font = new Font("Segoe UI", 12F);
            TeamNameTB.Location = new Point(36, 97);
            TeamNameTB.Name = "TeamNameTB";
            TeamNameTB.Size = new Size(210, 29);
            TeamNameTB.TabIndex = 2;
            // 
            // SelectTeamLB
            // 
            SelectTeamLB.AutoSize = true;
            SelectTeamLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectTeamLB.Location = new Point(32, 140);
            SelectTeamLB.Name = "SelectTeamLB";
            SelectTeamLB.Size = new Size(164, 21);
            SelectTeamLB.TabIndex = 3;
            SelectTeamLB.Text = "Select Team Member";
            // 
            // SelectTeamMembercomboBox
            // 
            SelectTeamMembercomboBox.Font = new Font("Segoe UI", 12F);
            SelectTeamMembercomboBox.FormattingEnabled = true;
            SelectTeamMembercomboBox.Location = new Point(38, 173);
            SelectTeamMembercomboBox.Name = "SelectTeamMembercomboBox";
            SelectTeamMembercomboBox.Size = new Size(208, 29);
            SelectTeamMembercomboBox.TabIndex = 4;
            // 
            // AddMember
            // 
            AddMember.BackColor = Color.White;
            AddMember.FlatStyle = FlatStyle.Flat;
            AddMember.Font = new Font("Segoe UI", 12F);
            AddMember.Location = new Point(78, 213);
            AddMember.Name = "AddMember";
            AddMember.Size = new Size(118, 35);
            AddMember.TabIndex = 5;
            AddMember.Text = "Add Member";
            AddMember.UseVisualStyleBackColor = false;
            AddMember.Click += AddMember_Click;
            // 
            // memberGroupBox
            // 
            memberGroupBox.Controls.Add(CreateMemberBTN);
            memberGroupBox.Controls.Add(CellphoneTB);
            memberGroupBox.Controls.Add(EmailTB);
            memberGroupBox.Controls.Add(LastNameTB);
            memberGroupBox.Controls.Add(FirstNameTB);
            memberGroupBox.Controls.Add(CellphoneLB);
            memberGroupBox.Controls.Add(EmailLB);
            memberGroupBox.Controls.Add(LastNameLB);
            memberGroupBox.Controls.Add(FirstNameLB);
            memberGroupBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            memberGroupBox.ForeColor = Color.DodgerBlue;
            memberGroupBox.Location = new Point(32, 276);
            memberGroupBox.Name = "memberGroupBox";
            memberGroupBox.Size = new Size(300, 261);
            memberGroupBox.TabIndex = 7;
            memberGroupBox.TabStop = false;
            memberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberBTN
            // 
            CreateMemberBTN.BackColor = Color.White;
            CreateMemberBTN.FlatStyle = FlatStyle.Flat;
            CreateMemberBTN.Font = new Font("Segoe UI", 12F);
            CreateMemberBTN.Location = new Point(114, 202);
            CreateMemberBTN.Name = "CreateMemberBTN";
            CreateMemberBTN.Size = new Size(167, 35);
            CreateMemberBTN.TabIndex = 10;
            CreateMemberBTN.Text = "Create Member";
            CreateMemberBTN.UseVisualStyleBackColor = false;
            CreateMemberBTN.Click += CreateMemberBTN_Click;
            // 
            // CellphoneTB
            // 
            CellphoneTB.Font = new Font("Segoe UI", 12F);
            CellphoneTB.Location = new Point(114, 154);
            CellphoneTB.Name = "CellphoneTB";
            CellphoneTB.Size = new Size(167, 29);
            CellphoneTB.TabIndex = 9;
            // 
            // EmailTB
            // 
            EmailTB.Font = new Font("Segoe UI", 12F);
            EmailTB.Location = new Point(114, 116);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(167, 29);
            EmailTB.TabIndex = 8;
            // 
            // LastNameTB
            // 
            LastNameTB.Font = new Font("Segoe UI", 12F);
            LastNameTB.Location = new Point(114, 81);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(167, 29);
            LastNameTB.TabIndex = 7;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Font = new Font("Segoe UI", 12F);
            FirstNameTB.Location = new Point(114, 43);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(167, 29);
            FirstNameTB.TabIndex = 6;
            // 
            // CellphoneLB
            // 
            CellphoneLB.AutoSize = true;
            CellphoneLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CellphoneLB.Location = new Point(7, 154);
            CellphoneLB.Name = "CellphoneLB";
            CellphoneLB.Size = new Size(84, 21);
            CellphoneLB.TabIndex = 5;
            CellphoneLB.Text = "Cellphone";
            // 
            // EmailLB
            // 
            EmailLB.AutoSize = true;
            EmailLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLB.Location = new Point(7, 116);
            EmailLB.Name = "EmailLB";
            EmailLB.Size = new Size(55, 21);
            EmailLB.TabIndex = 4;
            EmailLB.Text = "E-Mail";
            // 
            // LastNameLB
            // 
            LastNameLB.AutoSize = true;
            LastNameLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLB.Location = new Point(7, 81);
            LastNameLB.Name = "LastNameLB";
            LastNameLB.Size = new Size(86, 21);
            LastNameLB.TabIndex = 3;
            LastNameLB.Text = "Last Name";
            // 
            // FirstNameLB
            // 
            FirstNameLB.AutoSize = true;
            FirstNameLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLB.Location = new Point(6, 46);
            FirstNameLB.Name = "FirstNameLB";
            FirstNameLB.Size = new Size(88, 21);
            FirstNameLB.TabIndex = 2;
            FirstNameLB.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 12F);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 21;
            teamMembersListBox.Location = new Point(399, 90);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(353, 445);
            teamMembersListBox.TabIndex = 8;
            // 
            // CreateTeamBTN
            // 
            CreateTeamBTN.BackColor = Color.White;
            CreateTeamBTN.FlatStyle = FlatStyle.Flat;
            CreateTeamBTN.Font = new Font("Segoe UI", 12F);
            CreateTeamBTN.Location = new Point(300, 562);
            CreateTeamBTN.Name = "CreateTeamBTN";
            CreateTeamBTN.Size = new Size(167, 35);
            CreateTeamBTN.TabIndex = 11;
            CreateTeamBTN.Text = "Create Team";
            CreateTeamBTN.UseVisualStyleBackColor = false;
            CreateTeamBTN.Click += CreateTeamBTN_Click;
            // 
            // RemoveBNT
            // 
            RemoveBNT.BackColor = Color.White;
            RemoveBNT.FlatStyle = FlatStyle.Flat;
            RemoveBNT.Font = new Font("Segoe UI", 12F);
            RemoveBNT.Location = new Point(768, 90);
            RemoveBNT.Name = "RemoveBNT";
            RemoveBNT.Size = new Size(88, 75);
            RemoveBNT.TabIndex = 12;
            RemoveBNT.Text = "Remove Selected";
            RemoveBNT.UseVisualStyleBackColor = false;
            RemoveBNT.Click += RemoveBNT_Click;
            // 
            // TeamCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(877, 620);
            Controls.Add(RemoveBNT);
            Controls.Add(CreateTeamBTN);
            Controls.Add(teamMembersListBox);
            Controls.Add(memberGroupBox);
            Controls.Add(AddMember);
            Controls.Add(SelectTeamMembercomboBox);
            Controls.Add(SelectTeamLB);
            Controls.Add(TeamNameTB);
            Controls.Add(TeamNameLB);
            Controls.Add(HeaderLB);
            ForeColor = Color.DodgerBlue;
            Name = "TeamCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Team Creater";
            memberGroupBox.ResumeLayout(false);
            memberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLB;
        private Label TeamNameLB;
        private TextBox TeamNameTB;
        private Label SelectTeamLB;
        private ComboBox SelectTeamMembercomboBox;
        private Button AddMember;
        private GroupBox memberGroupBox;
        private TextBox CellphoneTB;
        private TextBox EmailTB;
        private TextBox LastNameTB;
        private TextBox FirstNameTB;
        private Label CellphoneLB;
        private Label EmailLB;
        private Label LastNameLB;
        private Label FirstNameLB;
        private Button CreateMemberBTN;
        private ListBox teamMembersListBox;
        private Button CreateTeamBTN;
        private Button RemoveBNT;
    }
}