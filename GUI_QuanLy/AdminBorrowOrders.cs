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
    public partial class AdminBorrowOrders : Form
    {
        public AdminBorrowOrders()
        {
            InitializeComponent();
        }

        private void btnAddBorrowOrders_Click(object sender, EventArgs e)
        {
            AddBorrowOrders addBorrowOrders = new AddBorrowOrders();
            addBorrowOrders.Show();
        }
    }
}
