namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_dang_ky_tai_khoan_doanh_nghiep
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_dang_ky = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_web_site = new System.Windows.Forms.TextBox();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.txt_dien_thoai = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_dan_toc = new System.Windows.Forms.ComboBox();
            this.cbb_quoc_tich = new System.Windows.Forms.ComboBox();
            this.pck_ngay_sinh = new System.Windows.Forms.DateTimePicker();
            this.rdo_nu = new System.Windows.Forms.RadioButton();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ho_ten = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_password_repeat = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email_repeat = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký tài khoản doanh nghiệp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_dang_ky);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 753);
            this.panel3.TabIndex = 9;
            // 
            // btn_dang_ky
            // 
            this.btn_dang_ky.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_dang_ky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dang_ky.Location = new System.Drawing.Point(43, 643);
            this.btn_dang_ky.Name = "btn_dang_ky";
            this.btn_dang_ky.Size = new System.Drawing.Size(492, 38);
            this.btn_dang_ky.TabIndex = 14;
            this.btn_dang_ky.Text = "Đăng Ký";
            this.btn_dang_ky.UseVisualStyleBackColor = false;
            this.btn_dang_ky.Click += new System.EventHandler(this.btn_dang_ky_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbb_dan_toc);
            this.groupBox2.Controls.Add(this.cbb_quoc_tich);
            this.groupBox2.Controls.Add(this.pck_ngay_sinh);
            this.groupBox2.Controls.Add(this.rdo_nu);
            this.groupBox2.Controls.Add(this.rdo_nam);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_ho_ten);
            this.groupBox2.Location = new System.Drawing.Point(43, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_web_site);
            this.groupBox3.Controls.Add(this.txt_fax);
            this.groupBox3.Controls.Add(this.txt_dien_thoai);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(33, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 135);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin liên lạc";
            // 
            // txt_web_site
            // 
            this.txt_web_site.Location = new System.Drawing.Point(130, 91);
            this.txt_web_site.Name = "txt_web_site";
            this.txt_web_site.Size = new System.Drawing.Size(250, 20);
            this.txt_web_site.TabIndex = 13;
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(130, 56);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(250, 20);
            this.txt_fax.TabIndex = 12;
            // 
            // txt_dien_thoai
            // 
            this.txt_dien_thoai.Location = new System.Drawing.Point(130, 26);
            this.txt_dien_thoai.Name = "txt_dien_thoai";
            this.txt_dien_thoai.Size = new System.Drawing.Size(250, 20);
            this.txt_dien_thoai.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Địa chỉ Website";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số Fax";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số điện thoại ";
            // 
            // cbb_dan_toc
            // 
            this.cbb_dan_toc.FormattingEnabled = true;
            this.cbb_dan_toc.Location = new System.Drawing.Point(163, 180);
            this.cbb_dan_toc.Name = "cbb_dan_toc";
            this.cbb_dan_toc.Size = new System.Drawing.Size(250, 21);
            this.cbb_dan_toc.TabIndex = 10;
            this.cbb_dan_toc.SelectedIndexChanged += new System.EventHandler(this.cbb_dan_toc_SelectedIndexChanged);
            // 
            // cbb_quoc_tich
            // 
            this.cbb_quoc_tich.FormattingEnabled = true;
            this.cbb_quoc_tich.Location = new System.Drawing.Point(163, 147);
            this.cbb_quoc_tich.Name = "cbb_quoc_tich";
            this.cbb_quoc_tich.Size = new System.Drawing.Size(250, 21);
            this.cbb_quoc_tich.TabIndex = 9;
            this.cbb_quoc_tich.SelectedIndexChanged += new System.EventHandler(this.cbb_quoc_tich_SelectedIndexChanged);
            // 
            // pck_ngay_sinh
            // 
            this.pck_ngay_sinh.Location = new System.Drawing.Point(163, 111);
            this.pck_ngay_sinh.Name = "pck_ngay_sinh";
            this.pck_ngay_sinh.Size = new System.Drawing.Size(250, 20);
            this.pck_ngay_sinh.TabIndex = 8;
            // 
            // rdo_nu
            // 
            this.rdo_nu.AutoSize = true;
            this.rdo_nu.Location = new System.Drawing.Point(251, 80);
            this.rdo_nu.Name = "rdo_nu";
            this.rdo_nu.Size = new System.Drawing.Size(39, 17);
            this.rdo_nu.TabIndex = 7;
            this.rdo_nu.TabStop = true;
            this.rdo_nu.Text = "Nữ";
            this.rdo_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Location = new System.Drawing.Point(163, 80);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(47, 17);
            this.rdo_nam.TabIndex = 6;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Nam";
            this.rdo_nam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Dân tộc*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Quốc tịch*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày sinh*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giới tính *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Họ tên *";
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Location = new System.Drawing.Point(163, 39);
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(250, 20);
            this.txt_ho_ten.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_password_repeat);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.txt_email_repeat);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đăng nhập";
            // 
            // txt_password_repeat
            // 
            this.txt_password_repeat.Location = new System.Drawing.Point(163, 122);
            this.txt_password_repeat.Name = "txt_password_repeat";
            this.txt_password_repeat.Size = new System.Drawing.Size(250, 20);
            this.txt_password_repeat.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(163, 88);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(250, 20);
            this.txt_password.TabIndex = 3;
            // 
            // txt_email_repeat
            // 
            this.txt_email_repeat.Location = new System.Drawing.Point(163, 55);
            this.txt_email_repeat.Name = "txt_email_repeat";
            this.txt_email_repeat.Size = new System.Drawing.Size(250, 20);
            this.txt_email_repeat.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(163, 26);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 20);
            this.txt_email.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khẩu *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại email *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email *";
            // 
            // frm_dang_ky_tai_khoan_doanh_nghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frm_dang_ky_tai_khoan_doanh_nghiep";
            this.Text = "Đăng ký tài khoản doanh nghiệp";
            this.Load += new System.EventHandler(this.frm_dang_ky_tai_khoan_doanh_nghiep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ho_ten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_password_repeat;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email_repeat;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbb_dan_toc;
        private System.Windows.Forms.ComboBox cbb_quoc_tich;
        private System.Windows.Forms.DateTimePicker pck_ngay_sinh;
        private System.Windows.Forms.RadioButton rdo_nu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_web_site;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.TextBox txt_dien_thoai;
        private System.Windows.Forms.Button btn_dang_ky;
        private System.Windows.Forms.RadioButton rdo_nam;
    }
}