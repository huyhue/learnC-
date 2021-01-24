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
    public partial class PanelGUI : Form
    {
        public PanelGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "HowKteam.com";
            btn.AutoSize = true;

            //Random rand = new Random();
            //btn.Location = new Point(rand.Next(0, pnlButton.Size.Width), rand.Next(0, pnlButton.Size.Height));

            //pnlButton.Controls.Add(btn);
            fpnlButton.Controls.Add(btn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fpnlButton.Enabled = !fpnlButton.Enabled;
        }
    }
}
