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
    public partial class fMain : System.Windows.Forms.Form
    {
        public fMain()
        {
            InitializeComponent();
            loadLabel();
        }

        void loadLabel()
        {
            Label lb = new Label();
            lb.Text = "HowKteam";
            this.Controls.Add(lb);
            lb.BackColor = Color.Red;
        }
        int i = 0;
        private void fMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da click len form "+i+" lan");
            i++;
            label1.Text = "Education";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.lb2.Text = "Share to be better";
        }
    }
}
