namespace Synagogue_App
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateMsg1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMsg1 = new System.Windows.Forms.TextBox();
            this.tbMsg2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMsg3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMsg4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMsg4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMsg3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbMsg2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMsg1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateMsg1
            // 
            this.btnUpdateMsg1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdateMsg1.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateMsg1.Location = new System.Drawing.Point(600, 454);
            this.btnUpdateMsg1.Name = "btnUpdateMsg1";
            this.btnUpdateMsg1.Size = new System.Drawing.Size(297, 67);
            this.btnUpdateMsg1.TabIndex = 5;
            this.btnUpdateMsg1.Text = "עדכן";
            this.btnUpdateMsg1.UseVisualStyleBackColor = true;
            this.btnUpdateMsg1.Click += new System.EventHandler(this.btnUpdateMsg1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(816, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "הודעה 1";
            // 
            // tbMsg1
            // 
            this.tbMsg1.Location = new System.Drawing.Point(17, 35);
            this.tbMsg1.Multiline = true;
            this.tbMsg1.Name = "tbMsg1";
            this.tbMsg1.Size = new System.Drawing.Size(784, 83);
            this.tbMsg1.TabIndex = 1;
            // 
            // tbMsg2
            // 
            this.tbMsg2.Location = new System.Drawing.Point(17, 137);
            this.tbMsg2.Multiline = true;
            this.tbMsg2.Name = "tbMsg2";
            this.tbMsg2.Size = new System.Drawing.Size(784, 83);
            this.tbMsg2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "הודעה 2";
            // 
            // tbMsg3
            // 
            this.tbMsg3.Location = new System.Drawing.Point(17, 238);
            this.tbMsg3.Multiline = true;
            this.tbMsg3.Name = "tbMsg3";
            this.tbMsg3.Size = new System.Drawing.Size(784, 83);
            this.tbMsg3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "הודעה 3";
            // 
            // tbMsg4
            // 
            this.tbMsg4.Location = new System.Drawing.Point(12, 340);
            this.tbMsg4.Multiline = true;
            this.tbMsg4.Name = "tbMsg4";
            this.tbMsg4.Size = new System.Drawing.Size(789, 83);
            this.tbMsg4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "הודעה 4";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 533);
            this.Controls.Add(this.btnUpdateMsg1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Messages";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "לוח הודעות";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateMsg1;
        private System.Windows.Forms.TextBox tbMsg4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMsg3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMsg2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMsg1;
        private System.Windows.Forms.Label label1;
    }
}