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
    public partial class Users : Form
    {
        quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db=  new quanlytiemsachEntities3())
            {
                taikhoan test = db.taikhoans.Find(Login.taikhoanuser.id);
                lbName.Text = test.ho + " " + test.ten;
                lbNgaySinh.Text = test.ngaysinh.ToString();
                lbUserName.Text = test.username;
                lbPassword.Text = test.password;
                lbMoney.Text = test.sotienconlai.ToString();
                if (test.phanquyen == 1)
                {
                    lbLoaiNguoiDung.Text = "Độc giả";
                }
                else if (test.phanquyen == 2)
                {
                    lbLoaiNguoiDung.Text = "Tác giả";
                }
            }
            
        }
    }
}
