namespace CSDCustomReplace
{
    partial class UIPanel_ResReplace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMod
            // 
            this.textBoxMod.Location = new System.Drawing.Point(890, 20);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.Size = new System.Drawing.Size(290, 30);
            this.textBoxMod.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "修改数值";
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Location = new System.Drawing.Point(417, 20);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.Size = new System.Drawing.Size(284, 30);
            this.textBoxOrg.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "原始数值";
            // 
            // UIPanel_ResReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrg);
            this.Controls.Add(this.label2);
            this.Name = "UIPanel_ResReplace";
            this.Size = new System.Drawing.Size(1274, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxMod;
        private Label label3;
        private TextBox textBoxOrg;
        private Label label2;
    }
}
