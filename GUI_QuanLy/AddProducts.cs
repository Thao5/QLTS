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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            themSach(txtID.Text, txtTenSach.Text,DateTime.ParseExact(dateXuatBan.Text, "yyyy/MM/dd", null), decimal.Parse(txtGiaBan.Text), int.Parse(txtSoLuong.Text), cbTacGia.SelectedValue.ToString(), txtTheLoai.Text, cbNhaXB.SelectedValue.ToString(), decimal.Parse(txtGiaNhap.Text), decimal.Parse(txtGiaThue.Text));
            this.Close();
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                cbNhaXB.DataSource = db.NXBs.ToList();
                cbNhaXB.ValueMember = "id";
                cbNhaXB.DisplayMember = "name";

                var test = from s in db.taikhoans where s.phanquyen.Equals(2) select s;
                cbTacGia.DataSource = test.ToList();
                cbTacGia.ValueMember = "id";
                cbTacGia.DisplayMember = "name";
            }
        }

        void themSach(String id, String name, DateTime ngay_xuat_ban, decimal gia_ban, int so_luong, String tac_gia, String the_loai, String nha_xuat_ban, decimal gia_nhap, decimal gia_thue)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                try
                {
                    sach s = new sach() { id = id, name = name, gia_ban = gia_ban, gia_nhap = gia_nhap, gia_thue = gia_thue, id_nxb = nha_xuat_ban, ngay_xuat_ban = ngay_xuat_ban, so_luong = so_luong, the_loai = the_loai };
                    sachthuoctacgia st = new sachthuoctacgia() { id_sach = s.id, id_user = tac_gia };
                    db.saches.Add(s);
                    db.SaveChanges();
                    db.sachthuoctacgias.Add(st);
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }

        private void txtTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
