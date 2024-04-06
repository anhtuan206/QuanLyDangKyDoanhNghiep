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
    public partial class frm_dangnhap_taikhoan_doanhnghiep : Form
    {
        private Form parentForm;

        public frm_dangnhap_taikhoan_doanhnghiep(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Hide();
            Form giaodien_doanhnghiep = new frm_giaodien_doanhnghiep();
            giaodien_doanhnghiep.Show();
        }
    }
}
