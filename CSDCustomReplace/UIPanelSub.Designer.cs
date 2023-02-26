namespace CSDCustomReplace
{
    partial class UIPanelSub
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
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(117, 17);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(353, 32);
            this.comboBoxSub.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "移除子项";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIPanelSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSub);
            this.Name = "UIPanelSub";
            this.Size = new System.Drawing.Size(1274, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxSub;
        private Button button1;
    }
}
