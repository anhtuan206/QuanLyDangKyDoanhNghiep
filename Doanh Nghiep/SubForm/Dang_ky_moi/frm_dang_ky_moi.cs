using QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    public partial class frm_dang_ky_moi : Form
    {
        public doanh_nghiep doanh_Nghiep;
        public frm_giaodien_doanhnghiep parentForm_doanhnghiep;
        public frm_quan_ly_dang_ky_doanh_nghiep parentForm_qly_dky_doanhnghiep;
        public Form currentFormChild;
        int current_step = 0;
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panMainFormBody.Controls.Add(childForm);
            panMainFormBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public frm_dang_ky_moi(frm_giaodien_doanhnghiep parentForm, doanh_nghiep doanh_Nghiep, frm_quan_ly_dang_ky_doanh_nghiep parentForm_qly_dky_doanhnghiep)
        {
            InitializeComponent();
            if (parentForm != null)
            {
                this.parentForm_doanhnghiep = parentForm;
            }
            this.doanh_Nghiep = doanh_Nghiep;
            if (parentForm_qly_dky_doanhnghiep != null)
            { 
                this.parentForm_qly_dky_doanhnghiep = parentForm_qly_dky_doanhnghiep;
            }
        }

        private void reset_button_color()
        {
            btn_buoc1.BackColor = default;
            btn_buoc2.BackColor = default;
            btn_buoc3.BackColor = default;
            btn_buoc4.BackColor = default;
            btn_buoc5.BackColor = default;
            btn_buoc6.BackColor = default;
            btn_buoc7.BackColor = default;
            btn_buoc8.BackColor = default;
            //btn_buoc9.BackColor = default;
        }

        private void btn_buoc1_Click(object sender, EventArgs e)
        {
            reset_button_color();
            btn_buoc1.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = false;
            btn_buoc_tiep_theo.Visible = true;
            OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
        }

        private void frm_dang_ky_moi_Load(object sender, EventArgs e)
        {
            btn_buoc1.BackColor = SystemColors.Highlight;
            OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
            current_step = 1;
            btn_quay_lai.Visible = false;
            btn_buoc_tiep_theo.Visible = true;
            if (doanh_Nghiep.is_submitted == true) { 
                btn_huy_dang_ky.Visible = false;
                btn_huy_dang_ky.Enabled = false;
            }
        }

        private void frm_dang_ky_moi_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_dang_ky_moi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentForm_doanhnghiep!=null)
                { parentForm_doanhnghiep.Show(); }
            if (parentForm_qly_dky_doanhnghiep != null)
                { parentForm_qly_dky_doanhnghiep.Show(); }
        }

        private void btn_buoc2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b2_dia_chi(doanh_Nghiep));
            current_step = 2;
            reset_button_color();
            btn_buoc2.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;
        }

        private void btn_buoc3_Click(object sender, EventArgs e)
        {
            current_step = 3;
            OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
            reset_button_color();
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;
            btn_buoc3.BackColor = SystemColors.Highlight;

        }

        private void btn_buoc4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
            current_step = 4;
            reset_button_color();
            btn_buoc4.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;

        }

        private void btn_buoc5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
            current_step = 5;
            reset_button_color();
            btn_buoc5.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;

        }

        private void btn_buoc6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
            current_step = 6;
            reset_button_color();
            btn_buoc6.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;

        }

        private void btn_buoc7_Click(object sender, EventArgs e)
        {
            current_step = 7;
            OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
            reset_button_color();
            btn_buoc7.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = true;

        }

        private void btn_buoc8_Click(object sender, EventArgs e)
        {
            current_step = 8;
            OpenChildForm(new b9_nop_ho_so(doanh_Nghiep));
            reset_button_color();
            btn_buoc8.BackColor = SystemColors.Highlight;
            btn_quay_lai.Visible = true;
            btn_buoc_tiep_theo.Visible = false;


        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            if (current_step == 1)
            {
                current_step++;
                OpenChildForm(new b2_dia_chi(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc2.BackColor = SystemColors.Highlight;

                return;
            }
            if (current_step == 2)
            {
                current_step++;
                OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc3.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 3)
            {
                current_step++;
                OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc4.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 4)
            {
                current_step++;
                OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc5.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 5)
            {
                current_step++;
                OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc6.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 6)
            {
                current_step++;
                OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc7.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 7)
            {
                current_step++;
                OpenChildForm(new b9_nop_ho_so(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = false;
                reset_button_color();
                btn_buoc8.BackColor = SystemColors.Highlight;

                return;
            }
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            if (current_step == 2)
            {
                current_step--;
                OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
                btn_quay_lai.Visible = false;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc1.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 3)
            {
                current_step--;
                OpenChildForm(new b2_dia_chi(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc2.BackColor = SystemColors.Highlight;
                return;
            }

            if (current_step == 4)
            {
                current_step--;
                OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc3.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 5)
            {
                current_step--;
                OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc4.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 6)
            {
                current_step--;
                OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc5.BackColor = SystemColors.Highlight;
                return;
            }

            if (current_step == 7)
            {
                current_step--;
                OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc6.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 8)
            {
                current_step--;
                OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                reset_button_color();
                btn_buoc7.BackColor = SystemColors.Highlight;
                return;
            }
            if (current_step == 9)
            {
                //current_step--;
                //OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
                //btn_quay_lai.Visible = true;
                //btn_buoc_tiep_theo.Visible = true;
                //return;
            }
            if (current_step == 10)
            {
                //current_step--;
                //OpenChildForm(new b9_bao_hiem_xa_hoi(doanh_Nghiep));
                //btn_quay_lai.Visible = true;
                //btn_buoc_tiep_theo.Visible = false;
                //return;
            }
        }

        private void btn_huy_dang_ky_Click(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted == true || doanh_Nghiep.is_approved == true)
            {
                MessageBox.Show("Hồ sơ đã nộp không được phép hủy");
                return;
            }
            xoa_nganh_nghe_dang_ky();
            xoa_nhan_su_doanh_nghiep();
            xoa_dia_chi_doanh_nghiep();
            xoa_thong_tin_thue();
            xoa_doanh_nghiep();
            this.Close();
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
        private void xoa_nganh_nghe_dang_ky()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe_dangky> nganh_Nghe_Dangkies = db.nganh_nghe_dangky.Where(item => item.id_doanh_nghiep == doanh_Nghiep.id).ToList<nganh_nghe_dangky>();
                foreach (nganh_nghe_dangky item in nganh_Nghe_Dangkies)
                {
                    db.nganh_nghe_dangky.Remove(item);
                    db.SaveChanges();
                }
            }
        }

        private void xoa_nhan_su_doanh_nghiep()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nhan_su_doanh_nghiep> nhan_Su_Doanh_Nghieps = db.nhan_su_doanh_nghiep.Where(item => item.id_doanh_nghiep == doanh_Nghiep.id).ToList<nhan_su_doanh_nghiep>();
                foreach (nhan_su_doanh_nghiep item in nhan_Su_Doanh_Nghieps)
                {
                    
                        db.nhan_su_doanh_nghiep.Remove(item);
                        db.SaveChanges();
                }
            }
        }

        private void xoa_doanh_nghiep()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.doanh_nghiep.Remove(doanh_Nghiep);
                db.SaveChanges();
            }
        }
    }
}
