namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_quanly_nhanvien
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancelchange = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_createsave = new System.Windows.Forms.Button();
            this.pck_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.pck_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.txt_noicap = new System.Windows.Forms.TextBox();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_nhanvien = new System.Windows.Forms.DataGridView();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noi_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lý  nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancelchange);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_createsave);
            this.panel3.Controls.Add(this.pck_ngaycap);
            this.panel3.Controls.Add(this.pck_ngaysinh);
            this.panel3.Controls.Add(this.rdo_nu);
            this.panel3.Controls.Add(this.rdo_nam);
            this.panel3.Controls.Add(this.txt_noicap);
            this.panel3.Controls.Add(this.txt_cccd);
            this.panel3.Controls.Add(this.txt_hoten);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 409);
            this.panel3.TabIndex = 9;
            // 
            // btn_cancelchange
            // 
            this.btn_cancelchange.Location = new System.Drawing.Point(261, 336);
            this.btn_cancelchange.Name = "btn_cancelchange";
            this.btn_cancelchange.Size = new System.Drawing.Size(90, 23);
            this.btn_cancelchange.TabIndex = 5;
            this.btn_cancelchange.Text = "Hủy thay đổi";
            this.btn_cancelchange.UseVisualStyleBackColor = true;
            this.btn_cancelchange.Click += new System.EventHandler(this.btn_cancelchange_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(138, 336);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xóa nhân viên";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_createsave
            // 
            this.btn_createsave.Location = new System.Drawing.Point(15, 336);
            this.btn_createsave.Name = "btn_createsave";
            this.btn_createsave.Size = new System.Drawing.Size(90, 23);
            this.btn_createsave.TabIndex = 7;
            this.btn_createsave.Text = "Tạo nhân viên";
            this.btn_createsave.UseVisualStyleBackColor = true;
            this.btn_createsave.Click += new System.EventHandler(this.btn_createsave_Click);
            // 
            // pck_ngaycap
            // 
            this.pck_ngaycap.Location = new System.Drawing.Point(127, 228);
            this.pck_ngaycap.Name = "pck_ngaycap";
            this.pck_ngaycap.Size = new System.Drawing.Size(225, 20);
            this.pck_ngaycap.TabIndex = 3;
            // 
            // pck_ngaysinh
            // 
            this.pck_ngaysinh.Location = new System.Drawing.Point(127, 116);
            this.pck_ngaysinh.Name = "pck_ngaysinh";
            this.pck_ngaysinh.Size = new System.Drawing.Size(225, 20);
            this.pck_ngaysinh.TabIndex = 3;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(238, 67);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_nu.TabIndex = 2;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            this.rdo_nu.CheckedChanged += new System.EventHandler(this.rdo_nu_CheckedChanged);
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(127, 67);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(47, 17);
            this.rdo_nam.TabIndex = 2;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            this.rdo_nam.CheckedChanged += new System.EventHandler(this.rdo_nam_CheckedChanged);
            // 
            // txt_noicap
            // 
            this.txt_noicap.Location = new System.Drawing.Point(127, 286);
            this.txt_noicap.Name = "txt_noicap";
            this.txt_noicap.Size = new System.Drawing.Size(225, 20);
            this.txt_noicap.TabIndex = 1;
            // 
            // txt_cccd
            // 
            this.txt_cccd.Location = new System.Drawing.Point(127, 179);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(225, 20);
            this.txt_cccd.TabIndex = 1;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(127, 11);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(225, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nơi cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 41);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_nhanvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(390, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 409);
            this.panel2.TabIndex = 10;
            // 
            // grid_nhanvien
            // 
            this.grid_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ho_ten,
            this.gioi_tinh,
            this.ngay_sinh,
            this.so_cccd,
            this.ngay_cap,
            this.noi_cap,
            this.id});
            this.grid_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.grid_nhanvien.Name = "grid_nhanvien";
            this.grid_nhanvien.Size = new System.Drawing.Size(772, 409);
            this.grid_nhanvien.TabIndex = 0;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Tên nhân viên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.ReadOnly = true;
            // 
            // so_cccd
            // 
            this.so_cccd.DataPropertyName = "so_cccd";
            this.so_cccd.HeaderText = "Số CCCD";
            this.so_cccd.Name = "so_cccd";
            this.so_cccd.ReadOnly = true;
            // 
            // ngay_cap
            // 
            this.ngay_cap.DataPropertyName = "ngay_cap";
            this.ngay_cap.HeaderText = "Ngày cấp";
            this.ngay_cap.Name = "ngay_cap";
            this.ngay_cap.ReadOnly = true;
            // 
            // noi_cap
            // 
            this.noi_cap.DataPropertyName = "noi_cap";
            this.noi_cap.HeaderText = "Nơi cấp";
            this.noi_cap.Name = "noi_cap";
            this.noi_cap.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID Nhân viên";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // frm_quanly_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_nhanvien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frm_quanly_nhanvien_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_nhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker pck_ngaycap;
        private System.Windows.Forms.DateTimePicker pck_ngaysinh;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.TextBox txt_noicap;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_nhanvien;
        private System.Windows.Forms.Button btn_cancelchange;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_createsave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn noi_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}