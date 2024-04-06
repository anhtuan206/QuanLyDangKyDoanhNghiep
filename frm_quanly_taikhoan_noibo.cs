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
    public partial class frm_quanly_taikhoan_noibo : Form
    {
        internal_account internal_Account = new internal_account();
        object nhan_vien_selected = null;
        int nhan_vien_id_selected;

        public frm_quanly_taikhoan_noibo()
        {
            InitializeComponent();
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void frm_quanly_taikhoan_noibo_Load(object sender, EventArgs e)
        {
            clear_Form();
            txt_username.Focus();
            cbb_nhanvien_ds();
            grid_internal_account_ds();
        }

        void clear_Form()
        {
            txt_username.Text = txt_password.Text = txt_password_repeat.Text = string.Empty;
            ckb_islocked.Checked = false;
            btn_cancelchange.Text = "Tạo tài khoản";
            btn_delete.Enabled = false;
            cbb_nhanvien.Items.Clear();
        }
        static bool ContainsSpecialCharacters(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra xem có ký tự đặc biệt nào trong chuỗi không
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.IsMatch(input);
        }

        void cbb_nhanvien_ds()
        {
            using (qldkdn_entity db = new qldkdn_entity())
            {
                cbb_nhanvien.DataSource = db.nhan_vien.ToList();
            }
            cbb_nhanvien.DisplayMember = "ho_ten";
            cbb_nhanvien.ValueMember = "id";

        }

        bool validate_Form()
        {
            bool validation = true;

            if (nhan_vien_selected == null)
            {
                validation = false;
                MessageBox.Show("Vui lòng chọn nhân viên");
                return validation;
            }

            if (ContainsSpecialCharacters(txt_username.Text.Trim()))
            {
                validation = false;
                MessageBox.Show("Tên tài khoản phải bắt đầu bằng chữ cái, chỉ được bao gồm chữ cái và số");
                return validation;
            }
            if (txt_username.Text.Trim().Length <= 0)
            {
                validation = false;
                MessageBox.Show("Tài khoản đăng nhập không được để trống!");
                return validation;
            }
            if (txt_password.Text.Trim().Length <= 0)
            {
                validation = false;
                MessageBox.Show("Mật khẩu không được để trống!");
                return validation;
            }

            if (txt_password.Text.Trim() != txt_password_repeat.Text.Trim())
            {
                validation = false;
                MessageBox.Show("Mật khẩu không trùng khớp");
                return validation;
            }
            return validation;
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            
            if (validate_Form())
            {
                internal_Account.username = txt_username.Text.Trim();
                internal_Account.password = txt_password.Text.Trim();
                internal_Account.is_locked = ckb_islocked.Checked;
                internal_Account.create_time = DateTime.Now;
                internal_Account.id_nhan_vien = (int)nhan_vien_selected;

                using (qldkdn_entity db = new qldkdn_entity()) { 
                    db.internal_account.Add(internal_Account);
                    db.SaveChanges();
                }
                clear_Form();
                MessageBox.Show("Tạo tài khoản thành công!");
                grid_internal_account_ds();
                cbb_nhanvien_ds();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (qldkdn_entity db = new qldkdn_entity())
            {
            }
        }

        void grid_internal_account_ds()
        {
            using (qldkdn_entity db = new qldkdn_entity())
            {
                grid_internal_account.DataSource = db.internal_account.ToList<internal_account>();
            }
        }

        private void grid_taikhoan_noibo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhan_vien_selected = cbb_nhanvien.SelectedValue;

            if (nhan_vien_selected != null && nhan_vien_selected.GetType() == typeof(int))
            {
                nhan_vien_id_selected = (int)cbb_nhanvien.SelectedValue;
            }
        }
    }
}
