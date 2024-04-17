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
        public external_account external_Account;
        public doanh_nghiep doanh_Nghiep = new doanh_nghiep();
        public frm_dang_ky_doanh_nghiep(frm_giaodien_doanhnghiep parentForm, external_account external_Account)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.external_Account = external_Account;
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
                doanh_Nghiep.external_account_id = external_Account.id;
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    db.doanh_nghiep.Add(doanh_Nghiep);
                    db.SaveChanges();
                }
                parentForm.Hide();
                frm_dang_ky_moi frm_dang_ky_moi = new frm_dang_ky_moi(parentForm,doanh_Nghiep);
                frm_dang_ky_moi.Show();
            }
            else
                MessageBox.Show("Tính năng này chưa được phát triển");
            
        }
    }
}
