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

        public b6_thong_tin_von(doanh_nghiep doanh_Nghiep)
        {
            InitializeComponent();
            //this.parentForm = parentForm;
            this.doanh_Nghiep = doanh_Nghiep;

        }
    }
}
