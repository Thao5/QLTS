using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Quanly
{
    public partial class AdminAuthors : Form
    {
        public static String id_tacgia;
        public AdminAuthors()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminAuthors_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.taikhoans where s.phanquyen.Equals(2) select new {id = s.id, username = s.username, password = s.password, ho = s.ho, ten = s.ten, ngaysinh = s.ngaysinh, sotienconlai = s.sotienconlai};
                dataGridAdminAuthors.DataSource = test.ToList();
            }
        }

        private void btnDeleteAuthors_Click(object sender, EventArgs e)
        {
            if (dataGridAdminAuthors.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminAuthors.SelectedRows[0];
                    String ID = Convert.ToString(row.Cells[0].Value.ToString());
                    var test = db.taikhoans.Where(s => s.id == ID).Include(s => s.codes);
                    db.taikhoans.RemoveRange(test);
                    var test1 = db.sachduocmuas.Where(s => s.id_user.Equals(ID)).ToList();
                    db.sachduocmuas.RemoveRange(test1);
                    var test2 = db.sachduocthues.Where(s => s.id_user.Equals(ID)).ToList();
                    db.sachduocthues.RemoveRange(test2);
                    var test3 = db.sachthuoctacgias.Where(s => s.id_user.Equals(ID)).ToList();
                    db.sachthuoctacgias.RemoveRange(test3);
                    db.taikhoans.Remove(db.taikhoans.Find(ID));
                    db.SaveChanges();
                    loadData();
                }
            }
        }

        private void btnAddAuthors_Click(object sender, EventArgs e)
        {
            AddAuthors addAuthors = new AddAuthors();
            addAuthors.Show();
        }

        private void btnEditAuthors_Click(object sender, EventArgs e)
        {
            if (dataGridAdminAuthors.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminAuthors.SelectedRows[0];
                    id_tacgia = Convert.ToString(row.Cells[0].Value.ToString());
                    EditAuthors editAuthors = new EditAuthors();
                    editAuthors.Show();
                }
            }
        }
    }
}
