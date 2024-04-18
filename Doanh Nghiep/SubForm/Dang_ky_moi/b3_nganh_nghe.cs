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
    public partial class b3_nganh_nghe : Form
    {
        //private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;

        private nganh_nghe_dangky nganh_Nghe_Dangky = new nganh_nghe_dangky();

        private int selected_nganh_nghe_cap_1_id = 0;
        private int selected_nganh_nghe_cap_2_id = 0;
        private int selected_nganh_nghe_cap_3_id = 0;
        private int selected_nganh_nghe_cap_4_id = 0;
        private int selected_nganh_nghe_cap_5_id = 0;



        public b3_nganh_nghe(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            //this.parentForm = parentForm;
            this.doanh_Nghiep = doanh_Nghiep;
        }

        private void ckb_nganh_nghe_khac_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_nganh_nghe_khac.Checked == true)
            {
                txt_nganh_nghe_khac.Enabled = true;
                txt_nganh_nghe_khac.Visible = true;
                cbb_nganh_nghe_cap_1.Enabled = false;
                cbb_nganh_nghe_cap_2.Enabled = false;
                cbb_nganh_nghe_cap_3.Enabled = false;
                cbb_nganh_nghe_cap_4.Enabled = false;
                cbb_nganh_nghe_cap_5.Enabled = false;
            }
            else
            {
                txt_nganh_nghe_khac.Enabled = false;
                txt_nganh_nghe_khac .Visible = false;
                cbb_nganh_nghe_cap_1.Enabled = true;
                cbb_nganh_nghe_cap_2.Enabled = true;
                cbb_nganh_nghe_cap_3.Enabled = true;
                cbb_nganh_nghe_cap_4.Enabled = true;
                cbb_nganh_nghe_cap_5.Enabled = true;
            }
        }

        private void cbb_nganh_nghe_cap_1_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe> cbb_list = db.nganh_nghe.Where(item => item.cap_do == 1).ToList();
                if (cbb_list.Count > 0)
                {
                    cbb_nganh_nghe_cap_1.DataSource = cbb_list;
                    cbb_nganh_nghe_cap_1.DisplayMember = "ten_nganh_nghe";
                    cbb_nganh_nghe_cap_1.ValueMember = "id";
                    cbb_nganh_nghe_cap_1.SelectedIndex = 0;
                    selected_nganh_nghe_cap_1_id = (int)cbb_nganh_nghe_cap_1.SelectedValue;
                }
            }
        }
        private void cbb_nganh_nghe_cap_2_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                if (selected_nganh_nghe_cap_1_id!=0)
                {
                    List<nganh_nghe> cbb_list = db.nganh_nghe.Where(item => item.cap_do == 2 && item.id_nganh_nghe == selected_nganh_nghe_cap_1_id).ToList();
                    if (cbb_list.Count > 0)
                    {
                        cbb_nganh_nghe_cap_2.DataSource = cbb_list;
                        cbb_nganh_nghe_cap_2.DisplayMember = "ten_nganh_nghe";
                        cbb_nganh_nghe_cap_2.ValueMember = "id";
                        cbb_nganh_nghe_cap_2.SelectedIndex = 0;
                        selected_nganh_nghe_cap_2_id = (int)cbb_nganh_nghe_cap_2.SelectedValue;

                    }
                }
            }
        }
        private void cbb_nganh_nghe_cap_3_ds()
        {
            if (selected_nganh_nghe_cap_2_id!=0)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    List<nganh_nghe> cbb_list = db.nganh_nghe.Where(item => item.cap_do == 3 && item.id_nganh_nghe == selected_nganh_nghe_cap_2_id).ToList();
                    if (cbb_list.Count > 0)
                    {
                        cbb_nganh_nghe_cap_3.DataSource = cbb_list;
                        cbb_nganh_nghe_cap_3.DisplayMember = "ten_nganh_nghe";
                        cbb_nganh_nghe_cap_3.ValueMember = "id";
                        cbb_nganh_nghe_cap_3.SelectedIndex = 0;
                        selected_nganh_nghe_cap_3_id = (int)cbb_nganh_nghe_cap_3.SelectedValue;

                    }
                }
            }
        }
        private void cbb_nganh_nghe_cap_4_ds()
        {
            if (selected_nganh_nghe_cap_3_id !=0)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    List<nganh_nghe> cbb_list = db.nganh_nghe.Where(item => item.cap_do == 4 && item.id_nganh_nghe == selected_nganh_nghe_cap_3_id).ToList();
                    if (cbb_list.Count > 0)
                    {
                        cbb_nganh_nghe_cap_4.DataSource = cbb_list;
                        cbb_nganh_nghe_cap_4.DisplayMember = "ten_nganh_nghe";
                        cbb_nganh_nghe_cap_4.ValueMember = "id";
                        cbb_nganh_nghe_cap_4.SelectedIndex = 0;
                        selected_nganh_nghe_cap_4_id = (int)cbb_nganh_nghe_cap_4.SelectedValue;

                    }
                }

            }
        }

        private void cbb_nganh_nghe_cap_5_ds()
        {
            if (selected_nganh_nghe_cap_4_id!=0)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    List<nganh_nghe> cbb_list = db.nganh_nghe.Where(item => item.cap_do == 5 && item.id_nganh_nghe == selected_nganh_nghe_cap_4_id).ToList();
                    if (cbb_list.Count > 0)
                    {
                        cbb_nganh_nghe_cap_4.Visible = true;
                        cbb_nganh_nghe_cap_5.DataSource = cbb_list;
                        cbb_nganh_nghe_cap_5.DisplayMember = "ten_nganh_nghe";
                        cbb_nganh_nghe_cap_5.ValueMember = "id";
                        cbb_nganh_nghe_cap_5.SelectedIndex = 0;
                        selected_nganh_nghe_cap_5_id = (int)cbb_nganh_nghe_cap_5.SelectedValue;

                    }
                    else
                    {
                        cbb_list = db.nganh_nghe.Where(item => item.cap_do == 4 && item.id_nganh_nghe == selected_nganh_nghe_cap_3_id).ToList();
                        if (cbb_list.Count > 0)
                        {
                            cbb_nganh_nghe_cap_4.Visible = false;
                            cbb_nganh_nghe_cap_5.DataSource = cbb_list;
                            cbb_nganh_nghe_cap_5.DisplayMember = "ten_nganh_nghe";
                            cbb_nganh_nghe_cap_5.ValueMember = "id";
                            cbb_nganh_nghe_cap_5.SelectedIndex = 0;
                            selected_nganh_nghe_cap_5_id = (int)cbb_nganh_nghe_cap_5.SelectedValue;
                        }
                        else
                        {
                            cbb_list = db.nganh_nghe.Where(item => item.cap_do == 3 && item.id_nganh_nghe == selected_nganh_nghe_cap_2_id).ToList();
                            if (cbb_list.Count > 0)
                            {
                                cbb_nganh_nghe_cap_4.Visible = false;
                                cbb_nganh_nghe_cap_3.Visible = false;
                                cbb_nganh_nghe_cap_5.DataSource = cbb_list;
                                cbb_nganh_nghe_cap_5.DisplayMember = "ten_nganh_nghe";
                                cbb_nganh_nghe_cap_5.ValueMember = "id";
                                cbb_nganh_nghe_cap_5.SelectedIndex = 0;
                                selected_nganh_nghe_cap_5_id = (int)cbb_nganh_nghe_cap_5.SelectedValue;
                            }
                        }
                    }
                }

            }
        }


        private void grid_nganh_nghe_dang_ky_ds()
        {
            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                var query = from nndk in db.nganh_nghe_dangky
                            where nndk.id_doanh_nghiep == doanh_Nghiep.id
                            select new
                            {
                                nndk.id,
                                nndk.id_nganh_nghe,
                                nndk.is_nganh_nghe_khac,
                                nndk.nganh_nghe_khac,
                                nndk.id_doanh_nghiep
                            };
                grid_nganh_nghe_dang_ky.AutoGenerateColumns = false;
                grid_nganh_nghe_dang_ky.DataSource = query.ToList();
                grid_nganh_nghe_dang_ky.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        private void b3_nganh_nghe_Load(object sender, EventArgs e)
        {
            if (doanh_Nghiep.is_submitted == true) { btn_luu_tam.Enabled = false; btn_luu_tam.Visible = false; }

            nganh_Nghe_Dangky.id = 0;
            grid_nganh_nghe_dang_ky_ds();
            cbb_nganh_nghe_cap_1_ds();
            cbb_nganh_nghe_cap_2_ds();
            cbb_nganh_nghe_cap_3_ds();
            cbb_nganh_nghe_cap_4_ds();
            cbb_nganh_nghe_cap_5_ds();
            btn_xoa_nganh_nghe_dang_ky.Enabled = false;
            btn_them_nganh_nghe_dang_ky.Enabled = true;
        }

        private void grid_nganh_nghe_dang_ky_DoubleClick(object sender, EventArgs e)
        {
            
            if (grid_nganh_nghe_dang_ky.CurrentRow.Index != -1)
            {
                nganh_Nghe_Dangky.id = Convert.ToInt32(grid_nganh_nghe_dang_ky.CurrentRow.Cells["id"].Value);
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    nganh_Nghe_Dangky = db.nganh_nghe_dangky.Where(item => item.id == nganh_Nghe_Dangky.id).FirstOrDefault();
                }
                btn_xoa_nganh_nghe_dang_ky.Enabled = true;
                btn_them_nganh_nghe_dang_ky.Enabled = false;
                cbb_nganh_nghe_cap_1.Enabled = false;
                cbb_nganh_nghe_cap_2.Enabled = false;
                cbb_nganh_nghe_cap_3.Enabled = false;
                cbb_nganh_nghe_cap_4.Enabled = false;
                cbb_nganh_nghe_cap_5.Enabled = false;
                ckb_nganh_nghe_khac.Enabled = false;
                txt_nganh_nghe_khac.Enabled = false;

            }
        }

        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            btn_xoa_nganh_nghe_dang_ky.Enabled = false;
            btn_them_nganh_nghe_dang_ky.Enabled = true;
            cbb_nganh_nghe_cap_1.Enabled = true;
            cbb_nganh_nghe_cap_2.Enabled = true;
            cbb_nganh_nghe_cap_3.Enabled = true;
            cbb_nganh_nghe_cap_4.Enabled = true;
            cbb_nganh_nghe_cap_5.Enabled = true;
            ckb_nganh_nghe_khac.Checked = false;
            txt_nganh_nghe_khac.Visible = false;
            ckb_nganh_nghe_khac.Enabled = true;
            txt_nganh_nghe_khac.Enabled = true;
            
        }

        private bool validate_nganh_nghe_dang_ky ()
        {
            bool is_valid = true;
            if (doanh_Nghiep == null || doanh_Nghiep.id == 0) { 
                is_valid = false;
                MessageBox.Show("Có lỗi liên quan đến id của doanh nghiệp");
                return is_valid;
            }
            if (ckb_nganh_nghe_khac.Checked == true)
            {
                if (txt_nganh_nghe_khac.Text.Trim().Length <= 0)
                {
                    is_valid = false;
                    MessageBox.Show("Vui lòng nhập thông tin ngành nghề khác");
                    return is_valid == false;
                }
                else
                {
                    if (selected_nganh_nghe_cap_5_id==0)
                    {
                        is_valid = false;
                        MessageBox.Show("Vui lòng chọn ngành nghề");
                        return is_valid;
                    }
                }
            }

            using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
            {
                List<nganh_nghe_dangky> nganh_Nghe_Dangkies = db.nganh_nghe_dangky.Where(item => item.id_doanh_nghiep == doanh_Nghiep.id).ToList();
                foreach (nganh_nghe_dangky item in nganh_Nghe_Dangkies)
                {
                    if (item.is_nganh_nghe_khac == false)
                    {
                        if (item.id_nganh_nghe == selected_nganh_nghe_cap_5_id) { 
                            is_valid = false;
                            MessageBox.Show("Ngành nghề đã được đăng ký");
                            return is_valid;
                        }
                    } else
                    {
                        if (item.nganh_nghe_khac.ToLower() == txt_nganh_nghe_khac.Text.ToLower())
                        {
                            is_valid = false;
                            MessageBox.Show("Ngành nghề đã được đăng ký");
                            return is_valid;
                        }
                    }
                }
            }
            return is_valid;
        }

        private void btn_them_nganh_nghe_dang_ky_Click(object sender, EventArgs e)
        {
            if (validate_nganh_nghe_dang_ky()==true)
            {
                nganh_Nghe_Dangky.id = 0;
                nganh_Nghe_Dangky.id_doanh_nghiep = doanh_Nghiep.id;
                if (ckb_nganh_nghe_khac.Checked == false)
                {

                    nganh_Nghe_Dangky.id_nganh_nghe = selected_nganh_nghe_cap_5_id;
                    nganh_Nghe_Dangky.is_nganh_nghe_khac = false;
                    using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                    { 
                        nganh_nghe tmp_nganh_nghe = db.nganh_nghe.Where(item => item.id == selected_nganh_nghe_cap_5_id).FirstOrDefault();
                        nganh_Nghe_Dangky.nganh_nghe_khac = tmp_nganh_nghe.ten_nganh_nghe;
                    }

                }
                else
                {
                    nganh_Nghe_Dangky.is_nganh_nghe_khac = true;
                    nganh_Nghe_Dangky.nganh_nghe_khac = txt_nganh_nghe_khac.Text.Trim();
                }

                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    db.nganh_nghe_dangky.Add(nganh_Nghe_Dangky);
                    db.SaveChanges();
                    nganh_Nghe_Dangky.id = 0;
                    grid_nganh_nghe_dang_ky_ds();
                    btn_xoa_nganh_nghe_dang_ky.Enabled = false;
                    btn_them_nganh_nghe_dang_ky.Enabled = true;
                    cbb_nganh_nghe_cap_1.Enabled = true;
                    cbb_nganh_nghe_cap_2.Enabled = true;
                    cbb_nganh_nghe_cap_3.Enabled = true;
                    cbb_nganh_nghe_cap_4.Enabled = true;
                    cbb_nganh_nghe_cap_5.Enabled = true;
                }
            }
        }

        private void btn_xoa_nganh_nghe_dang_ky_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa ngành nghề đã chọn?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (QuanLyDangKyDoanhNghiepEntities db = new QuanLyDangKyDoanhNghiepEntities())
                {
                    //var entry = db.Entry(nganh_Nghe_Dangky);
                    //if (entry.State == System.Data.Entity.EntityState.Detached)
                    //{
                    //    db.nganh_nghe_dangky.Attach(nganh_Nghe_Dangky);
                    //}
                    nganh_Nghe_Dangky = db.nganh_nghe_dangky.Where(item => item.id == nganh_Nghe_Dangky.id).FirstOrDefault();
                    db.nganh_nghe_dangky.Remove(nganh_Nghe_Dangky);
                    db.SaveChanges();
                    grid_nganh_nghe_dang_ky_ds();
                    btn_xoa_nganh_nghe_dang_ky.Enabled = false;
                    btn_them_nganh_nghe_dang_ky.Enabled = true;
                    cbb_nganh_nghe_cap_1.Enabled = true;
                    cbb_nganh_nghe_cap_2.Enabled = true;
                    cbb_nganh_nghe_cap_3.Enabled = true;
                    cbb_nganh_nghe_cap_4.Enabled = true;
                    cbb_nganh_nghe_cap_5.Enabled = true;
                    ckb_nganh_nghe_khac.Checked = false;
                    txt_nganh_nghe_khac.Text = string.Empty;
                    txt_nganh_nghe_khac.Visible = false;
                }
            }
        }

        private void cbb_nganh_nghe_cap_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cbb_selected = cbb_nganh_nghe_cap_1.SelectedValue;
            if (cbb_selected != null && cbb_selected.GetType() == typeof(int)) { 
                selected_nganh_nghe_cap_1_id = (int)cbb_nganh_nghe_cap_1.SelectedValue;
                cbb_nganh_nghe_cap_2_ds();
            }

        }

        private void cbb_nganh_nghe_cap_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cbb_selected = cbb_nganh_nghe_cap_2.SelectedValue;
            if (cbb_selected != null && cbb_selected.GetType() == typeof(int)) { 
                selected_nganh_nghe_cap_2_id = (int)cbb_nganh_nghe_cap_2.SelectedValue;
                cbb_nganh_nghe_cap_3_ds();
            }
        }

        private void cbb_nganh_nghe_cap_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cbb_selected = cbb_nganh_nghe_cap_3.SelectedValue;
            if (cbb_selected != null && cbb_selected.GetType() == typeof(int)) { 
                selected_nganh_nghe_cap_3_id = (int)cbb_nganh_nghe_cap_3.SelectedValue;
                cbb_nganh_nghe_cap_4_ds();
            }
        }

        private void cbb_nganh_nghe_cap_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cbb_selected = cbb_nganh_nghe_cap_4.SelectedValue;
            if (cbb_selected != null && cbb_selected.GetType() == typeof(int)) { 
                selected_nganh_nghe_cap_4_id = (int)cbb_nganh_nghe_cap_4.SelectedValue;
                cbb_nganh_nghe_cap_5_ds();
            }
        }

        private void cbb_nganh_nghe_cap_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cbb_selected = cbb_nganh_nghe_cap_5.SelectedValue;
            if (cbb_selected != null && cbb_selected.GetType() == typeof(int)) { 
                selected_nganh_nghe_cap_5_id = (int)cbb_nganh_nghe_cap_5.SelectedValue;
            }
        }

        private void btn_luu_tam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu hồ sơ thành công");
        }
    }
}
