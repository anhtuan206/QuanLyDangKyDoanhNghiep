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
    public partial class frm_edit_doanh_nghiep : Form
    {
        public frm_giaodien_doanhnghiep parentForm;
        public doanh_nghiep doanh_Nghiep = new doanh_nghiep();
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
        public frm_edit_doanh_nghiep(frm_giaodien_doanhnghiep parentForm,doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = doanh_Nghiep;
        }

        private void frm_edit_doanh_nghiep_Load(object sender, EventArgs e)
        {
            //OpenChildForm(new b1_chon_loai_hinh(this));
        }

        private void frm_edit_doanh_nghiep_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }
    }
}
