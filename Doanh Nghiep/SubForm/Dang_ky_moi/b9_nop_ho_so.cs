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
    public partial class b9_nop_ho_so : Form
    {
        //private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;
        public b9_nop_ho_so(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            //this.parentForm = parentForm;
            this.doanh_Nghiep = doanh_Nghiep;

        }

        private bool validate_ho_so()
        {
            bool is_valid = true;
            if (doanh_Nghiep.loai_hinh_id==0 || doanh_Nghiep.loai_hinh_id==null)
            {
                is_valid = false;
                MessageBox.Show("Hồ sơ không đáp ứng yêu cầu. Vui lòng chọn loại hình doanh nghiệp");
                return is_valid;
            }
            if (doanh_Nghiep.id_chu_so_huu == 0 || doanh_Nghiep.id_chu_so_huu == null)
            {
                is_valid = false;
                MessageBox.Show("Hồ sơ không đáp ứng yêu cầu. Vui lòng nhập thông tin chủ sở hữu");
                return is_valid;
            }
            if (doanh_Nghiep.id_dia_chi == 0 || doanh_Nghiep.id_dia_chi == null)
            {
                is_valid = false;
                MessageBox.Show("Hồ sơ không đáp ứng yêu cầu. Vui lòng nhập thông tin địa chỉ doanh nghiệp");
                return is_valid;
            }
            if (doanh_Nghiep.ten == "" || doanh_Nghiep.ten == null)
            {
                is_valid = false;
                MessageBox.Show("Hồ sơ không đáp ứng yêu cầu. Vui lòng nhập nhập tên doanh nghiệp");
                return is_valid;
            }
            if (doanh_Nghiep.von_dieu_le == 0 || doanh_Nghiep.von_dieu_le == null)
            {
                is_valid = false;
                MessageBox.Show("Hồ sơ không đáp ứng yêu cầu. Vui lòng nhập thông tin vốn điều lệ");
                return is_valid;
            }
            return is_valid;
        }

        private void btn_nop_ho_so_Click(object sender, EventArgs e)
        {
            if (validate_ho_so()==true)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    doanh_Nghiep.is_submitted = true;
                    db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Nộp hồ sơ thành công!");
                    btn_nop_ho_so.Enabled= false;
                }
            }
        }

        private void b9_nop_ho_so_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted == true)
            {
                btn_nop_ho_so.Enabled = false;
            }
        }
    }
}
