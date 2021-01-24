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
    public partial class TextboxGUI : Form
    {
        public TextboxGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (Int32.TryParse(txtValue.Text, out num))
                lbValue.Text = (num * num).ToString();
            else
                lbValue.Text = "Vui lòng nhập số!";
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            int num = 0;

            if (Int32.TryParse(txtValue.Text, out num))
                lbValue.Text = (num * num).ToString();
            else
                lbValue.Text = "Vui lòng nhập số!";
        }
    }
}
