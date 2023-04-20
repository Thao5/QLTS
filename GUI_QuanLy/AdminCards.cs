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
    public partial class AdminCards : Form
    {
        public AdminCards()
        {
            InitializeComponent();
        }

        private void btnAddCards_Click(object sender, EventArgs e)
        {
            AddCards addCards = new AddCards();
            addCards.Show();
        }

        private void AdminCards_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.codes select new { id = s.id, valid = s.valid, user = s.taikhoan.ten, ngaynap = s.ngaynap};
                dataGridAdminCards.DataSource = test.ToList();
            }
        }

        private void btnDeleteCards_Click(object sender, EventArgs e)
        {
            if (dataGridAdminCards.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminCards.SelectedRows[0];
                    String ID = Convert.ToString(row.Cells[0].Value.ToString());
                    db.codes.Remove(db.codes.Find(ID));
                    db.SaveChanges();
                    loadData();
                }
            }
        }
    }
}
