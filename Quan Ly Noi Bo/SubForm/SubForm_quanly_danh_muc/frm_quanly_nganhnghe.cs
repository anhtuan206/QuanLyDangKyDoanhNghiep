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
    public partial class frm_quanly_nganhnghe : Form
    {
        public nganh_nghe nganh_Nghe = new nganh_nghe();
        public frm_quanly_nganhnghe()
        {
            InitializeComponent();
        }


        void grid_nganh_nghe_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe> nganh_nghe_list = db.nganh_nghe.ToList<nganh_nghe>();
                grid_nganh_nghe.AutoGenerateColumns = false;
                grid_nganh_nghe.DataSource = nganh_nghe_list;
                grid_nganh_nghe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        void clear_Form()
        {
            //nganh_Nghe = null;
            nganh_Nghe.id = 0;
            txt_ten_nganh_nghe.Text = string.Empty;
            btn_delete.Enabled = false;
            btn_createsave.Text = "Thêm ngành nghề kinh doanh";
            grid_nganh_nghe_ds();
        }

        bool validate_Form()
        {
            bool validate = true;
            if (txt_ten_nganh_nghe.Text.Trim().Length <= 0)
            {
                validate = false;
                MessageBox.Show("Vui lòng nhập tên ngành nghề kinh doanh");
                return validate;
            }
            return validate;
        }
        private void frm_quanly_nganhnghe_Load(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            if (validate_Form())
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    nganh_Nghe.ten_nganh_nghe = txt_ten_nganh_nghe.Text.Trim();
                    if (nganh_Nghe.id == 0)
                    {
                        db.nganh_nghe.Add(nganh_Nghe);
                    }
                    else
                    {
                        db.Entry(nganh_Nghe).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Lưu ngành nghề kinh doanh thành công!");
                clear_Form();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa ngành nghề đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    //var entry = db.Entry(nganh_Nghe);
                    //if (entry.State == System.Data.Entity.EntityState.Detached)
                    //{
                    //    db.nganh_nghe.Attach(nganh_Nghe);
                    //}
                    db.nganh_nghe.Remove(nganh_Nghe);
                    db.SaveChanges();
                    clear_Form();
                }
            }
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void grid_nganh_nghe_DoubleClick(object sender, EventArgs e)
        {
            if (grid_nganh_nghe.CurrentRow.Index != -1)
            {
                nganh_Nghe.id = Convert.ToInt32(grid_nganh_nghe.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    nganh_Nghe = db.nganh_nghe.Where(x => x.id == nganh_Nghe.id).FirstOrDefault();
                    txt_ten_nganh_nghe.Text = nganh_Nghe.ten_nganh_nghe;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }

        
    }
}
