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
    public partial class AdminBuyOrders : Form
    {
        public AdminBuyOrders()
        {
            InitializeComponent();
        }

        private void btnAddBuyOrders_Click(object sender, EventArgs e)
        {
            AddBuyOrders addBuyOrders = new AddBuyOrders();
            addBuyOrders.Show();
        }
    }
}
