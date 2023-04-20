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
    public partial class AddBuyOrders : Form
    {
        public AddBuyOrders()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddBuyOrders_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                cbNguoiMua.DataSource = db.taikhoans.ToList();
                cbNguoiMua.ValueMember = "id";
                cbNguoiMua.DisplayMember = "name";

                cbTenSachBuy.DataSource = db.saches.ToList();
                cbTenSachBuy.ValueMember = "id";
                cbTenSachBuy.DisplayMember = "name";
            }   
        }

        private void btnSaveBuy_Click(object sender, EventArgs e)
        {
            themSachBuy(cbNguoiMua.SelectedValue.ToString(), cbTenSachBuy.SelectedValue.ToString());
            this.Close();
        }

        private void btnCancelBuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void themSachBuy(String id_user, String id_sach)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                decimal gia_tien = db.saches.Find(id_sach).gia_ban;
                db.sachduocmuas.Add(new sachduocmua() { gia_ban = gia_tien, created_date = DateTime.Now, id_sach = id_sach, id_user = id_user });
                db.SaveChanges();
            }
        }
    }
}
