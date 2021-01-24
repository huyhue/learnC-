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
    public partial class RadioButtonGUI : Form
    {
        public RadioButtonGUI()
        {
            InitializeComponent();
        }
        void ShowResult(Label lb, Panel pnl)
        {
            RadioButton ckb = null;

            foreach (RadioButton item in pnl.Controls)
            {
                if (item != null)
                    if (item.Checked)
                    {
                        ckb = item;
                        break;
                    }
            }

            if (ckb != null)
                lb.Text = ckb.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowResult(label1, panel1);
            ShowResult(label2, panel2);
            ShowResult(label3, panel3);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
                label1.Text = radio.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
                label2.Text = radio.Text;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
                label3.Text = radio.Text;
        }
    }
}
