namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.SubForm
{
    partial class frm_danh_sach_ho_so_dang_ky
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
            this.btn_xoa_ho_so = new System.Windows.Forms.Button();
            this.btn_tiep_tuc_nhap_thong_tin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_danh_sach_ho_so_dang_ky = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_tao_ho_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_submitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_approved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_danh_sach_ho_so_dang_ky)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hồ sơ đăng ký";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa_ho_so);
            this.panel2.Controls.Add(this.btn_tiep_tuc_nhap_thong_tin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 49);
            this.panel2.TabIndex = 5;
            // 
            // btn_xoa_ho_so
            // 
            this.btn_xoa_ho_so.BackColor = System.Drawing.Color.IndianRed;
            this.btn_xoa_ho_so.Enabled = false;
            this.btn_xoa_ho_so.Location = new System.Drawing.Point(190, 6);
            this.btn_xoa_ho_so.Name = "btn_xoa_ho_so";
            this.btn_xoa_ho_so.Size = new System.Drawing.Size(75, 31);
            this.btn_xoa_ho_so.TabIndex = 1;
            this.btn_xoa_ho_so.Text = "Xóa hồ sơ";
            this.btn_xoa_ho_so.UseVisualStyleBackColor = false;
            this.btn_xoa_ho_so.Click += new System.EventHandler(this.btn_xoa_ho_so_Click);
            // 
            // btn_tiep_tuc_nhap_thong_tin
            // 
            this.btn_tiep_tuc_nhap_thong_tin.Enabled = false;
            this.btn_tiep_tuc_nhap_thong_tin.Location = new System.Drawing.Point(12, 6);
            this.btn_tiep_tuc_nhap_thong_tin.Name = "btn_tiep_tuc_nhap_thong_tin";
            this.btn_tiep_tuc_nhap_thong_tin.Size = new System.Drawing.Size(172, 31);
            this.btn_tiep_tuc_nhap_thong_tin.TabIndex = 0;
            this.btn_tiep_tuc_nhap_thong_tin.Text = "Cập nhật thông tin hồ sơ";
            this.btn_tiep_tuc_nhap_thong_tin.UseVisualStyleBackColor = true;
            this.btn_tiep_tuc_nhap_thong_tin.Click += new System.EventHandler(this.btn_tiep_tuc_nhap_thong_tin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_danh_sach_ho_so_dang_ky);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 360);
            this.panel3.TabIndex = 6;
            // 
            // grid_danh_sach_ho_so_dang_ky
            // 
            this.grid_danh_sach_ho_so_dang_ky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_danh_sach_ho_so_dang_ky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.ngay_tao_ho_so,
            this.is_submitted,
            this.is_approved});
            this.grid_danh_sach_ho_so_dang_ky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_danh_sach_ho_so_dang_ky.Location = new System.Drawing.Point(0, 0);
            this.grid_danh_sach_ho_so_dang_ky.Name = "grid_danh_sach_ho_so_dang_ky";
            this.grid_danh_sach_ho_so_dang_ky.Size = new System.Drawing.Size(800, 360);
            this.grid_danh_sach_ho_so_dang_ky.TabIndex = 0;
            this.grid_danh_sach_ho_so_dang_ky.DoubleClick += new System.EventHandler(this.grid_danh_sach_ho_so_dang_ky_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã hồ sơ";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên doanh nghiệp";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // ngay_tao_ho_so
            // 
            this.ngay_tao_ho_so.DataPropertyName = "ngay_tao_ho_so";
            this.ngay_tao_ho_so.HeaderText = "Ngày tạo hồ sơ";
            this.ngay_tao_ho_so.Name = "ngay_tao_ho_so";
            this.ngay_tao_ho_so.ReadOnly = true;
            // 
            // is_submitted
            // 
            this.is_submitted.DataPropertyName = "is_submitted";
            this.is_submitted.HeaderText = "Đã nộp hồ sơ";
            this.is_submitted.Name = "is_submitted";
            this.is_submitted.ReadOnly = true;
            // 
            // is_approved
            // 
            this.is_approved.DataPropertyName = "is_approved";
            this.is_approved.HeaderText = "Hồ sơ đã được phê duyệt";
            this.is_approved.Name = "is_approved";
            this.is_approved.ReadOnly = true;
            // 
            // frm_danh_sach_ho_so_dang_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_danh_sach_ho_so_dang_ky";
            this.Text = "frm_danh_sach_ho_so_dang_ky";
            this.Load += new System.EventHandler(this.frm_danh_sach_ho_so_dang_ky_Load);
            this.Shown += new System.EventHandler(this.frm_danh_sach_ho_so_dang_ky_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_danh_sach_ho_so_dang_ky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grid_danh_sach_ho_so_dang_ky;
        private System.Windows.Forms.Button btn_xoa_ho_so;
        private System.Windows.Forms.Button btn_tiep_tuc_nhap_thong_tin;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_tao_ho_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_submitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_approved;
    }
}