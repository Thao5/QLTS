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
    public partial class AddBorrowOrders : Form
    {
        public AddBorrowOrders()
        {
            InitializeComponent();
        }

        private void btnSaveBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelBorrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
