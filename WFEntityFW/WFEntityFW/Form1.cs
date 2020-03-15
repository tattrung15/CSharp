using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEntityFW
{
    public partial class Form1 : Form
    {
        TestEntityEntities db = new TestEntityEntities();

        public Form1()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
            txbID.Enabled = false;
        }

        void AddBinding()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvShow.DataSource, "ID"));
            txbName.DataBindings.Add(new Binding("Text", dtgvShow.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbIDLop.DataBindings.Add(new Binding("Text", dtgvShow.DataSource, "IDLop", true, DataSourceUpdateMode.Never));
        }

        void LoadData()
        {
            var res = from c in db.SinhViens
                          //where c.ID <= 2
                          //select new { ID = c.ID, Name = c.Name, Lop = c.Lop.Name };
                      select c;
            dtgvShow.DataSource = res.ToList();
        }

        void AddSinhVien()
        {
            SinhVien sv = new SinhVien() { Name = txbName.Text, IDLop = int.Parse(txbIDLop.Text) };
            db.SinhViens.Add(sv);
            db.SaveChanges();
        }

        void DeleteSinhVien()
        {
            int id = int.Parse(txbID.Text);
            SinhVien sv = db.SinhViens.Where(p => p.ID == id).SingleOrDefault();
            db.SinhViens.Remove(sv);
            db.SaveChanges();
        }

        void EditSinhVien()
        {
            int id = Convert.ToInt32(dtgvShow.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            SinhVien sv = db.SinhViens.Find(id);
            sv.Name = txbName.Text;
            sv.IDLop = Convert.ToInt32(txbIDLop.Text);
            db.SaveChanges();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSinhVien();
            LoadData();
            MessageBox.Show("Đã thêm sinh viên");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSinhVien();
            LoadData();
            MessageBox.Show("Đã xóa sinh viên");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSinhVien();
        }
    }
}
