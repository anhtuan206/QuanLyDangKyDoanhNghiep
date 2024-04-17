using Azure.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep
{
    public partial class frm_dang_ky_tai_khoan_doanh_nghiep : Form
    {
        private frm_dangnhap parentForm;
        private external_account external_Account = new external_account();
        object selected_quoc_tich = null; public int selected_quoc_tich_id = 0;
        object selected_dan_toc = null; public int selected_dan_toc_id = 0;

        public frm_dang_ky_tai_khoan_doanh_nghiep(frm_dangnhap parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private bool is_validate()
        {
            bool is_valid = true;
            if (txt_email.Text.Trim().Length <= 0 || txt_email_repeat.Text.Trim().Length <= 0)
            {
                is_valid = false; MessageBox.Show("Vui lòng nhập email"); return is_valid;
            }
            if (txt_email.Text != txt_email_repeat.Text)
            {
                is_valid = false; MessageBox.Show("Email không trùng nhau"); return is_valid;
            }
            else { external_Account.email = txt_email.Text.ToLower(); }
            if (txt_password.Text.Trim().Length <= 0 || txt_password_repeat.Text.Trim().Length <= 0)
            {
                is_valid = false; MessageBox.Show("Mật khẩu không trùng nhau"); return is_valid;
            }
            else { external_Account.password = txt_password.Text; }
            if (txt_ho_ten.Text.Trim().Length <= 0)
            {
                is_valid = false; MessageBox.Show("Vui lòng nhập họ tên"); return is_valid;
            }
            else { external_Account.ho_ten = txt_ho_ten.Text.Trim(); }
            if (rdo_nam.Checked == rdo_nu.Checked)
            {
                is_valid = false; MessageBox.Show("Vui lòng chọn giới tính"); return is_valid;
            }
            else { external_Account.gioi_tinh = rdo_nam.Checked; }
            if (pck_ngay_sinh.Value > DateTime.Today)
            {
                is_valid = false;
                MessageBox.Show("Ngày sinh không hợp lệ");
                return is_valid;
            }
            else { external_Account.ngay_sinh = pck_ngay_sinh.Value; }

            int age = DateTime.Now.Year - pck_ngay_sinh.Value.Year;
            if (pck_ngay_sinh.Value > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                is_valid = false;
                MessageBox.Show("Chủ doanh nghiệp chưa đủ 18 tuổi");
                return is_valid;
            }
            else { external_Account.ngay_sinh = pck_ngay_sinh.Value; }

            if (selected_quoc_tich_id == 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quốc tịch");
                return is_valid;
            }
            else { external_Account.id_quoc_tich = selected_quoc_tich_id; }
            if (selected_dan_toc_id == 0) { is_valid = false; MessageBox.Show("Vui lòng chọn dân tộc"); return is_valid; } else { external_Account.id_dan_toc = selected_dan_toc_id; }

            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<external_account> external_Accounts = new List<external_account>();
                foreach (external_account item in external_Accounts)
                {
                    if (item.email.ToLower() == txt_email.Text.ToLower())
                    {
                        is_valid = false;
                        MessageBox.Show("Email này đã đăng ký, vui lòng chọn email khác");
                        return is_valid;
                    }
                }
            }
            return is_valid;
        }


        private void btn_dang_ky_Click(object sender, EventArgs e)
        {
            if (is_validate() == true)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    external_Account.create_time = DateTime.Now;
                    external_Account.is_locked = false;
                    db.external_account.Add(external_Account);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký tài khoản thành công! Chọn đăng nhập tài khoản doanh nghiệp và đăng nhập với tài khoản vừa tạo.");
                    parentForm.OpenChildForm(new frm_dangnhap_taikhoan_doanhnghiep(parentForm));
                }
            }
        }

        void change_selected_quoc_tich_id()
        {
            selected_quoc_tich = cbb_quoc_tich.SelectedValue;
            if (selected_quoc_tich != null && selected_quoc_tich.GetType() == typeof(int))
            {
                selected_quoc_tich_id = (int)selected_quoc_tich;
            }
        }

        void change_selected_dan_toc_id()
        {
            selected_dan_toc = cbb_dan_toc.SelectedValue;
            if (selected_dan_toc != null && selected_dan_toc.GetType() == typeof(int))
            {
                selected_dan_toc_id = (int)selected_dan_toc;
            }
        }
        void cbb_dan_toc_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<dan_toc> cbb_list = db.dan_toc.Where(item => item.id_quoc_tich == selected_quoc_tich_id).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_dan_toc.DataSource = cbb_list;
                    cbb_dan_toc.DisplayMember = "ten_dan_toc";
                    cbb_dan_toc.ValueMember = "id";
                    int defaultIndex = 0;
                    cbb_dan_toc.SelectedIndex = defaultIndex;
                    change_selected_dan_toc_id();
                }
            }
        }

        private void cbb_quoc_tich_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_quoc_tich_id();
            cbb_dan_toc_ds();
        }

        private void cbb_dan_toc_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_dan_toc_id();
        }

        private void frm_dang_ky_tai_khoan_doanh_nghiep_Load(object sender, EventArgs e)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quoc_tich> cbb_list = db.quoc_tich.ToList<quoc_tich>();
                cbb_quoc_tich.DataSource = cbb_list;
                cbb_quoc_tich.DisplayMember = "ten_quoc_tich";
                cbb_quoc_tich.ValueMember = "id";
                int defaultIndex = 0;
                defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                cbb_quoc_tich.SelectedIndex = defaultIndex;
                change_selected_quoc_tich_id();
            }
            txt_email.Focus();
        }
    }
}
