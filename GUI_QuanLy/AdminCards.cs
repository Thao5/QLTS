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
    public partial class AdminCards : Form
    {
        public AdminCards()
        {
            InitializeComponent();
        }

        private void btnAddCards_Click(object sender, EventArgs e)
        {
            AddCards addCards = new AddCards();
            addCards.Show();
        }
    }
}
