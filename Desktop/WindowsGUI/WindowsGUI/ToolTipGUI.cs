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
    public partial class ToolTipGUI : Form
    {
        public ToolTipGUI()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip() { IsBalloon = true };
            tip.SetToolTip(button2, "cái này là caption. chắc là chữ hiển thị đó mà");
        }
    }
}
