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
    }
}
