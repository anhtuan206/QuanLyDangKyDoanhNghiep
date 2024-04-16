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
    public partial class frm_dang_ky_moi : Form
    {
        public doanh_nghiep doanh_Nghiep = new doanh_nghiep();
        private frm_giaodien_doanhnghiep parentForm;
        public Form currentFormChild;
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

        public frm_dang_ky_moi(frm_giaodien_doanhnghiep parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btn_buoc1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b1_chon_loai_hinh(this));
        }

        private void frm_dang_ky_moi_Load(object sender, EventArgs e)
        {
            OpenChildForm(new b1_chon_loai_hinh(this));
        }

        private void frm_dang_ky_moi_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_dang_ky_moi_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btn_buoc2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b2_dia_chi(this));
        }

        private void btn_buoc3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b3_nganh_nghe(this));
        }

        private void btn_buoc4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b4_ten_doanh_nghiep(this));

        }

        private void btn_buoc5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b5_chu_so_huu(this));

        }

        private void btn_buoc6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b6_thong_tin_von(this));

        }

        private void btn_buoc7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b7_nguoi_dai_dien_theo_phap_luat(this));

        }

        private void btn_buoc8_Click(object sender, EventArgs e)
        {

        }
    }
}
