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
        public thong_tin_thue thong_Tin_Thue;
        public doanh_nghiep doanh_Nghiep;
        public thongtin_diachi thongtin_Diachi;

        object selected_quoc_gia = null; public int selected_quoc_gia_id = 0;
        object selected_thanh_pho = null; public int selected_thanh_pho_id = 0;
        object selected_quan_huyen = null; public int selected_quan_huyen_id = 0;
        object selected_phuong_xa = null; public int selected_phuong_xa_id = 0;

        public b8_thong_tin_thue(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.doanh_Nghiep = doanh_Nghiep;

        }

        private void update_form()
        {
            rdo_dia_chi_khac.Checked = true;
            rdo_giong_dia_chi_cty.Checked = false;
            foreach (quoc_tich item in cbb_quoc_gia.Items)
            {
                if (item.id == thongtin_Diachi.id_quoc_gia) { cbb_quoc_gia.SelectedItem = item; change_selected_quoc_gia_id(); break; }
            }
            foreach (thanh_pho item in cbb_thanh_pho.Items)
            {
                if (item.id == thongtin_Diachi.id_thanh_pho) { cbb_thanh_pho.SelectedItem = item; change_selected_thanh_pho_id(); break; }
            }
            foreach (quan_huyen item in cbb_quan_huyen.Items)
            {
                if (item.id == thongtin_Diachi.id_quan_huyen) { cbb_quan_huyen.SelectedItem = item; change_selected_quan_huyen_id(); break; }
            }
            foreach (phuong_xa item in cbb_phuong_xa.Items)
            {
                if (item.id == thongtin_Diachi.id_phuong_xa) { cbb_phuong_xa.SelectedItem = item; change_selected_phuong_xa_id(); break; }
            }
            if (thongtin_Diachi.so_nha_ten_duong != null) txt_dia_chi.Text = thongtin_Diachi.so_nha_ten_duong;
            if (thongtin_Diachi.dien_thoai != null) txt_dien_thoai.Text = thongtin_Diachi.dien_thoai;
            if (thongtin_Diachi.email != null) txt_email.Text = thongtin_Diachi.email;
            if (thongtin_Diachi.website != null) txt_website.Text = thongtin_Diachi.website;
            if (thongtin_Diachi.fax != null) txt_fax.Text = thongtin_Diachi.fax;
        }
        private void load_existing_data()
        {
            if (thongtin_Diachi != null)
            {
                if (doanh_Nghiep.id_dia_chi != null && doanh_Nghiep.id_dia_chi != 0)
                {
                    if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue == doanh_Nghiep.id_dia_chi)
                    {
                        rdo_giong_dia_chi_cty.Checked = true;
                        rdo_dia_chi_khac.Checked = false;
                    }
                    else
                    {
                        update_form();
                    }
                }
                else
                {
                    update_form();
                }
            }

            if (thong_Tin_Thue != null)
            {
                if (thong_Tin_Thue.ngay_bat_dau_nam_tai_chinh != null && thong_Tin_Thue.ngay_bat_dau_nam_tai_chinh != 0)
                {
                    foreach (string item in cbb_ngay_bat_dau_nam_tai_chinh.Items)
                    {
                        if (item == thong_Tin_Thue.ngay_bat_dau_nam_tai_chinh.ToString())
                        {
                            cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem = item;
                        }
                    }
                }
                if (thong_Tin_Thue.thang_bat_dau_nam_tai_chinh != null && thong_Tin_Thue.thang_bat_dau_nam_tai_chinh != 0)
                {
                    foreach (string item in cbb_thang_bat_dau_nam_tai_chinh.Items)
                    {
                        if (item == thong_Tin_Thue.thang_bat_dau_nam_tai_chinh.ToString())
                        {
                            cbb_thang_bat_dau_nam_tai_chinh.SelectedItem = item;

                        }
                    }
                }
                if (thong_Tin_Thue.ngay_ket_thuc_nam_tai_chinh != null && thong_Tin_Thue.ngay_ket_thuc_nam_tai_chinh != 0)
                {
                    foreach (string item in cbb_ngay_ket_thuc_nam_tai_chinh.Items)
                    {
                        if (item == thong_Tin_Thue.ngay_ket_thuc_nam_tai_chinh.ToString())
                        {
                            cbb_ngay_ket_thuc_nam_tai_chinh.SelectedItem = item;

                        }
                    }
                }
                if (thong_Tin_Thue.thang_ket_thuc_nam_tai_chinh != null && thong_Tin_Thue.thang_ket_thuc_nam_tai_chinh != 0)
                {
                    foreach (string item in cbb_thang_ket_thuc_nam_tai_chinh.Items)
                    {
                        if (item == thong_Tin_Thue.thang_ket_thuc_nam_tai_chinh.ToString())
                        {
                            cbb_thang_ket_thuc_nam_tai_chinh.SelectedItem = item;

                        }
                    }
                }
                if (thong_Tin_Thue.hach_toan_doc_lap == true) { rdo_hach_toan_doc_lap.Checked = true; } else { rdo_hach_toan_phu_thuoc.Checked = true; }
                if (thong_Tin_Thue.bao_cao_tai_chinh_hop_nhat != null && thong_Tin_Thue.bao_cao_tai_chinh_hop_nhat != false) { ckb_co_bao_cao_tai_chinh_hop_nhat.Checked = true; }
                //if (thong_Tin_Thue.so_lao_dong_du_kien != null) { txt_so_lao_dong_du_kien.Text = "asdfasdfsdf"; }
                if (thong_Tin_Thue.ngay_bat_dau_hoat_dong_kinh_doanh != null) { txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value = thong_Tin_Thue.ngay_bat_dau_hoat_dong_kinh_doanh.Value; }
            }

        }

        private void b8_thong_tin_thue_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep == null || doanh_Nghiep.id == 0)
            {
                MessageBox.Show("Có lỗi xảy ra. Dữ liệu doanh nghiệp không được truyền vào form");
                return;
            }
            if (doanh_Nghiep.is_submitted == true) { btn_luu_tam.Enabled = false; btn_luu_tam.Visible = false; }
            cbb_quoc_gia_ds();
            if (doanh_Nghiep.id_thong_tin_thue != null && doanh_Nghiep.id_thong_tin_thue != 0)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    thong_Tin_Thue = db.thong_tin_thue.Where(item => item.id == doanh_Nghiep.id_thong_tin_thue).FirstOrDefault();
                    if (thong_Tin_Thue != null)
                    {
                        if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != null && thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != 0)
                        {
                            thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue).FirstOrDefault();
                            if (thongtin_Diachi == null)
                            {
                                thongtin_Diachi = new thongtin_diachi();
                            }
                        }
                    }
                    else
                    {
                        thong_Tin_Thue = new thong_tin_thue();
                        thongtin_Diachi = new thongtin_diachi();
                    }
                }
                load_existing_data();
            }
            else
            {
                thong_Tin_Thue = new thong_tin_thue();
                thongtin_Diachi = new thongtin_diachi();
                rdo_giong_dia_chi_cty.Checked = true;
                rdo_hach_toan_doc_lap.Checked = true;
                foreach (string item in cbb_ngay_bat_dau_nam_tai_chinh.Items)
                {
                    if (item == "1")
                    {
                        cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem = item;
                    }
                }
                foreach (string item in cbb_thang_bat_dau_nam_tai_chinh.Items)
                {
                    if (item == "1")
                    {
                        cbb_thang_bat_dau_nam_tai_chinh.SelectedItem = item;
                    }
                }
                foreach (string item in cbb_ngay_ket_thuc_nam_tai_chinh.Items)
                {
                    if (item == "31")
                    {
                        cbb_ngay_ket_thuc_nam_tai_chinh.SelectedItem = item;
                    }
                }
                foreach (string item in cbb_thang_ket_thuc_nam_tai_chinh.Items)
                {
                    if (item == "12")
                    {
                        cbb_thang_ket_thuc_nam_tai_chinh.SelectedItem = item;
                    }
                }
                //txt_so_lao_dong_du_kien.Text = "0";
                txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value = DateTime.Today;
            }
        }

        void change_selected_quoc_gia_id()
        {
            selected_quoc_gia = cbb_quoc_gia.SelectedValue;
            if (selected_quoc_gia != null && selected_quoc_gia.GetType() == typeof(int))
            {
                selected_quoc_gia_id = (int)selected_quoc_gia;
                cbb_thanh_pho_ds();
            }
        }
        void cbb_quoc_gia_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quoc_tich> cbb_list = db.quoc_tich.ToList();

                if (cbb_list.Count > 0)
                {
                    cbb_quoc_gia.DataSource = cbb_list;
                    cbb_quoc_gia.DisplayMember = "ten_quoc_tich";
                    cbb_quoc_gia.ValueMember = "id";
                    //int defaultIndex = 0;
                    //if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_quoc_gia != null)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_quoc_gia);
                    //}
                    //else
                    //{
                    //}
                    int defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                    cbb_quoc_gia.SelectedIndex = defaultIndex;
                    change_selected_quoc_gia_id();
                }
            }
        }
        void change_selected_thanh_pho_id()
        {
            selected_thanh_pho = cbb_thanh_pho.SelectedValue;
            if (selected_thanh_pho != null && selected_thanh_pho.GetType() == typeof(int))
            {
                selected_thanh_pho_id = (int)selected_thanh_pho;
                cbb_quan_huyen_ds();
            }
        }
        void cbb_thanh_pho_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<thanh_pho> cbb_list = db.thanh_pho.Where(item => item.id_quoc_gia == selected_quoc_gia_id).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_thanh_pho.DataSource = cbb_list;
                    cbb_thanh_pho.DisplayMember = "ten_thanh_pho";
                    cbb_thanh_pho.ValueMember = "id";
                    int defaultIndex = 0;
                    //if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_thanh_pho != null)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_thanh_pho);
                    //}
                    cbb_thanh_pho.SelectedIndex = defaultIndex;
                    change_selected_thanh_pho_id();
                }
            }
        }
        void change_selected_quan_huyen_id()
        {
            selected_quan_huyen = cbb_quan_huyen.SelectedValue;
            if (selected_quan_huyen != null && selected_quan_huyen.GetType() == typeof(int))
            {
                selected_quan_huyen_id = (int)selected_quan_huyen;
                cbb_phuong_xa_ds();
            }
        }
        void cbb_quan_huyen_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quan_huyen> cbb_list = db.quan_huyen.Where(item => item.id_thanh_pho == selected_thanh_pho_id).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_quan_huyen.DataSource = cbb_list;
                    cbb_quan_huyen.DisplayMember = "ten_quan_huyen";
                    cbb_quan_huyen.ValueMember = "id";
                    int defaultIndex = 0;
                    //if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_quan_huyen != null)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_quan_huyen);
                    //}
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
                List<phuong_xa> cbb_list = db.phuong_xa.Where(item => item.id_quan_huyen == selected_quan_huyen_id).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_phuong_xa.DataSource = cbb_list;
                    cbb_phuong_xa.DisplayMember = "ten_phuong_xa";
                    cbb_phuong_xa.ValueMember = "id";
                    int defaultIndex = 0;
                    //if (thongtin_Diachi.id_phuong_xa != null)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_phuong_xa);
                    //}
                    cbb_phuong_xa.SelectedIndex = defaultIndex;
                    change_selected_phuong_xa_id();
                }
            }
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

        private void cbb_quoc_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_quoc_gia_id();
            cbb_thanh_pho_ds();
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
            if (selected_quoc_gia_id <= 0 || cbb_quoc_gia.SelectedIndex < 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quốc gia");
                return is_valid;
            }
            else { thongtin_Diachi.id_quoc_gia = selected_quoc_gia_id; }
            if (selected_thanh_pho_id <= 0 || cbb_thanh_pho.SelectedIndex < 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn thành phố");
                return is_valid;
            }
            else { thongtin_Diachi.id_thanh_pho = selected_thanh_pho_id; }
            if (selected_quan_huyen_id <= 0 || cbb_quan_huyen.SelectedIndex < 0)
            {
                is_valid = false;
                MessageBox.Show("Vui lòng chọn quận huyện");
                return is_valid;
            }
            else { thongtin_Diachi.id_quan_huyen = selected_quan_huyen_id; }
            if (selected_phuong_xa_id <= 0 || cbb_phuong_xa.SelectedIndex < 0)
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
            if (cbb_ngay_bat_dau_nam_tai_chinh.SelectedItem == null || cbb_thang_bat_dau_nam_tai_chinh.SelectedItem == null)
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
            }
            else { thong_Tin_Thue.hach_toan_doc_lap = rdo_hach_toan_doc_lap.Checked; }

            thong_Tin_Thue.so_lao_dong_du_kien = 0;
            thong_Tin_Thue.bao_cao_tai_chinh_hop_nhat = ckb_co_bao_cao_tai_chinh_hop_nhat.Checked;
            //if (txt_so_lao_dong_du_kien.Text.Trim().Length > 0)
            //{
            //    if (txt_so_lao_dong_du_kien.Text.GetType() == typeof(int))
            //    {
            //        int so_lao_dong_du_kien = Convert.ToInt32(txt_so_lao_dong_du_kien.Text);
            //        if (so_lao_dong_du_kien >= 0)
            //        {
            //            thong_Tin_Thue.so_lao_dong_du_kien = so_lao_dong_du_kien;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Số lao động dự kiến không hợp lệ");
            //            txt_so_lao_dong_du_kien.Text = string.Empty;
            //        }
            //    }
            //}

            if (txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value <= DateTime.Now)
            {
                is_valid = false;
                MessageBox.Show("Ngày bắt đầu hoạt động kinh doanh phải là một ngày trong tương lai");
                return is_valid;
            }
            else
            {
                thong_Tin_Thue.ngay_bat_dau_hoat_dong_kinh_doanh = txt_ngay_bat_dau_hoat_dong_kinh_doanh.Value;
            }

            return is_valid;
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            //Xử lý dữ liệu địa chỉ gửi thông báo thuế
            bool is_diachi_valid = true;
            if (rdo_dia_chi_khac.Checked == true)
            {
                is_diachi_valid = validate_dia_chi();
            }
            else
            {
                if (doanh_Nghiep.id_dia_chi == null || doanh_Nghiep.id_dia_chi == 0)
                {
                    MessageBox.Show("Chưa có thông tin địa chỉ doanh nghiệp");
                    is_diachi_valid = false;
                }
            }

            //Xử lý dữ liệu thông tin thuế
            bool is_valid_thongtin_thue = validate_thong_tin_thue();
            if (is_valid_thongtin_thue == false)
            {
                return;
            }

            if (is_diachi_valid == true && is_valid_thongtin_thue == true)
            {
                //Câp nhật
                if (doanh_Nghiep.id_thong_tin_thue != null && doanh_Nghiep.id_thong_tin_thue != 0)
                {
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        thong_Tin_Thue = db.thong_tin_thue.Where(item => item.id == thong_Tin_Thue.id).FirstOrDefault();
                    }
                    if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != null && thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != 0)
                    {
                        //Nếu giống địa chỉ công ty
                        if (rdo_giong_dia_chi_cty.Checked == true && rdo_dia_chi_khac.Checked == false)
                        {
                            if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != doanh_Nghiep.id_dia_chi)
                            {
                                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                                {
                                    thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue).FirstOrDefault();
                                    thong_Tin_Thue.thongtin_diachi = null;
                                    thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue = null;
                                    db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                    db.thongtin_diachi.Remove(thongtin_Diachi);
                                    db.SaveChanges();
                                    thong_Tin_Thue.thongtin_diachi = doanh_Nghiep.thongtin_diachi;
                                    db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                    thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue).FirstOrDefault();
                                }
                            }
                        }
                        if (rdo_dia_chi_khac.Checked == true && rdo_giong_dia_chi_cty.Checked == false)
                        {
                            if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != doanh_Nghiep.id_dia_chi)
                            {
                                //modify
                                thongtin_Diachi = thong_Tin_Thue.thongtin_diachi;
                                validate_dia_chi();
                                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                                {
                                    db.Entry(thongtin_Diachi).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                            else
                            {
                                //create new
                                thongtin_Diachi = new thongtin_diachi();
                                validate_dia_chi();
                                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                                {
                                    db.thongtin_diachi.Add(thongtin_Diachi);
                                    db.SaveChanges();
                                    thong_Tin_Thue.thongtin_diachi = null;
                                    thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue = null;
                                    db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                    thong_Tin_Thue.thongtin_diachi = thongtin_Diachi;
                                    db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }
                        }
                        // Nếu địa chỉ nhận thông báo thuế đã có trước đó nhưng không phải là địa chỉ cty thì update thông tin địa chỉ
                        //if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != doanh_Nghiep.id_dia_chi && rdo_dia_chi_khac.Checked==true) {
                        //    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        //    {
                        //        db.Entry(thongtin_Diachi).State = System.Data.Entity.EntityState.Modified;
                        //        db.SaveChanges();
                        //    }
                        //}
                        //if (thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != doanh_Nghiep.id_dia_chi && rdo_dia_chi_khac.Checked == true) { 
                        //}
                        //else
                        //{
                        //    if (rdo_dia_chi_khac.Checked == true)
                        //    {
                        //        thongtin_Diachi = new thongtin_diachi();
                        //        validate_dia_chi();
                        //        using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        //        {
                        //            db.thongtin_diachi.Add(thongtin_Diachi);
                        //            db.SaveChanges();
                        //            thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue = thongtin_Diachi.id;
                        //            db.SaveChanges();
                        //        }
                        //    }
                        //    if (rdo_giong_dia_chi_cty.Checked == true && doanh_Nghiep.id_dia_chi != null && doanh_Nghiep.id_dia_chi != 0 && thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue != doanh_Nghiep.id_dia_chi)
                        //    {
                        //        using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        //        {
                        //            thongtin_diachi current_diachi = db.thongtin_diachi.Where(item => item.id == thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue).FirstOrDefault();
                        //            thong_Tin_Thue.thongtin_diachi = null;
                        //            thongtin_Diachi = null;
                        //            db.thongtin_diachi.Remove(current_diachi);
                        //            thongtin_Diachi = db.thongtin_diachi.Where((item) => item.id == doanh_Nghiep.id_dia_chi).FirstOrDefault();
                        //            thong_Tin_Thue.thongtin_diachi = thongtin_Diachi;
                        //            db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                        //            db.SaveChanges();
                        //        }
                        //    }
                        //}
                        //using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        //{
                        //    Console.WriteLine("Cập nhật thông tin thuế ");
                        //    db.Entry(thong_Tin_Thue).State = System.Data.Entity.EntityState.Modified;
                        //    db.SaveChanges();
                        //}
                    }
                }
                else
                {
                    if (rdo_dia_chi_khac.Checked == true)
                    {
                        using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        {
                            db.thongtin_diachi.Add(thongtin_Diachi);
                            db.SaveChanges();
                        }
                        thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue = thongtin_Diachi.id;
                    }
                    else
                    {
                        thong_Tin_Thue.id_dia_chi_nhan_thong_bao_thue = doanh_Nghiep.id_dia_chi;
                    }
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.thong_tin_thue.Add(thong_Tin_Thue);
                        db.SaveChanges();
                    }
                    doanh_Nghiep.id_thong_tin_thue = thong_Tin_Thue.id;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Lưu dữ liệu thành công");
            }
        }
    }
}
