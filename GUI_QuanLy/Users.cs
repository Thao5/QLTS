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
    public partial class Users : Form
    {
        quanlytiemsachEntities3 db = new quanlytiemsachEntities3();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
         
        }
    }
}
