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
        }

        void clear_Form()
        {
            txt_username.Text = txt_password.Text = txt_password_repeat.Text = string.Empty;
            ckb_islocked.Checked = false;
            btn_createsave.Text = "Tạo tài khoản";
            btn_delete.Enabled = false;
            internal_Account.id = 0;
            nhan_vien_id_selected = 0;
            nhan_vien_selected = null;
            grid_internal_account_ds();
            cbb_nhanvien_ds();
        }
        static bool ContainsSpecialCharacters(string input)
        {
            // Sử dụng biểu thức chính quy để kiểm tra xem có ký tự đặc biệt nào trong chuỗi không
            Regex regex = new Regex("[^a-zA-Z0-9]");
            return regex.IsMatch(input);
        }

        void cbb_nhanvien_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
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

            if (nhan_vien_id_selected == 0)
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
            nhan_vien_selected = cbb_nhanvien.SelectedValue;
            if (nhan_vien_selected != null && nhan_vien_selected.GetType() == typeof(int))
            {
                nhan_vien_id_selected = (int)cbb_nhanvien.SelectedValue;
            }

            if (validate_Form())
            {
                internal_Account.username = txt_username.Text.Trim();
                internal_Account.password = txt_password.Text.Trim();
                internal_Account.is_locked = ckb_islocked.Checked;
                internal_Account.create_time = DateTime.Now;
                internal_Account.id_nhan_vien = nhan_vien_id_selected;

                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities()) {
                    if (internal_Account.id == 0)
                        db.internal_account.Add(internal_Account);
                    else
                        db.Entry(internal_Account).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                }
                MessageBox.Show("Lưu tài khoản thành công!");
                clear_Form();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tài khoản đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    var entry = db.Entry(internal_Account);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.internal_account.Attach(internal_Account);
                        db.internal_account.Remove(internal_Account);
                        db.SaveChanges();
                        clear_Form();
                    }
                }
            }
        }

        void grid_internal_account_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                var query = from acc in db.internal_account
                            join nv in db.nhan_vien on acc.id_nhan_vien equals nv.id
                            select new
                            {
                                acc.id,
                                acc.username,
                                acc.create_time,
                                acc.is_locked,
                                acc.id_nhan_vien,
                                nv.ho_ten,
                                nv.ngay_sinh,
                                nv.so_cccd
                            };
                grid_internal_account.AutoGenerateColumns = false;
                //grid_internal_account.DataSource = db.internal_account.ToList<internal_account>();
                grid_internal_account.DataSource = query.ToList();
                grid_internal_account.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void grid_internal_account_DoubleClick(object sender, EventArgs e)
        {
            if (grid_internal_account.CurrentRow.Index != -1)
            {
                internal_Account.id = Convert.ToInt32(grid_internal_account.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    internal_Account = db.internal_account.Where(x => x.id == internal_Account.id).FirstOrDefault();
                    cbb_nhanvien.SelectedValue = internal_Account.id_nhan_vien;
                    txt_username.Text = internal_Account.username;
                    txt_password.Text = internal_Account.password;
                    txt_password_repeat.Text = internal_Account.password;
                    ckb_islocked.Checked = internal_Account.is_locked;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }
    }
}
