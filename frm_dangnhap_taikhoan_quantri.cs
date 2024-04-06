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
    public partial class frm_dangnhap_taikhoan_quantri : Form
    {
        private Form parentForm;

        public frm_dangnhap_taikhoan_quantri(Form parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Hide();
            Form giaodien_quantri = new frm_giaodien_quantri();
            giaodien_quantri.Show();
        }
    }
}
