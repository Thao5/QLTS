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
    public partial class AdminProduct : Form
    {
        public AdminProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
            var test = from s in db.saches select new {id  = s.id, name = s.name, ngay_xuat_ban = s.ngay_xuat_ban, gia_ban = s.gia_ban, gia_thue = s.gia_thue , so_luong = s.so_luong, the_loai = s.the_loai, gia_nhap = s.gia_nhap, nameNxb = s.NXB.name};
            dataGridAdminProduct.DataSource = test.ToList();
        }
    }
}
