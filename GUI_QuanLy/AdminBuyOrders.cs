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
    public partial class AdminBuyOrders : Form
    {
        public AdminBuyOrders()
        {
            InitializeComponent();
        }

        private void btnAddBuyOrders_Click(object sender, EventArgs e)
        {
            AddBuyOrders addBuyOrders = new AddBuyOrders();
            addBuyOrders.Show();
        }

        private void AdminBuyOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.sachduocmuas select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user};
                dataGridAdminBuy.DataSource = test.ToList();
            }
        }

        private void btnDeleteBuyOrders_Click(object sender, EventArgs e)
        {
            if (dataGridAdminBuy.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminBuy.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    db.sachduocmuas.Remove(db.sachduocmuas.Find(ID));
                    db.SaveChanges();
                    loadData();
                }
            }
        }
    }
}
