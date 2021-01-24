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
    public partial class CheckboxGUI : Form
    {
        public CheckboxGUI()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("CheckedChanged");
        }

        private void ckbKter_CheckStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("CheckStateChanged");
        }

        private void ckbKter_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string kter = ckbKter.CheckState == CheckState.Checked ? "là" : ckbKter.CheckState == CheckState.Unchecked ? "không phải" : "phải cũng không phải là";
            string showString = string.Format("Chào bạn {0}, bạn {1} kter!", name, kter);

            MessageBox.Show(showString);
        }
    }
}
