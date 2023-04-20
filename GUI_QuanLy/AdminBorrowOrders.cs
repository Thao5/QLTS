using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Quanly
{
    public partial class AdminBorrowOrders : Form
    {
        public AdminBorrowOrders()
        {
            InitializeComponent();
        }

        private void btnAddBorrowOrders_Click(object sender, EventArgs e)
        {
            AddBorrowOrders addBorrowOrders = new AddBorrowOrders();
            addBorrowOrders.Show();
        }

        private void AdminBorrowOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.sachduocthues select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                dataGridAdminBorrow.DataSource = test.ToList();
            }
        }

        private void btnDeleteBorrowOrders_Click(object sender, EventArgs e)
        {
            if (dataGridAdminBorrow.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminBorrow.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    db.sachduocthues.Remove(db.sachduocthues.Find(ID));
                    db.SaveChanges();
                    loadData();
                }
            }
        }
    }
}
