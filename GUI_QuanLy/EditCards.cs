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
    public partial class EditCards : Form
    {
        public EditCards()
        {
            InitializeComponent();
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSaveCards_Click(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                db.codes.Find(AdminCards.id_card).valid = Boolean.Parse(cbTrangThaiCard.SelectedItem.ToString());
                db.codes.Find(AdminCards.id_card).ngaynap = DateTime.ParseExact(dateNgayNap.Text, "dd/MM/yyyy", null);
                db.codes.Find(AdminCards.id_card).id_user = cbUserCard.SelectedValue.ToString();
                db.SaveChanges();
            }
            this.Close();
        }

        private void btnCancelCards_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCards_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                txtIDCard.Text = AdminCards.id_card;
                if (db.codes.Find(AdminCards.id_card).valid)
                {
                    cbTrangThaiCard.SelectedIndex = 0;
                }
                else
                {
                    cbTrangThaiCard.SelectedIndex = 1;
                }
                dateNgayNap.Text = db.codes.Find(AdminCards.id_card).ngaynap.ToString();
                var test = from s in db.taikhoans select s;
                cbUserCard.DataSource = test.ToList();
                cbUserCard.ValueMember = "id";
                cbUserCard.DisplayMember = "ten";
                cbUserCard.SelectedValue = db.codes.Find(AdminCards.id_card).id_user;
            }

            
        }
    }
}
