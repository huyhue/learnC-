using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         /*   AddLV();*/
            ViewDGV();
        }
        public void ViewDGV()
        {
            List<SV> l = new List<SV>();
            l.Add(new SV(101, "NVA", 1.1));
            l.AddRange(new SV[]
            {
                new SV(101,"NVB",1.2),
                new SV(103,"NVC",1.3)
            });
            dgv.DataSource = l;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void A(object o, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text + " hello");
        }
        public void B(object o, EventArgs e)
        {

        }

        public void AddLV()
        {
            ColumnHeader c1 = new ColumnHeader();
            c1.Text = "MSSV";
            ColumnHeader c2 = new ColumnHeader();
            c2.Text = "Name SV";
            ColumnHeader c3 = new ColumnHeader();
            c3.Text = "DTB";
            listView1.Columns.AddRange(new ColumnHeader[] { c1, c2, c3 });
            
            ListViewItem i1 = new ListViewItem();
            i1.Text = "1001";
            ListViewItem.ListViewSubItem sb1 = new ListViewItem.ListViewSubItem();
            sb1.Text = "NVA";
            ListViewItem.ListViewSubItem sb2 = new ListViewItem.ListViewSubItem();
            sb2.Text = "1.1";
            i1.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sb1, sb2 });
            listView1.Items.Add(i1);

            ListViewItem i2 = new ListViewItem();
            i2.Text = "1002";
            ListViewItem.ListViewSubItem sb3 = new ListViewItem.ListViewSubItem();
            sb3.Text = "NVB";
            ListViewItem.ListViewSubItem sb4 = new ListViewItem.ListViewSubItem();
            sb4.Text = "1.2";
            i2.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sb3, sb4 });
            listView1.Items.Add(i2);

            ListViewItem i3 = new ListViewItem();
            i3.Text = "1003";
            ListViewItem.ListViewSubItem sb5 = new ListViewItem.ListViewSubItem();
            sb5.Text = "NVC";
            ListViewItem.ListViewSubItem sb6 = new ListViewItem.ListViewSubItem();
            sb6.Text = "1.3";
            i3.SubItems.AddRange(new ListViewItem.ListViewSubItem[] { sb5, sb6 });
            listView1.Items.Add(i3);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text + " hello");
            string txt = textBox1.Text;
            //IndexOf neu trung tra ve vi tri item trung trong listbox
            //neu khong trung tra ve gia tri -1
            if (listBox1.Items.IndexOf(txt) < 0)
            {
                listBox1.Items.Add(txt);
            }
            else
            {
                MessageBox.Show("Trung roi cu oi");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kich vao phan tu nao la xoa cai do
            if(listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int index = comboBox1.SelectedIndex;
            textBox1.Text = comboBox1.Items[index].ToString();*/

            textBox1.Text = comboBox1.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Enter Name Customer Please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
            }
            txtTotal.Text = Total().ToString();
        }
        private double Total()
        {
            double s = 0;
            if (ck1.Checked)
                s += 100;
            if (ck2.Checked)
                s += 1200;
            if (ck3.Checked)
                s += 200;
            s += Convert.ToInt32(cb2.SelectedIndex.ToString()) * 80;

            return s;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListView.SelectedListViewItemCollection r = listView1.SelectedItems;
            if (r.Count == 1)
            {
                string MSSV = r[0].Text;
                string Name = r[0].SubItems[1].Text;
                string DTB = r[0].SubItems[2].Text;
                MessageBox.Show("MSSV: " + MSSV + " Name: " + Name + " DTB: " + DTB);
            }
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv.SelectedRows;
            if(r.Count == 1)
            {
                int MSSV = Convert.ToInt32(r[0].Cells[0].Value.ToString());
                string Name = r[0].Cells["NameSV"].Value.ToString();
                double DTB = Convert.ToDouble(r[0].Cells["DTB"].Value.ToString());

                MessageBox.Show("MSSV: " + MSSV.ToString() + " Name: " + Name + " DTB: " + DTB.ToString());
            }
        }
    }
}
