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

namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.SubForm
{
    public partial class frm_quan_ly_dang_ky_doanh_nghiep : Form
    {
        public doanh_nghiep doanh_Nghiep = new doanh_nghiep();
        public internal_account internal_Account;
        public frm_giaodien_quantri parentForm;

        public frm_quan_ly_dang_ky_doanh_nghiep(frm_giaodien_quantri parentForm,internal_account internal_Account)
        {
            InitializeComponent();
            this.internal_Account = internal_Account;
            this.parentForm = parentForm;
        }

        private void frm_quan_ly_dang_ky_doanh_nghiep_Load(object sender, EventArgs e)
        {
            btn_xem_ho_so.Enabled = false;
            btn_duyet_ho_so.Enabled = false;
            btn_xoa_ho_so.Enabled = false;
            btn_khong_duyet_ho_so.Enabled = false;
            grid_danh_sach_ho_so_dang_ky_ds();
        }
        private void grid_danh_sach_ho_so_dang_ky_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {

                grid_danh_sach_ho_so_dang_ky.AutoGenerateColumns = false;
                grid_danh_sach_ho_so_dang_ky.DataSource = db.doanh_nghiep.Where(item => item.is_submitted==true && item.is_approved==null).ToList<doanh_nghiep>();
                grid_danh_sach_ho_so_dang_ky.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void btn_xoa_ho_so_Click(object sender, EventArgs e)
        {
            xoa_nganh_nghe_dang_ky();
            xoa_nhan_su_doanh_nghiep();
            xoa_dia_chi_doanh_nghiep();
            xoa_thong_tin_thue();
            xoa_doanh_nghiep();
            btn_xem_ho_so.Enabled = false;
            btn_duyet_ho_so.Enabled = false;
            btn_xoa_ho_so.Enabled = false;
            btn_khong_duyet_ho_so.Enabled = false;
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
            //    }
            //    db.SaveChanges();
            //}
        }

        private void xoa_doanh_nghiep()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_Nghiep.id).FirstOrDefault();
                db.doanh_nghiep.Remove(doanh_Nghiep);
                db.SaveChanges();
                grid_danh_sach_ho_so_dang_ky_ds();
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

        private void btn_xem_ho_so_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_dang_ky_moi frm_Dang_Ky_Moi = new frm_dang_ky_moi(null, doanh_Nghiep, this);
            frm_Dang_Ky_Moi.Show();
        }

        private void grid_danh_sach_ho_so_dang_ky_DoubleClick(object sender, EventArgs e)
        {
            if (grid_danh_sach_ho_so_dang_ky.CurrentRow.Index != -1) { 
                doanh_Nghiep.id = Convert.ToInt32(grid_danh_sach_ho_so_dang_ky.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities()) { 
                    doanh_Nghiep = db.doanh_nghiep.Where(item => item.id == doanh_Nghiep.id).FirstOrDefault();
                }
                btn_xem_ho_so.Enabled = true;
                btn_duyet_ho_so.Enabled = true;
                btn_xoa_ho_so.Enabled = true;
                btn_khong_duyet_ho_so.Enabled = true;
            }
        }

        private void btn_duyet_ho_so_Click(object sender, EventArgs e)
        {
            doanh_Nghiep.is_approved = true;
            doanh_Nghiep.approved_time = DateTime.Now;
            doanh_Nghiep.approved_by = internal_Account.id;
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void btn_khong_duyet_ho_so_Click(object sender, EventArgs e)
        {
            doanh_Nghiep.is_approved = false;
            doanh_Nghiep.approved_time = DateTime.Now;
            doanh_Nghiep.approved_by = internal_Account.id;
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void frm_quan_ly_dang_ky_doanh_nghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
