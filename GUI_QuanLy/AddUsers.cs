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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
            List<String> userType = new List<String>() { "Admin", "User", "Author" };
            cbLoaiNguoiDung.DataSource = userType;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
