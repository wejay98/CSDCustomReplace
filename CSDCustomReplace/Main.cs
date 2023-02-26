using CSDCustomReplace;

namespace AutoReplace
{
    public partial class Main : Form
    {
        private UIListGroup ui_list_group;
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ui_list_group = new UIListGroup();
            listContent.Controls.Add(ui_list_group);
        }
    }
}