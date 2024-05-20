namespace Tournament_Tracker
{
    partial class TournamentCreateForm
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
            TournamentNameLB = new Label();
            TournamentNameTB = new TextBox();
            EntryFeeLB = new Label();
            EntryFeeTB = new TextBox();
            SelctTeamLB = new Label();
            SelectTeamComboBox = new ComboBox();
            AddTeamBTN = new Button();
            CreatePrizeBTN = new Button();
            TeamPlayersLB = new Label();
            tournamentTeamsListBox = new ListBox();
            PrizesLB = new Label();
            prizesListBox = new ListBox();
            TeamPlayersDeleteBTN = new Button();
            PrizesDeleteBTN = new Button();
            CreateTournamentBTN = new Button();
            NewTeamLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLB.Location = new Point(28, 23);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(181, 25);
            HeaderLB.TabIndex = 0;
            HeaderLB.Text = "Create Tournament ";
            // 
            // TournamentNameLB
            // 
            TournamentNameLB.AutoSize = true;
            TournamentNameLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentNameLB.Location = new Point(28, 68);
            TournamentNameLB.Name = "TournamentNameLB";
            TournamentNameLB.Size = new Size(148, 21);
            TournamentNameLB.TabIndex = 1;
            TournamentNameLB.Text = "Tournament  Name";
            // 
            // TournamentNameTB
            // 
            TournamentNameTB.Font = new Font("Segoe UI", 12F);
            TournamentNameTB.Location = new Point(33, 97);
            TournamentNameTB.Name = "TournamentNameTB";
            TournamentNameTB.Size = new Size(176, 29);
            TournamentNameTB.TabIndex = 2;
            // 
            // EntryFeeLB
            // 
            EntryFeeLB.AutoSize = true;
            EntryFeeLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EntryFeeLB.Location = new Point(33, 160);
            EntryFeeLB.Name = "EntryFeeLB";
            EntryFeeLB.Size = new Size(78, 21);
            EntryFeeLB.TabIndex = 3;
            EntryFeeLB.Text = "Entry Fee";
            // 
            // EntryFeeTB
            // 
            EntryFeeTB.Font = new Font("Segoe UI", 12F);
            EntryFeeTB.Location = new Point(117, 152);
            EntryFeeTB.Name = "EntryFeeTB";
            EntryFeeTB.Size = new Size(92, 29);
            EntryFeeTB.TabIndex = 4;
            EntryFeeTB.Text = "0";
            // 
            // SelctTeamLB
            // 
            SelctTeamLB.AutoSize = true;
            SelctTeamLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelctTeamLB.Location = new Point(35, 223);
            SelctTeamLB.Name = "SelctTeamLB";
            SelctTeamLB.Size = new Size(97, 21);
            SelctTeamLB.TabIndex = 5;
            SelctTeamLB.Text = "Select Team";
            // 
            // SelectTeamComboBox
            // 
            SelectTeamComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectTeamComboBox.FormattingEnabled = true;
            SelectTeamComboBox.Location = new Point(40, 253);
            SelectTeamComboBox.Name = "SelectTeamComboBox";
            SelectTeamComboBox.Size = new Size(171, 29);
            SelectTeamComboBox.TabIndex = 7;
            // 
            // AddTeamBTN
            // 
            AddTeamBTN.BackColor = Color.White;
            AddTeamBTN.FlatStyle = FlatStyle.Flat;
            AddTeamBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamBTN.Location = new Point(69, 301);
            AddTeamBTN.Name = "AddTeamBTN";
            AddTeamBTN.Size = new Size(123, 31);
            AddTeamBTN.TabIndex = 8;
            AddTeamBTN.Text = "Add Team";
            AddTeamBTN.UseVisualStyleBackColor = false;
            AddTeamBTN.Click += AddTeamBTN_Click;
            // 
            // CreatePrizeBTN
            // 
            CreatePrizeBTN.BackColor = Color.White;
            CreatePrizeBTN.FlatStyle = FlatStyle.Flat;
            CreatePrizeBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeBTN.Location = new Point(69, 369);
            CreatePrizeBTN.Name = "CreatePrizeBTN";
            CreatePrizeBTN.Size = new Size(123, 31);
            CreatePrizeBTN.TabIndex = 9;
            CreatePrizeBTN.Text = "Create Prize";
            CreatePrizeBTN.UseVisualStyleBackColor = false;
            CreatePrizeBTN.Click += CreatePrizeBTN_Click;
            // 
            // TeamPlayersLB
            // 
            TeamPlayersLB.AutoSize = true;
            TeamPlayersLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamPlayersLB.Location = new Point(281, 68);
            TeamPlayersLB.Name = "TeamPlayersLB";
            TeamPlayersLB.Size = new Size(121, 21);
            TeamPlayersLB.TabIndex = 10;
            TeamPlayersLB.Text = "Teams / Players";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.Font = new Font("Segoe UI", 12F);
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 21;
            tournamentTeamsListBox.Location = new Point(287, 97);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(251, 109);
            tournamentTeamsListBox.TabIndex = 11;
            // 
            // PrizesLB
            // 
            PrizesLB.AutoSize = true;
            PrizesLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizesLB.Location = new Point(287, 241);
            PrizesLB.Name = "PrizesLB";
            PrizesLB.Size = new Size(52, 21);
            PrizesLB.TabIndex = 12;
            PrizesLB.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.Font = new Font("Segoe UI", 12F);
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 21;
            prizesListBox.Location = new Point(287, 265);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(251, 109);
            prizesListBox.TabIndex = 13;
            // 
            // TeamPlayersDeleteBTN
            // 
            TeamPlayersDeleteBTN.BackColor = Color.White;
            TeamPlayersDeleteBTN.FlatStyle = FlatStyle.Flat;
            TeamPlayersDeleteBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeamPlayersDeleteBTN.Location = new Point(553, 97);
            TeamPlayersDeleteBTN.Name = "TeamPlayersDeleteBTN";
            TeamPlayersDeleteBTN.Size = new Size(123, 59);
            TeamPlayersDeleteBTN.TabIndex = 14;
            TeamPlayersDeleteBTN.Text = "Delete\r\nSelected";
            TeamPlayersDeleteBTN.UseVisualStyleBackColor = false;
            TeamPlayersDeleteBTN.Click += TeamPlayersDeleteBTN_Click;
            // 
            // PrizesDeleteBTN
            // 
            PrizesDeleteBTN.BackColor = Color.White;
            PrizesDeleteBTN.FlatStyle = FlatStyle.Flat;
            PrizesDeleteBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrizesDeleteBTN.Location = new Point(553, 265);
            PrizesDeleteBTN.Name = "PrizesDeleteBTN";
            PrizesDeleteBTN.Size = new Size(123, 59);
            PrizesDeleteBTN.TabIndex = 15;
            PrizesDeleteBTN.Text = "Delete\r\nSelected";
            PrizesDeleteBTN.UseVisualStyleBackColor = false;
            PrizesDeleteBTN.Click += PrizesDeleteBTN_Click;
            // 
            // CreateTournamentBTN
            // 
            CreateTournamentBTN.BackColor = Color.White;
            CreateTournamentBTN.FlatStyle = FlatStyle.Flat;
            CreateTournamentBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentBTN.Location = new Point(287, 410);
            CreateTournamentBTN.Name = "CreateTournamentBTN";
            CreateTournamentBTN.Size = new Size(213, 39);
            CreateTournamentBTN.TabIndex = 16;
            CreateTournamentBTN.Text = "Create Tournament";
            CreateTournamentBTN.UseVisualStyleBackColor = false;
            CreateTournamentBTN.Click += CreateTournamentBTN_Click;
            // 
            // NewTeamLinkLabel
            // 
            NewTeamLinkLabel.AutoSize = true;
            NewTeamLinkLabel.Location = new Point(149, 228);
            NewTeamLinkLabel.Name = "NewTeamLinkLabel";
            NewTeamLinkLabel.Size = new Size(64, 15);
            NewTeamLinkLabel.TabIndex = 17;
            NewTeamLinkLabel.TabStop = true;
            NewTeamLinkLabel.Text = "create new";
            NewTeamLinkLabel.LinkClicked += NewTeamLinkLabel_LinkClicked;
            // 
            // TournamentCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(744, 473);
            Controls.Add(NewTeamLinkLabel);
            Controls.Add(CreateTournamentBTN);
            Controls.Add(PrizesDeleteBTN);
            Controls.Add(TeamPlayersDeleteBTN);
            Controls.Add(prizesListBox);
            Controls.Add(PrizesLB);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(TeamPlayersLB);
            Controls.Add(CreatePrizeBTN);
            Controls.Add(AddTeamBTN);
            Controls.Add(SelectTeamComboBox);
            Controls.Add(SelctTeamLB);
            Controls.Add(EntryFeeTB);
            Controls.Add(EntryFeeLB);
            Controls.Add(TournamentNameTB);
            Controls.Add(TournamentNameLB);
            Controls.Add(HeaderLB);
            ForeColor = Color.DodgerBlue;
            Name = "TournamentCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament Creater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLB;
        private Label TournamentNameLB;
        private TextBox TournamentNameTB;
        private Label EntryFeeLB;
        private TextBox EntryFeeTB;
        private Label SelctTeamLB;
        private ComboBox SelectTeamComboBox;
        private Button AddTeamBTN;
        private Button CreatePrizeBTN;
        private Label TeamPlayersLB;
        private ListBox tournamentTeamsListBox;
        private Label PrizesLB;
        private ListBox prizesListBox;
        private Button TeamPlayersDeleteBTN;
        private Button PrizesDeleteBTN;
        private Button CreateTournamentBTN;
        private LinkLabel NewTeamLinkLabel;
    }
}