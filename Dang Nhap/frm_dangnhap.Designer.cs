namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_dangnhap
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
            this.btn_dangnhaptaikhoandoanhnghiep = new System.Windows.Forms.Button();
            this.btn_dangnhaptaikhoanquantri = new System.Windows.Forms.Button();
            this.btn_dangkytaikhoandoanhnghiep = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dangnhaptaikhoandoanhnghiep
            // 
            this.btn_dangnhaptaikhoandoanhnghiep.Location = new System.Drawing.Point(3, 72);
            this.btn_dangnhaptaikhoandoanhnghiep.Name = "btn_dangnhaptaikhoandoanhnghiep";
            this.btn_dangnhaptaikhoandoanhnghiep.Size = new System.Drawing.Size(244, 54);
            this.btn_dangnhaptaikhoandoanhnghiep.TabIndex = 0;
            this.btn_dangnhaptaikhoandoanhnghiep.Text = "Đăng nhập tài khoản doanh nghiệp";
            this.btn_dangnhaptaikhoandoanhnghiep.UseVisualStyleBackColor = true;
            this.btn_dangnhaptaikhoandoanhnghiep.Click += new System.EventHandler(this.btn_dangnhaptaikhoandoanhnghiep_Click);
            // 
            // btn_dangnhaptaikhoanquantri
            // 
            this.btn_dangnhaptaikhoanquantri.Location = new System.Drawing.Point(3, 12);
            this.btn_dangnhaptaikhoanquantri.Name = "btn_dangnhaptaikhoanquantri";
            this.btn_dangnhaptaikhoanquantri.Size = new System.Drawing.Size(244, 54);
            this.btn_dangnhaptaikhoanquantri.TabIndex = 1;
            this.btn_dangnhaptaikhoanquantri.Text = "Đăng nhập tài khoản quản trị";
            this.btn_dangnhaptaikhoanquantri.UseVisualStyleBackColor = true;
            this.btn_dangnhaptaikhoanquantri.Click += new System.EventHandler(this.btn_dangnhaptaikhoanquantri_Click);
            // 
            // btn_dangkytaikhoandoanhnghiep
            // 
            this.btn_dangkytaikhoandoanhnghiep.Location = new System.Drawing.Point(3, 132);
            this.btn_dangkytaikhoandoanhnghiep.Name = "btn_dangkytaikhoandoanhnghiep";
            this.btn_dangkytaikhoandoanhnghiep.Size = new System.Drawing.Size(244, 50);
            this.btn_dangkytaikhoandoanhnghiep.TabIndex = 2;
            this.btn_dangkytaikhoandoanhnghiep.Text = "Đăng ký tài khoản doanh nghiệp";
            this.btn_dangkytaikhoandoanhnghiep.UseVisualStyleBackColor = true;
            this.btn_dangkytaikhoandoanhnghiep.Click += new System.EventHandler(this.btn_dangkytaikhoandoanhnghiep_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panMainFormBody);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 261);
            this.panel1.TabIndex = 3;
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(251, 0);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(510, 261);
            this.panMainFormBody.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_dangnhaptaikhoanquantri);
            this.panel2.Controls.Add(this.btn_dangkytaikhoandoanhnghiep);
            this.panel2.Controls.Add(this.btn_dangnhaptaikhoandoanhnghiep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 261);
            this.panel2.TabIndex = 3;
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(761, 261);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(777, 259);
            this.Name = "frm_dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dangnhaptaikhoandoanhnghiep;
        private System.Windows.Forms.Button btn_dangnhaptaikhoanquantri;
        private System.Windows.Forms.Button btn_dangkytaikhoandoanhnghiep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panMainFormBody;
    }
}

