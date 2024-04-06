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
    public partial class frm_dangkytaikhoandoanhnghiep : Form
    {
        private Form parentForm;

        public frm_dangkytaikhoandoanhnghiep(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký tài khoản thành công! Chọn đăng nhập tài khoản doanh nghiệp và đăng nhập với tài khoản vừa tạo.");
        }
    }
}
