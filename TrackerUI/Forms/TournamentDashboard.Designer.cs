namespace TrackerUI.Forms
{
    partial class TournamentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboard));
            this.lbHeader = new System.Windows.Forms.Label();
            this.cbxLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.lbLoadExistingTournament = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(124, 36);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(488, 62);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Tournament Dashboard";
            // 
            // cbxLoadExistingTournament
            // 
            this.cbxLoadExistingTournament.FormattingEnabled = true;
            this.cbxLoadExistingTournament.Location = new System.Drawing.Point(132, 184);
            this.cbxLoadExistingTournament.Name = "cbxLoadExistingTournament";
            this.cbxLoadExistingTournament.Size = new System.Drawing.Size(472, 45);
            this.cbxLoadExistingTournament.TabIndex = 3;
            // 
            // lbLoadExistingTournament
            // 
            this.lbLoadExistingTournament.AutoSize = true;
            this.lbLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoadExistingTournament.Location = new System.Drawing.Point(129, 130);
            this.lbLoadExistingTournament.Name = "lbLoadExistingTournament";
            this.lbLoadExistingTournament.Size = new System.Drawing.Size(479, 54);
            this.lbLoadExistingTournament.TabIndex = 2;
            this.lbLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.Location = new System.Drawing.Point(245, 251);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(247, 53);
            this.btnLoadTournament.TabIndex = 4;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(193, 346);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(351, 101);
            this.btnCreateTournament.TabIndex = 5;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.cbxLoadExistingTournament);
            this.Controls.Add(this.lbLoadExistingTournament);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.ComboBox cbxLoadExistingTournament;
        private System.Windows.Forms.Label lbLoadExistingTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}