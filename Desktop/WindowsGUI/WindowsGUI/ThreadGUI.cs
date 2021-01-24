using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGUI
{
    public partial class ThreadGUI : Form
    {
        public ThreadGUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thrd = new Thread(Demo);
            thrd.IsBackground = true;
            thrd.Start();
        }

        void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("www.HowKteam.com");
        }
        int speed = 100;

        void MovePictureBox()
        {
            new Thread(
                () =>
                {
                    while (true)
                    {
                        if (checkBox1.Checked)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                        }
                        else
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                        }
                        Thread.Sleep(speed);
                    }
                }
                )
            { IsBackground = true }.Start();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("www.HowKteam.com");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MovePictureBox();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out speed))
            {
            }
        }
    }
}
