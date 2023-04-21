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
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                db.saches.Find(AdminProduct.id_product).name = txtTenSach.Text;
                db.saches.Find(AdminProduct.id_product).ngay_xuat_ban = DateTime.ParseExact(dateXuatBan.Text, "yyyy/MM/dd", null);
                db.saches.Find(AdminProduct.id_product).gia_ban = decimal.Parse(txtGiaBan.Text);
                db.saches.Find(AdminProduct.id_product).so_luong = int.Parse(txtSoLuong.Text);
                db.saches.Find(AdminProduct.id_product).the_loai = txtTheLoai.Text;
                db.saches.Find(AdminProduct.id_product).id_nxb = cbNhaXB.SelectedValue.ToString();
                db.saches.Find(AdminProduct.id_product).gia_nhap = decimal.Parse(txtGiaNhap.Text);
                db.saches.Find(AdminProduct.id_product).gia_thue = decimal.Parse(txtGiaThue.Text);
                db.SaveChanges();
            }
            this.Close();
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

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void EditProducts_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                txtID.Text = AdminProduct.id_product;
                txtTenSach.Text = db.saches.Find(AdminProduct.id_product).name;
                dateXuatBan.Text = db.saches.Find(AdminProduct.id_product).ngay_xuat_ban.ToString();
                txtGiaBan.Text = db.saches.Find(AdminProduct.id_product).gia_ban.ToString();
                txtSoLuong.Text = db.saches.Find(AdminProduct.id_product).so_luong.ToString();
                txtTheLoai.Text = db.saches.Find(AdminProduct.id_product).the_loai;
                cbNhaXB.DataSource = db.NXBs.ToList();
                cbNhaXB.ValueMember = "id";
                cbNhaXB.DisplayMember = "name";
                cbNhaXB.SelectedValue = db.saches.Find(AdminProduct.id_product).id_nxb;
                txtGiaNhap.Text = db.saches.Find(AdminProduct.id_product).gia_nhap.ToString();
                txtGiaThue.Text = db.saches.Find(AdminProduct.id_product).gia_thue.ToString();
            }
            
        }
    }
}
