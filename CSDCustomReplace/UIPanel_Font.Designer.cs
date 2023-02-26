namespace CSDCustomReplace
{
    partial class UIPanel_Font
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
            this.label1 = new System.Windows.Forms.Label();
            this.resQuote = new System.Windows.Forms.TextBox();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "引用资源";
            // 
            // resQuote
            // 
            this.resQuote.Location = new System.Drawing.Point(292, 18);
            this.resQuote.Name = "resQuote";
            this.resQuote.Size = new System.Drawing.Size(353, 30);
            this.resQuote.TabIndex = 1;
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Location = new System.Drawing.Point(787, 18);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.Size = new System.Drawing.Size(135, 30);
            this.textBoxOrg.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "原始数值";
            // 
            // textBoxMod
            // 
            this.textBoxMod.Location = new System.Drawing.Point(1051, 18);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.Size = new System.Drawing.Size(135, 30);
            this.textBoxMod.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(963, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "修改数值";
            // 
            // UIPanel_Font
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resQuote);
            this.Controls.Add(this.label1);
            this.Name = "UIPanel_Font";
            this.Size = new System.Drawing.Size(1274, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox resQuote;
        private TextBox textBoxOrg;
        private Label label2;
        private TextBox textBoxMod;
        private Label label3;
    }
}
