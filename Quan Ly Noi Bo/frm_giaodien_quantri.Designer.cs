﻿namespace QuanLyDangKyDoanhNghiep
{
    partial class frm_giaodien_quantri
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_quan_ly_danh_muc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btn_quan_ly_danh_muc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 409);
            this.panel3.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Quản lý tài khoản doanh nghiệp";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản lý tài khoản nội bộ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản lý đăng ký doanh nghiệp";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_quan_ly_danh_muc
            // 
            this.btn_quan_ly_danh_muc.Location = new System.Drawing.Point(26, 21);
            this.btn_quan_ly_danh_muc.Name = "btn_quan_ly_danh_muc";
            this.btn_quan_ly_danh_muc.Size = new System.Drawing.Size(102, 57);
            this.btn_quan_ly_danh_muc.TabIndex = 0;
            this.btn_quan_ly_danh_muc.Text = "Quản lý danh mục";
            this.btn_quan_ly_danh_muc.UseVisualStyleBackColor = true;
            this.btn_quan_ly_danh_muc.Click += new System.EventHandler(this.btn_quan_ly_danh_muc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 8;
            // 
            // frm_giaodien_quantri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frm_giaodien_quantri";
            this.Text = "Quản lý đăng ký doanh nghiệp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_giaodien_quantri_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_quan_ly_danh_muc;
    }
}