namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    partial class b4_ten_doanh_nghiep
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
            this.btn_huy_dang_ky = new System.Windows.Forms.Button();
            this.btn_quay_lai = new System.Windows.Forms.Button();
            this.btn_luu_tam = new System.Windows.Forms.Button();
            this.btn_buoc_tiep_theo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ten_doanh_nghiep = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten_doanh_nghiep = new System.Windows.Forms.TextBox();
            this.cbb_prefix = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 41);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên doanh nghiệp";
            // 
            // btn_huy_dang_ky
            // 
            this.btn_huy_dang_ky.BackColor = System.Drawing.Color.Tomato;
            this.btn_huy_dang_ky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy_dang_ky.Location = new System.Drawing.Point(17, 3);
            this.btn_huy_dang_ky.Name = "btn_huy_dang_ky";
            this.btn_huy_dang_ky.Size = new System.Drawing.Size(88, 34);
            this.btn_huy_dang_ky.TabIndex = 12;
            this.btn_huy_dang_ky.Text = "Hủy đăng ký";
            this.btn_huy_dang_ky.UseVisualStyleBackColor = false;
            this.btn_huy_dang_ky.Click += new System.EventHandler(this.btn_huy_dang_ky_Click);
            // 
            // btn_quay_lai
            // 
            this.btn_quay_lai.Location = new System.Drawing.Point(137, 3);
            this.btn_quay_lai.Name = "btn_quay_lai";
            this.btn_quay_lai.Size = new System.Drawing.Size(88, 34);
            this.btn_quay_lai.TabIndex = 13;
            this.btn_quay_lai.Text = "Quay lại bước trước đó";
            this.btn_quay_lai.UseVisualStyleBackColor = true;
            this.btn_quay_lai.Click += new System.EventHandler(this.btn_quay_lai_Click);
            // 
            // btn_luu_tam
            // 
            this.btn_luu_tam.Location = new System.Drawing.Point(231, 3);
            this.btn_luu_tam.Name = "btn_luu_tam";
            this.btn_luu_tam.Size = new System.Drawing.Size(88, 34);
            this.btn_luu_tam.TabIndex = 14;
            this.btn_luu_tam.Text = "Lưu tạm";
            this.btn_luu_tam.UseVisualStyleBackColor = true;
            this.btn_luu_tam.Click += new System.EventHandler(this.btn_luu_tam_Click);
            // 
            // btn_buoc_tiep_theo
            // 
            this.btn_buoc_tiep_theo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buoc_tiep_theo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buoc_tiep_theo.Location = new System.Drawing.Point(325, 3);
            this.btn_buoc_tiep_theo.Name = "btn_buoc_tiep_theo";
            this.btn_buoc_tiep_theo.Size = new System.Drawing.Size(88, 34);
            this.btn_buoc_tiep_theo.TabIndex = 15;
            this.btn_buoc_tiep_theo.Text = "Bước tiếp theo";
            this.btn_buoc_tiep_theo.UseVisualStyleBackColor = false;
            this.btn_buoc_tiep_theo.Click += new System.EventHandler(this.btn_buoc_tiep_theo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_buoc_tiep_theo);
            this.panel2.Controls.Add(this.btn_luu_tam);
            this.panel2.Controls.Add(this.btn_quay_lai);
            this.panel2.Controls.Add(this.btn_huy_dang_ky);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(431, 48);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbl_ten_doanh_nghiep);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_ten_doanh_nghiep);
            this.panel3.Controls.Add(this.cbb_prefix);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 361);
            this.panel3.TabIndex = 18;
            // 
            // lbl_ten_doanh_nghiep
            // 
            this.lbl_ten_doanh_nghiep.AutoSize = true;
            this.lbl_ten_doanh_nghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_doanh_nghiep.Location = new System.Drawing.Point(16, 211);
            this.lbl_ten_doanh_nghiep.Name = "lbl_ten_doanh_nghiep";
            this.lbl_ten_doanh_nghiep.Size = new System.Drawing.Size(218, 24);
            this.lbl_ten_doanh_nghiep.TabIndex = 4;
            this.lbl_ten_doanh_nghiep.Text = "lbl_ten_doanh_nghiep";
            this.lbl_ten_doanh_nghiep.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(20, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kiểm tra trùng tên";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên doanh nghiệp";
            // 
            // txt_ten_doanh_nghiep
            // 
            this.txt_ten_doanh_nghiep.Location = new System.Drawing.Point(20, 96);
            this.txt_ten_doanh_nghiep.Name = "txt_ten_doanh_nghiep";
            this.txt_ten_doanh_nghiep.Size = new System.Drawing.Size(257, 20);
            this.txt_ten_doanh_nghiep.TabIndex = 1;
            // 
            // cbb_prefix
            // 
            this.cbb_prefix.FormattingEnabled = true;
            this.cbb_prefix.Items.AddRange(new object[] {
            "CÔNG TY TNHH",
            "CÔNG TY TRÁCH NHIỆM HỮU HẠN"});
            this.cbb_prefix.Location = new System.Drawing.Point(20, 69);
            this.cbb_prefix.Name = "cbb_prefix";
            this.cbb_prefix.Size = new System.Drawing.Size(257, 21);
            this.cbb_prefix.TabIndex = 0;
            // 
            // b4_ten_doanh_nghiep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "b4_ten_doanh_nghiep";
            this.Text = "b4_ten_doanh_nghiep";
            this.Load += new System.EventHandler(this.b4_ten_doanh_nghiep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_huy_dang_ky;
        private System.Windows.Forms.Button btn_quay_lai;
        private System.Windows.Forms.Button btn_luu_tam;
        private System.Windows.Forms.Button btn_buoc_tiep_theo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ten_doanh_nghiep;
        private System.Windows.Forms.ComboBox cbb_prefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ten_doanh_nghiep;
    }
}