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
    public partial class ButtonGUI : Form
    {
        public ButtonGUI()
        {
            InitializeComponent();
            LoadButton();
        }
        void LoadButton()
        {

        }
        int i = 0;
        void AddButton()
        {
            Button btn = new Button() { Text = i.ToString() };
            Random rand = new Random();
            btn.Location = new Point(rand.Next(0, this.Size.Width), rand.Next(0, this.Size.Height));
            btn.Click += btn_Click;

            this.Controls.Add(btn);

            i++;
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;//ep kieu
            MessageBox.Show(btn.Text);
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            AddButton();
        }
    }
}
