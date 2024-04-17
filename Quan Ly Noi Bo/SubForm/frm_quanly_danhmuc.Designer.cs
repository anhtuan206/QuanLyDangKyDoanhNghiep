namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_quanly_danhmuc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_danhmuc_nganhnghe = new System.Windows.Forms.Button();
            this.btn_danhmuc_nhanvien = new System.Windows.Forms.Button();
            this.btn_danhmuc_dantoc = new System.Windows.Forms.Button();
            this.btn_danhmuc_quoctich = new System.Windows.Forms.Button();
            this.btn_taikhoan_noibo = new System.Windows.Forms.Button();
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.btn_danhmuc_loaihinh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý danh mục";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_danhmuc_loaihinh);
            this.panel2.Controls.Add(this.btn_danhmuc_nganhnghe);
            this.panel2.Controls.Add(this.btn_danhmuc_nhanvien);
            this.panel2.Controls.Add(this.btn_danhmuc_dantoc);
            this.panel2.Controls.Add(this.btn_danhmuc_quoctich);
            this.panel2.Controls.Add(this.btn_taikhoan_noibo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 520);
            this.panel2.TabIndex = 1;
            // 
            // btn_danhmuc_nganhnghe
            // 
            this.btn_danhmuc_nganhnghe.Location = new System.Drawing.Point(3, 154);
            this.btn_danhmuc_nganhnghe.Name = "btn_danhmuc_nganhnghe";
            this.btn_danhmuc_nganhnghe.Size = new System.Drawing.Size(200, 31);
            this.btn_danhmuc_nganhnghe.TabIndex = 4;
            this.btn_danhmuc_nganhnghe.Text = "Danh mục ngành nghề";
            this.btn_danhmuc_nganhnghe.UseVisualStyleBackColor = true;
            this.btn_danhmuc_nganhnghe.Click += new System.EventHandler(this.btn_danhmuc_nganhnghe_Click);
            // 
            // btn_danhmuc_nhanvien
            // 
            this.btn_danhmuc_nhanvien.Location = new System.Drawing.Point(3, 117);
            this.btn_danhmuc_nhanvien.Name = "btn_danhmuc_nhanvien";
            this.btn_danhmuc_nhanvien.Size = new System.Drawing.Size(200, 31);
            this.btn_danhmuc_nhanvien.TabIndex = 3;
            this.btn_danhmuc_nhanvien.Text = "Nhân viên";
            this.btn_danhmuc_nhanvien.UseVisualStyleBackColor = true;
            this.btn_danhmuc_nhanvien.Click += new System.EventHandler(this.btn_danhmuc_nhanvien_Click);
            // 
            // btn_danhmuc_dantoc
            // 
            this.btn_danhmuc_dantoc.Location = new System.Drawing.Point(3, 80);
            this.btn_danhmuc_dantoc.Name = "btn_danhmuc_dantoc";
            this.btn_danhmuc_dantoc.Size = new System.Drawing.Size(200, 31);
            this.btn_danhmuc_dantoc.TabIndex = 2;
            this.btn_danhmuc_dantoc.Text = "Dân tộc";
            this.btn_danhmuc_dantoc.UseVisualStyleBackColor = true;
            this.btn_danhmuc_dantoc.Click += new System.EventHandler(this.btn_danhmuc_dantoc_Click);
            // 
            // btn_danhmuc_quoctich
            // 
            this.btn_danhmuc_quoctich.Location = new System.Drawing.Point(3, 43);
            this.btn_danhmuc_quoctich.Name = "btn_danhmuc_quoctich";
            this.btn_danhmuc_quoctich.Size = new System.Drawing.Size(200, 31);
            this.btn_danhmuc_quoctich.TabIndex = 1;
            this.btn_danhmuc_quoctich.Text = "Quốc tịch";
            this.btn_danhmuc_quoctich.UseVisualStyleBackColor = true;
            this.btn_danhmuc_quoctich.Click += new System.EventHandler(this.btn_danhmuc_quoctich_Click);
            // 
            // btn_taikhoan_noibo
            // 
            this.btn_taikhoan_noibo.Location = new System.Drawing.Point(3, 6);
            this.btn_taikhoan_noibo.Name = "btn_taikhoan_noibo";
            this.btn_taikhoan_noibo.Size = new System.Drawing.Size(200, 31);
            this.btn_taikhoan_noibo.TabIndex = 0;
            this.btn_taikhoan_noibo.Text = "Tài khoản nội bộ";
            this.btn_taikhoan_noibo.UseVisualStyleBackColor = true;
            this.btn_taikhoan_noibo.Click += new System.EventHandler(this.btn_taikhoan_noibo_Click);
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(206, 41);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(978, 520);
            this.panMainFormBody.TabIndex = 2;
            // 
            // btn_danhmuc_loaihinh
            // 
            this.btn_danhmuc_loaihinh.Location = new System.Drawing.Point(3, 191);
            this.btn_danhmuc_loaihinh.Name = "btn_danhmuc_loaihinh";
            this.btn_danhmuc_loaihinh.Size = new System.Drawing.Size(200, 31);
            this.btn_danhmuc_loaihinh.TabIndex = 4;
            this.btn_danhmuc_loaihinh.Text = "Danh mục loại hình";
            this.btn_danhmuc_loaihinh.UseVisualStyleBackColor = true;
            this.btn_danhmuc_loaihinh.Click += new System.EventHandler(this.btn_danhmuc_loaihinh_Click);
            // 
            // frm_quanly_danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_danhmuc";
            this.Text = "Quản lý danh mục";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_quanlydanhmuc_FormClosed);
            this.Load += new System.EventHandler(this.frm_quanly_danhmuc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_danhmuc_nganhnghe;
        private System.Windows.Forms.Button btn_danhmuc_nhanvien;
        private System.Windows.Forms.Button btn_danhmuc_dantoc;
        private System.Windows.Forms.Button btn_danhmuc_quoctich;
        private System.Windows.Forms.Button btn_taikhoan_noibo;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_danhmuc_loaihinh;
    }
}