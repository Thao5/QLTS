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
            themCard(txtIDCard.Text, Boolean.Parse(cbTrangThaiCard.SelectedItem.ToString()), cbUserCard.SelectedValue.ToString(), DateTime.ParseExact(dateNgayNap.Text, "dd/MM/yyyy", null));
            this.Close();
        }

        private void btnCancelCards_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCards_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                var test = from s in db.taikhoans select s;
                cbUserCard.DataSource = test.ToList();
                cbUserCard.ValueMember = "id";
                cbUserCard.DisplayMember = "name";
            }
            
        }

        void themCard(String id, Boolean valid, String id_user, DateTime ngaynap)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                try
                {

                    db.codes.Add(new code() { id = id, valid = valid, id_user = id_user, ngaynap = ngaynap });
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
    }
}
