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
    public partial class MessageBoxGUI : Form
    {
        public MessageBoxGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("nội dung", "caption", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);

            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Đóng messagebox nè");
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    MessageBox.Show("NO");
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Cái mới của yes");
                    break;
                default:
                    break;
            }
        }
    }
}
