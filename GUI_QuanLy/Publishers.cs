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
    public partial class Publishers : Form
    {
        quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
        public Publishers()
        {
            InitializeComponent();
        }

        private void Publishers_Load(object sender, EventArgs e)
        {
            view();
        }

        void view()
        {
            var test = from s in db.NXBs select new { id = s.id, name = s.name};
            dataGridPublishers.DataSource = test.ToList();
        }
    }
}
