using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDCustomReplace
{
    public partial class UIListGroup : UserControl
    {
        UIPanelSub uIPanelSub;
        public UIListGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uIPanelSub = new UIPanelSub();
            uIPanelSub.Location = new System.Drawing.Point(0, this.Height);
            groupBox.Controls.Add(uIPanelSub);
            this.Height += uIPanelSub.Height+3;
            uIPanelSub.BringToFront();
            
        }

        public void RemoveItem()
        {
            this.Height = groupBox.Height -= 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this);
        }
    }
}
