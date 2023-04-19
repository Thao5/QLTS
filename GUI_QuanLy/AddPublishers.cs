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
    public partial class AddPublishers : Form
    {
        public AddPublishers()
        {
            InitializeComponent();
        }

        private void btnCancelPublisher_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavePublisher_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
