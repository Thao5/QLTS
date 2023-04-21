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
    public partial class EditBuyOrders : Form
    {
        public EditBuyOrders()
        {
            InitializeComponent();
        }

        private void btnCancelBuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveBuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
