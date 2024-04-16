namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep
{
    partial class frm_dang_ky_doanh_nghiep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dang_ky_doanh_nghiep));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_bat_dau = new System.Windows.Forms.Button();
            this.lbl_mo_ta = new System.Windows.Forms.Label();
            this.rdo_thay_doi_noi_dung = new System.Windows.Forms.RadioButton();
            this.rdo_cap_lai_giay = new System.Windows.Forms.RadioButton();
            this.rdo_dang_ky_moi = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 41);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký doanh nghiệp";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.btn_bat_dau);
            this.panel3.Controls.Add(this.lbl_mo_ta);
            this.panel3.Controls.Add(this.rdo_thay_doi_noi_dung);
            this.panel3.Controls.Add(this.rdo_cap_lai_giay);
            this.panel3.Controls.Add(this.rdo_dang_ky_moi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 382);
            this.panel3.TabIndex = 8;
            // 
            // btn_bat_dau
            // 
            this.btn_bat_dau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_bat_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bat_dau.Location = new System.Drawing.Point(17, 290);
            this.btn_bat_dau.Name = "btn_bat_dau";
            this.btn_bat_dau.Size = new System.Drawing.Size(246, 42);
            this.btn_bat_dau.TabIndex = 17;
            this.btn_bat_dau.Text = "Bắt đầu";
            this.btn_bat_dau.UseVisualStyleBackColor = false;
            this.btn_bat_dau.Click += new System.EventHandler(this.btn_bat_dau_Click);
            // 
            // lbl_mo_ta
            // 
            this.lbl_mo_ta.AutoSize = true;
            this.lbl_mo_ta.Location = new System.Drawing.Point(34, 140);
            this.lbl_mo_ta.Name = "lbl_mo_ta";
            this.lbl_mo_ta.Size = new System.Drawing.Size(190, 117);
            this.lbl_mo_ta.TabIndex = 15;
            this.lbl_mo_ta.Text = resources.GetString("lbl_mo_ta.Text");
            this.lbl_mo_ta.Visible = false;
            // 
            // rdo_thay_doi_noi_dung
            // 
            this.rdo_thay_doi_noi_dung.AutoSize = true;
            this.rdo_thay_doi_noi_dung.Location = new System.Drawing.Point(17, 109);
            this.rdo_thay_doi_noi_dung.Name = "rdo_thay_doi_noi_dung";
            this.rdo_thay_doi_noi_dung.Size = new System.Drawing.Size(346, 17);
            this.rdo_thay_doi_noi_dung.TabIndex = 13;
            this.rdo_thay_doi_noi_dung.TabStop = true;
            this.rdo_thay_doi_noi_dung.Text = "Đăng ký thay đổi nội dung đăng ký doanh nghiệp/đơn vị trực thuộc";
            this.rdo_thay_doi_noi_dung.UseVisualStyleBackColor = true;
            this.rdo_thay_doi_noi_dung.CheckedChanged += new System.EventHandler(this.rdo_thay_doi_noi_dung_CheckedChanged);
            // 
            // rdo_cap_lai_giay
            // 
            this.rdo_cap_lai_giay.AutoSize = true;
            this.rdo_cap_lai_giay.Location = new System.Drawing.Point(17, 70);
            this.rdo_cap_lai_giay.Name = "rdo_cap_lai_giay";
            this.rdo_cap_lai_giay.Size = new System.Drawing.Size(256, 17);
            this.rdo_cap_lai_giay.TabIndex = 11;
            this.rdo_cap_lai_giay.TabStop = true;
            this.rdo_cap_lai_giay.Text = "Đăng ký cấp lại Giấy chứng nhận/Giấy xác nhận";
            this.rdo_cap_lai_giay.UseVisualStyleBackColor = true;
            // 
            // rdo_dang_ky_moi
            // 
            this.rdo_dang_ky_moi.AutoSize = true;
            this.rdo_dang_ky_moi.Location = new System.Drawing.Point(17, 31);
            this.rdo_dang_ky_moi.Name = "rdo_dang_ky_moi";
            this.rdo_dang_ky_moi.Size = new System.Drawing.Size(246, 17);
            this.rdo_dang_ky_moi.TabIndex = 9;
            this.rdo_dang_ky_moi.TabStop = true;
            this.rdo_dang_ky_moi.Text = "Thành lập mới doanh nghiệp/đơn vị trực thuộc";
            this.rdo_dang_ky_moi.UseVisualStyleBackColor = true;
            // 
            // frm_dang_ky_doanh_nghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 423);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frm_dang_ky_doanh_nghiep";
            this.Text = "frm_dang_ky_doanh_nghiep";
            this.Load += new System.EventHandler(this.frm_dang_ky_doanh_nghiep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_bat_dau;
        private System.Windows.Forms.Label lbl_mo_ta;
        private System.Windows.Forms.RadioButton rdo_thay_doi_noi_dung;
        private System.Windows.Forms.RadioButton rdo_cap_lai_giay;
        private System.Windows.Forms.RadioButton rdo_dang_ky_moi;
    }
}