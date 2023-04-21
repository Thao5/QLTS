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
    public partial class Login : Form
    {
        public static taikhoan taikhoanuser;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db =  new quanlytiemsachEntities3())
            {
                taikhoanuser = db.taikhoans.Where(s=> s.username.Equals(txtUserName.Text) && s.password.Equals(txtPassword.Text)).FirstOrDefault();
                if (taikhoanuser == null)
                {
                    DialogResult result = MessageBox.Show("Sai mật khẩu hay tài khoản!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    if(taikhoanuser.phanquyen != 0)
                    {
                        this.Hide();
                        Form1 form = new Form1();
                        form.Show();
                    }
                    else
                    {
                        this.Hide();
                        AdminHome home = new AdminHome();
                        home.Show();
                    }
                }
            }
        }
    }
}
