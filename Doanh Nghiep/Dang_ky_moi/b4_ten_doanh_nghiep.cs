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
    public partial class b4_ten_doanh_nghiep : Form
    {
        private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;

        public b4_ten_doanh_nghiep(frm_dang_ky_moi parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = parentForm.doanh_Nghiep;

        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                if (luu_ten_doanh_nghiep()==true)
                {
                    parentForm.OpenChildForm(new b5_chu_so_huu(parentForm));
                }
            }
            else
            {
                parentForm.OpenChildForm(new b5_chu_so_huu(parentForm));
            }

        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (luu_ten_doanh_nghiep() == true)
                {
                    parentForm.OpenChildForm(new b4_ten_doanh_nghiep(parentForm));
                }
            }
            else { 
                    parentForm.OpenChildForm(new b4_ten_doanh_nghiep(parentForm));
            }

        }

        private void btn_huy_dang_ky_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn không muốn tiếp tục?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (doanh_Nghiep.id != 0)
                {
                    using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                    {
                        var entry = db.Entry(doanh_Nghiep);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.doanh_nghiep.Attach(doanh_Nghiep);
                            db.doanh_nghiep.Remove(doanh_Nghiep);
                            db.SaveChanges();
                        }
                    }
                }
                parentForm.Close();
            }
        }

        private void b4_ten_doanh_nghiep_Load(object sender, EventArgs e)
        {
            string tendoanhnghiep = doanh_Nghiep.ten;
            if (doanh_Nghiep.ten != null) { 
                if (tendoanhnghiep.Length == 0)
                {
                    lbl_ten_doanh_nghiep.Visible = false;
                }
                else
                {
                    lbl_ten_doanh_nghiep.Text = tendoanhnghiep;
                    lbl_ten_doanh_nghiep.Visible = true;
                }
            }
        }

        private bool kiem_tra_trung_ten_doanh_nghiep()
        {
            
            bool is_trungten = false;
            //Nếu tên đã có trong db và ô nhập tên doanh nghiệp trống
            if (doanh_Nghiep.ten.Length > 0 && txt_ten_doanh_nghiep.Text.Trim().Length<=0) { 
                return is_trungten;
            }
            if (txt_ten_doanh_nghiep.Text.Trim().Length > 0)
            {
                string tendoanhnghiep = cbb_prefix.Text + " " + txt_ten_doanh_nghiep.Text.ToUpper();
                
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    List<doanh_nghiep> doanh_nghiep_list = db.doanh_nghiep.ToList<doanh_nghiep>();
                    is_trungten = false;
                    foreach (doanh_nghiep item in doanh_nghiep_list)
                    {
                        if (item.ten != null) { 
                            string exist_ten_doanh_nghiep = item.ten.ToUpper();
                            if (tendoanhnghiep == exist_ten_doanh_nghiep)
                            {
                                MessageBox.Show("Đã có doanh nghiệp đăng ký với tên được chọn. Vui lòng chọn tên khác!");
                                is_trungten=true;
                                break;
                            }
                        }
                    }
                    if (is_trungten == false)
                    {
                        lbl_ten_doanh_nghiep.Text = "Tên doanh nghiệp có thể sử dung: " + tendoanhnghiep;
                        lbl_ten_doanh_nghiep.Visible = true;
                        return is_trungten;
                    }
                }
            }
            else
            {
                is_trungten = true;
                MessageBox.Show("Vui lòng nhập tên doanh nghiệp");
                return is_trungten;
            }
            return is_trungten; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiem_tra_trung_ten_doanh_nghiep();
        }

        private bool luu_ten_doanh_nghiep()
        {
            if ((doanh_Nghiep.ten != null || doanh_Nghiep.ten.Length > 0)&&txt_ten_doanh_nghiep.Text.Trim().Length<=0 && kiem_tra_trung_ten_doanh_nghiep()==true) {
                return true;               
            }
            if (kiem_tra_trung_ten_doanh_nghiep()==false)
            {
                string tendoanhnghiep = cbb_prefix.Text + " " + txt_ten_doanh_nghiep.Text.ToUpper();
                doanh_Nghiep.ten = tendoanhnghiep;
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities()) { 
                    db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            if (luu_ten_doanh_nghiep() == true) { 
                MessageBox.Show("Lưu hồ sơ thành công");
                parentForm.Close();
            }
        }
    }
}
