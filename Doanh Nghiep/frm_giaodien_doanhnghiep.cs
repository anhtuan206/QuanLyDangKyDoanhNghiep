using QuanLyDangKyDoanhNghiep.Doanh_Nghiep;
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
            this.external_Account  = external_Account;
            this.parentForm = parentForm;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
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
            OpenChildForm(new frm_dang_ky_doanh_nghiep(this,external_Account));
        }

        private void frm_giaodien_doanhnghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btn_danh_sach_ho_so_dang_ky_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_danh_sach_ho_so_dang_ky(this,external_Account));
        }

        private void frm_giaodien_doanhnghiep_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dang_ky_doanh_nghiep(this,external_Account));
            btn_dang_ky_doanh_nghiep.Focus();
        }
    }
}
