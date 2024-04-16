using QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.SubForm
{
    public partial class frm_danh_sach_ho_so_dang_ky : Form
    {
        public frm_giaodien_doanhnghiep parentForm;
        private doanh_nghiep doanh_Nghiep = new doanh_nghiep();

        public frm_danh_sach_ho_so_dang_ky(frm_giaodien_doanhnghiep parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void grid_danh_sach_ho_so_dang_ky_ds()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                
                grid_danh_sach_ho_so_dang_ky.AutoGenerateColumns = false;
                grid_danh_sach_ho_so_dang_ky.DataSource = db.doanh_nghiep.ToList<doanh_nghiep>();
                grid_danh_sach_ho_so_dang_ky.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void frm_danh_sach_ho_so_dang_ky_Load(object sender, EventArgs e)
        {
            grid_danh_sach_ho_so_dang_ky_ds();
        }

        private void grid_danh_sach_ho_so_dang_ky_DoubleClick(object sender, EventArgs e)
        {
            if (grid_danh_sach_ho_so_dang_ky.CurrentRow.Index != -1)
            {
                doanh_Nghiep.id = Convert.ToInt32(grid_danh_sach_ho_so_dang_ky.CurrentRow.Cells["id"].Value);
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_Nghiep.id).FirstOrDefault();
                }
                if (doanh_Nghiep != null)
                {
                    btn_tiep_tuc_nhap_thong_tin.Enabled = true;
                    btn_xoa_ho_so.Enabled = true;
                }
            }
        }

        private void btn_xoa_ho_so_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa hồ sơ đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    var entry = db.Entry(doanh_Nghiep);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.doanh_nghiep.Attach(doanh_Nghiep);
                        db.doanh_nghiep.Remove(doanh_Nghiep);
                        db.SaveChanges();
                        grid_danh_sach_ho_so_dang_ky_ds();
                        btn_tiep_tuc_nhap_thong_tin.Enabled = false;
                        btn_xoa_ho_so.Enabled = false;
                    }
                }
            }
        }

        private void btn_tiep_tuc_nhap_thong_tin_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            frm_edit_doanh_nghiep frm_Edit_Doanh_Nghiep = new frm_edit_doanh_nghiep(parentForm,doanh_Nghiep);
            frm_Edit_Doanh_Nghiep.Show();
        }
    }
}
