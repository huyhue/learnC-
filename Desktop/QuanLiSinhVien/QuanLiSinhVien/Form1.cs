using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        private DB db;
        public Form1()
        {
            InitializeComponent();
            db = new DB();
            loadCB();
            loadCBS();
            cbClassS.SelectedIndex = 0;
            cbClass.SelectedIndex = 0;
            dgv.DataSource = GetList(cbClassS.Items[cbClassS.SelectedIndex].ToString());
        }
        public void loadCB()
        {
            foreach (SV i in db.li)
            {
                if (cbClass.Items.IndexOf(i.lop) == -1)
                {
                    cbClass.Items.Add(i.lop);
                }
            }
            cbSearch.Items.Add("MSSV");
            cbSearch.Items.Add("NameSV");
            cbSearch.Items.Add("lop");
            cbSearch.Items.Add("Ngaysinh");
            cbSearch.Items.Add("Gender");
            cbSearch.SelectedIndex = 0;
            cbSort.Items.Add("MSSV");
            cbSort.Items.Add("NameSV");
            cbSort.Items.Add("lop");
            cbSort.Items.Add("Ngaysinh");
            cbSort.Items.Add("Gender");
            cbSort.SelectedIndex = 0;
        }
        public void loadCBS()
        {
            cbClassS.Items.Add("All");
            foreach(SV i in db.li)
            {
                if (cbClassS.Items.IndexOf(i.lop) == -1)
                {
                    cbClassS.Items.Add(i.lop);
                }
            }
        }

        public List<SV> GetList(string select)
        {
            List<SV> data = new List<SV>();
            if (select == "All")
            {
                data = db.li;
            }
            else
            {
                foreach (SV i in db.li)
                {
                    if (i.lop == select)
                    {
                        data.Add(i);
                    }
                }
            }
            return data;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int mssv = Convert.ToInt32(txtMs.Text);
            string name = txtName.Text;
            string lop = cbClass.Items[cbClass.SelectedIndex].ToString();
            DateTime nam = dtm.Value;
            bool gender = false;
            if (rbM.Checked)
            {
                gender = true;
            }
            SV sv = new SV(mssv, name, lop, nam, gender);
            db.li.Add(sv);
            dgv.DataSource = null;
            cbClass.SelectedIndex = 0;
            dgv.DataSource = GetList("All");
        }   


        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv.SelectedRows;
            if (r.Count > 0)
            {
                List<int> MSdel = new List<int>();
                foreach(DataGridViewRow i in r)
                {
                    int mssv = Convert.ToInt32(i.Cells["MSSV"].Value.ToString());
                    MSdel.Add(mssv);
                }
                foreach (int i in MSdel)
                {
                    for(int j = 0; j < db.li.Count; j++)
                    {
                        if (i == db.li[j].MSSV)
                        {
                            db.li.RemoveAt(j);
                        }
                    }
                }
                dgv.DataSource = null;
                cbClass.SelectedIndex = 0; 
                dgv.DataSource = GetList("All");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int MSSV = Convert.ToInt32(txtMs.Text);
            foreach (SV i in db.li)
            {
                if (i.MSSV == MSSV)
                {
                    i.NameSV = txtName.Text;
                    i.lop = cbClass.Items[cbClass.SelectedIndex].ToString();
                    i.ngaysinh = dtm.Value;
                    i.gender = rbM.Checked;

                    btnUpdate.Enabled = false;

                    dgv.DataSource = null;
                    cbClass.SelectedIndex = 0;
                    dgv.DataSource = GetList("All");
                }
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            SVComparer compare = new SVComparer();
            int index = cbSort.SelectedIndex;

            if (index == 0)
            {
                compare.compareByFields = SVComparer.sortBy.MSSV;
            }
            else if (index == 1)
            {
                compare.compareByFields = SVComparer.sortBy.NameSV;
            }
            else if (index == 2)
            {
                compare.compareByFields = SVComparer.sortBy.lop;
            }
            else if (index == 3)
            {
                compare.compareByFields = SVComparer.sortBy.ngaysinh;
            }
            else if (index == 4)
            {
                compare.compareByFields = SVComparer.sortBy.gender;
            }
            else
            {
                MessageBox.Show("Error Sorting");
            }
            db.li.Sort(compare);
            dgv.DataSource = null;
            dgv.DataSource = db.li;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int field = cbSearch.SelectedIndex;
                string txt = txtSearch.Text;
                List<SV> data = new List<SV>();
                foreach (SV i in db.li)
                {
                    if (field == 0 && i.MSSV == Convert.ToInt32(txt))
                    {
                        data.Add(i);
                    }
                    if (field == 1 && i.NameSV.Contains(txt))
                    {
                        data.Add(i);
                    }
                    if (field == 2 && i.lop.Contains(txt))
                    {
                        data.Add(i);
                    }
                    if (field == 3 && i.ngaysinh == DateTime.Parse(txt))
                    {
                        data.Add(i);
                    }
                    if (field == 4 && i.gender == bool.Parse(txt))
                    {
                        data.Add(i);
                    }
                    else
                    {
                        MessageBox.Show("Error Search");
                    }
                }
                    dgv.DataSource = data;
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }
        

        private void cbClassS_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cbClassS.Items[cbClassS.SelectedIndex].ToString();
            dgv.DataSource = GetList(select);
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgv.SelectedRows;
            if (r.Count == 1)
            {
                int MSSV = Convert.ToInt32(r[0].Cells["MSSV"].Value.ToString());
                foreach (SV i in db.li)
                {
                    if (i.MSSV == MSSV)
                    {
                        txtMs.Text = i.MSSV.ToString();
                        txtName.Text = i.NameSV;
                        string Lop = i.lop;
                        int index = cbClass.Items.IndexOf(Lop);
                        cbClass.SelectedIndex = index;
                        dtm.Value = i.ngaysinh;

                        if (i.gender)
                        {
                            rbM.Checked = true;
                        }
                        else
                        {
                            rbF.Checked = true;
                        }
                    }
                }
                btnUpdate.Enabled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
