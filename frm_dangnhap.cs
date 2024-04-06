﻿using System;
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
    public partial class frm_dangnhap : Form
    {

        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
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

        private void btn_dangnhaptaikhoanquantri_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dangnhap_taikhoan_quantri(this));
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dangnhap_taikhoan_quantri(this));
        }

        private void btn_dangnhaptaikhoandoanhnghiep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dangnhap_taikhoan_doanhnghiep(this));
        }

        private void btn_dangkytaikhoandoanhnghiep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_dangkytaikhoandoanhnghiep(this));
        }
    }
}
