using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc
{
    public partial class frm_quanly_loaihinh : Form
    {
        public loai_hinh loai_Hinh = new loai_hinh();

        public frm_quanly_loaihinh()
        {
            InitializeComponent();
        }
        void grid_loai_hinh_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<loai_hinh> loai_hinh_list = db.loai_hinh.ToList<loai_hinh>();
                grid_loai_hinh.AutoGenerateColumns = false;
                grid_loai_hinh.DataSource = loai_hinh_list;
                grid_loai_hinh.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        void clear_Form()
        {
            //loai_Hinh = null;
            loai_Hinh.id = 0;
            txt_ten_loai_hinh.Text = string.Empty;
            btn_delete.Enabled = false;
            btn_createsave.Text = "Thêm loại hình kinh doanh";
            grid_loai_hinh_ds();
        }

        bool validate_Form()
        {
            bool validate = true;
            if (txt_ten_loai_hinh.Text.Trim().Length<=0) { 
                validate = false;
                MessageBox.Show("Vui lòng nhập tên loại hình kinh doanh");
                return validate;
            }
            return validate;
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            if (validate_Form())
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    loai_Hinh.ten_loai_hinh = txt_ten_loai_hinh.Text.Trim();
                    if (loai_Hinh.id == 0)
                    {
                        db.loai_hinh.Add(loai_Hinh);
                    }
                    else
                    {
                        db.Entry(loai_Hinh).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Lưu loại hình kinh doanh thành công!");
                clear_Form();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa loại hình kinh doanh đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    var entry = db.Entry(loai_Hinh);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.loai_hinh.Attach(loai_Hinh);
                        db.loai_hinh.Remove(loai_Hinh);
                        db.SaveChanges();
                        clear_Form();
                    }
                }
            }
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void grid_loai_hinh_DoubleClick(object sender, EventArgs e)
        {
            if (grid_loai_hinh.CurrentRow.Index != -1)
            {
                loai_Hinh.id = Convert.ToInt32(grid_loai_hinh.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    loai_Hinh = db.loai_hinh.Where(x => x.id == loai_Hinh.id).FirstOrDefault();
                    txt_ten_loai_hinh.Text = loai_Hinh.ten_loai_hinh;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }

        private void frm_quanly_loaihinh_Load(object sender, EventArgs e)
        {
            clear_Form();
        }
    }
}
