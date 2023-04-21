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
    public partial class EditPublishers : Form
    {
        public EditPublishers()
        {
            InitializeComponent();
        }

        private void btnCancelPublisher_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnSavePublisher_Click(object sender, EventArgs e)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                db.NXBs.Find(AdminPublishers.id_NXB).name = txtNXB.Text;
                db.SaveChanges();
            }
            this.Close();
        }

        private void EditPublishers_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                txtID.Text = AdminPublishers.id_NXB;
                txtNXB.Text = db.NXBs.Find(AdminPublishers.id_NXB).name;
            }
        }
    }
}
