using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Quanly
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                if (cbNhaXB.SelectedIndex == 0 && cbTime.SelectedIndex == 0)
                {
                    var test = from s in db.sachduocthues select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeMuon.DataSource = test.ToList();

                    var test1 = from s in db.sachduocmuas select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeBan.DataSource = test1.ToList();

                    lbTotalSachMuon.Text = db.sachduocthues.Sum(s => s.gia_thue).ToString();
                    lbTotalSachBan.Text = db.sachduocmuas.Sum(s => s.gia_ban).ToString();

                    lbTotal.Text = (db.sachduocthues.Sum(s => s.gia_thue) + db.sachduocmuas.Sum(s => s.gia_ban)).ToString();
                }
                else if(cbNhaXB.SelectedIndex == 0 && cbTime.SelectedIndex == 1)
                {
                    int year = int.Parse(txtTime.Text);
                    var test = from s in db.sachduocthues where s.created_date.Year.Equals(year) select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeMuon.DataSource = test.ToList();

                    var test1 = from s in db.sachduocmuas where s.created_date.Year.Equals(year) select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeBan.DataSource = test1.ToList();

                    if(test.Any() && test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_ban).ToString();

                        lbTotal.Text = (db.sachduocthues.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_thue) + db.sachduocmuas.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_ban)).ToString();
                    }
                    else if(test.Any() && !test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = (db.sachduocthues.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_thue)).ToString();
                    }
                    else if(!test.Any() && test1.Any())
                    {
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_ban).ToString();
                        lbTotalSachMuon.Text = "0";
                        lbTotal.Text = (db.sachduocmuas.Where(s => s.created_date.Year.Equals(year)).Sum(s => s.gia_ban)).ToString();
                    }
                    else
                    {
                        lbTotalSachMuon.Text = "0";
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = "0";
                    }
                }
                else if (cbNhaXB.SelectedIndex == 0 && cbTime.SelectedIndex == 2)
                {
                    var thang = int.Parse(txtTime.Text);
                    var test = from s in db.sachduocthues where s.created_date.Month.Equals(thang) select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeMuon.DataSource = test.ToList();

                    var test1 = from s in db.sachduocmuas where s.created_date.Month.Equals(thang) select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                    dataGridThongKeBan.DataSource = test1.ToList();

                    if (test.Any() && test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban).ToString();

                        lbTotal.Text = (db.sachduocthues.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue) + db.sachduocmuas.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban)).ToString();
                    }
                    else if (test.Any() && !test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = (db.sachduocthues.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue)).ToString();
                    }
                    else if (!test.Any() && test1.Any())
                    {
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban).ToString();
                        lbTotalSachMuon.Text = "0";
                        lbTotal.Text = (db.sachduocmuas.Where(s => s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban)).ToString();
                    }
                    else
                    {
                        lbTotalSachMuon.Text = "0";
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = "0";
                    }
                }
                else if (cbNhaXB.SelectedIndex != 0 && cbTime.SelectedIndex == 0)
                {
                    var test = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Include(s=>s.sach).Select(s => new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeMuon.DataSource = test.ToList();
                    var test1 = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Include(s => s.sach).Select(s => new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeBan.DataSource = test1.ToList();

                    if (test.Any() && test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_ban).ToString();

                        lbTotal.Text = (db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_thue) + db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_ban)).ToString();
                    }
                    else if (test.Any() && !test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_thue).ToString();
                    }
                    else if (!test.Any() && test1.Any())
                    {
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_ban).ToString();
                        lbTotalSachMuon.Text = "0";
                        lbTotal.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString())).Sum(s => s.gia_ban).ToString();
                    }
                    else
                    {
                        lbTotalSachMuon.Text = "0";
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = "0";
                    }

                    
                }
                else if(cbNhaXB.SelectedIndex != 0 && cbTime.SelectedIndex == 2)
                {
                    var thang = int.Parse(txtTime.Text);
                    var test = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Select(s => new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeMuon.DataSource = test.ToList();
                    var test1 = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Select(s => new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeBan.DataSource = test1.ToList();

                    if (test.Any() && test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban).ToString();

                        lbTotal.Text = (db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue) + db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban)).ToString();
                    }
                    else if (test.Any() && !test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = (db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_thue)).ToString();
                    }
                    else if (!test.Any() && test1.Any())
                    {
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban).ToString();
                        lbTotalSachMuon.Text = "0";
                        lbTotal.Text = (db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Month.Equals(thang)).Sum(s => s.gia_ban)).ToString();
                    }
                    else
                    {
                        lbTotalSachMuon.Text = "0";
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = "0";
                    }
                }
                else if (cbNhaXB.SelectedIndex != 0 && cbTime.SelectedIndex == 1)
                {
                    int year = int.Parse(txtTime.Text);
                    var test = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Select(s => new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeMuon.DataSource = test.ToList();
                    var test1 = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Select(s => new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user });
                    dataGridThongKeBan.DataSource = test1.ToList();

                    if (test.Any() && test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_ban).ToString();

                        lbTotal.Text = (db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_thue) + db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_ban)).ToString();
                    }
                    else if (test.Any() && !test1.Any())
                    {
                        lbTotalSachMuon.Text = db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_thue).ToString();
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = (db.sachduocthues.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_thue)).ToString();
                    }
                    else if (!test.Any() && test1.Any())
                    {
                        lbTotalSachBan.Text = db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_ban).ToString();
                        lbTotalSachMuon.Text = "0";
                        lbTotal.Text = (db.sachduocmuas.Where(s => s.sach.id_nxb.Equals(cbNhaXB.SelectedValue.ToString()) && s.created_date.Year.Equals(year)).Sum(s => s.gia_ban)).ToString();
                    }
                    else
                    {
                        lbTotalSachMuon.Text = "0";
                        lbTotalSachBan.Text = "0";
                        lbTotal.Text = "0";
                    }
                }
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            using(quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                cbNhaXB.DataSource = db.NXBs.ToList();
                cbNhaXB.ValueMember = "id";
                cbNhaXB.DisplayMember = "name";

                cbNhaXB.SelectedIndex = 0;


                cbTime.SelectedIndex = 0;

                var test = from s in db.sachduocthues select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                dataGridThongKeMuon.DataSource = test.ToList();

                var test1 = from s in db.sachduocmuas select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                dataGridThongKeBan.DataSource = test1.ToList();

                lbTotalSachMuon.Text = db.sachduocthues.Sum(s=>s.gia_thue).ToString();
                lbTotalSachBan.Text = db.sachduocmuas.Sum(s=>s.gia_ban).ToString();

                lbTotal.Text = (db.sachduocthues.Sum(s => s.gia_thue) + db.sachduocmuas.Sum(s => s.gia_ban)).ToString();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            using (quanlytiemsachEntities3 db = new quanlytiemsachEntities3())
            {
                cbNhaXB.DataSource = db.NXBs.ToList();
                cbNhaXB.ValueMember = "id";
                cbNhaXB.DisplayMember = "name";

                cbNhaXB.SelectedIndex = 0;


                cbTime.SelectedIndex = 0;

                var test = from s in db.sachduocthues select new { id = s.id, ngay_thue = s.ngay_thue, ngay_tra = s.ngay_tra, gia_thue = s.gia_thue, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                dataGridThongKeMuon.DataSource = test.ToList();

                var test1 = from s in db.sachduocmuas select new { id = s.id, gia_ban = s.gia_ban, created_date = s.created_date, id_sach = s.id_sach, id_user = s.id_user };
                dataGridThongKeBan.DataSource = test1.ToList();

                lbTotalSachMuon.Text = db.sachduocthues.Sum(s => s.gia_thue).ToString();
                lbTotalSachBan.Text = db.sachduocmuas.Sum(s => s.gia_ban).ToString();

                lbTotal.Text = (db.sachduocthues.Sum(s => s.gia_thue) + db.sachduocmuas.Sum(s => s.gia_ban)).ToString();
            }
        }
    }
}
