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
    public partial class b6_thong_tin_von : Form
    {
        private doanh_nghiep doanh_Nghiep;

        public b6_thong_tin_von(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.doanh_Nghiep = doanh_Nghiep;

        }

        private void b6_thong_tin_von_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted == true) { btn_luu_tam.Enabled = false; btn_luu_tam.Visible = false; }

            if (doanh_Nghiep.von_dieu_le!=null)
            {
                textBox1.Text = doanh_Nghiep.von_dieu_le.ToString();
            }
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal decimalValue)) {
                if (decimalValue > 0)
                {
                    doanh_Nghiep.von_dieu_le = decimalValue;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    {
                        db.Entry(doanh_Nghiep).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Lưu dữ liệu thành công");

                    }
                }
                else { MessageBox.Show("Vốn điều lệ phải lớn hơn 0"); }

            }
            else { MessageBox.Show("Vốn điều lệ không hợp lệ"); }
        }
    }
}
