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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                if(db.taikhoans.Find(Login.taikhoanuser.id).password.Equals(txtOldPassword.Text))
                {
                    db.taikhoans.Find(Login.taikhoanuser.id).password = txtNewPassword.Text;
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Bạn đã đổi mật khẩu thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Mật khẩu cũ không khớp với hệ thống!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
