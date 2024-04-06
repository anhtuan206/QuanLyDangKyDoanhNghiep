using QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc;
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
    public partial class frm_quanly_danhmuc : Form
    {

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

        private Form parentForm;

        public frm_quanly_danhmuc(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frm_quanlydanhmuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_taikhoan_noibo.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_taikhoan_noibo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_danhmuc_nhanvien.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_nhanvien());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_danhmuc_quoctich.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_quoctich());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_danhmuc_dantoc.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_dantoc());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_danhmuc_nganhnghe.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_nganhnghe());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset_button_style();
            btn_danhmuc_loaihinh.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_loaihinh());
        }
        void reset_button_style()
        {
            btn_danhmuc_dantoc.BackColor = default;
            btn_danhmuc_loaihinh.BackColor = default;
            btn_danhmuc_nganhnghe.BackColor = default;
            btn_danhmuc_nhanvien.BackColor = default;
            btn_danhmuc_quoctich.BackColor = default;
            btn_taikhoan_noibo.BackColor = default;
        }

        private void frm_quanly_danhmuc_Load(object sender, EventArgs e)
        {
            reset_button_style();
            btn_taikhoan_noibo.BackColor = SystemColors.Highlight;
            OpenChildForm(new frm_quanly_taikhoan_noibo());
        }
    }
}
