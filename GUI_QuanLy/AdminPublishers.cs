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
    public partial class AdminPublishers : Form
    {
        public AdminPublishers()
        {
            InitializeComponent();
        }

        private void btnAddPublishers_Click(object sender, EventArgs e)
        {
            AddPublishers addPublishers = new AddPublishers();
            addPublishers.Show();
        }
    }
}
