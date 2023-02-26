namespace CSDCustomReplace
{
    partial class UIListGroup
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panelHead);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1280, 100);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "第1项";
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.button1);
            this.panelHead.Controls.Add(this.btnAdd);
            this.panelHead.Controls.Add(this.comboBox1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHead.Location = new System.Drawing.Point(3, 26);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1274, 71);
            this.panelHead.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1132, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "移除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加项";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按钮",
            "图片"});
            this.comboBox1.Location = new System.Drawing.Point(30, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // UIListGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UIListGroup";
            this.Size = new System.Drawing.Size(1280, 100);
            this.groupBox.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private Panel panelHead;
        private Button button1;
        private Button btnAdd;
        private ComboBox comboBox1;
    }
}
