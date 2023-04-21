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
    public partial class Products : Form
    {
        quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
        public Products()
        {
            InitializeComponent();
        }

        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridProducts.SelectedRows[0];
                    String ID = Convert.ToString(row.Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Bạn có muốn mượn sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.taikhoans.Find(Login.taikhoanuser.id).sotienconlai >= db.saches.Find(ID).gia_thue)
                        {
                            db.sachduocthues.Add(new sachduocthue() { gia_thue = db.saches.Find(ID).gia_thue, ngay_thue = DateTime.Now, created_date = DateTime.Now, id_sach = ID, id_user = Login.taikhoanuser.id });
                            db.taikhoans.Find(Login.taikhoanuser.id).sotienconlai -= db.saches.Find(ID).gia_thue;
                            db.SaveChanges();
                            result = MessageBox.Show("Đã thuê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            result = MessageBox.Show("Bạn không đủ tiền!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            view();
        }

        void view()
        {
            var test = from s in db.saches select new { id = s.id, name = s.name, ngay_xuat_ban = s.ngay_xuat_ban, gia_ban = s.gia_ban, gia_thue = s.gia_thue, so_luong = s.so_luong, the_loai = s.the_loai, gia_nhap = s.gia_nhap };
            dataGridProducts.DataSource = test.ToList();

        }

        void borrow()
        {

            //var ktra = from s in db.taikhoans where s.phanquyen.Equals(2) && s.sotienconlai.Equals(10000) select {  }



        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dataGridProducts.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridProducts.SelectedRows[0];
                    String ID = Convert.ToString(row.Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Bạn có muốn mua sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (db.taikhoans.Find(Login.taikhoanuser.id).sotienconlai >= db.saches.Find(ID).gia_ban)
                        {
                            db.sachduocmuas.Add(new sachduocmua() { gia_ban = db.saches.Find(ID).gia_ban, created_date = DateTime.Now, id_sach = ID, id_user = Login.taikhoanuser.id });
                            db.taikhoans.Find(Login.taikhoanuser.id).sotienconlai -= db.saches.Find(ID).gia_ban;
                            db.SaveChanges();
                            result = MessageBox.Show("Đã mua thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            result = MessageBox.Show("Bạn không đủ tiền!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
