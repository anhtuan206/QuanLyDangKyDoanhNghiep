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
    public partial class frm_giaodien_quantri : Form
    {
        public frm_giaodien_quantri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form quanly_danhmuc = new frm_quanlydanhmuc(this);
            quanly_danhmuc.Show();
        }

        private void frm_giaodien_quantri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
