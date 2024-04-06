namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_quanly_taikhoan_noibo
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_nhanvien = new System.Windows.Forms.ComboBox();
            this.btn_cancelchange = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_createsave = new System.Windows.Forms.Button();
            this.ckb_islocked = new System.Windows.Forms.CheckBox();
            this.txt_password_repeat = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_internal_account = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_locked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_internal_account)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbb_nhanvien);
            this.panel3.Controls.Add(this.btn_cancelchange);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_createsave);
            this.panel3.Controls.Add(this.ckb_islocked);
            this.panel3.Controls.Add(this.txt_password_repeat);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 720);
            this.panel3.TabIndex = 5;
            // 
            // cbb_nhanvien
            // 
            this.cbb_nhanvien.FormattingEnabled = true;
            this.cbb_nhanvien.Location = new System.Drawing.Point(156, 24);
            this.cbb_nhanvien.Name = "cbb_nhanvien";
            this.cbb_nhanvien.Size = new System.Drawing.Size(227, 21);
            this.cbb_nhanvien.TabIndex = 5;
            this.cbb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.cbb_nhanvien_SelectedIndexChanged);
            // 
            // btn_cancelchange
            // 
            this.btn_cancelchange.Location = new System.Drawing.Point(293, 227);
            this.btn_cancelchange.Name = "btn_cancelchange";
            this.btn_cancelchange.Size = new System.Drawing.Size(90, 23);
            this.btn_cancelchange.TabIndex = 4;
            this.btn_cancelchange.Text = "Hủy thay đổi";
            this.btn_cancelchange.UseVisualStyleBackColor = true;
            this.btn_cancelchange.Click += new System.EventHandler(this.btn_cancelchange_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(167, 227);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa tài khoản";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_createsave
            // 
            this.btn_createsave.Location = new System.Drawing.Point(41, 227);
            this.btn_createsave.Name = "btn_createsave";
            this.btn_createsave.Size = new System.Drawing.Size(90, 23);
            this.btn_createsave.TabIndex = 4;
            this.btn_createsave.Text = "Tạo tài khoản";
            this.btn_createsave.UseVisualStyleBackColor = true;
            this.btn_createsave.Click += new System.EventHandler(this.btn_createsave_Click);
            // 
            // ckb_islocked
            // 
            this.ckb_islocked.AutoSize = true;
            this.ckb_islocked.Location = new System.Drawing.Point(156, 182);
            this.ckb_islocked.Name = "ckb_islocked";
            this.ckb_islocked.Size = new System.Drawing.Size(15, 14);
            this.ckb_islocked.TabIndex = 3;
            this.ckb_islocked.UseVisualStyleBackColor = true;
            // 
            // txt_password_repeat
            // 
            this.txt_password_repeat.Location = new System.Drawing.Point(156, 141);
            this.txt_password_repeat.Name = "txt_password_repeat";
            this.txt_password_repeat.Size = new System.Drawing.Size(227, 20);
            this.txt_password_repeat.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(156, 102);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(227, 20);
            this.txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(156, 63);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(227, 20);
            this.txt_username.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khóa tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại mật khẩu *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản *";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 41);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản nội bộ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_internal_account);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(427, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 720);
            this.panel2.TabIndex = 6;
            // 
            // grid_internal_account
            // 
            this.grid_internal_account.AllowUserToOrderColumns = true;
            this.grid_internal_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_internal_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.create_time,
            this.is_locked,
            this.id_nhan_vien,
            this.ho_ten,
            this.ngay_sinh,
            this.so_cccd});
            this.grid_internal_account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_internal_account.Location = new System.Drawing.Point(0, 0);
            this.grid_internal_account.Name = "grid_internal_account";
            this.grid_internal_account.Size = new System.Drawing.Size(757, 720);
            this.grid_internal_account.TabIndex = 0;
            this.grid_internal_account.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_taikhoan_noibo_CellContentClick);
            this.grid_internal_account.DoubleClick += new System.EventHandler(this.grid_internal_account_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Tài khoản";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // create_time
            // 
            this.create_time.DataPropertyName = "create_time";
            this.create_time.HeaderText = "Thời gian tạo";
            this.create_time.Name = "create_time";
            this.create_time.ReadOnly = true;
            // 
            // is_locked
            // 
            this.is_locked.DataPropertyName = "is_locked";
            this.is_locked.HeaderText = "Bị khóa";
            this.is_locked.Name = "is_locked";
            this.is_locked.ReadOnly = true;
            // 
            // id_nhan_vien
            // 
            this.id_nhan_vien.DataPropertyName = "id_nhan_vien";
            this.id_nhan_vien.HeaderText = "id_nhan_vien";
            this.id_nhan_vien.Name = "id_nhan_vien";
            this.id_nhan_vien.ReadOnly = true;
            this.id_nhan_vien.Visible = false;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Nhân viên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
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
            // frm_quanly_taikhoan_noibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_taikhoan_noibo";
            this.Text = "Quản lý tài khoản nội bộ";
            this.Load += new System.EventHandler(this.frm_quanly_taikhoan_noibo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_internal_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelchange;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_createsave;
        private System.Windows.Forms.CheckBox ckb_islocked;
        private System.Windows.Forms.TextBox txt_password_repeat;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbb_nhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_internal_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_time;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_locked;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_cccd;
    }
}