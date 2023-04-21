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
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
            List<String> userType = new List<String>() { "Admin", "User", "Author" };
            cbLoaiNguoiDung.DataSource = userType;
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            { 
                db.taikhoans.Find(AdminUsers.id_user).ho = txtHo.Text;
                db.taikhoans.Find(AdminUsers.id_user).ten = txtTen.Text ;
                db.taikhoans.Find(AdminUsers.id_user).ngaysinh = DateTime.ParseExact(dateNgaySinh.Text, "dd/MM/yyyy", null);
                db.taikhoans.Find(AdminUsers.id_user).username = txtUserName.Text;
                db.taikhoans.Find(AdminUsers.id_user).password = txtPassword.Text;
                db.taikhoans.Find(AdminUsers.id_user).phanquyen = cbLoaiNguoiDung.SelectedIndex;
                db.taikhoans.Find(AdminUsers.id_user).sotienconlai = decimal.Parse(txtSoTien.Text);
                db.SaveChanges();
            }
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

        private void EditUsers_Load(object sender, EventArgs e)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                txtID.Text = AdminUsers.id_user.ToString();
                txtHo.Text = db.taikhoans.Find(AdminUsers.id_user).ho;
                txtTen.Text = db.taikhoans.Find(AdminUsers.id_user).ten;
                dateNgaySinh.Text = db.taikhoans.Find(AdminUsers.id_user).ngaysinh.ToString();
                txtUserName.Text = db.taikhoans.Find(AdminUsers.id_user).username;
                txtPassword.Text = db.taikhoans.Find(AdminUsers.id_user).password;
                cbLoaiNguoiDung.SelectedIndex = db.taikhoans.Find(AdminUsers.id_user).phanquyen;
                txtSoTien.Text = db.taikhoans.Find(AdminUsers.id_user).sotienconlai.ToString();
            }
        }
    }
}
