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
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            AddUsers addUsers = new AddUsers(); 
            addUsers.Show();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.taikhoans select new { id = s.id, username = s.username, password = s.password, ho = s.ho, ten = s.ten, ngaysinh = s.ngaysinh, sotienconlai = s.sotienconlai, phanquyen = s.phanquyen };
                dataGridAdminUsers.DataSource = test.ToList();
            }
        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            if (dataGridAdminUsers.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminUsers.SelectedRows[0];
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
    }
}
