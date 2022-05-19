﻿namespace TrackerUI.Forms
{
    partial class CreatePrize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrize));
            this.lbPlaceNumber = new System.Windows.Forms.Label();
            this.txtPlaceNumber = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbPlaceName = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.lbPriceAmount = new System.Windows.Forms.Label();
            this.txtPrizeAmount = new System.Windows.Forms.TextBox();
            this.lbPricePercentage = new System.Windows.Forms.Label();
            this.txtPricePercentage = new System.Windows.Forms.TextBox();
            this.lbOr = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPlaceNumber
            // 
            this.lbPlaceNumber.AutoSize = true;
            this.lbPlaceNumber.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaceNumber.Location = new System.Drawing.Point(12, 82);
            this.lbPlaceNumber.Name = "lbPlaceNumber";
            this.lbPlaceNumber.Size = new System.Drawing.Size(223, 45);
            this.lbPlaceNumber.TabIndex = 2;
            this.lbPlaceNumber.Text = "Place Number";
            // 
            // txtPlaceNumber
            // 
            this.txtPlaceNumber.Location = new System.Drawing.Point(256, 82);
            this.txtPlaceNumber.Name = "txtPlaceNumber";
            this.txtPlaceNumber.Size = new System.Drawing.Size(287, 43);
            this.txtPlaceNumber.TabIndex = 3;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(12, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(267, 62);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Create Prize";
            // 
            // lbPlaceName
            // 
            this.lbPlaceName.AutoSize = true;
            this.lbPlaceName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaceName.Location = new System.Drawing.Point(12, 153);
            this.lbPlaceName.Name = "lbPlaceName";
            this.lbPlaceName.Size = new System.Drawing.Size(191, 45);
            this.lbPlaceName.TabIndex = 4;
            this.lbPlaceName.Text = "Place Name";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(256, 153);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(287, 43);
            this.txtPlaceName.TabIndex = 5;
            // 
            // lbPriceAmount
            // 
            this.lbPriceAmount.AutoSize = true;
            this.lbPriceAmount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceAmount.Location = new System.Drawing.Point(12, 224);
            this.lbPriceAmount.Name = "lbPriceAmount";
            this.lbPriceAmount.Size = new System.Drawing.Size(215, 45);
            this.lbPriceAmount.TabIndex = 6;
            this.lbPriceAmount.Text = "Prize Amount";
            // 
            // txtPrizeAmount
            // 
            this.txtPrizeAmount.Location = new System.Drawing.Point(256, 224);
            this.txtPrizeAmount.Name = "txtPrizeAmount";
            this.txtPrizeAmount.Size = new System.Drawing.Size(287, 43);
            this.txtPrizeAmount.TabIndex = 7;
            // 
            // lbPricePercentage
            // 
            this.lbPricePercentage.AutoSize = true;
            this.lbPricePercentage.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPricePercentage.Location = new System.Drawing.Point(12, 382);
            this.lbPricePercentage.Name = "lbPricePercentage";
            this.lbPricePercentage.Size = new System.Drawing.Size(258, 45);
            this.lbPricePercentage.TabIndex = 9;
            this.lbPricePercentage.Text = "Prize Percentage";
            // 
            // txtPricePercentage
            // 
            this.txtPricePercentage.Location = new System.Drawing.Point(256, 382);
            this.txtPricePercentage.Name = "txtPricePercentage";
            this.txtPricePercentage.Size = new System.Drawing.Size(287, 43);
            this.txtPricePercentage.TabIndex = 10;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOr.Location = new System.Drawing.Point(207, 308);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(128, 45);
            this.lbOr.TabIndex = 8;
            this.lbOr.Text = "---or---";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(197, 461);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(198, 63);
            this.btnCreatePrize.TabIndex = 11;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.BtnCreatePrize_Click);
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 548);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lbOr);
            this.Controls.Add(this.lbPricePercentage);
            this.Controls.Add(this.txtPricePercentage);
            this.Controls.Add(this.lbPriceAmount);
            this.Controls.Add(this.txtPrizeAmount);
            this.Controls.Add(this.lbPlaceName);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.lbPlaceNumber);
            this.Controls.Add(this.txtPlaceNumber);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrize";
            this.Text = "CreatePrize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlaceNumber;
        private System.Windows.Forms.TextBox txtPlaceNumber;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbPlaceName;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label lbPriceAmount;
        private System.Windows.Forms.TextBox txtPrizeAmount;
        private System.Windows.Forms.Label lbPricePercentage;
        private System.Windows.Forms.TextBox txtPricePercentage;
        private System.Windows.Forms.Label lbOr;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}