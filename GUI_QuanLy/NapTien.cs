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
    public partial class NapTien : Form
    {
        public NapTien()
        {
            InitializeComponent();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var manap = db.codes.Where(s => s.id.Equals(txtCode.Text.Trim()) && s.id_user == null).FirstOrDefault();
                if (manap != null)
                {
                    db.taikhoans.Find(Login.taikhoanuser.id).sotienconlai += 50000;
                    db.codes.Find(txtCode.Text.Trim()).id_user = Login.taikhoanuser.id;
                    db.codes.Find(txtCode.Text.Trim()).ngaynap = DateTime.Now;
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Bạn đã nạp thành công 50000VND vào tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn nhập sai mã nạp hoặc mã đã được sử dụng!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
