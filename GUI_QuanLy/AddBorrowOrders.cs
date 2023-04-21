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
    public partial class AddBorrowOrders : Form
    {
        public AddBorrowOrders()
        {
            InitializeComponent();
        }

        private void btnSaveBorrow_Click(object sender, EventArgs e)
        {
            themSachMuon(cbTenSachBorrow.SelectedValue.ToString(), cbNguoiThue.SelectedValue.ToString(), DateTime.ParseExact(dateNgayThue.Text, "dd/MM/yyyy", null));
            this.Close();
        }

        private void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBorrowOrders_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                cbNguoiThue.DataSource = db.taikhoans.ToList();
                cbNguoiThue.ValueMember = "id";
                cbNguoiThue.DisplayMember = "name";

                cbTenSachBorrow.DataSource = db.saches.ToList();
                cbTenSachBorrow.ValueMember = "id";
                cbTenSachBorrow.DisplayMember = "name";
            }
        }

        void themSachMuon(String id_sach, String id_user, DateTime ngay_thue)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                db.sachduocthues.Add(new sachduocthue() { id_sach = id_sach, id_user = id_user, ngay_thue = ngay_thue, ngay_tra = ngay_thue.AddDays(60), created_date = DateTime.Now });
                db.SaveChanges();
            }
        }
    }
}
