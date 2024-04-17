using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep
{
    public partial class frm_quanly_taikhoan_doanhnghiep : Form
    {
        private external_account external_Account = new external_account();
        public internal_account internal_Account = new internal_account();
        public frm_giaodien_quantri parentForm;
        public frm_quanly_taikhoan_doanhnghiep(frm_giaodien_quantri parentForm,internal_account internal_Account)
        {
            InitializeComponent();
            this.internal_Account = internal_Account;
            this.parentForm = parentForm;
        }

        private void frm_quanly_taikhoan_doanhnghiep_Load(object sender, EventArgs e)
        {
            grid_external_account_ds();
        }

        void grid_external_account_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                grid_external_account.AutoGenerateColumns = false;
                grid_external_account.DataSource = db.external_account.ToList<external_account>();
                grid_external_account.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void grid_external_account_DoubleClick(object sender, EventArgs e)
        {
            if (grid_external_account.CurrentRow.Index != -1) { 
                external_Account.id = external_Account.id = Convert.ToInt32(grid_external_account.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities()) { 
                    external_Account = db.external_account.Where(item => item.id == external_Account.id).FirstOrDefault();
                    button1.Enabled = true;
                    button2.Enabled=true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (external_Account.is_locked==null)
            {
                external_Account.is_locked=true;
            }
            if (external_Account.is_locked==true)
            {
                external_Account.is_locked=false;
            }
            else
            {
                external_Account.is_locked = true;
            }
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.Entry(external_Account).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                button1.Enabled = false;
                button2.Enabled = false;
                grid_external_account_ds();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<doanh_nghiep> doanh_Nghieps = db.doanh_nghiep.Where(item => item.external_account_id == external_Account.id).ToList();
                if (doanh_Nghieps.Count == 0)
                {
                    db.external_account.Remove(external_Account);
                    db.SaveChanges();
                    button1.Enabled = false;
                    button2.Enabled = false;
                    grid_external_account_ds();
                }
                else
                {
                    MessageBox.Show("Tài khoản có hồ sơ doanh nghiệp đã được đăng ký, không được phép xóa");
                }

            }
        }

        private void frm_quanly_taikhoan_doanhnghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
