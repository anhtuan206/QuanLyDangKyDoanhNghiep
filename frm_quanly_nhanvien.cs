using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep
{
    public partial class frm_quanly_nhanvien : Form
    {
        public nhan_vien nhan_Vien = new nhan_vien();
        int nhanvien_id_selected = 0;

        public frm_quanly_nhanvien()
        {
            InitializeComponent();
        }

        private void rdo_nam_CheckedChanged(object sender, EventArgs e)
        {
            rdo_nu.Checked = !(rdo_nam.Checked);
        }

        private void rdo_nu_CheckedChanged(object sender, EventArgs e)
        {
            rdo_nam.Checked = !(rdo_nu.Checked);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();
        }
        void clear_Form() {
            txt_hoten.Text = txt_cccd.Text = txt_noicap.Text = string.Empty;
            pck_ngaycap.Text = pck_ngaysinh.Text = string.Empty;
            rdo_nam.Checked = rdo_nu.Checked = false;
            btn_createsave.Text = "Tạo nhân viên";
            btn_delete.Enabled = false;
            nhanvien_id_selected = 0;
            grid_nhanvien_ds();
        }

        bool validate_Form()
        {
            bool validate = true;
            if (txt_hoten.Text.Trim().Length <= 0) {
                validate = false;
                MessageBox.Show("Tên nhân viên không được để trống!");
                return validate;
            }
            if (rdo_nam.Checked == rdo_nu.Checked)
            {
                validate = false;
                MessageBox.Show("Vui lòng chọn giới tính");
                return validate;
            }

            if (pck_ngaysinh.Value > DateTime.Today) {
                validate = false;
                MessageBox.Show("Ngày sinh của nhân viên không hợp lệ");
                return validate;
            }

            int age = DateTime.Now.Year - pck_ngaysinh.Value.Year;
            if (pck_ngaysinh.Value > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                validate = false;
                MessageBox.Show("Nhân viên không đủ 18 tuổi");
                return validate;
            }

            if (txt_cccd.Text.Trim().Length <= 0)
            {
                validate = false;
                MessageBox.Show("Số CCCD không được để trống!");
                return validate;
            }

            if (!ContainsOnlyDigits(txt_cccd.Text.Trim()))
            {
                validate = false;
                MessageBox.Show("Số CCCD không hợp lệ");
                return validate;
            }

            if (pck_ngaycap.Value > DateTime.Today)
            {
                validate = false;
                MessageBox.Show("Ngày cấp CCCD không hợp lệ");
                return validate;
            }

            if (txt_noicap.Text.Trim().Length <= 0)
            {
                validate = false;
                MessageBox.Show("Nơi cấp không được để trống!");
                return validate;
            }

            return validate;
        }

        static bool ContainsOnlyDigits(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra xem chuỗi chỉ chứa ký tự số hay không
            Regex regex = new Regex("^[0-9]*$");
            return regex.IsMatch(input);
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            if (validate_Form())
            {
                nhan_Vien.ho_ten = txt_hoten.Text.Trim();
                nhan_Vien.gioi_tinh = rdo_nam.Checked;
                nhan_Vien.ngay_sinh = pck_ngaysinh.Value;
                nhan_Vien.so_cccd = txt_cccd.Text.Trim();
                nhan_Vien.ngay_cap = pck_ngaycap.Value;
                nhan_Vien.noi_cap = txt_noicap.Text.Trim();
                using (qldkdn_entity db = new qldkdn_entity())
                {
                    db.nhan_vien.Add(nhan_Vien);
                    db.SaveChanges();
                    MessageBox.Show("Tạo nhân viên thành công!");
                    clear_Form();
                }
            }
        }

        void grid_nhanvien_ds()
        {
            using (qldkdn_entity db = new qldkdn_entity())
            {
                grid_nhanvien.DataSource = db.nhan_vien.ToList<nhan_vien>();
            }
        }

        private void frm_quanly_nhanvien_Load(object sender, EventArgs e)
        {
            clear_Form() ;
        }
    }
}
