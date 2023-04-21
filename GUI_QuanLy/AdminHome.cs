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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }
        private void changeForm(Form Formch)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form th = Formch as Form;
            th.TopLevel = false;
            th.Dock = DockStyle.Fill;
            th.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.Controls.Add(th);
            this.panelContainer.Tag = th;
            th.Show();
            lbTitle.Text = Formch.Text;
        }
        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(20, 20, 20, 20);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = new Panel();
            panel.Margin = new Padding(20, 20, 20, 20);
            panel.Dock = DockStyle.Fill;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminSanPham_Click(object sender, EventArgs e)
        {
            changeForm(new AdminProduct());
        }

        private void btnAdminSachMua_Click(object sender, EventArgs e)
        {
            changeForm(new AdminBuyOrders());
        }

        private void btnAdminSachMuon_Click(object sender, EventArgs e)
        {
            changeForm(new AdminBorrowOrders());
        }

        private void btnAdminTacGia_Click(object sender, EventArgs e)
        {
            changeForm(new AdminAuthors());
        }

        private void btnAdminNhaXuatBan_Click(object sender, EventArgs e)
        {
            changeForm(new AdminPublishers());
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            changeForm(new AdminUsers());
        }

        private void btnAdminCards_Click(object sender, EventArgs e)
        {
            changeForm(new AdminCards());
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
