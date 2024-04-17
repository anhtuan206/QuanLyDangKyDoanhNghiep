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
        //int nhanvien_id_selected = 0;

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
            if (MessageBox.Show("Bạn muốn xóa nhân viên đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    //var entry = db.Entry(nhan_Vien);
                    //if (entry.State == System.Data.Entity.EntityState.Detached)
                    //{
                    //    db.nhan_vien.Attach(nhan_Vien);
                    //}
                        db.nhan_vien.Remove(nhan_Vien);
                        db.SaveChanges();
                        clear_Form();
                }
            }
            clear_Form();
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();
        }
        void clear_Form() {
            txt_hoten.Text = txt_cccd.Text = txt_noicap.Text = string.Empty;
            pck_ngaycap.Text = pck_ngaysinh.Text = string.Empty;
            rdo_nam.Checked = true;
            btn_createsave.Text = "Tạo nhân viên";
            btn_delete.Enabled = false;
            nhan_Vien.id = 0;
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

            if (pck_ngaycap.Value<=pck_ngaysinh.Value)
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
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    if (nhan_Vien.id == 0)
                    {
                        db.nhan_vien.Add(nhan_Vien);

                    }
                    else
                    {
                        db.Entry(nhan_Vien).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Lưu nhân viên thành công!");
                clear_Form();
            }
        }

        void grid_nhanvien_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nhan_vien> nhan_vien_list = db.nhan_vien.ToList<nhan_vien>();
                /*foreach (nhan_vien item in nhan_vien_list)
                {
                    grid_nhanvien.da
                }*/
                grid_nhanvien.AutoGenerateColumns = false;
                grid_nhanvien.DataSource = db.nhan_vien.ToList<nhan_vien>();
                grid_nhanvien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells) ;
            }
        }

        private void frm_quanly_nhanvien_Load(object sender, EventArgs e)
        {
            clear_Form() ;
        }

        private void grid_nhanvien_DoubleClick(object sender, EventArgs e)
        {
            if (grid_nhanvien.CurrentRow.Index != -1)
            {
                nhan_Vien.id = Convert.ToInt32(grid_nhanvien.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    nhan_Vien = db.nhan_vien.Where(x => x.id == nhan_Vien.id).FirstOrDefault();
                    txt_hoten.Text = nhan_Vien.ho_ten;
                    if (nhan_Vien.gioi_tinh)
                    {    rdo_nam.Checked = true;
                        rdo_nu.Checked = false;
                    }
                    else
                    { rdo_nam.Checked = false; rdo_nu.Checked = true;}
                    pck_ngaysinh.Value = nhan_Vien.ngay_sinh;
                    txt_cccd.Text = nhan_Vien.so_cccd;
                    pck_ngaycap.Value = nhan_Vien.ngay_cap;
                    txt_noicap.Text = nhan_Vien.noi_cap;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }
    }
}
