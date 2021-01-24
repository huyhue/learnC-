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
    public partial class EntityGUI : Form
    {
        TestEntityEntities db = new TestEntityEntities();
        public EntityGUI()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
        }
        #region methods
        void AddBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "IDLop", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvData.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void LoadData()
        {
            //using (KteamEntities db = new KteamEntities())
            {
                var result = from c in db.SinhVien
                                 //where c.ID > 1 && c.ID < 4
                             select c;

                //var result = db.SinhVien.Find(2);

                dtgvData.DataSource = result.ToList();
            }
        }
        void AddSinhVien()
        {
            //using (KteamEntities db = new KteamEntities())
            {
                SinhVien sv = new SinhVien() { Name = txbName.Text, IDLop = Convert.ToInt32(txbID.Text) };
                db.SinhVien.Add(sv);
                db.SaveChanges();
            }
        }
        void DeleteSinhVien()
        {
            int id = Convert.ToInt32(txbID.Text);
            SinhVien sv = db.SinhVien.Where(p => p.IDLop == id && p.Name == txbName.Text).SingleOrDefault();
            db.SinhVien.Remove(sv);
            db.SaveChanges();
        }
        void EditSinhVien()
        {
            int id = Convert.ToInt32(dtgvData.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            SinhVien sv = db.SinhVien.Find(id);
            sv.Name = txbName.Text;
            sv.IDLop = Convert.ToInt32(txbID.Text);
            db.SaveChanges();
        }
        #endregion

        #region Events

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSinhVien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSinhVien();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSinhVien();
        }
        #endregion
    }
}
