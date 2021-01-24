using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGUI
{
    public partial class MenuStripGUI : Form
    {
        public MenuStripGUI()
        {
            InitializeComponent();
        }

        private void MenuStripGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = mntsCombo.SelectedItem.ToString();
            label1.Text = str;
        }

        private void huy1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã click vào free education");
        }
    }
}
