using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGUI
{
    public partial class ProcessGUI : Form
    {
        public ProcessGUI()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Process.Start(Application.StartupPath + "\\WindowsGUI.exe");
            string link = @"http:\\www.howkteam.com";
            Process.Start(link);
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = Application.StartupPath + "\\WindowsGUI.exe";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
        }
        void GetProcesses()
        {
            Process[] processArr = Process.GetProcesses();
            //var item = Process.GetCurrentProcess();
            foreach (Process item in processArr)
            {
                txbLog.Text = item.ProcessName + "\n" + txbLog.Text;
            }
        }
    }
}
