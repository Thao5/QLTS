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
            var test = from s in db.saches select new { id = s.id , name = s.name , ngay_xuat_ban = s.ngay_xuat_ban , gia_ban =s.gia_ban , gia_thue =s.gia_thue , so_luong =s.so_luong , the_loai =s.the_loai , gia_nhap =s.gia_nhap };
            dataGridProducts.DataSource = test.ToList();
            
        }

        void borrow()
        {

            var ktra = from s in db.taikhoans where s.phanquyen.Equals(2) && s.sotienconlai.Equals(10000) select {  }
            
           
        
        }
}
