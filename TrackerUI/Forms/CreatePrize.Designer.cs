namespace TrackerUI.Forms
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
            this.lbPlaceNumber = new System.Windows.Forms.Label();
            this.txtPlaceNumber = new System.Windows.Forms.TextBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrizeAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.lbPlaceNumber.TabIndex = 16;
            this.lbPlaceNumber.Text = "Place Number";
            // 
            // txtPlaceNumber
            // 
            this.txtPlaceNumber.Location = new System.Drawing.Point(256, 82);
            this.txtPlaceNumber.Name = "txtPlaceNumber";
            this.txtPlaceNumber.Size = new System.Drawing.Size(287, 43);
            this.txtPlaceNumber.TabIndex = 15;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(12, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(267, 62);
            this.lbHeader.TabIndex = 14;
            this.lbHeader.Text = "Create Prize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "Place Name";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(256, 153);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(287, 43);
            this.txtPlaceName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prize Amount";
            // 
            // txtPrizeAmount
            // 
            this.txtPrizeAmount.Location = new System.Drawing.Point(256, 224);
            this.txtPrizeAmount.Name = "txtPrizeAmount";
            this.txtPrizeAmount.Size = new System.Drawing.Size(287, 43);
            this.txtPrizeAmount.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prize Percentage";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 382);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 43);
            this.textBox3.TabIndex = 21;
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOr.Location = new System.Drawing.Point(207, 308);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(128, 45);
            this.lbOr.TabIndex = 23;
            this.lbOr.Text = "---or---";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(197, 461);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(198, 63);
            this.btnCreatePrize.TabIndex = 24;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // CreatePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 548);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lbOr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrizeAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.lbPlaceNumber);
            this.Controls.Add(this.txtPlaceNumber);
            this.Controls.Add(this.lbHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrizeAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbOr;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}