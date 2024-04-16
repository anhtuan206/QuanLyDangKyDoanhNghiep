﻿using System;
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
        private frm_dang_ky_moi parentForm;
        private doanh_nghiep doanh_Nghiep;

        public b6_thong_tin_von(frm_dang_ky_moi parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.doanh_Nghiep = parentForm.doanh_Nghiep;

        }

        private void btn_buoc_tiep_theo_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new b7_nguoi_dai_dien_theo_phap_luat(parentForm));

        }

        private void btn_quay_lai_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new b5_chu_so_huu(parentForm));

        }

        private void btn_huy_dang_ky_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn không muốn tiếp tục?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (doanh_Nghiep.id != 0)
                {
                    using (tuanpa2_QuanLyDangKyDoanhNghiepEntities db = new tuanpa2_QuanLyDangKyDoanhNghiepEntities())
                    {
                        var entry = db.Entry(doanh_Nghiep);
                        if (entry.State == System.Data.Entity.EntityState.Detached)
                        {
                            db.doanh_nghiep.Attach(doanh_Nghiep);
                            db.doanh_nghiep.Remove(doanh_Nghiep);
                            db.SaveChanges();
                        }
                    }
                }
                parentForm.Close();
            }
        }
    }
}