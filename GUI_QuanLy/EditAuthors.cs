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
    public partial class EditAuthors : Form
    {
        public EditAuthors()
        {
            InitializeComponent();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db =  new quanlytiemsachEntities3())
            {
                db.taikhoans.Find(AdminAuthors.id_tacgia).ho = txtHo.Text;
                db.taikhoans.Find(AdminAuthors.id_tacgia).ten = txtTen.Text;
                db.taikhoans.Find(AdminAuthors.id_tacgia).ngaysinh = DateTime.ParseExact(dateNgaySinh.Text, "dd/MM/yyyy", null);
                db.taikhoans.Find(AdminAuthors.id_tacgia).username = txtUserName.Text;
                db.taikhoans.Find(AdminAuthors.id_tacgia).password = txtPassword.Text;
                db.taikhoans.Find(AdminAuthors.id_tacgia).sotienconlai = decimal.Parse(txtSoTien.Text);
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnCancelUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAuthors_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db =  new quanlytiemsachEntities3())
            {
                txtID.Text = AdminAuthors.id_tacgia.ToString();
                txtHo.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).ho;
                txtTen.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).ten;
                dateNgaySinh.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).ngaysinh.ToString();
                txtUserName.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).username;
                txtPassword.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).password;
                txtSoTien.Text = db.taikhoans.Find(AdminAuthors.id_tacgia).sotienconlai.ToString();
            }
            
        }
    }
}
