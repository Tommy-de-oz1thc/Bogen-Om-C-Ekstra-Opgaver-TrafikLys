namespace Tournament_Tracker
{
    partial class PrizeCreateForm
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
            PlaceNumberLB = new Label();
            PlaceNameLB = new Label();
            PrizeAmountLB = new Label();
            PrizePercentageLB = new Label();
            orLB = new Label();
            PlaceNumberTB = new TextBox();
            PlaceNameTB = new TextBox();
            PrizeAmountTB = new TextBox();
            PrizePercentageTB = new TextBox();
            CreatePrizeBTN = new Button();
            SuspendLayout();
            // 
            // HeaderLB
            // 
            HeaderLB.AutoSize = true;
            HeaderLB.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeaderLB.Location = new Point(31, 28);
            HeaderLB.Name = "HeaderLB";
            HeaderLB.Size = new Size(115, 25);
            HeaderLB.TabIndex = 0;
            HeaderLB.Text = "Create Prize";
            // 
            // PlaceNumberLB
            // 
            PlaceNumberLB.AutoSize = true;
            PlaceNumberLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PlaceNumberLB.Location = new Point(34, 91);
            PlaceNumberLB.Name = "PlaceNumberLB";
            PlaceNumberLB.Size = new Size(112, 21);
            PlaceNumberLB.TabIndex = 1;
            PlaceNumberLB.Text = "Place Number";
            // 
            // PlaceNameLB
            // 
            PlaceNameLB.AutoSize = true;
            PlaceNameLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PlaceNameLB.Location = new Point(35, 136);
            PlaceNameLB.Name = "PlaceNameLB";
            PlaceNameLB.Size = new Size(95, 21);
            PlaceNameLB.TabIndex = 2;
            PlaceNameLB.Text = "Place Name";
            // 
            // PrizeAmountLB
            // 
            PrizeAmountLB.AutoSize = true;
            PrizeAmountLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PrizeAmountLB.Location = new Point(35, 191);
            PrizeAmountLB.Name = "PrizeAmountLB";
            PrizeAmountLB.Size = new Size(108, 21);
            PrizeAmountLB.TabIndex = 3;
            PrizeAmountLB.Text = "Prize Amount";
            // 
            // PrizePercentageLB
            // 
            PrizePercentageLB.AutoSize = true;
            PrizePercentageLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PrizePercentageLB.Location = new Point(34, 301);
            PrizePercentageLB.Name = "PrizePercentageLB";
            PrizePercentageLB.Size = new Size(131, 21);
            PrizePercentageLB.TabIndex = 4;
            PrizePercentageLB.Text = "Prize Percentage";
            // 
            // orLB
            // 
            orLB.AutoSize = true;
            orLB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            orLB.Location = new Point(249, 241);
            orLB.Name = "orLB";
            orLB.Size = new Size(46, 21);
            orLB.TabIndex = 5;
            orLB.Text = "- or -";
            // 
            // PlaceNumberTB
            // 
            PlaceNumberTB.Font = new Font("Segoe UI", 12F);
            PlaceNumberTB.Location = new Point(192, 83);
            PlaceNumberTB.Name = "PlaceNumberTB";
            PlaceNumberTB.Size = new Size(169, 29);
            PlaceNumberTB.TabIndex = 6;
            // 
            // PlaceNameTB
            // 
            PlaceNameTB.Font = new Font("Segoe UI", 12F);
            PlaceNameTB.Location = new Point(192, 128);
            PlaceNameTB.Name = "PlaceNameTB";
            PlaceNameTB.Size = new Size(169, 29);
            PlaceNameTB.TabIndex = 7;
            // 
            // PrizeAmountTB
            // 
            PrizeAmountTB.Font = new Font("Segoe UI", 12F);
            PrizeAmountTB.Location = new Point(192, 183);
            PrizeAmountTB.Name = "PrizeAmountTB";
            PrizeAmountTB.Size = new Size(169, 29);
            PrizeAmountTB.TabIndex = 8;
            PrizeAmountTB.Text = "0";
            // 
            // PrizePercentageTB
            // 
            PrizePercentageTB.Font = new Font("Segoe UI", 12F);
            PrizePercentageTB.Location = new Point(192, 293);
            PrizePercentageTB.Name = "PrizePercentageTB";
            PrizePercentageTB.Size = new Size(169, 29);
            PrizePercentageTB.TabIndex = 9;
            PrizePercentageTB.Text = "0";
            // 
            // CreatePrizeBTN
            // 
            CreatePrizeBTN.BackColor = Color.White;
            CreatePrizeBTN.FlatStyle = FlatStyle.Flat;
            CreatePrizeBTN.Font = new Font("Segoe UI", 12F);
            CreatePrizeBTN.Location = new Point(192, 371);
            CreatePrizeBTN.Name = "CreatePrizeBTN";
            CreatePrizeBTN.Size = new Size(169, 37);
            CreatePrizeBTN.TabIndex = 10;
            CreatePrizeBTN.Text = "Create Prize";
            CreatePrizeBTN.UseVisualStyleBackColor = false;
            CreatePrizeBTN.Click += CreatePrizeBTN_Click;
            // 
            // PrizeCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 450);
            Controls.Add(CreatePrizeBTN);
            Controls.Add(PrizePercentageTB);
            Controls.Add(PrizeAmountTB);
            Controls.Add(PlaceNameTB);
            Controls.Add(PlaceNumberTB);
            Controls.Add(orLB);
            Controls.Add(PrizePercentageLB);
            Controls.Add(PrizeAmountLB);
            Controls.Add(PlaceNameLB);
            Controls.Add(PlaceNumberLB);
            Controls.Add(HeaderLB);
            ForeColor = Color.DodgerBlue;
            Name = "PrizeCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prize Creation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLB;
        private Label PlaceNumberLB;
        private Label PlaceNameLB;
        private Label PrizeAmountLB;
        private Label PrizePercentageLB;
        private Label orLB;
        private TextBox PlaceNumberTB;
        private TextBox PlaceNameTB;
        private TextBox PrizeAmountTB;
        private TextBox PrizePercentageTB;
        private Button CreatePrizeBTN;
    }
}