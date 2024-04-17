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
    public partial class frm_dang_ky_moi : Form
    {
        public doanh_nghiep doanh_Nghiep;
        public frm_giaodien_doanhnghiep parentForm;
        public Form currentFormChild;
        int current_step = 0;
        public void OpenChildForm(Form childForm)
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

        public frm_dang_ky_moi(frm_giaodien_doanhnghiep parentForm, doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = doanh_Nghiep;
        }

        private void btn_buoc1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
        }

        private void frm_dang_ky_moi_Load(object sender, EventArgs e)
        {
            OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
            current_step = 1;
            btn_quay_lai.Visible = false;
        }

        private void frm_dang_ky_moi_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_dang_ky_moi_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btn_buoc2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b2_dia_chi(doanh_Nghiep));
            current_step = 2;
        }

        private void btn_buoc3_Click(object sender, EventArgs e)
        {
            current_step = 3;
            OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
        }

        private void btn_buoc4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
            current_step = 4;

        }

        private void btn_buoc5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
            current_step = 5;

        }

        private void btn_buoc6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
            current_step = 6;

        }

        private void btn_buoc7_Click(object sender, EventArgs e)
        {
            current_step = 7;
            OpenChildForm(new b7_nguoi_dai_dien_theo_phap_luat(doanh_Nghiep));
        }

        private void btn_buoc8_Click(object sender, EventArgs e)
        {
            current_step = 8;
            OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));

        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            if (current_step == 1)
            {
                current_step++;
                OpenChildForm(new b2_dia_chi(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 2)
            {
                current_step++;
                OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 3)
            {
                current_step++;
                OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 4)
            {
                current_step++;
                OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 5)
            {
                current_step++;
                OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 6)
            {
                current_step++;
                OpenChildForm(new b7_nguoi_dai_dien_theo_phap_luat(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 7)
            {
                current_step++;
                OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 8)
            {
                current_step++;
                OpenChildForm(new b9_bao_hiem_xa_hoi(doanh_Nghiep));
                btn_quay_lai.Visible = true;
                btn_buoc_tiep_theo.Visible = true;
                return;
            }
            if (current_step == 9)
            {
                current_step++;
                OpenChildForm(new b10_dang_ky_su_dung_hoa_don(doanh_Nghiep));
                btn_buoc_tiep_theo.Visible = false;
                btn_quay_lai.Visible = true;
                return;
            }
        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            if (current_step == 2)
            {
                current_step--;
                OpenChildForm(new b1_chon_loai_hinh(doanh_Nghiep));
                btn_quay_lai.Visible = false;
                btn_buoc_tiep_theo.Visible = true;

            }
            else
            {
                if (current_step == 3)
                {
                    current_step--;
                    OpenChildForm(new b2_dia_chi(doanh_Nghiep));
                    btn_quay_lai.Visible = true;
                    btn_buoc_tiep_theo.Visible = true;
                }
                else
                {

                    if (current_step == 4)
                    {
                        current_step--;
                        OpenChildForm(new b3_nganh_nghe(doanh_Nghiep));
                        btn_quay_lai.Visible = true;
                        btn_buoc_tiep_theo.Visible = true;
                    }
                    else
                    {
                        if (current_step == 5)
                        {
                            current_step--;
                            OpenChildForm(new b4_ten_doanh_nghiep(doanh_Nghiep));
                            btn_quay_lai.Visible = true;
                            btn_buoc_tiep_theo.Visible = true;
                        }
                        else
                        {

                            if (current_step == 6)
                            {
                                current_step--;
                                OpenChildForm(new b5_chu_so_huu(doanh_Nghiep));
                                btn_quay_lai.Visible = true;
                                btn_buoc_tiep_theo.Visible = true;
                            }
                            else
                            {

                                if (current_step == 7)
                                {
                                    current_step--;
                                    OpenChildForm(new b6_thong_tin_von(doanh_Nghiep));
                                    btn_quay_lai.Visible = true;
                                    btn_buoc_tiep_theo.Visible = true;
                                }
                                else
                                {
                                    if (current_step == 8)
                                    {
                                        current_step--;
                                        OpenChildForm(new b7_nguoi_dai_dien_theo_phap_luat(doanh_Nghiep));
                                        btn_quay_lai.Visible = true;
                                        btn_buoc_tiep_theo.Visible = true;
                                    }
                                    else
                                    {
                                        if (current_step == 9)
                                        {
                                            current_step--;
                                            OpenChildForm(new b8_thong_tin_thue(doanh_Nghiep));
                                            btn_quay_lai.Visible = true;
                                            btn_buoc_tiep_theo.Visible = true;
                                        }
                                        else
                                        {
                                            if (current_step == 10)
                                            {
                                                current_step--;
                                                OpenChildForm(new b9_bao_hiem_xa_hoi(doanh_Nghiep));
                                                btn_quay_lai.Visible = true;
                                                btn_buoc_tiep_theo.Visible = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
