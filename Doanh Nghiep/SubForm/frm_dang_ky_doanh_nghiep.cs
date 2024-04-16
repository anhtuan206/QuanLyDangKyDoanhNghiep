using QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep
{
    public partial class frm_dang_ky_doanh_nghiep : Form
    {
        public frm_giaodien_doanhnghiep parentForm;
        public frm_dang_ky_doanh_nghiep(frm_giaodien_doanhnghiep parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void rdo_thay_doi_noi_dung_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_thay_doi_noi_dung.Checked)
                lbl_mo_ta.Visible = true;
            else lbl_mo_ta.Visible = false;
        }

        private void frm_dang_ky_doanh_nghiep_Load(object sender, EventArgs e)
        {
            rdo_dang_ky_moi.Checked = true;
        }

        private void btn_bat_dau_Click(object sender, EventArgs e)
        {
            if (rdo_dang_ky_moi.Checked==true)
            {
                parentForm.Hide();
                Form frm_dang_ky_moi = new frm_dang_ky_moi(parentForm);
                frm_dang_ky_moi.Show();
            }
            else
                MessageBox.Show("Tính năng này chưa được phát triển");
            
        }
    }
}
