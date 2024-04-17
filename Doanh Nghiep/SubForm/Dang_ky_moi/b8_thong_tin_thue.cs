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
    public partial class b8_thong_tin_thue : Form
    {
        private thong_tin_thue thong_Tin_Thue;
        private doanh_nghiep doanh_Nghiep;
        private thongtin_diachi thongtin_Diachi;

        private List<quoc_tich> quoc_Tich_list = new List<quoc_tich>();

        object selected_quoc_gia = null; public int selected_quoc_gia_id = 0;
        object selected_thanh_pho = null; public int selected_thanh_pho_id = 0;
        object selected_quan_huyen = null; public int selected_quan_huyen_id = 0;
        object selected_phuong_xa = null; public int selected_phuong_xa_id = 0;

        public b8_thong_tin_thue(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.doanh_Nghiep = doanh_Nghiep;

        }

        private void rdo_dia_chi_khac_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_dia_chi_khac.Checked)
            {
                cbb_quoc_gia.Enabled = true;
                cbb_thanh_pho.Enabled = true;
                cbb_quan_huyen.Enabled = true;
                cbb_phuong_xa.Enabled = true;
                txt_dia_chi.Enabled = true;
                txt_dien_thoai.Enabled = true;
                txt_fax.Enabled = true;
                txt_email.Enabled = true;
                txt_website.Enabled = true;
            }
            else
            {
                cbb_quoc_gia.Enabled = false;
                cbb_thanh_pho.Enabled = false;
                cbb_quan_huyen.Enabled = false;
                cbb_phuong_xa.Enabled = false;
                txt_dia_chi.Enabled = false;
                txt_dien_thoai.Enabled = false;
                txt_fax.Enabled = false;
                txt_email.Enabled = false;
                txt_website.Enabled = false;
            }
        }

        private void rdo_giong_dia_chi_cty_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_dia_chi_khac.Checked)
            {
                cbb_quoc_gia.Enabled = true;
                cbb_thanh_pho.Enabled = true;
                cbb_quan_huyen.Enabled = true;
                cbb_phuong_xa.Enabled = true;
                txt_dia_chi.Enabled = true;
                txt_dien_thoai.Enabled = true;
                txt_fax.Enabled = true;
                txt_email.Enabled = true;
                txt_website.Enabled = true;
            }
            else
            {
                cbb_quoc_gia.Enabled = false;
                cbb_thanh_pho.Enabled = false;
                cbb_quan_huyen.Enabled = false;
                cbb_phuong_xa.Enabled = false;
                txt_dia_chi.Enabled = false;
                txt_dien_thoai.Enabled = false;
                txt_fax.Enabled = false;
                txt_email.Enabled = false;
                txt_website.Enabled = false;
            }
        }

        private void load_existing_data()
        {
            if (thong_Tin_Thue == null) { return; }
            if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue == doanh_Nghiep.id_dia_chi)
            {
                rdo_giong_dia_chi_cty.Checked = true;
            }
            else
            {
                rdo_dia_chi_khac.Checked = true;
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue).FirstOrDefault();
                    if (thongtin_Diachi.so_nha_ten_duong!=null) txt_dia_chi.Text = thongtin_Diachi.so_nha_ten_duong;
                    if (thongtin_Diachi.dien_thoai!=null) txt_dien_thoai.Text = thongtin_Diachi.dien_thoai;
                    if (thongtin_Diachi.email != null) txt_email.Text = thongtin_Diachi.email;
                    if (thongtin_Diachi.website != null) txt_website.Text = thongtin_Diachi.website;
                }
            }
            cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem = thong_Tin_Thue.ngay_bat_dau_nam_tai_chinh;
            cbb_thang_bat_dau_nam_tai_chinh.SelectedItem = thong_Tin_Thue.thang_bat_dau_nam_tai_chinh;
            cbb_ngay_ket_thuc_nam_tai_chinh.SelectedItem = thong_Tin_Thue.ngay_ket_thuc_nam_tai_chinh;
            cbb_thang_ket_thuc_nam_tai_chinh.SelectedItem = thong_Tin_Thue.thang_ket_thuc_nam_tai_chinh;
            if (thong_Tin_Thue.hach_toan_doc_lap==true) { rdo_hach_toan_doc_lap.Checked = true; } else { rdo_hach_toan_phu_thuoc.Checked=true; }
            if (thong_Tin_Thue.bao_cao_tai_chinh_hop_nhat==true) { ckb_co_bao_cao_tai_chinh_hop_nhat.Checked = true; } else { ckb_co_bao_cao_tai_chinh_hop_nhat.Checked = false; }
            if (thong_Tin_Thue.so_lao_dong_du_kien!=null) { txt_so_lao_dong_du_kien.Text = thong_Tin_Thue.so_lao_dong_du_kien.ToString(); }

        }

        private void b8_thong_tin_thue_Load(object sender, EventArgs e)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                quoc_Tich_list = db.quoc_tich.ToList<quoc_tich>();
            }
            if (doanh_Nghiep.id_thong_tin_thue != null) { 
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    thong_Tin_Thue = db.thong_tin_thue.Where(item => item.id == doanh_Nghiep.id_thong_tin_thue).FirstOrDefault();
                }
                cbb_quoc_gia_ds();
                load_existing_data();
            }
            else
            {
                thong_Tin_Thue = new thong_tin_thue();
            }
        }

        void change_selected_quoc_gia_id()
        {
            selected_quoc_gia = cbb_quoc_gia.SelectedValue;
            if (selected_quoc_gia != null && selected_quoc_gia.GetType() == typeof(int))
            {
                selected_quoc_gia_id = (int)selected_quoc_gia;
            }
        }
   
        void cbb_quoc_gia_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                //List<quoc_tich> cbb_list = db.quoc_tich.ToList();
                List<quoc_tich> cbb_list = quoc_Tich_list;

                if (cbb_list.Count > 0)
                {
                    cbb_quoc_gia.DataSource = cbb_list;
                    cbb_quoc_gia.DisplayMember = "ten_quoc_tich";
                    cbb_quoc_gia.ValueMember = "id";
                    int defaultIndex = 0;
                    if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_quoc_gia != null)
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_quoc_gia);
                    }
                    else
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                    }
                    cbb_quoc_gia.SelectedIndex = defaultIndex;
                    change_selected_quoc_gia_id();
                }
            }
        }
        private void cbb_quoc_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_quoc_gia_id();
            cbb_thanh_pho_ds();
        }
        void change_selected_thanh_pho_id()
        {
            selected_thanh_pho = cbb_thanh_pho.SelectedValue;
            if (selected_thanh_pho != null && selected_thanh_pho.GetType() == typeof(int))
            {
                selected_thanh_pho_id = (int)selected_thanh_pho;
            }
        }
        void cbb_thanh_pho_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<thanh_pho> cbb_list = db.thanh_pho.ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_thanh_pho.DataSource = cbb_list;
                    cbb_thanh_pho.DisplayMember = "ten_thanh_pho";
                    cbb_thanh_pho.ValueMember = "id";
                    int defaultIndex = 0;
                    if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_thanh_pho != null)
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_thanh_pho);
                    }
                    cbb_thanh_pho.SelectedIndex = defaultIndex;
                    change_selected_thanh_pho_id();
                }
                else
                {
                    MessageBox.Show("Danh sách thành phố trống");
                }
            }
        }
        void change_selected_quan_huyen_id()
        {
            selected_quan_huyen = cbb_quan_huyen.SelectedValue;
            if (selected_quan_huyen != null && selected_quan_huyen.GetType() == typeof(int))
            {
                selected_quan_huyen_id = (int)selected_quan_huyen;
            }
        }
        void cbb_quan_huyen_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quan_huyen> cbb_list = db.quan_huyen.ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_quan_huyen.DataSource = cbb_list;
                    cbb_quan_huyen.DisplayMember = "ten_quan_huyen";
                    cbb_quan_huyen.ValueMember = "id";
                    int defaultIndex = 0;
                    if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_quan_huyen != null)
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_quan_huyen);
                    }
                    cbb_quan_huyen.SelectedIndex = defaultIndex;
                    change_selected_quan_huyen_id();
                }
            }
        }
        void change_selected_phuong_xa_id()
        {
            selected_phuong_xa = cbb_phuong_xa.SelectedValue;
            if (selected_phuong_xa != null && selected_phuong_xa.GetType() == typeof(int))
            {
                selected_phuong_xa_id = (int)selected_phuong_xa;
            }
        }
        void cbb_phuong_xa_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<phuong_xa> cbb_list = db.phuong_xa.ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_phuong_xa.DataSource = cbb_list;
                    cbb_phuong_xa.DisplayMember = "ten_phuong_xa";
                    cbb_phuong_xa.ValueMember = "id";
                    int defaultIndex = 0;
                    if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_phuong_xa != null)
                    {
                        defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_phuong_xa);
                    }
                    cbb_phuong_xa.SelectedIndex = defaultIndex;
                    change_selected_phuong_xa_id();
                }
            }
        }

        private void cbb_thanh_pho_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_thanh_pho_id();
            cbb_quan_huyen_ds();
        }

        private void cbb_quan_huyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_quan_huyen_id();
            cbb_phuong_xa_ds();
        }

        private void cbb_phuong_xa_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_phuong_xa_id();
        }

        private bool validate_dia_chi()
        {
            bool is_valid = true;
            if (selected_quoc_gia_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quốc gia");
                return is_valid;
            }
            else { thongtin_Diachi.id_quoc_gia = selected_quoc_gia_id; }
            if (selected_thanh_pho_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn thành phố");
                return is_valid;
            }
            else { thongtin_Diachi.id_thanh_pho = selected_thanh_pho_id; }
            if (selected_quan_huyen_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quận huyện");
                return is_valid;
            }
            else { thongtin_Diachi.id_quan_huyen = selected_quan_huyen_id; }
            if (selected_phuong_xa_id <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn phường xã");
                return is_valid;
            }
            else { thongtin_Diachi.id_phuong_xa = selected_phuong_xa_id; }
            if (txt_dia_chi.Text.Trim().Length <= 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng nhập địa chỉ cụ thể");
                return is_valid;
            }
            else { thongtin_Diachi.so_nha_ten_duong = txt_dia_chi.Text; }

            if (txt_dien_thoai.Text.Trim().Length > 0) { thongtin_Diachi.dien_thoai = txt_dien_thoai.Text; }
            if (txt_fax.Text.Trim().Length > 0) { thongtin_Diachi.fax = txt_fax.Text; }
            if (txt_email.Text.Trim().Length > 0) { thongtin_Diachi.email = txt_email.Text; }
            if (txt_website.Text.Trim().Length > 0) { thongtin_Diachi.website = txt_website.Text; }

            return is_valid;
        }

        private bool validate_thong_tin_thue()
        {
            bool is_valid = true;
            if (cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem == null || cbb_thang_bat_dau_nam_tai_chinh.SelectedItem==null)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn ngày bắt đầu năm tài chính");
                return is_valid;
            }
            else
            {
                thong_Tin_Thue.ngay_bat_dau_nam_tai_chinh = int.Parse(cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem.ToString());
                thong_Tin_Thue.thang_bat_dau_nam_tai_chinh = int.Parse(cbb_thang_bat_dau_nam_tai_chinh.SelectedItem.ToString());

            }
            if (cbb_ngay_ket_thuc_nam_tai_chinh.SelectedItem == null || cbb_thang_ket_thuc_nam_tai_chinh.SelectedItem == null)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn ngày kết thúc năm tài chính");
                return is_valid;
            }
            else
            {
                thong_Tin_Thue.ngay_ket_thuc_nam_tai_chinh = int.Parse(cbb_ngay_ket_thuc_nam_tai_chinh.SelectedItem.ToString());
                thong_Tin_Thue.thang_ket_thuc_nam_tai_chinh = int.Parse(cbb_thang_ket_thuc_nam_tai_chinh.SelectedItem.ToString());
            }
            if (rdo_hach_toan_doc_lap.Checked == rdo_hach_toan_phu_thuoc.Checked)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn hình thức hạch toán");
                return is_valid;
            } else { thong_Tin_Thue.hach_toan_doc_lap = rdo_hach_toan_doc_lap.Checked; }
            
            if (txt_so_lao_dong_du_kien.Text.Trim().Length>0)
            {
                if (txt_so_lao_dong_du_kien.Text.GetType() == typeof(int)) {
                    int so_lao_dong_du_kien = int.Parse(txt_so_lao_dong_du_kien.Text);
                    if (so_lao_dong_du_kien>=0)
                    {
                        thong_Tin_Thue.so_lao_dong_du_kien = so_lao_dong_du_kien;
                    }
                    else
                    {
                        MessageBox.Show("Số lao động dự kiến không hợp lệ");
                        txt_so_lao_dong_du_kien.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Số lao động dự kiến không hợp lệ");
                    txt_so_lao_dong_du_kien.Text = string.Empty;
                }
            }

            if (txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value <= DateTime.Now)
            {
                is_valid = false;
                MessageBox.Show("Ngày bắt đầu hoạt động kinh doanh phải là một ngày trong tương lai");
                return is_valid;
            } else
            {
                thong_Tin_Thue.ngay_bat_dau_hoat_dong_kinh_doanh = txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value;
            }
            
            return is_valid;
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            bool is_diachi_valid = true;
            if (rdo_dia_chi_khac.Checked==true) {
                is_diachi_valid = validate_dia_chi();
            }
            bool is_valid_thongtin_thue = validate_thong_tin_thue();
            if (is_diachi_valid == true && is_valid_thongtin_thue==true) { 
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    db.thong_tin_thue.Add(thong_Tin_Thue);
                    db.SaveChanges();
                    if (doanh_Nghiep.id_thong_tin_thue==null || doanh_Nghiep.id_thong_tin_thue==0)
                    {
                        doanh_Nghiep.id_thong_tin_thue = thong_Tin_Thue.id;
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                    }
                    
                    MessageBox.Show("Lưu dữ liệu thành công");
                }
            }
        }
    }
}
