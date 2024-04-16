using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    public partial class b2_dia_chi : Form
    {
        private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;
        public thongtin_diachi thongtin_Diachi = new thongtin_diachi {
            id = 0
        };
        

        object selected_quoc_gia = null; public int selected_quoc_gia_id = 0;
        object selected_thanh_pho = null; public int selected_thanh_pho_id = 0;
        object selected_quan_huyen = null; public int selected_quan_huyen_id = 0;
        object selected_phuong_xa = null; public int selected_phuong_xa_id = 0;

        public b2_dia_chi(frm_dang_ky_moi parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = parentForm.doanh_Nghiep;

        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                them_dia_chi();
                parentForm.OpenChildForm(new b3_nganh_nghe(parentForm));
            }   
            else
            {
                parentForm.OpenChildForm(new b3_nganh_nghe(parentForm));
            }
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu dữ liệu?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                them_dia_chi();
                parentForm.OpenChildForm(new b1_chon_loai_hinh(parentForm));
            }
            else { 
                parentForm.OpenChildForm(new b1_chon_loai_hinh(parentForm));
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

        void cbb_quoc_gia_update()
        {

            if (cbb_quoc_gia.SelectedIndex >= 0)
            {
                selected_quoc_gia = cbb_quoc_gia.SelectedValue;

                if (selected_quoc_gia != null && selected_quoc_gia.GetType() == typeof(int))
                {
                    selected_quoc_gia_id = (int)cbb_quoc_gia.SelectedValue;
                    //MessageBox.Show("ID quoc gia da chon: " + selected_quoc_gia_id.ToString());
                    cbb_thanh_pho_ds(selected_quoc_gia_id);
                }
                Console.WriteLine("selected_quoc_gia = null");

            }
            Console.WriteLine("cbb_quoc_gia.SelectedIndex < 0");

        }

        void cbb_quoc_gia_ds()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                List<quoc_tich> cbb_list = db.quoc_tich.ToList();
                if (cbb_list.Count> 0)
                {
                    cbb_quoc_gia.DataSource = cbb_list;
                    cbb_quoc_gia.DisplayMember = "ten_quoc_tich";
                    cbb_quoc_gia.ValueMember = "id";
                    int defaultIndex = 0;
                    if (thongtin_Diachi.id!=0 && doanh_Nghiep.id_dia_chi!=null)
                    {
                        defaultIndex = cbb_list.FindIndex(item => item.id == thongtin_Diachi.id_quoc_gia);
                        cbb_quoc_gia.SelectedIndex = defaultIndex;
                        Console.WriteLine("Hiển thị quốc gia theo giá trị của địa chỉ");

                    }
                    else
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                        if (defaultIndex != -1)
                        {
                            cbb_quoc_gia.SelectedIndex = defaultIndex;
                            Console.WriteLine("Hiển thị Việt Nam là quốc gia mặc định");
                        }
                        else
                        {
                            cbb_quoc_gia.SelectedIndex = defaultIndex;
                            Console.WriteLine("Hiển thị quốc gia đầu tiên trong danh sách");

                        }
                    }
                    cbb_quoc_gia_update();
                }
                else
                {
                    MessageBox.Show("Danh sách quốc gia trống");
                }
                    
            }
        }
        void cbb_thanh_pho_update()
        {
            if (cbb_thanh_pho.SelectedIndex >= 0)
            {
                selected_thanh_pho = cbb_thanh_pho.SelectedValue;

                if (selected_thanh_pho != null && selected_thanh_pho.GetType() == typeof(int))
                {
                    selected_thanh_pho_id = (int)cbb_thanh_pho.SelectedValue;
                    cbb_quan_huyen_ds(selected_thanh_pho_id);
                }

            }
        }

        void cbb_thanh_pho_ds(int id_quoc_gia)
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                List<thanh_pho> cbb_list = db.thanh_pho.Where(item => item.id_quoc_gia == id_quoc_gia).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_thanh_pho.DataSource = cbb_list;
                    cbb_thanh_pho.DisplayMember = "ten_thanh_pho";
                    cbb_thanh_pho.ValueMember = "id";
                    if (doanh_Nghiep.id_dia_chi != null && thongtin_Diachi.id != 0) {
                        int defaultIndex = cbb_list.FindIndex(item => item.id == thongtin_Diachi.id_thanh_pho);
                        cbb_thanh_pho.SelectedIndex = defaultIndex;
                    }
                    else
                    {
                        cbb_thanh_pho.SelectedIndex = 0;
                    }
                    cbb_thanh_pho_update();
                }
            }
        }

        void cbb_quan_huyen_update()
        {
            selected_quan_huyen = cbb_quan_huyen.SelectedValue;

            if (selected_quan_huyen != null && selected_quan_huyen.GetType() == typeof(int))
            {
                selected_quan_huyen_id = (int)cbb_quan_huyen.SelectedValue;
                cbb_phuong_xa_ds(selected_quan_huyen_id);
            }
        }

        void cbb_quan_huyen_ds(int id_thanh_pho)
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                List<quan_huyen> cbb_list = db.quan_huyen.Where(item => item.id_thanh_pho == id_thanh_pho).ToList();
                if (cbb_list.Count>0)
                {
                    cbb_quan_huyen.DataSource = cbb_list;
                    cbb_quan_huyen.DisplayMember = "ten_quan_huyen";
                    cbb_quan_huyen.ValueMember = "id";
                    if (doanh_Nghiep.id_dia_chi != null && thongtin_Diachi.id != 0)
                    {
                        int defaultIndex = cbb_list.FindIndex(item => item.id == thongtin_Diachi.id_quan_huyen);
                        cbb_quan_huyen.SelectedIndex = defaultIndex;
                    }
                    else
                    {
                        cbb_quan_huyen.SelectedIndex = 0;
                    }
                    cbb_quan_huyen_update();
                }
            }
        }

        void cbb_phuong_xa_update()
        {
            selected_phuong_xa = cbb_phuong_xa.SelectedValue;

            if (selected_phuong_xa != null && selected_phuong_xa.GetType() == typeof(int))
            {
                selected_phuong_xa_id = (int)cbb_phuong_xa.SelectedValue;
            }
        }

        void cbb_phuong_xa_ds(int id_quan_huyen)
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                List<phuong_xa> cbb_list = db.phuong_xa.Where(item => item.id_quan_huyen == id_quan_huyen).ToList();
                if (cbb_list.Count> 0)
                {
                    cbb_phuong_xa.DataSource = cbb_list;
                    cbb_phuong_xa.DisplayMember = "ten_phuong_xa";
                    cbb_phuong_xa.ValueMember = "id";
                    if (doanh_Nghiep.id_dia_chi != null && thongtin_Diachi.id != 0)
                    { 
                        int defaultIndex = cbb_list.FindIndex(item => item.id == thongtin_Diachi.id_phuong_xa);
                        cbb_phuong_xa.SelectedIndex = defaultIndex;
                    }
                    else
                    {
                        cbb_phuong_xa.SelectedIndex = 0;
                    }
                    cbb_phuong_xa_update();
                }
            }
        }



        private void cbb_quoc_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_thanh_pho.DataSource = null;cbb_thanh_pho.Items.Clear();
            cbb_quan_huyen.DataSource = null;  cbb_quan_huyen.Items.Clear();
            cbb_phuong_xa.DataSource = null;cbb_phuong_xa.Items.Clear();

            selected_quoc_gia = cbb_quoc_gia.SelectedValue;

            cbb_thanh_pho_ds(selected_quoc_gia_id);
        }

        private void cbb_thanh_pho_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_quan_huyen.DataSource = null;
            cbb_quan_huyen.Items.Clear();
            cbb_thanh_pho_update();
        }

        private void cbb_quan_huyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_phuong_xa.DataSource = null;
            cbb_phuong_xa.Items.Clear();
            cbb_quan_huyen_update();
        }

        private void cbb_phuong_xa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_phuong_xa_update();
        }

        private void b2_dia_chi_Load(object sender, EventArgs e)
        {
            get_dia_chi_on_load();
            cbb_quoc_gia_ds();
        }

        private bool validate_dia_chi()
        {
            bool is_valid = true;
            if (selected_quoc_gia_id <= 0 )
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quốc gia");
                return is_valid;
            }
            if (selected_thanh_pho_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn thành phố");
                return is_valid ;
            }
            if (selected_quan_huyen_id<= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quận huyện");
                return is_valid ;
            }
            if (selected_phuong_xa_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn phường xã");
                return is_valid;
            }
            if (txt_dia_chi.Text.Trim().Length <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng nhập địa chỉ cụ thể");
                return is_valid;
            }

            return is_valid;
        }

        private void them_dia_chi()
        {   
            if (validate_dia_chi())
            {
                thongtin_Diachi.id_quoc_gia = selected_quoc_gia_id;
                thongtin_Diachi.id_thanh_pho = selected_thanh_pho_id;
                thongtin_Diachi.id_quan_huyen = selected_quan_huyen_id;
                thongtin_Diachi.id_phuong_xa = selected_phuong_xa_id;
                thongtin_Diachi.so_nha_ten_duong = txt_dia_chi.Text.Trim();
                thongtin_Diachi.dien_thoai = txt_dien_thoai.Text.Trim();
                thongtin_Diachi.fax = txt_fax.Text.Trim();
                thongtin_Diachi.email = txt_email.Text.Trim();
                thongtin_Diachi.website = txt_website.Text.Trim();

                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    if (doanh_Nghiep.id_dia_chi == null && thongtin_Diachi.id == 0)
                    {
                        //Thêm thông tin địa chỉ
                        db.thongtin_diachi.Add(thongtin_Diachi);
                        db.SaveChanges();
                        int new_inserted_dia_chi_id = thongtin_Diachi.id;
                        
                        doanh_Nghiep.id_dia_chi = new_inserted_dia_chi_id;
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(thongtin_Diachi).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }
        private void get_dia_chi_on_load()
        {
            if (doanh_Nghiep.id_dia_chi != null)
            {
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    thongtin_Diachi = db.thongtin_diachi.FirstOrDefault(item => item.id == doanh_Nghiep.id_dia_chi.Value);
                    txt_dia_chi.Text = thongtin_Diachi.so_nha_ten_duong;
                    txt_dien_thoai.Text = thongtin_Diachi.dien_thoai;
                    txt_email.Text = thongtin_Diachi.email;
                    txt_fax.Text = thongtin_Diachi.fax;
                    txt_website.Text = thongtin_Diachi.website;
                }
            }
            else
            {
                thongtin_Diachi.id = 0;
                //MessageBox.Show("Thông tin địa chỉ không tôn tại");
            }
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            them_dia_chi();
            MessageBox.Show("Lưu hồ sơ thành công");
            parentForm.Close();
        }
    }
}
