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
    public partial class Borrow_Orders : Form
    {
        public Borrow_Orders()
        {
            InitializeComponent();
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.Show();
        }

        private void Borrow_Orders_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db =  new quanlytiemsachEntities3())
            {
                var test = from s in db.sachduocthues where s.id_user.Equals(Login.taikhoanuser.id) select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, sach = s.sach.name, user = Login.taikhoanuser.ten };
                dataGridBorrowOrders.DataSource = test.ToList();
                lbMoneyBorrow.Text = db.sachduocthues.Where(s=>s.id_user.Equals(Login.taikhoanuser.id)).Sum(s=>s.gia_thue).ToString();
            }
        }
    }
}
