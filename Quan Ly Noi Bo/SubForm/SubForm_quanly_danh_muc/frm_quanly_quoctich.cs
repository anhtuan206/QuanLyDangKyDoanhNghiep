using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc
{
    public partial class frm_quanly_quoctich : Form
    {
        public quoc_tich quoc_Tich = new quoc_tich();

        public frm_quanly_quoctich()
        {
            InitializeComponent();
        }

        bool validate_Form()
        {
            bool validate = true;
            if (txt_ten_quoc_tich.Text.Trim().Length <= 0 )
            {
                validate = false;
                MessageBox.Show("Vui lòng nhập tên quốc gia");
                return validate;
            }
            return validate;
        }

        void clear_Form ()
        {
            txt_ten_quoc_tich.Text = string.Empty;
            btn_delete.Enabled = false;
            grid_quoc_tich_ds();
            quoc_Tich.id = 0;
            btn_createsave.Text = "Thêm quốc gia";
        }

        void grid_quoc_tich_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<quoc_tich> quoc_tich_list = db.quoc_tich.ToList<quoc_tich>();
                grid_quoc_tich.AutoGenerateColumns = false;
                grid_quoc_tich.DataSource = quoc_tich_list;
                grid_quoc_tich.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            if (validate_Form())
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    quoc_Tich.ten_quoc_tich = txt_ten_quoc_tich.Text.Trim();
                    if (quoc_Tich.id == 0)
                    {
                        db.quoc_tich.Add(quoc_Tich);
                    }
                    else
                    {
                        db.Entry(quoc_Tich).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Lưu quốc gia thành công");
                clear_Form();
            }
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form ();
        }

        private void frm_quanly_quoctich_Load(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void grid_quoc_tich_DoubleClick(object sender, EventArgs e)
        {
            if (grid_quoc_tich.CurrentRow.Index != -1 )
            {
                quoc_Tich.id = Convert.ToInt32(grid_quoc_tich.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    quoc_Tich = db.quoc_tich.Where(x => x.id == quoc_Tich.id).FirstOrDefault();
                    txt_ten_quoc_tich.Text = quoc_Tich.ten_quoc_tich;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa quốc gia đã chọn?","Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    var entry = db.Entry(quoc_Tich);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.quoc_tich.Attach(quoc_Tich);
                        db.quoc_tich.Remove(quoc_Tich);
                        db.SaveChanges();
                        clear_Form();
                    }
                }
            }
        }
    }
}
