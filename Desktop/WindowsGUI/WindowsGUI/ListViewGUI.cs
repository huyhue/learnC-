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
    public partial class ListViewGUI : Form
    {
        public ListViewGUI()
        {
            InitializeComponent();
            LoadListview();
        }

        ImageList imgListSmall;
        ImageList imgListLarge;

        void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(68, 68) };
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\1.png"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\2.png"));
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\3.png"));


            imgListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\1.png"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\2.png"));
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\3.png"));
        }

        void LoadListview()
        {
            LoadImageList();

            lsvShow.FullRowSelect = true;
            lsvShow.GridLines = true;
            lsvShow.LargeImageList = imgListLarge;
            lsvShow.SmallImageList = imgListSmall;

            lsvShow.Columns.Add("Tên column 1");
            lsvShow.Columns.Add("Tên column 2");
            lsvShow.Columns.Add("Tên column 3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item1";
            item1.ImageIndex = 0;
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item2";
            item2.ImageIndex = 1;
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item3";
            item3.ImageIndex = 2;
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            lsvShow.Items.Add(item1);
            lsvShow.Items.Add(item2);
            lsvShow.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.LargeIcon;

            lsvShow.CheckBoxes = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.Details;

            lsvShow.CheckBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lsvShow.View = View.SmallIcon;

            lsvShow.CheckBoxes = false;
        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;

            if (lsv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lsv.SelectedItems)
                {
                    MessageBox.Show(item.Text);
                }
            }
        }
    }
}
