﻿namespace TrackerUI.Forms
{
    partial class CreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournament));
            this.lbHeader = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lbTournamentName = new System.Windows.Forms.Label();
            this.lbEntryFee = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.cbxSelectTeam = new System.Windows.Forms.ComboBox();
            this.lbSelectTeam = new System.Windows.Forms.Label();
            this.lnklbCreateNew = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lbxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lbTeams = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.lbPrizes = new System.Windows.Forms.Label();
            this.lbxPrizesList = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(12, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(403, 62);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(23, 119);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(392, 43);
            this.txtTournamentName.TabIndex = 3;
            // 
            // lbTournamentName
            // 
            this.lbTournamentName.AutoSize = true;
            this.lbTournamentName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTournamentName.Location = new System.Drawing.Point(15, 71);
            this.lbTournamentName.Name = "lbTournamentName";
            this.lbTournamentName.Size = new System.Drawing.Size(290, 45);
            this.lbTournamentName.TabIndex = 2;
            this.lbTournamentName.Text = "Tournament Name";
            // 
            // lbEntryFee
            // 
            this.lbEntryFee.AutoSize = true;
            this.lbEntryFee.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEntryFee.Location = new System.Drawing.Point(15, 187);
            this.lbEntryFee.Name = "lbEntryFee";
            this.lbEntryFee.Size = new System.Drawing.Size(153, 45);
            this.lbEntryFee.TabIndex = 4;
            this.lbEntryFee.Text = "Entry Fee";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(210, 190);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(205, 43);
            this.txtEntryFee.TabIndex = 5;
            this.txtEntryFee.Text = "0";
            // 
            // cbxSelectTeam
            // 
            this.cbxSelectTeam.FormattingEnabled = true;
            this.cbxSelectTeam.Location = new System.Drawing.Point(23, 332);
            this.cbxSelectTeam.Name = "cbxSelectTeam";
            this.cbxSelectTeam.Size = new System.Drawing.Size(392, 45);
            this.cbxSelectTeam.TabIndex = 8;
            // 
            // lbSelectTeam
            // 
            this.lbSelectTeam.AutoSize = true;
            this.lbSelectTeam.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTeam.Location = new System.Drawing.Point(14, 275);
            this.lbSelectTeam.Name = "lbSelectTeam";
            this.lbSelectTeam.Size = new System.Drawing.Size(231, 54);
            this.lbSelectTeam.TabIndex = 6;
            this.lbSelectTeam.Text = "Select Team";
            // 
            // lnklbCreateNew
            // 
            this.lnklbCreateNew.AutoSize = true;
            this.lnklbCreateNew.Location = new System.Drawing.Point(286, 291);
            this.lnklbCreateNew.Name = "lnklbCreateNew";
            this.lnklbCreateNew.Size = new System.Drawing.Size(161, 38);
            this.lnklbCreateNew.TabIndex = 7;
            this.lnklbCreateNew.TabStop = true;
            this.lnklbCreateNew.Text = "Create New";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(127, 376);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(174, 40);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(127, 432);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(174, 40);
            this.btnCreatePrize.TabIndex = 10;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lbxTournamentPlayers
            // 
            this.lbxTournamentPlayers.FormattingEnabled = true;
            this.lbxTournamentPlayers.ItemHeight = 37;
            this.lbxTournamentPlayers.Location = new System.Drawing.Point(494, 119);
            this.lbxTournamentPlayers.Name = "lbxTournamentPlayers";
            this.lbxTournamentPlayers.Size = new System.Drawing.Size(307, 152);
            this.lbxTournamentPlayers.TabIndex = 12;
            // 
            // lbTeams
            // 
            this.lbTeams.AutoSize = true;
            this.lbTeams.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeams.Location = new System.Drawing.Point(487, 71);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(110, 45);
            this.lbTeams.TabIndex = 11;
            this.lbTeams.Text = "Teams";
            // 
            // btnDeleteSelectedPlayer
            // 
            this.btnDeleteSelectedPlayer.Location = new System.Drawing.Point(837, 156);
            this.btnDeleteSelectedPlayer.Name = "btnDeleteSelectedPlayer";
            this.btnDeleteSelectedPlayer.Size = new System.Drawing.Size(111, 68);
            this.btnDeleteSelectedPlayer.TabIndex = 13;
            this.btnDeleteSelectedPlayer.Text = "Delete Selected";
            this.btnDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrize
            // 
            this.btnDeleteSelectedPrize.Location = new System.Drawing.Point(837, 376);
            this.btnDeleteSelectedPrize.Name = "btnDeleteSelectedPrize";
            this.btnDeleteSelectedPrize.Size = new System.Drawing.Size(111, 68);
            this.btnDeleteSelectedPrize.TabIndex = 16;
            this.btnDeleteSelectedPrize.Text = "Delete Selected";
            this.btnDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // lbPrizes
            // 
            this.lbPrizes.AutoSize = true;
            this.lbPrizes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrizes.Location = new System.Drawing.Point(487, 291);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(103, 45);
            this.lbPrizes.TabIndex = 14;
            this.lbPrizes.Text = "Prizes";
            // 
            // lbxPrizesList
            // 
            this.lbxPrizesList.FormattingEnabled = true;
            this.lbxPrizesList.ItemHeight = 37;
            this.lbxPrizesList.Location = new System.Drawing.Point(494, 339);
            this.lbxPrizesList.Name = "lbxPrizesList";
            this.lbxPrizesList.Size = new System.Drawing.Size(307, 152);
            this.lbxPrizesList.TabIndex = 15;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(367, 514);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(245, 68);
            this.btnCreateTournament.TabIndex = 17;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 617);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrize);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.lbxPrizesList);
            this.Controls.Add(this.btnDeleteSelectedPlayer);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.lbxTournamentPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lnklbCreateNew);
            this.Controls.Add(this.cbxSelectTeam);
            this.Controls.Add(this.lbSelectTeam);
            this.Controls.Add(this.lbEntryFee);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lbTournamentName);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournament";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lbTournamentName;
        private System.Windows.Forms.Label lbEntryFee;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.ComboBox cbxSelectTeam;
        private System.Windows.Forms.Label lbSelectTeam;
        private System.Windows.Forms.LinkLabel lnklbCreateNew;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lbxTournamentPlayers;
        private System.Windows.Forms.Label lbTeams;
        private System.Windows.Forms.Button btnDeleteSelectedPlayer;
        private System.Windows.Forms.Button btnDeleteSelectedPrize;
        private System.Windows.Forms.Label lbPrizes;
        private System.Windows.Forms.ListBox lbxPrizesList;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}