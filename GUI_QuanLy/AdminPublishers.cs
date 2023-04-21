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
    public partial class AdminPublishers : Form
    {
        public static String id_NXB;
        public AdminPublishers()
        {
            InitializeComponent();
        }

        private void btnAddPublishers_Click(object sender, EventArgs e)
        {
            AddPublishers addPublishers = new AddPublishers();
            addPublishers.Show();
        }

        private void AdminPublishers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.NXBs select new {id = s.id, name = s.name};
                dataGridAdminPublishers.DataSource = test.ToList();
            }
        }

        private void btnDeletePublishers_Click(object sender, EventArgs e)
        {
            if (dataGridAdminPublishers.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminPublishers.SelectedRows[0];
                    String ID = Convert.ToString(row.Cells[0].Value.ToString());
                    var test1 = db.sachthuoctacgias.Where(s => s.sach.id_nxb.Equals(ID)).ToList();
                    db.sachthuoctacgias.RemoveRange(test1);
                    var test2 = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(ID)).ToList();
                    db.sachduocmuas.RemoveRange(test2);
                    var test3 = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(ID)).ToList();
                    db.sachduocthues.RemoveRange(test3);
                    var test4 = db.saches.Where(s => s.id_nxb == ID).ToList();
                    db.saches.RemoveRange(test4);
                    db.NXBs.Remove(db.NXBs.Find(ID));
                    db.SaveChanges();
                    loadData();
                }
            }
        }

        private void btnEditPublishers_Click(object sender, EventArgs e)
        {
            if (dataGridAdminPublishers.SelectedRows.Count > 0)
            {
                using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
                {
                    DataGridViewRow row = dataGridAdminPublishers.SelectedRows[0];
                    id_NXB = Convert.ToString(row.Cells[0].Value.ToString());
                    EditPublishers editPublishers = new EditPublishers();
                    editPublishers.Show();
                }
            }
        }
    }
}
