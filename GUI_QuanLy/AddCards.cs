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
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();
        }

        private void cbLoaiNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSaveCards_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelCards_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
