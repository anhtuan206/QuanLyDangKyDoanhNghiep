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
    public partial class frm_quanlydanhmuc : Form
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

        public frm_quanlydanhmuc(Form parentForm)
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
            OpenChildForm(new frm_quanly_taikhoan_noibo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_quanly_nhanvien());
        }
    }
}
