namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.SubForm
{
    partial class frm_quan_ly_dang_ky_doanh_nghiep
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grid_danh_sach_ho_so_dang_ky = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdo_all = new System.Windows.Forms.RadioButton();
            this.rdo_approved = new System.Windows.Forms.RadioButton();
            this.rdo_unapproved = new System.Windows.Forms.RadioButton();
            this.btn_tim_theo_ma_ho_so = new System.Windows.Forms.Button();
            this.txt_ma_ho_so = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_khong_duyet_ho_so = new System.Windows.Forms.Button();
            this.btn_duyet_ho_so = new System.Windows.Forms.Button();
            this.btn_xoa_ho_so = new System.Windows.Forms.Button();
            this.btn_xem_ho_so = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_tao_ho_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_submitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approved_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_danh_sach_ho_so_dang_ky)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 41);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý đăng ký doanh nghiệp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 651);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grid_danh_sach_ho_so_dang_ky);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(909, 551);
            this.panel5.TabIndex = 3;
            // 
            // grid_danh_sach_ho_so_dang_ky
            // 
            this.grid_danh_sach_ho_so_dang_ky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_danh_sach_ho_so_dang_ky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.ngay_tao_ho_so,
            this.is_submitted,
            this.approved_time});
            this.grid_danh_sach_ho_so_dang_ky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_danh_sach_ho_so_dang_ky.Location = new System.Drawing.Point(0, 0);
            this.grid_danh_sach_ho_so_dang_ky.Name = "grid_danh_sach_ho_so_dang_ky";
            this.grid_danh_sach_ho_so_dang_ky.Size = new System.Drawing.Size(909, 551);
            this.grid_danh_sach_ho_so_dang_ky.TabIndex = 1;
            this.grid_danh_sach_ho_so_dang_ky.DoubleClick += new System.EventHandler(this.grid_danh_sach_ho_so_dang_ky_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btn_tim_theo_ma_ho_so);
            this.panel4.Controls.Add(this.txt_ma_ho_so);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(909, 100);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdo_all);
            this.panel6.Controls.Add(this.rdo_approved);
            this.panel6.Controls.Add(this.rdo_unapproved);
            this.panel6.Location = new System.Drawing.Point(11, 35);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(530, 48);
            this.panel6.TabIndex = 4;
            // 
            // rdo_all
            // 
            this.rdo_all.AutoSize = true;
            this.rdo_all.Location = new System.Drawing.Point(362, 15);
            this.rdo_all.Name = "rdo_all";
            this.rdo_all.Size = new System.Drawing.Size(106, 17);
            this.rdo_all.TabIndex = 0;
            this.rdo_all.TabStop = true;
            this.rdo_all.Text = "Hiện tất cả hồ sơ";
            this.rdo_all.UseVisualStyleBackColor = true;
            this.rdo_all.CheckedChanged += new System.EventHandler(this.rdo_all_CheckedChanged);
            // 
            // rdo_approved
            // 
            this.rdo_approved.AutoSize = true;
            this.rdo_approved.Location = new System.Drawing.Point(194, 15);
            this.rdo_approved.Name = "rdo_approved";
            this.rdo_approved.Size = new System.Drawing.Size(135, 17);
            this.rdo_approved.TabIndex = 0;
            this.rdo_approved.TabStop = true;
            this.rdo_approved.Text = "Hiển thị hồ sơ đã duyệt";
            this.rdo_approved.UseVisualStyleBackColor = true;
            this.rdo_approved.CheckedChanged += new System.EventHandler(this.rdo_approved_CheckedChanged);
            // 
            // rdo_unapproved
            // 
            this.rdo_unapproved.AutoSize = true;
            this.rdo_unapproved.Location = new System.Drawing.Point(14, 15);
            this.rdo_unapproved.Name = "rdo_unapproved";
            this.rdo_unapproved.Size = new System.Drawing.Size(152, 17);
            this.rdo_unapproved.TabIndex = 0;
            this.rdo_unapproved.TabStop = true;
            this.rdo_unapproved.Text = "Hiển thị hồ sơ chưa chuyệt";
            this.rdo_unapproved.UseVisualStyleBackColor = true;
            this.rdo_unapproved.CheckedChanged += new System.EventHandler(this.rdo_unapproved_CheckedChanged);
            // 
            // btn_tim_theo_ma_ho_so
            // 
            this.btn_tim_theo_ma_ho_so.Location = new System.Drawing.Point(182, 6);
            this.btn_tim_theo_ma_ho_so.Name = "btn_tim_theo_ma_ho_so";
            this.btn_tim_theo_ma_ho_so.Size = new System.Drawing.Size(137, 23);
            this.btn_tim_theo_ma_ho_so.TabIndex = 3;
            this.btn_tim_theo_ma_ho_so.Text = "Tìm theo mã hồ sơ";
            this.btn_tim_theo_ma_ho_so.UseVisualStyleBackColor = true;
            this.btn_tim_theo_ma_ho_so.Click += new System.EventHandler(this.btn_tim_theo_ma_ho_so_Click);
            // 
            // txt_ma_ho_so
            // 
            this.txt_ma_ho_so.Location = new System.Drawing.Point(11, 8);
            this.txt_ma_ho_so.Name = "txt_ma_ho_so";
            this.txt_ma_ho_so.Size = new System.Drawing.Size(157, 20);
            this.txt_ma_ho_so.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_khong_duyet_ho_so);
            this.panel3.Controls.Add(this.btn_duyet_ho_so);
            this.panel3.Controls.Add(this.btn_xoa_ho_so);
            this.panel3.Controls.Add(this.btn_xem_ho_so);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 52);
            this.panel3.TabIndex = 9;
            // 
            // btn_khong_duyet_ho_so
            // 
            this.btn_khong_duyet_ho_so.BackColor = System.Drawing.Color.Gold;
            this.btn_khong_duyet_ho_so.Location = new System.Drawing.Point(198, 4);
            this.btn_khong_duyet_ho_so.Name = "btn_khong_duyet_ho_so";
            this.btn_khong_duyet_ho_so.Size = new System.Drawing.Size(89, 45);
            this.btn_khong_duyet_ho_so.TabIndex = 0;
            this.btn_khong_duyet_ho_so.Text = "Không duyệt hồ sơ";
            this.btn_khong_duyet_ho_so.UseVisualStyleBackColor = false;
            this.btn_khong_duyet_ho_so.Click += new System.EventHandler(this.btn_khong_duyet_ho_so_Click);
            // 
            // btn_duyet_ho_so
            // 
            this.btn_duyet_ho_so.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_duyet_ho_so.Location = new System.Drawing.Point(103, 4);
            this.btn_duyet_ho_so.Name = "btn_duyet_ho_so";
            this.btn_duyet_ho_so.Size = new System.Drawing.Size(89, 45);
            this.btn_duyet_ho_so.TabIndex = 0;
            this.btn_duyet_ho_so.Text = "Duyệt hồ sơ";
            this.btn_duyet_ho_so.UseVisualStyleBackColor = false;
            this.btn_duyet_ho_so.Click += new System.EventHandler(this.btn_duyet_ho_so_Click);
            // 
            // btn_xoa_ho_so
            // 
            this.btn_xoa_ho_so.BackColor = System.Drawing.Color.Crimson;
            this.btn_xoa_ho_so.Enabled = false;
            this.btn_xoa_ho_so.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_xoa_ho_so.Location = new System.Drawing.Point(293, 4);
            this.btn_xoa_ho_so.Name = "btn_xoa_ho_so";
            this.btn_xoa_ho_so.Size = new System.Drawing.Size(89, 45);
            this.btn_xoa_ho_so.TabIndex = 0;
            this.btn_xoa_ho_so.Text = "Xóa hồ sơ";
            this.btn_xoa_ho_so.UseVisualStyleBackColor = false;
            this.btn_xoa_ho_so.Visible = false;
            this.btn_xoa_ho_so.Click += new System.EventHandler(this.btn_xoa_ho_so_Click);
            // 
            // btn_xem_ho_so
            // 
            this.btn_xem_ho_so.Location = new System.Drawing.Point(8, 4);
            this.btn_xem_ho_so.Name = "btn_xem_ho_so";
            this.btn_xem_ho_so.Size = new System.Drawing.Size(89, 45);
            this.btn_xem_ho_so.TabIndex = 0;
            this.btn_xem_ho_so.Text = "Xem hồ sơ";
            this.btn_xem_ho_so.UseVisualStyleBackColor = true;
            this.btn_xem_ho_so.Click += new System.EventHandler(this.btn_xem_ho_so_Click);
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
            this.is_submitted.Visible = false;
            // 
            // approved_time
            // 
            this.approved_time.DataPropertyName = "approved_time";
            this.approved_time.HeaderText = "Ngày phê duyệt";
            this.approved_time.Name = "approved_time";
            this.approved_time.ReadOnly = true;
            // 
            // frm_quan_ly_dang_ky_doanh_nghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 692);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quan_ly_dang_ky_doanh_nghiep";
            this.Text = "frm_quan_ly_dang_ky_doanh_nghiep";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_quan_ly_dang_ky_doanh_nghiep_FormClosed);
            this.Load += new System.EventHandler(this.frm_quan_ly_dang_ky_doanh_nghiep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_danh_sach_ho_so_dang_ky)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grid_danh_sach_ho_so_dang_ky;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_xem_ho_so;
        private System.Windows.Forms.Button btn_khong_duyet_ho_so;
        private System.Windows.Forms.Button btn_duyet_ho_so;
        private System.Windows.Forms.Button btn_xoa_ho_so;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_tim_theo_ma_ho_so;
        private System.Windows.Forms.TextBox txt_ma_ho_so;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdo_all;
        private System.Windows.Forms.RadioButton rdo_approved;
        private System.Windows.Forms.RadioButton rdo_unapproved;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_tao_ho_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_submitted;
        private System.Windows.Forms.DataGridViewTextBoxColumn approved_time;
    }
}