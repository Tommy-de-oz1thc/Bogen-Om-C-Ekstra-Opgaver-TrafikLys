namespace Tournament_Tracker
{
    partial class DashboardForm
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
            LoadTournamentLB = new Label();
            LoadExistingTournamentcomboBox = new ComboBox();
            LoadTournamentBTN = new Button();
            CreateTournamentBTN = new Button();
            SuspendLayout();
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Segoe UI", 32F);
            HeaderLB.Location = new Point(45, 27);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(470, 59);
            HeaderLB.TabIndex = 0;
            HeaderLB.Text = "Tournament Dashboard";
            // 
            // LoadTournamentLB
            // 
            LoadTournamentLB.AutoSize = true;
            LoadTournamentLB.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentLB.Location = new Point(114, 86);
            LoadTournamentLB.Name = "LoadTournamentLB";
            LoadTournamentLB.Size = new Size(351, 37);
            LoadTournamentLB.TabIndex = 1;
            LoadTournamentLB.Text = "Load Existing Tournament";
            // 
            // LoadExistingTournamentcomboBox
            // 
            LoadExistingTournamentcomboBox.Font = new Font("Segoe UI", 14F);
            LoadExistingTournamentcomboBox.FormattingEnabled = true;
            LoadExistingTournamentcomboBox.Location = new Point(122, 130);
            LoadExistingTournamentcomboBox.Name = "LoadExistingTournamentcomboBox";
            LoadExistingTournamentcomboBox.Size = new Size(332, 33);
            LoadExistingTournamentcomboBox.TabIndex = 2;
            // 
            // LoadTournamentBTN
            // 
            LoadTournamentBTN.BackColor = Color.White;
            LoadTournamentBTN.FlatStyle = FlatStyle.Flat;
            LoadTournamentBTN.Font = new Font("Segoe UI", 18F);
            LoadTournamentBTN.Location = new Point(163, 194);
            LoadTournamentBTN.Name = "LoadTournamentBTN";
            LoadTournamentBTN.Size = new Size(232, 54);
            LoadTournamentBTN.TabIndex = 3;
            LoadTournamentBTN.Text = "Load Tournament";
            LoadTournamentBTN.UseVisualStyleBackColor = false;
            LoadTournamentBTN.Click += LoadTournamentBTN_Click;
            // 
            // CreateTournamentBTN
            // 
            CreateTournamentBTN.BackColor = Color.White;
            CreateTournamentBTN.FlatStyle = FlatStyle.Flat;
            CreateTournamentBTN.Font = new Font("Segoe UI", 18F);
            CreateTournamentBTN.Location = new Point(122, 290);
            CreateTournamentBTN.Name = "CreateTournamentBTN";
            CreateTournamentBTN.Size = new Size(332, 88);
            CreateTournamentBTN.TabIndex = 4;
            CreateTournamentBTN.Text = "Create Tournament";
            CreateTournamentBTN.UseVisualStyleBackColor = false;
            CreateTournamentBTN.Click += CreateTournamentBTN_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(557, 420);
            Controls.Add(CreateTournamentBTN);
            Controls.Add(LoadTournamentBTN);
            Controls.Add(LoadExistingTournamentcomboBox);
            Controls.Add(LoadTournamentLB);
            Controls.Add(HeaderLB);
            ForeColor = Color.DodgerBlue;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLB;
        private Label LoadTournamentLB;
        private ComboBox LoadExistingTournamentcomboBox;
        private Button LoadTournamentBTN;
        private Button CreateTournamentBTN;
    }
}