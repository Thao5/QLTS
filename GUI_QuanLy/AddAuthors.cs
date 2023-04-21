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
    public partial class AddAuthors : Form
    {
        public AddAuthors()
        {
            InitializeComponent();
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            themAuthor(txtID.Text, txtHo.Text, txtTen.Text, DateTime.ParseExact(dateNgaySinh.Text, "dd/MM/yyyy", null), txtUserName.Text, txtPassword.Text, decimal.Parse(txtSoTien.Text));
            this.Close();
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

        void themAuthor(String id, String ho, String ten, DateTime ngaysinh, String username, String password, decimal sotien)
        {
            using(quanlytiemsachEntities3 db =  new quanlytiemsachEntities3())
            {
                db.taikhoans.Add(new taikhoan() { id = id, ho = ho, ten = ten, ngaysinh = ngaysinh, username = username, password = password, sotienconlai = sotien, phanquyen = 2 });
                db.SaveChanges();
            }
        }
    }
}
