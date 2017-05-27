namespace Synagogue_App
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbVer = new System.Windows.Forms.RichTextBox();
            this.rtbHFVer = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.lblEndLicDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.rtbVer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbHFVer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbAbout, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEndLicDate, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 607);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rtbVer
            // 
            this.rtbVer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rtbVer.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbVer.Location = new System.Drawing.Point(3, 83);
            this.rtbVer.Name = "rtbVer";
            this.rtbVer.ReadOnly = true;
            this.rtbVer.Size = new System.Drawing.Size(553, 64);
            this.rtbVer.TabIndex = 0;
            this.rtbVer.Text = "";
            // 
            // rtbHFVer
            // 
            this.rtbHFVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbHFVer.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbHFVer.Location = new System.Drawing.Point(4, 153);
            this.rtbHFVer.Name = "rtbHFVer";
            this.rtbHFVer.ReadOnly = true;
            this.rtbHFVer.Size = new System.Drawing.Size(555, 64);
            this.rtbHFVer.TabIndex = 1;
            this.rtbHFVer.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(197, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rtbAbout
            // 
            this.rtbAbout.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbAbout.Location = new System.Drawing.Point(4, 285);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ReadOnly = true;
            this.rtbAbout.Size = new System.Drawing.Size(556, 319);
            this.rtbAbout.TabIndex = 2;
            this.rtbAbout.Text = "";
            // 
            // lblEndLicDate
            // 
            this.lblEndLicDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEndLicDate.AutoSize = true;
            this.lblEndLicDate.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEndLicDate.Location = new System.Drawing.Point(497, 237);
            this.lblEndLicDate.Name = "lblEndLicDate";
            this.lblEndLicDate.Size = new System.Drawing.Size(63, 28);
            this.lblEndLicDate.TabIndex = 4;
            this.lblEndLicDate.Text = "label";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(587, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "אודות";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtbVer;
        private System.Windows.Forms.RichTextBox rtbHFVer;
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEndLicDate;
    }
}