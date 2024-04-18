using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    public partial class b5_chu_so_huu : Form
    {
        public doanh_nghiep doanh_Nghiep;
        public nhan_su_doanh_nghiep nhan_Su_Doanh_Nghiep;
        public thongtin_diachi thongtin_Diachi;

        object selected_quoc_gia = null; public int selected_quoc_gia_id = 0;
        object selected_thanh_pho = null; public int selected_thanh_pho_id = 0;
        object selected_quan_huyen = null; public int selected_quan_huyen_id = 0;
        object selected_phuong_xa = null; public int selected_phuong_xa_id = 0;
        object selected_quoc_tich = null; public int selected_quoc_tich_id = 0;
        object selected_dan_toc = null; public int selected_dan_toc_id = 0;

        public b5_chu_so_huu(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.doanh_Nghiep = doanh_Nghiep;
        }
        private void b5_chu_so_huu_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep == null || doanh_Nghiep.id == 0)
            {
                MessageBox.Show("Có lỗi xảy ra. Dữ liệu doanh nghiệp không được truyền vào form");
                return;
            }
            cbb_quoc_tich_ds();
            cbb_quoc_gia_ds();

            if (doanh_Nghiep.is_submitted == true) { btn_luu_tam.Enabled = false; btn_luu_tam.Visible = false; }

            if (doanh_Nghiep.id_chu_so_huu != 0 && doanh_Nghiep.id_chu_so_huu != null)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    nhan_Su_Doanh_Nghiep = db.nhan_su_doanh_nghiep.Where(item => item.id == doanh_Nghiep.id_chu_so_huu).FirstOrDefault();
                    if (nhan_Su_Doanh_Nghiep != null)
                    {
                        if (nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru != null && nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru != 0)
                        {
                            thongtin_Diachi = db.thongtin_diachi.Where(item => item.id == nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru).FirstOrDefault();
                        }
                    }
                }

                if (nhan_Su_Doanh_Nghiep != null)
                {
                    //Thông tin của chủ sở hữu
                    txt_ho_ten.Text = nhan_Su_Doanh_Nghiep.ho_ten;
                    if (nhan_Su_Doanh_Nghiep.gioi_tinh == true)
                    {
                        rdo_nam.Checked = true;
                        rdo_nu.Checked = false;
                    }
                    else
                    {
                        rdo_nam.Checked = false;
                        rdo_nu.Checked = true;
                    }
                    pck_ngay_sinh.Value = nhan_Su_Doanh_Nghiep.ngay_sinh.Value;
                    if (nhan_Su_Doanh_Nghiep.id_quoc_tich != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != 0)
                    {
                        foreach (quoc_tich item in cbb_quoc_tich.Items)
                        {
                            if (item.id == nhan_Su_Doanh_Nghiep.id_quoc_tich)
                            {
                                cbb_quoc_tich.SelectedItem = item;
                                change_selected_quoc_tich_id();
                                break;
                            }
                        }

                    }
                    if (nhan_Su_Doanh_Nghiep.id_dan_toc != null && nhan_Su_Doanh_Nghiep.id_dan_toc != 0)
                    {
                        foreach (dan_toc item in cbb_dan_toc.Items)
                        {
                            if (item.id == nhan_Su_Doanh_Nghiep.id_dan_toc)
                            {
                                cbb_dan_toc.SelectedItem = item;
                                change_selected_dan_toc_id();
                                break;
                            }
                        }
                    }
                    pck_ngay_cap.Value = nhan_Su_Doanh_Nghiep.ngay_cap.Value;
                    pck_ngay_het_han.Value = nhan_Su_Doanh_Nghiep.ngay_het_han.Value;
                    txt_noi_cap.Text = nhan_Su_Doanh_Nghiep.noi_cap;
                    txt_so_giay_to_phap_ly.Text = nhan_Su_Doanh_Nghiep.so_giay_to_phap_ly;
                    foreach (string item in cbb_loai_giay_to_phap_ly.Items)
                    {
                        if (item == nhan_Su_Doanh_Nghiep.loai_giay_to_phap_ly)
                        {
                            cbb_loai_giay_to_phap_ly.SelectedItem = item;
                        }
                    }
                    //Thông tin địa chỉ của chủ sở hữu
                    if (nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru != null && nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru != 0)
                    {
                        if (thongtin_Diachi != null)
                        {
                            foreach (quoc_tich item in cbb_quoc_gia.Items)
                            {
                                if (item.id == thongtin_Diachi.id_quoc_gia) { cbb_quoc_gia.SelectedItem = item; change_selected_quoc_gia_id(); ; break; }
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
                            txt_dia_chi.Text = thongtin_Diachi.so_nha_ten_duong;
                            txt_fax.Text = thongtin_Diachi.fax;
                            txt_dien_thoai.Text = thongtin_Diachi.dien_thoai;
                            txt_website.Text = thongtin_Diachi.website;
                            txt_email.Text = thongtin_Diachi.email;
                        }
                    }
                    else
                    {
                        thongtin_Diachi = new thongtin_diachi();
                    }
                }
            }
            else
            {
                nhan_Su_Doanh_Nghiep = new nhan_su_doanh_nghiep();
                thongtin_Diachi = new thongtin_diachi();
            }
        }


        private bool validate_chu_so_huu()
        {
            bool is_validated = true;
            if (doanh_Nghiep == null || doanh_Nghiep.id == 0)
            {
                is_validated = false;
                MessageBox.Show("ID doanh nghiệp không hợp lệ");
                return is_validated;
            }
            else
            {
                if (nhan_Su_Doanh_Nghiep.id_doanh_nghiep == null || nhan_Su_Doanh_Nghiep.id_doanh_nghiep == 0) { nhan_Su_Doanh_Nghiep.id_doanh_nghiep = doanh_Nghiep.id; }
                else if (nhan_Su_Doanh_Nghiep.id_doanh_nghiep != doanh_Nghiep.id) { nhan_Su_Doanh_Nghiep.id_doanh_nghiep = doanh_Nghiep.id; }
            }
            if (txt_ho_ten.Text.Trim().Length <= 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng nhập họ tên");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ho_ten = txt_ho_ten.Text; }
            if (rdo_nam.Checked == rdo_nu.Checked)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng chọn giới tính");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.gioi_tinh = rdo_nam.Checked; }

            if (pck_ngay_sinh.Value > DateTime.Today)
            {
                is_validated = false;
                MessageBox.Show("Ngày sinh không hợp lệ");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ngay_sinh = pck_ngay_sinh.Value; }

            int age = DateTime.Now.Year - pck_ngay_sinh.Value.Year;
            if (pck_ngay_sinh.Value > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                is_validated = false;
                MessageBox.Show("Chủ doanh nghiệp chưa đủ 18 tuổi");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ngay_sinh = pck_ngay_sinh.Value; }

            if (selected_quoc_tich_id == 0 || cbb_quoc_tich.SelectedIndex < 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng chọn quốc tịch");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.id_quoc_tich = selected_quoc_tich_id; }

            if (selected_dan_toc_id == 0 || cbb_dan_toc.SelectedIndex < 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng chọn dân tộc");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.id_dan_toc = selected_dan_toc_id; }

            if (cbb_loai_giay_to_phap_ly.SelectedIndex < 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng chọn loại giấy tờ pháp lý");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.loai_giay_to_phap_ly = cbb_loai_giay_to_phap_ly.SelectedItem.ToString(); }

            if (txt_so_giay_to_phap_ly.Text.Trim().Length <= 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng nhập số giấy tờ pháp lý");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.so_giay_to_phap_ly = txt_so_giay_to_phap_ly.Text; }

            if (pck_ngay_cap.Value <= pck_ngay_sinh.Value)
            {
                is_validated = false;
                MessageBox.Show("Ngày cấp giấy tờ pháp nhỏ hơn ngày sinh. Dữ liệu không hợp lệ!");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ngay_cap = pck_ngay_cap.Value; }

            if (pck_ngay_cap.Value >= pck_ngay_het_han.Value)
            {
                is_validated = false;
                MessageBox.Show("Ngày cấp giấy tờ lớn hơn hoặc bằng ngày hết hạn. Dữ liệu không hợp lệ!");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ngay_cap = pck_ngay_cap.Value; }

            if (txt_noi_cap.Text.Trim().Length <= 0)
            {
                is_validated = false;
                MessageBox.Show("Vui lòng nhập nơi cấp giấy tờ pháp lý");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.noi_cap = txt_noi_cap.Text; }

            if (pck_ngay_het_han.Value <= pck_ngay_cap.Value)
            {
                is_validated = false;
                MessageBox.Show("Ngày cấp giấy tờ lớn hơn hoặc bằng ngày hết hạn. Dữ liệu không hợp lệ!");
                return is_validated;
            }
            else { nhan_Su_Doanh_Nghiep.ngay_het_han = pck_ngay_het_han.Value; }

            return is_validated;
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

        private bool luu_du_lieu()
        {
            if (validate_dia_chi() == true && validate_chu_so_huu() == true)
            {
                //Trường hợp tạo mới
                if (doanh_Nghiep.id_chu_so_huu == null || doanh_Nghiep.id_chu_so_huu == 0)
                {
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.thongtin_diachi.Add(thongtin_Diachi);
                        db.SaveChanges();
                    }
                    nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru = thongtin_Diachi.id;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.nhan_su_doanh_nghiep.Add(nhan_Su_Doanh_Nghiep);
                        db.SaveChanges();
                    }
                    doanh_Nghiep.id_chu_so_huu = nhan_Su_Doanh_Nghiep.id;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                //Trường hợp cập nhật
                if (doanh_Nghiep.id_chu_so_huu != null && doanh_Nghiep.id_chu_so_huu != 0)
                {
                    //Tạo mới địa chỉ thường trú
                    if (nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru == null || nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru == 0)
                    {
                        using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        {
                            db.thongtin_diachi.Add(thongtin_Diachi);
                            db.SaveChanges();
                            nhan_Su_Doanh_Nghiep.dia_chi_thuong_tru = thongtin_Diachi.id;
                        }
                        
                    }
                    else
                    {
                        using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                        {
                            db.Entry(thongtin_Diachi).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    //Cập nhật chủ sở hữu
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(nhan_Su_Doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                return true;
            }
            return false;
        }
        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            if (luu_du_lieu() == true)
            {
                MessageBox.Show("Lưu hồ sơ thành công");
            }
        }

        // Datasource nhan su doanh nghiep
        void change_selected_quoc_tich_id()
        {
            selected_quoc_tich = cbb_quoc_tich.SelectedValue;
            if (selected_quoc_tich != null && selected_quoc_tich.GetType() == typeof(int))
            {
                selected_quoc_tich_id = (int)selected_quoc_tich;
            }
        }
        void cbb_quoc_tich_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quoc_tich> cbb_list = db.quoc_tich.ToList();

                if (cbb_list.Count > 0)
                {
                    cbb_quoc_tich.DataSource = cbb_list;
                    cbb_quoc_tich.DisplayMember = "ten_quoc_tich";
                    cbb_quoc_tich.ValueMember = "id";
                    //int defaultIndex = 0;
                    //if (nhan_Su_Doanh_Nghiep != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != 0)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == nhan_Su_Doanh_Nghiep.id_quoc_tich);
                    //}
                    //else
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                    //}
                    //cbb_quoc_tich.SelectedIndex = defaultIndex;
                    //if (nhan_Su_Doanh_Nghiep != null)
                    //{
                    //    if (nhan_Su_Doanh_Nghiep.id_quoc_tich != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != 0)
                    //    {
                    //    }
                    //}
                    int defaultIndex = cbb_list.FindIndex(qt => qt.ten_quoc_tich == "Việt Nam");
                    cbb_quoc_tich.SelectedIndex = defaultIndex;
                    change_selected_quoc_tich_id();
                }
            }
        }
        void change_selected_dan_toc_id()
        {
            selected_dan_toc = cbb_dan_toc.SelectedValue;
            if (selected_dan_toc != null && selected_dan_toc.GetType() == typeof(int))
            {
                selected_dan_toc_id = (int)selected_dan_toc;
            }
        }
        void cbb_dan_toc_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<dan_toc> cbb_list = db.dan_toc.Where(item => item.id_quoc_tich == selected_quoc_tich_id).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_dan_toc.DataSource = cbb_list;
                    cbb_dan_toc.DisplayMember = "ten_dan_toc";
                    cbb_dan_toc.ValueMember = "id";
                    //int defaultIndex = 0;
                    //if (nhan_Su_Doanh_Nghiep != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != null && nhan_Su_Doanh_Nghiep.id_quoc_tich != 0)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == nhan_Su_Doanh_Nghiep.id_dan_toc);
                    //}
                    //cbb_dan_toc.SelectedIndex = defaultIndex;
                    if (nhan_Su_Doanh_Nghiep != null)
                    {
                        if (nhan_Su_Doanh_Nghiep.id_dan_toc != null && nhan_Su_Doanh_Nghiep.id_dan_toc != 0)
                        {
                            int defaultIndex = cbb_list.FindIndex(qt => qt.id == nhan_Su_Doanh_Nghiep.id_dan_toc);
                            cbb_dan_toc.SelectedIndex = defaultIndex;
                        }
                    }
                    change_selected_dan_toc_id();
                }
            }
        }

        // Datasource Thong tin dia chi
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
                //List<quoc_tich> cbb_list = quoc_Tich_list;

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
                    //if (thongtin_Diachi.id != 0 && thongtin_Diachi.id_phuong_xa != null)
                    //{
                    //    defaultIndex = cbb_list.FindIndex(qt => qt.id == thongtin_Diachi.id_phuong_xa);
                    //}
                    cbb_phuong_xa.SelectedIndex = defaultIndex;
                    change_selected_phuong_xa_id();
                }
            }
        }
        private void cbb_quoc_tich_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_quoc_tich_id();
            cbb_dan_toc_ds();

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
        private void cbb_loai_giay_to_phap_ly_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbb_loai_giay_to_phap_ly.SelectedItem.ToString());
        }
        private void cbb_dan_toc_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_selected_dan_toc_id();
        }
    }
}
