namespace TrackerUI.Forms
{
    partial class TournamentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbTournamentName = new System.Windows.Forms.Label();
            this.lbRound = new System.Windows.Forms.Label();
            this.cbxRound = new System.Windows.Forms.ComboBox();
            this.chbUnplayOnly = new System.Windows.Forms.CheckBox();
            this.lbxMatchup = new System.Windows.Forms.ListBox();
            this.lbTeamOneName = new System.Windows.Forms.Label();
            this.lbTeamOneScore = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTeamTwoName = new System.Windows.Forms.Label();
            this.lbVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(12, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(271, 62);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Tournament:";
            // 
            // lbTournamentName
            // 
            this.lbTournamentName.AutoSize = true;
            this.lbTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTournamentName.Location = new System.Drawing.Point(304, 9);
            this.lbTournamentName.Name = "lbTournamentName";
            this.lbTournamentName.Size = new System.Drawing.Size(167, 62);
            this.lbTournamentName.TabIndex = 1;
            this.lbTournamentName.Text = "<Null>";
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRound.Location = new System.Drawing.Point(16, 92);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(139, 54);
            this.lbRound.TabIndex = 2;
            this.lbRound.Text = "Round";
            // 
            // cbxRound
            // 
            this.cbxRound.FormattingEnabled = true;
            this.cbxRound.Location = new System.Drawing.Point(171, 101);
            this.cbxRound.Name = "cbxRound";
            this.cbxRound.Size = new System.Drawing.Size(300, 45);
            this.cbxRound.TabIndex = 3;
            // 
            // chbUnplayOnly
            // 
            this.chbUnplayOnly.AutoSize = true;
            this.chbUnplayOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbUnplayOnly.Location = new System.Drawing.Point(171, 171);
            this.chbUnplayOnly.Name = "chbUnplayOnly";
            this.chbUnplayOnly.Size = new System.Drawing.Size(218, 42);
            this.chbUnplayOnly.TabIndex = 4;
            this.chbUnplayOnly.Text = "Unplayed Only";
            this.chbUnplayOnly.UseVisualStyleBackColor = true;
            // 
            // lbxMatchup
            // 
            this.lbxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxMatchup.FormattingEnabled = true;
            this.lbxMatchup.ItemHeight = 37;
            this.lbxMatchup.Location = new System.Drawing.Point(25, 233);
            this.lbxMatchup.Name = "lbxMatchup";
            this.lbxMatchup.Size = new System.Drawing.Size(446, 335);
            this.lbxMatchup.TabIndex = 5;
            // 
            // lbTeamOneName
            // 
            this.lbTeamOneName.AutoSize = true;
            this.lbTeamOneName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamOneName.Location = new System.Drawing.Point(543, 225);
            this.lbTeamOneName.Name = "lbTeamOneName";
            this.lbTeamOneName.Size = new System.Drawing.Size(203, 45);
            this.lbTeamOneName.TabIndex = 6;
            this.lbTeamOneName.Text = "<team one>";
            // 
            // lbTeamOneScore
            // 
            this.lbTeamOneScore.AutoSize = true;
            this.lbTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamOneScore.Location = new System.Drawing.Point(509, 279);
            this.lbTeamOneScore.Name = "lbTeamOneScore";
            this.lbTeamOneScore.Size = new System.Drawing.Size(100, 45);
            this.lbTeamOneScore.TabIndex = 7;
            this.lbTeamOneScore.Text = "Score";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(615, 282);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 43);
            this.txtTeamOneScore.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(615, 489);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 43);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(509, 487);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(100, 45);
            this.lbScore.TabIndex = 10;
            this.lbScore.Text = "Score";
            // 
            // lbTeamTwoName
            // 
            this.lbTeamTwoName.AutoSize = true;
            this.lbTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamTwoName.Location = new System.Drawing.Point(543, 432);
            this.lbTeamTwoName.Name = "lbTeamTwoName";
            this.lbTeamTwoName.Size = new System.Drawing.Size(202, 45);
            this.lbTeamTwoName.TabIndex = 9;
            this.lbTeamTwoName.Text = "<team two>";
            // 
            // lbVersus
            // 
            this.lbVersus.AutoSize = true;
            this.lbVersus.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersus.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbVersus.Location = new System.Drawing.Point(578, 360);
            this.lbVersus.Name = "lbVersus";
            this.lbVersus.Size = new System.Drawing.Size(137, 45);
            this.lbVersus.TabIndex = 12;
            this.lbVersus.Text = "---VS---";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(747, 361);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(117, 46);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 587);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lbVersus);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbTeamTwoName);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lbTeamOneScore);
            this.Controls.Add(this.lbTeamOneName);
            this.Controls.Add(this.lbxMatchup);
            this.Controls.Add(this.chbUnplayOnly);
            this.Controls.Add(this.cbxRound);
            this.Controls.Add(this.lbRound);
            this.Controls.Add(this.lbTournamentName);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbTournamentName;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.ComboBox cbxRound;
        private System.Windows.Forms.CheckBox chbUnplayOnly;
        private System.Windows.Forms.ListBox lbxMatchup;
        private System.Windows.Forms.Label lbTeamOneName;
        private System.Windows.Forms.Label lbTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbTeamTwoName;
        private System.Windows.Forms.Label lbVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

