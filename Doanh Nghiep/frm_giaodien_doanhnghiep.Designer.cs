namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_giaodien_doanhnghiep
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
            this.btn_danh_sach_ho_so_dang_ky = new System.Windows.Forms.Button();
            this.btn_dang_ky_doanh_nghiep = new System.Windows.Forms.Button();
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_danh_sach_ho_so_dang_ky);
            this.panel2.Controls.Add(this.btn_dang_ky_doanh_nghiep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 409);
            this.panel2.TabIndex = 2;
            // 
            // btn_danh_sach_ho_so_dang_ky
            // 
            this.btn_danh_sach_ho_so_dang_ky.Location = new System.Drawing.Point(3, 51);
            this.btn_danh_sach_ho_so_dang_ky.Name = "btn_danh_sach_ho_so_dang_ky";
            this.btn_danh_sach_ho_so_dang_ky.Size = new System.Drawing.Size(200, 39);
            this.btn_danh_sach_ho_so_dang_ky.TabIndex = 0;
            this.btn_danh_sach_ho_so_dang_ky.Text = "Danh sách hồ sơ đăng ký";
            this.btn_danh_sach_ho_so_dang_ky.UseVisualStyleBackColor = true;
            this.btn_danh_sach_ho_so_dang_ky.Click += new System.EventHandler(this.btn_danh_sach_ho_so_dang_ky_Click);
            // 
            // btn_dang_ky_doanh_nghiep
            // 
            this.btn_dang_ky_doanh_nghiep.Location = new System.Drawing.Point(3, 6);
            this.btn_dang_ky_doanh_nghiep.Name = "btn_dang_ky_doanh_nghiep";
            this.btn_dang_ky_doanh_nghiep.Size = new System.Drawing.Size(200, 39);
            this.btn_dang_ky_doanh_nghiep.TabIndex = 0;
            this.btn_dang_ky_doanh_nghiep.Text = "Đăng ký doanh nghiệp";
            this.btn_dang_ky_doanh_nghiep.UseVisualStyleBackColor = true;
            this.btn_dang_ky_doanh_nghiep.Click += new System.EventHandler(this.btn_dang_ky_doanh_nghiep_Click);
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(206, 41);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(594, 409);
            this.panMainFormBody.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tạo dữ liệu mẫu tự động";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_giaodien_doanhnghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_giaodien_doanhnghiep";
            this.Text = "Đăng ký doanh nghiệp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_giaodien_doanhnghiep_FormClosed);
            this.Load += new System.EventHandler(this.frm_giaodien_doanhnghiep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.Button btn_dang_ky_doanh_nghiep;
        private System.Windows.Forms.Button btn_danh_sach_ho_so_dang_ky;
        private System.Windows.Forms.Button button1;
    }
}