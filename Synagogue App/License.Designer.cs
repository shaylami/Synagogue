namespace Synagogue_App
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.tbLicKey = new System.Windows.Forms.TextBox();
            this.btnUpdateKey = new System.Windows.Forms.Button();
            this.lblLicDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLicKey
            // 
            this.tbLicKey.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbLicKey.Location = new System.Drawing.Point(159, 45);
            this.tbLicKey.Name = "tbLicKey";
            this.tbLicKey.Size = new System.Drawing.Size(320, 31);
            this.tbLicKey.TabIndex = 0;
            // 
            // btnUpdateKey
            // 
            this.btnUpdateKey.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateKey.Location = new System.Drawing.Point(235, 96);
            this.btnUpdateKey.Name = "btnUpdateKey";
            this.btnUpdateKey.Size = new System.Drawing.Size(159, 56);
            this.btnUpdateKey.TabIndex = 2;
            this.btnUpdateKey.Text = "הפעל";
            this.btnUpdateKey.UseVisualStyleBackColor = true;
            this.btnUpdateKey.Click += new System.EventHandler(this.btnUpdateKey_Click);
            // 
            // lblLicDate
            // 
            this.lblLicDate.AutoSize = true;
            this.lblLicDate.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLicDate.Location = new System.Drawing.Point(10, 48);
            this.lblLicDate.Name = "lblLicDate";
            this.lblLicDate.Size = new System.Drawing.Size(118, 24);
            this.lblLicDate.TabIndex = 3;
            this.lblLicDate.Text = "מפתח מוצר ";
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 164);
            this.Controls.Add(this.lblLicDate);
            this.Controls.Add(this.btnUpdateKey);
            this.Controls.Add(this.tbLicKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "רישיון מוצר";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLicKey;
        private System.Windows.Forms.Button btnUpdateKey;
        private System.Windows.Forms.Label lblLicDate;
    }
}