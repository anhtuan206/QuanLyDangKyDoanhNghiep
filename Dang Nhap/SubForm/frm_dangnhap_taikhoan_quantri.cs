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
    public partial class frm_dangnhap_taikhoan_quantri : Form
    {
        public frm_dangnhap parentForm;
        public internal_account internal_Account;

        public frm_dangnhap_taikhoan_quantri(frm_dangnhap parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim().Length > 0 && txt_password.Text.Trim().Length > 0)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    internal_Account = db.internal_account.Where(item => item.username == txt_username.Text.Trim().ToLower()).FirstOrDefault();
                    if (internal_Account != null)
                    {
                        if (internal_Account.username == txt_username.Text.Trim().ToLower() && internal_Account.password == txt_password.Text.Trim())
                        {
                            frm_giaodien_quantri giaodien_quantri = new frm_giaodien_quantri(internal_Account, parentForm);
                            giaodien_quantri.Show();
                            parentForm.Hide();
                        }
                    }
                    else { MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng!"); }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống");
            }
        }

        private void frm_dangnhap_taikhoan_quantri_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }
    }
}
