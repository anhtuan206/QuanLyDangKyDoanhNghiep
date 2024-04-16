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
    public partial class frm_quanly_dantoc : Form
    {
        public dan_toc dan_Toc = new dan_toc();
        object quoc_gia_selected = null;
        public int quoc_gia_id_selected = 0;

        public frm_quanly_dantoc()
        {
            InitializeComponent();
        }

        void grid_dan_toc_ds()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            {
                var query = from dt in db.dan_toc
                            join qt in db.quoc_tich on dt.id_quoc_tich equals qt.id
                            select new
                            {
                                dt.id,
                                dt.ten_dan_toc,
                                dt.id_quoc_tich,
                                qt.ten_quoc_tich
                            };
                grid_dan_toc.AutoGenerateColumns = false;
                grid_dan_toc.DataSource = query.ToList();
                grid_dan_toc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }

        void cbb_quoc_tich_ds()
        {
            using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
            { 
                List<quoc_tich> quoc_tich_list = db.quoc_tich.ToList();
                cbb_quoc_gia.DataSource = quoc_tich_list;
                cbb_quoc_gia.DisplayMember = "ten_quoc_tich";
                cbb_quoc_gia.ValueMember = "id";
            }
        }

        void clear_Form() {
            txt_ten_dan_toc.Text = string.Empty;
            btn_delete.Enabled = false;
            btn_createsave.Text = "Thêm dân tộc";
            quoc_gia_selected = null;
            quoc_gia_id_selected = 0;
            dan_Toc.id = 0;
            cbb_quoc_tich_ds();
            grid_dan_toc_ds();
        }

        private void frm_quanly_dantoc_Load(object sender, EventArgs e)
        {
            clear_Form();
        }

        private void btn_cancelchange_Click(object sender, EventArgs e)
        {
            clear_Form();

        }

        private void cbb_quoc_gia_SelectedIndexChanged(object sender, EventArgs e)
        {
            quoc_gia_selected = cbb_quoc_gia.SelectedValue;

            if (quoc_gia_selected != null && quoc_gia_selected.GetType() == typeof(int))
            {
                quoc_gia_id_selected = (int)cbb_quoc_gia.SelectedValue;
            }
        }

        bool validate_Form()
        {
            bool validate = true;
            if (quoc_gia_selected == null)
            {
                validate = false;
                MessageBox.Show("vui lòng chọn quốc gia");
                return validate;
            }

            if (quoc_gia_id_selected == 0)
            {
                validate = false ;
                MessageBox.Show("vui lòng chọn quốc gia");
                return validate;
            }

            if (txt_ten_dan_toc.Text.Trim().Length <= 0)
            {
                validate = false ;
                MessageBox.Show("Vui lòng nhập tên dân tộc");
                return validate;
            }
            return validate;
        }

        private void btn_createsave_Click(object sender, EventArgs e)
        {
            quoc_gia_selected = cbb_quoc_gia.SelectedValue;

            if (quoc_gia_selected != null && quoc_gia_selected.GetType() == typeof(int))
            {
                quoc_gia_id_selected = (int)cbb_quoc_gia.SelectedValue;
            }

            if (validate_Form())
            {
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    dan_Toc.ten_dan_toc = txt_ten_dan_toc.Text.Trim();
                    dan_Toc.id_quoc_tich = quoc_gia_id_selected;
                    if (dan_Toc.id == 0)
                    {
                        db.dan_toc.Add(dan_Toc);
                    }
                    else
                    {
                        db.Entry(dan_Toc).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                MessageBox.Show("Lưu dân tộc thành công!");
                clear_Form();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa dân tộc đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    var entry = db.Entry(dan_Toc);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.dan_toc.Attach(dan_Toc);
                        db.dan_toc.Remove(dan_Toc);
                        db.SaveChanges();
                        clear_Form();
                    }
                }
            }
        }

        private void grid_dan_toc_DoubleClick(object sender, EventArgs e)
        {
            if (grid_dan_toc.CurrentRow.Index != -1)
            {
                dan_Toc.id = Convert.ToInt32(grid_dan_toc.CurrentRow.Cells["id"].Value);
                using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                {
                    dan_Toc = db.dan_toc.Where(x => x.id == dan_Toc.id).FirstOrDefault();
                    txt_ten_dan_toc.Text = dan_Toc.ten_dan_toc;
                    cbb_quoc_gia.SelectedValue = dan_Toc.id_quoc_tich;
                }
                btn_createsave.Text = "Lưu thay đổi";
                btn_delete.Enabled = true;
            }
        }
    }
}
