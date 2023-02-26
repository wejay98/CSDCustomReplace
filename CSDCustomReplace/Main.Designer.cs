namespace AutoReplace
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.listContent = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadConfig);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 141);
            this.panel1.TabIndex = 2;
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadConfig.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadConfig.Location = new System.Drawing.Point(1009, 55);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(204, 62);
            this.btnLoadConfig.TabIndex = 2;
            this.btnLoadConfig.Text = "读取配置";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1236, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 62);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "请在右侧添加条目，在下方选择修改项：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveConfig);
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 820);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1483, 141);
            this.panel2.TabIndex = 3;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveConfig.Location = new System.Drawing.Point(1009, 36);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(204, 62);
            this.btnSaveConfig.TabIndex = 4;
            this.btnSaveConfig.Text = "保存配置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClean.Location = new System.Drawing.Point(63, 36);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(204, 62);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "清空内容";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRun.Location = new System.Drawing.Point(1236, 36);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(204, 62);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // listContent
            // 
            this.listContent.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            this.listContent.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listContent.Location = new System.Drawing.Point(0, 141);
            this.listContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listContent.Name = "listContent";
            this.listContent.Size = new System.Drawing.Size(1483, 679);
            this.listContent.TabIndex = 4;
            this.listContent.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 961);
            this.Controls.Add(this.listContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnAdd;
        private Button btnLoadConfig;
        private Button btnSaveConfig;
        private Button btnClean;
        private Button btnRun;
        private ListView listContent;
    }
}