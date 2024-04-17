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
        private doanh_nghiep doanh_Nghiep;

        object selected_loai_hinh = null;
        int selected_loai_hinh_id = 0;

        public b1_chon_loai_hinh(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.doanh_Nghiep = doanh_Nghiep;
        }
        void cbb_loai_hinh_doanh_nghiep_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<loai_hinh> loai_hinh_list = db.loai_hinh.ToList();
                if (loai_hinh_list.Count>0)
                {
                    cbb_chon_loai_hinh.DataSource = loai_hinh_list;
                    cbb_chon_loai_hinh.DisplayMember = "ten_loai_hinh";
                    cbb_chon_loai_hinh.ValueMember = "id";
                    int defaultIndex = 0;
                    if (doanh_Nghiep.loai_hinh_id != null || doanh_Nghiep.loai_hinh_id != 0)
                    {
                        defaultIndex = loai_hinh_list.FindIndex(item => item.id == doanh_Nghiep.loai_hinh_id);
                    }
                    cbb_chon_loai_hinh.SelectedIndex = defaultIndex;
                    change_selected_loaihinh_id();
                }
            }
        }

        private void b1_chon_loai_hinh_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted==true) { btn_luu_tam.Enabled = false; btn_luu_tam.Visible = false; }
            cbb_loai_hinh_doanh_nghiep_ds();
        }
        private void cbb_chon_loai_hinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_loaihinh_id();
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            if (cbb_chon_loai_hinh.SelectedIndex != -1) {
                change_selected_loaihinh_id();
                if (selected_loai_hinh_id != 0 )
                {
                    doanh_Nghiep.loai_hinh_id = selected_loai_hinh_id;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Lưu dữ liệu thành công!");
                    }
                }

            } else
            {
                MessageBox.Show("Vui lòng chọn loại hình doanh nghiệp");
            }
        }

        private void change_selected_loaihinh_id ()
        {
            selected_loai_hinh = cbb_chon_loai_hinh.SelectedValue;

            if (selected_loai_hinh != null && selected_loai_hinh.GetType() == typeof(int))
            {
                selected_loai_hinh_id = (int)cbb_chon_loai_hinh.SelectedValue;
            }
        }

    }
}
