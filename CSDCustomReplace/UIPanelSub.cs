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
    public partial class UIPanelSub : UserControl
    {
        public UIPanelSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            UIListGroup uIListGroup = new UIListGroup();
            uIListGroup.RemoveItem();
            this.Controls.Remove(this);
        }
    }
}
