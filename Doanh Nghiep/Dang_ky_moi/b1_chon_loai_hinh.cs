using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    public partial class b1_chon_loai_hinh : Form
    {
        private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;
        object id_loai_hinh = null;

        public b1_chon_loai_hinh(frm_dang_ky_moi parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = parentForm.doanh_Nghiep;
        }
        void cbb_loai_hinh_doanh_nghiep_ds()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                List<loai_hinh> loai_hinh_list = db.loai_hinh.ToList();
                cbb_chon_loai_hinh.DataSource = loai_hinh_list;
                cbb_chon_loai_hinh.DisplayMember = "ten_loai_hinh";
                cbb_chon_loai_hinh.ValueMember = "id";
            }
        }

        private void b1_chon_loai_hinh_Load(object sender, EventArgs e)
        {
            cbb_loai_hinh_doanh_nghiep_ds();
        }

        private void tao_doanh_nghiep()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                db.doanh_nghiep.Add(doanh_Nghiep);
                db.SaveChanges();
            }
        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                id_loai_hinh = cbb_chon_loai_hinh.SelectedValue;

                if (id_loai_hinh != null && id_loai_hinh.GetType() == typeof(int))
                {
                    doanh_Nghiep.loai_hinh_id = (int)cbb_chon_loai_hinh.SelectedValue;
                    tao_doanh_nghiep();
                    parentForm.OpenChildForm(new b2_dia_chi(parentForm));
                }
                else
                {
                    MessageBox.Show("Có lỗi khi lưu loại hình doanh nghiệp");
                }
            } else
            {
                parentForm.OpenChildForm(new b2_dia_chi(parentForm));
            }
        }

        private void cbb_chon_loai_hinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_loai_hinh = cbb_chon_loai_hinh.SelectedValue;

            if (id_loai_hinh != null && id_loai_hinh.GetType() == typeof(int))
            {
                id_loai_hinh = (int)cbb_chon_loai_hinh.SelectedValue;
            }
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            id_loai_hinh = cbb_chon_loai_hinh.SelectedValue;

            if (id_loai_hinh != null && id_loai_hinh.GetType() == typeof(int))
            {
                doanh_Nghiep.loai_hinh_id = (int)cbb_chon_loai_hinh.SelectedValue;
                tao_doanh_nghiep();
                parentForm.OpenChildForm(new b2_dia_chi(parentForm));
            }
            else
            {
                MessageBox.Show("Có lỗi khi lưu loại hình doanh nghiệp");
            }
        }

        private void btn_huy_dang_ky_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn không muốn tiếp tục?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (doanh_Nghiep.id != 0) { 
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

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {

        }
    }
}
