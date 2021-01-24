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
    public partial class ContextMenuGUI : Form
    {
        ContextMenuStrip contextMenu;
        public ContextMenuGUI()
        {
            InitializeComponent(); 
            contextMenu = new ContextMenuStrip();
            contextMenu.Width = 500;
            var item = new ToolStripLabel() { Text = "Click me, oh baby", AutoSize = true };
            item.Click += item_Click;
            contextMenu.Items.Add(item);
        }

        void item_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            contextMenu.Show(this, this.PointToClient(MousePosition));
        }
    }
}
