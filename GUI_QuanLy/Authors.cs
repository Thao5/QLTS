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
    public partial class Authors : Form
    {
        quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
        public Authors()
        {
            InitializeComponent();
        }

        private void dataGridAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            view();
        }

        void view()
        {
            var ktra = from s in db.taikhoans where s.phanquyen.Equals(2) select new {id =s.id, username = s.username, password=s.password, ho = s.ho, ten=s.ten, ngaysinh=s.ngaysinh, sotienconlai=s.sotienconlai };
            dataGridAuthors.DataSource = ktra.ToList();
        }
    }
}
