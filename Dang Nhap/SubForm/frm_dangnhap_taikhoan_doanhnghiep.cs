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
    public partial class frm_dangnhap_taikhoan_doanhnghiep : Form
    {
        private frm_dangnhap parentForm;
        public external_account external_Account = new external_account();
        public frm_dangnhap_taikhoan_doanhnghiep(frm_dangnhap parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_dang_nhap_Click(object sender, EventArgs e)
        {
            if (txt_email.Text.Trim().Length > 0 && txt_password.Text.Trim().Length > 0) {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    external_Account = db.external_account.Where(item => item.email == txt_email.Text.Trim().ToLower()).FirstOrDefault();
                    if (external_Account != null)
                    {
                        if (external_Account.is_locked!=false)
                        {
                            MessageBox.Show("Tài khoản bị khóa");
                        }
                        else
                        {
                            if (external_Account.email == txt_email.Text.Trim().ToLower() && external_Account.password == txt_password.Text.Trim()) {
                                txt_email.Text = txt_password.Text = string.Empty;
                                frm_giaodien_doanhnghiep giaodien_doanhnghiep = new frm_giaodien_doanhnghiep(external_Account, parentForm);
                                giaodien_doanhnghiep.Show();
                                parentForm.Hide();
                            }
                        }
                    }
                    else { MessageBox.Show("Email hoặc mật khẩu chưa đúng!"); }
                }
            }
            else {
                MessageBox.Show("Email và mật khẩu không được để trống");
            }
        }

        private void frm_dangnhap_taikhoan_doanhnghiep_Load(object sender, EventArgs e)
        {
            txt_email.Focus();
        }
    }
}
