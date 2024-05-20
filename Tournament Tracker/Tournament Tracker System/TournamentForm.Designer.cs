namespace Tournament_Tracker
{
    partial class TournamentForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLB = new Label();
            labelTournament = new Label();
            RoundLB = new Label();
            RoundComboBox = new ComboBox();
            checkBoxUnPlayed = new CheckBox();
            matchupListBox = new ListBox();
            Team1LB = new Label();
            Team2LB = new Label();
            ScoreTeam1LB = new Label();
            ScoreTeam2LB = new Label();
            VSLB = new Label();
            ScoreTeam1TB = new TextBox();
            ScoreTeam2TB = new TextBox();
            ScoreBTN = new Button();
            SampleTeam1LB = new Label();
            SampleTeam2LB = new Label();
            SuspendLayout();
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLB.Location = new Point(34, 26);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(120, 25);
            HeaderLB.TabIndex = 0;
            HeaderLB.Text = "Tournament:";
            // 
            // labelTournament
            // 
            labelTournament.AutoSize = true;
            labelTournament.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTournament.Location = new Point(160, 26);
            labelTournament.Name = "labelTournament";
            labelTournament.Size = new Size(86, 25);
            labelTournament.TabIndex = 1;
            labelTournament.Text = "<name>";
            // 
            // RoundLB
            // 
            RoundLB.AutoSize = true;
            RoundLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoundLB.Location = new Point(43, 77);
            RoundLB.Name = "RoundLB";
            RoundLB.Size = new Size(77, 25);
            RoundLB.TabIndex = 2;
            RoundLB.Text = "Round:";
            // 
            // RoundComboBox
            // 
            RoundComboBox.FormattingEnabled = true;
            RoundComboBox.Location = new Point(126, 82);
            RoundComboBox.Name = "RoundComboBox";
            RoundComboBox.Size = new Size(158, 23);
            RoundComboBox.TabIndex = 3;
            RoundComboBox.SelectedIndexChanged += RoundComboBox_SelectedIndexChanged;
            // 
            // checkBoxUnPlayed
            // 
            checkBoxUnPlayed.AutoSize = true;
            checkBoxUnPlayed.FlatStyle = FlatStyle.Flat;
            checkBoxUnPlayed.Location = new Point(126, 121);
            checkBoxUnPlayed.Name = "checkBoxUnPlayed";
            checkBoxUnPlayed.Size = new Size(101, 19);
            checkBoxUnPlayed.TabIndex = 4;
            checkBoxUnPlayed.Text = "UnPlayed Only";
            checkBoxUnPlayed.UseVisualStyleBackColor = true;
            checkBoxUnPlayed.CheckedChanged += checkBoxUnPlayed_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.Font = new Font("Segoe UI", 12F);
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 21;
            matchupListBox.Location = new Point(51, 176);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(233, 214);
            matchupListBox.TabIndex = 5;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // Team1LB
            // 
            Team1LB.AutoSize = true;
            Team1LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Team1LB.Location = new Point(438, 176);
            Team1LB.Name = "Team1LB";
            Team1LB.Size = new Size(74, 25);
            Team1LB.TabIndex = 6;
            Team1LB.Text = "Team 1";
            // 
            // Team2LB
            // 
            Team2LB.AutoSize = true;
            Team2LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Team2LB.Location = new Point(438, 318);
            Team2LB.Name = "Team2LB";
            Team2LB.Size = new Size(74, 25);
            Team2LB.TabIndex = 7;
            Team2LB.Text = "Team 2";
            // 
            // ScoreTeam1LB
            // 
            ScoreTeam1LB.AutoSize = true;
            ScoreTeam1LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreTeam1LB.Location = new Point(365, 220);
            ScoreTeam1LB.Name = "ScoreTeam1LB";
            ScoreTeam1LB.Size = new Size(62, 25);
            ScoreTeam1LB.TabIndex = 8;
            ScoreTeam1LB.Text = "Score";
            // 
            // ScoreTeam2LB
            // 
            ScoreTeam2LB.AutoSize = true;
            ScoreTeam2LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreTeam2LB.Location = new Point(365, 372);
            ScoreTeam2LB.Name = "ScoreTeam2LB";
            ScoreTeam2LB.Size = new Size(62, 25);
            ScoreTeam2LB.TabIndex = 9;
            ScoreTeam2LB.Text = "Score";
            // 
            // VSLB
            // 
            VSLB.AutoSize = true;
            VSLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VSLB.Location = new Point(422, 276);
            VSLB.Name = "VSLB";
            VSLB.Size = new Size(36, 25);
            VSLB.TabIndex = 10;
            VSLB.Text = "VS";
            // 
            // ScoreTeam1TB
            // 
            ScoreTeam1TB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreTeam1TB.Location = new Point(438, 217);
            ScoreTeam1TB.Name = "ScoreTeam1TB";
            ScoreTeam1TB.Size = new Size(100, 33);
            ScoreTeam1TB.TabIndex = 11;
            // 
            // ScoreTeam2TB
            // 
            ScoreTeam2TB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreTeam2TB.Location = new Point(438, 364);
            ScoreTeam2TB.Name = "ScoreTeam2TB";
            ScoreTeam2TB.Size = new Size(100, 33);
            ScoreTeam2TB.TabIndex = 12;
            // 
            // ScoreBTN
            // 
            ScoreBTN.BackColor = Color.White;
            ScoreBTN.FlatStyle = FlatStyle.Flat;
            ScoreBTN.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScoreBTN.Location = new Point(610, 276);
            ScoreBTN.Name = "ScoreBTN";
            ScoreBTN.Size = new Size(93, 39);
            ScoreBTN.TabIndex = 13;
            ScoreBTN.Text = "Score";
            ScoreBTN.UseVisualStyleBackColor = false;
            ScoreBTN.Click += ScoreBTN_Click;
            // 
            // SampleTeam1LB
            // 
            SampleTeam1LB.AutoSize = true;
            SampleTeam1LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SampleTeam1LB.Location = new Point(365, 176);
            SampleTeam1LB.Name = "SampleTeam1LB";
            SampleTeam1LB.Size = new Size(77, 25);
            SampleTeam1LB.TabIndex = 14;
            SampleTeam1LB.Text = "Sample";
            // 
            // SampleTeam2LB
            // 
            SampleTeam2LB.AutoSize = true;
            SampleTeam2LB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SampleTeam2LB.Location = new Point(365, 318);
            SampleTeam2LB.Name = "SampleTeam2LB";
            SampleTeam2LB.Size = new Size(77, 25);
            SampleTeam2LB.TabIndex = 15;
            SampleTeam2LB.Text = "Sample";
            // 
            // TournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(754, 450);
            Controls.Add(SampleTeam2LB);
            Controls.Add(SampleTeam1LB);
            Controls.Add(ScoreBTN);
            Controls.Add(ScoreTeam2TB);
            Controls.Add(ScoreTeam1TB);
            Controls.Add(VSLB);
            Controls.Add(ScoreTeam2LB);
            Controls.Add(ScoreTeam1LB);
            Controls.Add(Team2LB);
            Controls.Add(Team1LB);
            Controls.Add(matchupListBox);
            Controls.Add(checkBoxUnPlayed);
            Controls.Add(RoundComboBox);
            Controls.Add(RoundLB);
            Controls.Add(labelTournament);
            Controls.Add(HeaderLB);
            ForeColor = Color.DodgerBlue;
            Name = "TournamentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLB;
        private Label labelTournament;
        private Label RoundLB;
        private ComboBox RoundComboBox;
        private CheckBox checkBoxUnPlayed;
        private ListBox matchupListBox;
        private Label Team1LB;
        private Label Team2LB;
        private Label ScoreTeam1LB;
        private Label ScoreTeam2LB;
        private Label VSLB;
        private TextBox ScoreTeam1TB;
        private TextBox ScoreTeam2TB;
        private Button ScoreBTN;
        private Label SampleTeam1LB;
        private Label SampleTeam2LB;
    }
}
