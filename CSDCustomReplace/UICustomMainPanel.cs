using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDCustomReplace
{
    public partial class UICustomMainPanel : Component
    {
        public UICustomMainPanel()
        {
            InitializeComponent();
        }

        public UICustomMainPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
