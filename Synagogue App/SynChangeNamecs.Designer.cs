namespace Synagogue_App
{
    partial class SynChangeNamecs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynChangeNamecs));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSetSynName = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSynNewName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSetSynName);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSynNewName);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(799, 176);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSetSynName
            // 
            this.btnSetSynName.BackColor = System.Drawing.Color.Snow;
            this.btnSetSynName.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSetSynName.Location = new System.Drawing.Point(8, 99);
            this.btnSetSynName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSynName.Name = "btnSetSynName";
            this.btnSetSynName.Size = new System.Drawing.Size(256, 62);
            this.btnSetSynName.TabIndex = 5;
            this.btnSetSynName.Text = "עדכן שם";
            this.btnSetSynName.UseVisualStyleBackColor = false;
            this.btnSetSynName.Click += new System.EventHandler(this.btnSetSynName_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(777, 66);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 16);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(616, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם בית כנסת";
            // 
            // textBoxSynNewName
            // 
            this.textBoxSynNewName.Font = new System.Drawing.Font("Narkisim", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxSynNewName.Location = new System.Drawing.Point(8, 56);
            this.textBoxSynNewName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSynNewName.Name = "textBoxSynNewName";
            this.textBoxSynNewName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSynNewName.Size = new System.Drawing.Size(761, 36);
            this.textBoxSynNewName.TabIndex = 0;
            this.textBoxSynNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
            // 
            // SynChangeNamecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 211);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SynChangeNamecs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "עדכן שם בית כנסת";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSynNewName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSetSynName;
    }
}