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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            themUser(txtID.Text, txtUserName.Text, txtPassword.Text, txtHo.Text, txtTen.Text, DateTime.ParseExact(dateNgaySinh.Text, "dd/MM/yyyy", null), decimal.Parse(txtSoTien.Text), cbLoaiNguoiDung.SelectedIndex);
            this.Close();
        }

        void themUser(String id,  String username, String password, String ho, String ten, DateTime ngaysinh, decimal sotienconlai, int phanquyen)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                db.taikhoans.Add(new taikhoan() { id = id, username = username, password = password, ho = ho, ten = ten, ngaysinh = ngaysinh, sotienconlai = sotienconlai, phanquyen = phanquyen });
                db.SaveChanges();
            }
        }

        private void btnCancelUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
