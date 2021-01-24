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
    public partial class ImageGUI : Form
    {
        string extention = ".png";
        public ImageGUI()
        {
            InitializeComponent();
            cbImage.SelectedValueChanged += cbImage_SelectedValueChanged;

            LoadImageName();
        }

        private void cbImage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + extention);

                pcbImage.Image = bm;
            }
        }
        void LoadImageName()
        {
            List<string> ListImage = new List<string>() { "1", "2", "3" };
            cbImage.DataSource = ListImage;
        }

    }
}
