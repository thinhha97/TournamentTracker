namespace TrackerUI.Forms
{
    partial class CreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeam));
            this.lbTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.cbxSelectTeam = new System.Windows.Forms.ComboBox();
            this.lbSelectTeamMember = new System.Windows.Forms.Label();
            this.grbAddNewMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lbCellphone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbxTeamMembers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteSelectedTeamMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.grbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamName.Location = new System.Drawing.Point(15, 71);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(192, 45);
            this.lbTeamName.TabIndex = 2;
            this.lbTeamName.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(23, 116);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(472, 42);
            this.txtTeamName.TabIndex = 3;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(12, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(272, 62);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Create Team";
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.Location = new System.Drawing.Point(158, 255);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Size = new System.Drawing.Size(174, 40);
            this.btnAddTeamMember.TabIndex = 6;
            this.btnAddTeamMember.Text = "Add Team Member";
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            // 
            // cbxSelectTeam
            // 
            this.cbxSelectTeam.FormattingEnabled = true;
            this.cbxSelectTeam.Location = new System.Drawing.Point(21, 208);
            this.cbxSelectTeam.Name = "cbxSelectTeam";
            this.cbxSelectTeam.Size = new System.Drawing.Size(472, 44);
            this.cbxSelectTeam.TabIndex = 5;
            // 
            // lbSelectTeamMember
            // 
            this.lbSelectTeamMember.AutoSize = true;
            this.lbSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectTeamMember.Location = new System.Drawing.Point(13, 154);
            this.lbSelectTeamMember.Name = "lbSelectTeamMember";
            this.lbSelectTeamMember.Size = new System.Drawing.Size(392, 54);
            this.lbSelectTeamMember.TabIndex = 4;
            this.lbSelectTeamMember.Text = "Select Team Member";
            // 
            // grbAddNewMember
            // 
            this.grbAddNewMember.Controls.Add(this.btnCreateMember);
            this.grbAddNewMember.Controls.Add(this.txtCellphone);
            this.grbAddNewMember.Controls.Add(this.lbCellphone);
            this.grbAddNewMember.Controls.Add(this.txtEmail);
            this.grbAddNewMember.Controls.Add(this.lbEmail);
            this.grbAddNewMember.Controls.Add(this.txtLastName);
            this.grbAddNewMember.Controls.Add(this.lbLastName);
            this.grbAddNewMember.Controls.Add(this.txtFirstName);
            this.grbAddNewMember.Controls.Add(this.lbFirstName);
            this.grbAddNewMember.Location = new System.Drawing.Point(23, 313);
            this.grbAddNewMember.Name = "grbAddNewMember";
            this.grbAddNewMember.Size = new System.Drawing.Size(470, 322);
            this.grbAddNewMember.TabIndex = 7;
            this.grbAddNewMember.TabStop = false;
            this.grbAddNewMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(135, 258);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(174, 40);
            this.btnCreateMember.TabIndex = 16;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(158, 198);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(249, 42);
            this.txtCellphone.TabIndex = 15;
            // 
            // lbCellphone
            // 
            this.lbCellphone.AutoSize = true;
            this.lbCellphone.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCellphone.Location = new System.Drawing.Point(8, 196);
            this.lbCellphone.Name = "lbCellphone";
            this.lbCellphone.Size = new System.Drawing.Size(166, 45);
            this.lbCellphone.TabIndex = 14;
            this.lbCellphone.Text = "Cellphone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 42);
            this.txtEmail.TabIndex = 13;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(8, 142);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(98, 45);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(251, 42);
            this.txtLastName.TabIndex = 11;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(6, 92);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(174, 45);
            this.lbLastName.TabIndex = 10;
            this.lbLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(251, 42);
            this.txtFirstName.TabIndex = 9;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(6, 41);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(176, 45);
            this.lbFirstName.TabIndex = 8;
            this.lbFirstName.Text = "First Name";
            // 
            // lbxTeamMembers
            // 
            this.lbxTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxTeamMembers.FormattingEnabled = true;
            this.lbxTeamMembers.ItemHeight = 36;
            this.lbxTeamMembers.Location = new System.Drawing.Point(545, 119);
            this.lbxTeamMembers.Name = "lbxTeamMembers";
            this.lbxTeamMembers.Size = new System.Drawing.Size(335, 506);
            this.lbxTeamMembers.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Team Members";
            // 
            // btnDeleteSelectedTeamMember
            // 
            this.btnDeleteSelectedTeamMember.Location = new System.Drawing.Point(903, 417);
            this.btnDeleteSelectedTeamMember.Name = "btnDeleteSelectedTeamMember";
            this.btnDeleteSelectedTeamMember.Size = new System.Drawing.Size(111, 68);
            this.btnDeleteSelectedTeamMember.TabIndex = 19;
            this.btnDeleteSelectedTeamMember.Text = "Delete Selected";
            this.btnDeleteSelectedTeamMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(319, 652);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(290, 69);
            this.btnCreateTeam.TabIndex = 20;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 731);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteSelectedTeamMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxTeamMembers);
            this.Controls.Add(this.grbAddNewMember);
            this.Controls.Add(this.btnAddTeamMember);
            this.Controls.Add(this.cbxSelectTeam);
            this.Controls.Add(this.lbSelectTeamMember);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.grbAddNewMember.ResumeLayout(false);
            this.grbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.ComboBox cbxSelectTeam;
        private System.Windows.Forms.Label lbSelectTeamMember;
        private System.Windows.Forms.GroupBox grbAddNewMember;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lbCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.ListBox lbxTeamMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteSelectedTeamMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}