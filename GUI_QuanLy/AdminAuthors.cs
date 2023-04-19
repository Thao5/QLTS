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
    public partial class AdminAuthors : Form
    {
        public AdminAuthors()
        {
            InitializeComponent();
        }

        private void btnAddAuthors_Click(object sender, EventArgs e)
        {
            AddAuthors addAuthors = new AddAuthors();
            addAuthors.Show();
        }
    }
}
