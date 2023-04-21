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
    public partial class BuyOrders : Form
    {
        public BuyOrders()
        {
            InitializeComponent();
        }

        private void BuyOrders_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.sachduocmuas where s.id_user.Equals(Login.taikhoanuser.id) select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, sach = s.sach.name, user = Login.taikhoanuser.ten };
                dataGridBuyOrders.DataSource = test.ToList();
                lbMoneyBuy.Text = db.sachduocmuas.Where(s => s.id_user.Equals(Login.taikhoanuser.id)).Sum(s => s.gia_ban).ToString();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut();
            checkOut.Show();
        }
    }
}
