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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void changeForm(Form Formch)
        {
            if(this.panelContainer.Controls.Count > 0)
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
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            changeForm(new Products());
        }

        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            changeForm(new Publishers());
        }

        private void btnSachMua_Click(object sender, EventArgs e)
        {
            changeForm(new BuyOrders());
        }

        private void btnSachMuon_Click(object sender, EventArgs e)
        {
            changeForm(new Borrow_Orders());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            changeForm(new Users());
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            changeForm(new Authors());
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            BuyOrders buyOrders = new BuyOrders();
            buyOrders.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Borrow_Orders buyOrders = new Borrow_Orders(); 
            buyOrders.Show();
        }

        
       
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
