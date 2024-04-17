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

namespace QuanLyDangKyDoanhNghiep
{
    public partial class frm_giaodien_quantri : Form
    {
        public internal_account internal_Account;
        public frm_dangnhap frm_Dangnhap;
        public frm_giaodien_quantri(internal_account internal_Account,frm_dangnhap frm_Dangnhap)
        {
            InitializeComponent();
            this.frm_Dangnhap = frm_Dangnhap;
            this.internal_Account = internal_Account;
        }

        private void btn_quan_ly_danh_muc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_quanly_danhmuc frm_Quanly_Danhmuc = new frm_quanly_danhmuc(this,internal_Account);
            frm_Quanly_Danhmuc.Show();
        }

        private void frm_giaodien_quantri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Dangnhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_quan_ly_dang_ky_doanh_nghiep frm_Quan_Ly_Dang_Ky_Doanh_Nghiep = new frm_quan_ly_dang_ky_doanh_nghiep(this,internal_Account);
            frm_Quan_Ly_Dang_Ky_Doanh_Nghiep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_quanly_taikhoan_doanhnghiep frm_Quanly_Taikhoan_Doanhnghiep = new frm_quanly_taikhoan_doanhnghiep(this,internal_Account);
            frm_Quanly_Taikhoan_Doanhnghiep.Show();
        }
    }
}
