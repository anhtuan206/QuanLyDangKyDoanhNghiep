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
        public external_account external_Account;
        public doanh_nghiep doanh_Nghiep = new doanh_nghiep();

        public frm_danh_sach_ho_so_dang_ky(frm_giaodien_doanhnghiep parentForm, external_account external_Account)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.external_Account = external_Account;
        }

        private void grid_danh_sach_ho_so_dang_ky_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
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
                int doanh_nghiep_id = Convert.ToInt32(grid_danh_sach_ho_so_dang_ky.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_nghiep_id).FirstOrDefault();
                }
                if (doanh_Nghiep != null)
                {
                    btn_tiep_tuc_nhap_thong_tin.Enabled = true;
                    btn_xoa_ho_so.Enabled = true;
                    if (doanh_Nghiep.is_submitted == true)
                    {
                        btn_tiep_tuc_nhap_thong_tin.Text = "Xem thông tin hồ sơ";
                    }
                    else
                    {
                        btn_tiep_tuc_nhap_thong_tin.Text = "Cập nhật thông tin hồ sơ";
                    }
                }
            }
        }

        private void xoa_nganh_nghe_dang_ky()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe_dangky> nganh_Nghe_Dangkies = db.nganh_nghe_dangky.Where(item => item.id_doanh_nghiep == doanh_Nghiep.id).ToList<nganh_nghe_dangky>();
                foreach (nganh_nghe_dangky item in nganh_Nghe_Dangkies)
                {
                    db.nganh_nghe_dangky.Remove(item);
                }
                db.SaveChanges();
            }
        }

        private void xoa_nhan_su_doanh_nghiep()
        {
            //using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            //{
            //    List<nhan_su_doanh_nghiep> nhan_Su_Doanh_Nghieps = db.nhan_su_doanh_nghiep.Where(item => item.id_doanh_nghiep == doanh_Nghiep.id).ToList<nhan_su_doanh_nghiep>();
            //    foreach (nhan_su_doanh_nghiep item in nhan_Su_Doanh_Nghieps)
            //    {
            //        db.nhan_su_doanh_nghiep.Remove(item);
            //        db.SaveChanges();
            //    }
            //}
        }

        private void xoa_doanh_nghiep()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_Nghiep.id).FirstOrDefault();
                if (doanh_Nghiep!= null)
                {
                    db.doanh_nghiep.Remove(doanh_Nghiep);
                    db.SaveChanges();
                    grid_danh_sach_ho_so_dang_ky_ds();
                    btn_tiep_tuc_nhap_thong_tin.Enabled = false;
                    btn_xoa_ho_so.Enabled = false;
                }
            }
        }

        private void xoa_dia_chi_doanh_nghiep()
        {
            if (doanh_Nghiep.id_dia_chi.HasValue)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    thongtin_diachi thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == doanh_Nghiep.id_dia_chi).FirstOrDefault();
                    db.thongtin_diachi.Remove(thongtin_Diachi);
                    db.SaveChanges();
                }
            }
        }
        private void xoa_thong_tin_thue()
        {
            if (doanh_Nghiep.id_thong_tin_thue.HasValue)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    thong_tin_thue thong_Tin_Thue = db.thong_tin_thue.Where(item => item.id == doanh_Nghiep.id_thong_tin_thue).FirstOrDefault();
                    db.thong_tin_thue.Remove(thong_Tin_Thue);
                    db.SaveChanges();
                }
            }
        }

        private void btn_xoa_ho_so_Click(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted == true || doanh_Nghiep.is_approved == true) {
                MessageBox.Show("Không thể xóa hồ sơ đã nộp hoặc đã được phê duyệt");
                return;
            }
            if (MessageBox.Show("Bạn muốn xóa hồ sơ đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_Nghiep.id).FirstOrDefault();
                    doanh_Nghiep.loai_hinh = null;
                    doanh_Nghiep.id_dia_chi = null;
                    doanh_Nghiep.thongtin_diachi = null;
                    doanh_Nghiep.id_chu_so_huu = null;
                    doanh_Nghiep.nhan_su_doanh_nghiep = null;
                    doanh_Nghiep.id_nguoi_dai_dien_phap_luat = null;
                    doanh_Nghiep.nhan_su_doanh_nghiep1 = null;
                    doanh_Nghiep.nhan_su_doanh_nghiep2 = null;
                    doanh_Nghiep.thong_tin_thue = null;
                    doanh_Nghiep.id_thong_tin_thue = null;
                    doanh_Nghiep.nganh_nghe_dangky = null;
                    db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }

                xoa_nganh_nghe_dang_ky();
                xoa_nhan_su_doanh_nghiep();
                xoa_dia_chi_doanh_nghiep();
                xoa_thong_tin_thue();
                xoa_doanh_nghiep();
            }
        }

        private void btn_tiep_tuc_nhap_thong_tin_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            frm_dang_ky_moi frm_dang_ky_moi = new frm_dang_ky_moi(parentForm, doanh_Nghiep,null);
            frm_dang_ky_moi.Show();
        }
    }
}
