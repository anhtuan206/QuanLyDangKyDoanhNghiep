using QuanLyDangKyDoanhNghiep.Doanh_Nghiep;
using QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi;
using QuanLyDangKyDoanhNghiep.Doanh_Nghiep.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep
{
    public partial class frm_giaodien_doanhnghiep : Form
    {
        public external_account external_Account;
        public frm_dangnhap parentForm;

        public frm_giaodien_doanhnghiep(external_account external_Account, frm_dangnhap parentForm)
        {
            InitializeComponent();
            this.external_Account = external_Account;
            this.parentForm = parentForm;
        }
        private Form currentFormChild;
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

        private void btn_dang_ky_doanh_nghiep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dang_ky_doanh_nghiep(this, external_Account));
        }

        private void frm_giaodien_doanhnghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btn_danh_sach_ho_so_dang_ky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_danh_sach_ho_so_dang_ky(this, external_Account));
        }

        private void frm_giaodien_doanhnghiep_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dang_ky_doanh_nghiep(this, external_Account));
            btn_dang_ky_doanh_nghiep.Focus();
        }

        //Tạo dữ liệu tự động
        string random_string()
        {
            // Define the characters from which the random string will be composed
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";

            // Initialize a new instance of the Random class
            Random random = new Random();

            // Define the length of the random string
            int length = random.Next(10, 20);


            // Use StringBuilder to efficiently construct the string
            StringBuilder builder = new StringBuilder(length);

            // Generate random characters and append them to the StringBuilder
            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }

            // Convert StringBuilder to string and display the result
            string randomString = builder.ToString();

            return randomString;
        }
        string random_string_number()
        {
            // Define the characters from which the random string will be composed
            const string chars = "0123456789 ";

            // Initialize a new instance of the Random class
            Random random = new Random();

            // Define the length of the random string
            int length = random.Next(7, 12);


            // Use StringBuilder to efficiently construct the string
            StringBuilder builder = new StringBuilder(length);

            // Generate random characters and append them to the StringBuilder
            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }

            // Convert StringBuilder to string and display the result
            string randomString = builder.ToString();

            return randomString;
        }
        string random_phone()
        {
            // Initialize a new instance of the Random class
            Random random = new Random();

            // Generate a random area code (3 digits)
            string areaCode = random.Next(100, 1000).ToString();

            // Generate a random exchange code (3 digits)
            string exchangeCode = random.Next(100, 1000).ToString();

            // Generate a random subscriber number (4 digits)
            string subscriberNumber = random.Next(1000, 10000).ToString();

            // Concatenate the parts to form the phone number
            string phoneNumber = $"{areaCode}-{exchangeCode}-{subscriberNumber}";

            return phoneNumber;
        }
        static string GenerateRandomString(int length)
        {
            Random random = new Random();

            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(stringChars);
        }
        string random_website()
        {
            Random random = new Random();

            string[] domains = { "example", "sample", "test", "demo", "website", "company", "blog", "info", "business", "solution" };
            string[] tlds = { "com", "net", "org", "edu", "gov", "info", "biz", "io" };
            // Generate a random subdomain or leave it blank
            string subdomain = random.Next(2) == 0 ? GenerateRandomString(5) + "." : "";

            // Generate a random domain name
            string domain = domains[random.Next(domains.Length)];

            // Generate a random top-level domain (TLD)
            string tld = tlds[random.Next(tlds.Length)];

            // Concatenate the parts to form the website address
            string websiteAddress = $"{subdomain}{domain}.{tld}";
            return websiteAddress;
        }
        string random_loai_giay_to_phap_ly()
        {
            Random random = new Random();
            // Define the list of documents
            List<string> documents = new List<string>
            {
                "Thẻ căn cước công dân",
                "Chứng minh nhân dân",
                "Hộ chiếu Việt Nam",
                "Hộ chiếu nước ngoài",
                "Giấy tờ có giá trị thay thế hộ chiếu nước ngoài",
                "Loại khác"
            };

            // Randomly pick an item from the list
            string randomDocument = documents[random.Next(documents.Count)];
            return randomDocument;
        }
        DateTime GenerateRandomBirthday()
        {
            Random random = new Random();
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Calculate the maximum date that would make the person 18 years old or older
            DateTime maxDate = currentDate.AddYears(-18);

            // Generate a random date within the range from 18 years ago until today
            DateTime randomBirthday = RandomDate(maxDate, currentDate);

            return randomBirthday;
        }
        DateTime RandomDate(DateTime fromDate, DateTime toDate)
        {
            Random random = new Random();
            // Calculate the range of days
            TimeSpan range = toDate - fromDate;

            // Generate a random number of days within the range
            int randomDays = random.Next(range.Days);

            // Return a random date within the specified range
            return fromDate.AddDays(randomDays);
        }
        dan_toc random_dantoc()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<dan_toc> item_list = db.dan_toc.ToList();
                if (item_list.Any())
                {
                    // Initialize a new instance of the Random class
                    Random random = new Random();

                    // Generate a random index within the range of the list
                    int randomIndex = random.Next(item_list.Count);

                    // Retrieve the randomly picked entry from the list
                    dan_toc randomEntry = item_list[randomIndex];
                    return randomEntry;
                }
            }
            return null;
        }
        phuong_xa random_phuong_xa()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<phuong_xa> item_list = db.phuong_xa.ToList();
                if (item_list.Any())
                {
                    // Initialize a new instance of the Random class
                    Random random = new Random();

                    // Generate a random index within the range of the list
                    int randomIndex = random.Next(item_list.Count);

                    // Retrieve the randomly picked entry from the list
                    phuong_xa randomEntry = item_list[randomIndex];
                    return randomEntry;
                }
            }
            return null;
        }
        quoc_tich get_quoc_tich(dan_toc param)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                return db.quoc_tich.Where(item => item.id == param.id_quoc_tich).FirstOrDefault();
            }
        }
        quan_huyen get_quan_huyen(phuong_xa param)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                return db.quan_huyen.Where(item => item.id == param.id_quan_huyen).FirstOrDefault();
            }
        }
        thanh_pho get_thanh_pho(quan_huyen param)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                return db.thanh_pho.Where(item => item.id == param.id_thanh_pho).FirstOrDefault();
            }
        }
        quoc_tich get_quoc_gia(thanh_pho param)
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                return db.quoc_tich.Where(item => item.id == param.id_quoc_gia).FirstOrDefault();
            }
        }
        thongtin_diachi random_thong_tin_dia_chi()
        {
            thongtin_diachi new_thong_tin_dia_chi = new thongtin_diachi();
            new_thong_tin_dia_chi.phuong_xa = random_phuong_xa();
            new_thong_tin_dia_chi.quan_huyen = get_quan_huyen(new_thong_tin_dia_chi.phuong_xa);
            new_thong_tin_dia_chi.thanh_pho = get_thanh_pho(new_thong_tin_dia_chi.quan_huyen);
            new_thong_tin_dia_chi.quoc_tich = get_quoc_gia(new_thong_tin_dia_chi.thanh_pho);
            new_thong_tin_dia_chi.so_nha_ten_duong = random_string();
            new_thong_tin_dia_chi.dien_thoai = random_phone();
            new_thong_tin_dia_chi.fax = random_phone();
            new_thong_tin_dia_chi.website = random_website();
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.thongtin_diachi.Add(new_thong_tin_dia_chi);
                db.SaveChanges();
            }
            return new_thong_tin_dia_chi;

        }
        thong_tin_thue random_thong_tin_thue()
        {
            thong_tin_thue new_thong_tin_thue = new thong_tin_thue();
            thongtin_diachi dia_chi_nhan_thong_bao_thue = random_thong_tin_dia_chi();
            new_thong_tin_thue.thongtin_diachi = dia_chi_nhan_thong_bao_thue;
            new_thong_tin_thue.ngay_bat_dau_nam_tai_chinh = new_thong_tin_thue.thang_bat_dau_nam_tai_chinh = 1;
            new_thong_tin_thue.ngay_ket_thuc_nam_tai_chinh = 31;
            new_thong_tin_thue.thang_ket_thuc_nam_tai_chinh = 12;
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.thong_tin_thue.Add(new_thong_tin_thue);
                db.SaveChanges();
            }
            return new_thong_tin_thue;

        }
        nhan_su_doanh_nghiep random_nhan_su_doanh_nghiep()
        {
            nhan_su_doanh_nghiep new_nhan_su_doanh_nghiep = new nhan_su_doanh_nghiep();
            new_nhan_su_doanh_nghiep.ho_ten = random_string();
            new_nhan_su_doanh_nghiep.dan_toc = random_dantoc();
            new_nhan_su_doanh_nghiep.quoc_tich = get_quoc_tich(new_nhan_su_doanh_nghiep.dan_toc);
            if (new_nhan_su_doanh_nghiep.ho_ten.Length % 2 == 0)
            {
                new_nhan_su_doanh_nghiep.gioi_tinh = true;
            }
            else { new_nhan_su_doanh_nghiep.gioi_tinh = false; }
            new_nhan_su_doanh_nghiep.ngay_sinh = GenerateRandomBirthday();
            new_nhan_su_doanh_nghiep.ngay_cap = new_nhan_su_doanh_nghiep.ngay_sinh.Value.AddYears(3);
            new_nhan_su_doanh_nghiep.noi_cap = random_string();
            new_nhan_su_doanh_nghiep.ngay_het_han = DateTime.Today.AddYears(10);
            new_nhan_su_doanh_nghiep.loai_giay_to_phap_ly = random_loai_giay_to_phap_ly();
            new_nhan_su_doanh_nghiep.so_giay_to_phap_ly = random_string_number();
            thongtin_diachi dia_chi_thuong_tru = random_thong_tin_dia_chi();
            new_nhan_su_doanh_nghiep.thongtin_diachi = dia_chi_thuong_tru;

            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.nhan_su_doanh_nghiep.Add(new_nhan_su_doanh_nghiep);
                db.SaveChanges();
            }
            return new_nhan_su_doanh_nghiep;
        }
        nganh_nghe get_random_nganh_nghe()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe> item_list = db.nganh_nghe.Where(item => item.cap_do == 5).ToList();
                if (item_list.Any())
                {
                    // Initialize a new instance of the Random class
                    Random random = new Random();

                    // Generate a random index within the range of the list
                    int randomIndex = random.Next(item_list.Count);

                    // Retrieve the randomly picked entry from the list
                    nganh_nghe randomEntry = item_list[randomIndex];
                    return randomEntry;
                }
            }
            return null;
        }
        
        void random_nganh_nghe_dang_ky(doanh_nghiep doanh_Nghiep)
        {
            Random random = new Random();
            for (int i = 0; i <= random.Next(10); i++) { 
                nganh_nghe nganh_Nghe = get_random_nganh_nghe();
                if (doanh_Nghiep!=null && nganh_Nghe!=null)
                {
                    nganh_nghe_dangky nganh_Nghe_Dangky = new nganh_nghe_dangky();
                    if (i < 7)
                    { 
                        nganh_Nghe_Dangky.id_nganh_nghe = nganh_Nghe.id;
                        nganh_Nghe_Dangky.nganh_nghe_khac = nganh_Nghe.ten_nganh_nghe;
                        nganh_Nghe_Dangky.is_nganh_nghe_khac = false;
                    }
                    else
                    {
                        nganh_Nghe_Dangky.is_nganh_nghe_khac = true;
                        nganh_Nghe_Dangky.nganh_nghe_khac = random_string();
                    }

                    nganh_Nghe_Dangky.id_doanh_nghiep = doanh_Nghiep.id;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.nganh_nghe_dangky.Add(nganh_Nghe_Dangky);
                        db.SaveChanges();
                    }
                }
            }
        }
        doanh_nghiep random_doanh_nghiep()
        {
            doanh_nghiep new_doanh_nghiep = new doanh_nghiep();
            Random random = new Random();
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<loai_hinh> loai_Hinhs = db.loai_hinh.ToList();
                // Check if the list is not empty
                if (loai_Hinhs.Any())
                {
                    int randomIndex = random.Next(loai_Hinhs.Count);
                    loai_hinh randomEntry = loai_Hinhs[randomIndex];
                    //loai_Hinh = db.loai_hinh.Where(item=> item.id == randomEntry.id).FirstOrDefault();
                    new_doanh_nghiep.loai_hinh_id = randomEntry.id;
                }
                List<external_account> external_Accounts = db.external_account.ToList();
                if (external_Accounts.Any())
                {
                    int randomIndex = random.Next(external_Accounts.Count);
                    external_account randomEntry = external_Accounts[randomIndex];
                    new_doanh_nghiep.external_account_id = randomEntry.id;
                    //random_external_account = db.external_account.Where(item => item.id == randomEntry.id).FirstOrDefault();
                }
            }
            new_doanh_nghiep.ten = random_string();
            new_doanh_nghiep.thongtin_diachi = random_thong_tin_dia_chi();
            new_doanh_nghiep.nhan_su_doanh_nghiep = random_nhan_su_doanh_nghiep();
            new_doanh_nghiep.thong_tin_thue = random_thong_tin_thue();
            new_doanh_nghiep.ngay_tao_ho_so = DateTime.Today.AddDays(random.Next(-100, 100));
            if (random.Next(100) % 2 == 0) { 
                new_doanh_nghiep.is_submitted = true; 
            } else new_doanh_nghiep.is_submitted = false;
            if (new_doanh_nghiep.is_submitted == true) { 
                if (random.Next(50) % 2 == 0) { 
                    new_doanh_nghiep.is_approved = true; 
                    new_doanh_nghiep.approved_time = new_doanh_nghiep.ngay_tao_ho_so.Value.AddDays(random.Next(1, 10)); 
                }
            }
            new_doanh_nghiep.von_dieu_le = random.Next(1000000, 100000000);
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                db.doanh_nghiep.Add(new_doanh_nghiep);
                db.SaveChanges();
            }
            random_nganh_nghe_dang_ky(new_doanh_nghiep);
            return new_doanh_nghiep;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Doanh nghiep
            doanh_nghiep new_doanh_nghiep = random_doanh_nghiep();
            OpenChildForm(new frm_danh_sach_ho_so_dang_ky(this, external_Account));

            if (new_doanh_nghiep == null)
            {
                MessageBox.Show("Doanh nghiệp chưa được tạo");
            }
        }
    }
}
