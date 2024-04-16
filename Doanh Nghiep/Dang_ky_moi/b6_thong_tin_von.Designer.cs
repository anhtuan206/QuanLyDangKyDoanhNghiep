namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    partial class b6_thong_tin_von
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin về vốn";
            // 
            // btn_huy_dang_ky
            // 
            this.btn_huy_dang_ky.BackColor = System.Drawing.Color.Tomato;
            this.btn_huy_dang_ky.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_huy_dang_ky.Location = new System.Drawing.Point(42, 404);
            this.btn_huy_dang_ky.Name = "btn_huy_dang_ky";
            this.btn_huy_dang_ky.Size = new System.Drawing.Size(88, 34);
            this.btn_huy_dang_ky.TabIndex = 17;
            this.btn_huy_dang_ky.Text = "Hủy đăng ký";
            this.btn_huy_dang_ky.UseVisualStyleBackColor = false;
            this.btn_huy_dang_ky.Click += new System.EventHandler(this.btn_huy_dang_ky_Click);
            // 
            // btn_quay_lai
            // 
            this.btn_quay_lai.Location = new System.Drawing.Point(171, 404);
            this.btn_quay_lai.Name = "btn_quay_lai";
            this.btn_quay_lai.Size = new System.Drawing.Size(88, 34);
            this.btn_quay_lai.TabIndex = 18;
            this.btn_quay_lai.Text = "Quay lại bước trước đó";
            this.btn_quay_lai.UseVisualStyleBackColor = true;
            this.btn_quay_lai.Click += new System.EventHandler(this.btn_quay_lai_Click);
            // 
            // btn_luu_tam
            // 
            this.btn_luu_tam.Location = new System.Drawing.Point(265, 404);
            this.btn_luu_tam.Name = "btn_luu_tam";
            this.btn_luu_tam.Size = new System.Drawing.Size(88, 34);
            this.btn_luu_tam.TabIndex = 19;
            this.btn_luu_tam.Text = "Lưu tạm";
            this.btn_luu_tam.UseVisualStyleBackColor = true;
            // 
            // btn_buoc_tiep_theo
            // 
            this.btn_buoc_tiep_theo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_buoc_tiep_theo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buoc_tiep_theo.Location = new System.Drawing.Point(359, 404);
            this.btn_buoc_tiep_theo.Name = "btn_buoc_tiep_theo";
            this.btn_buoc_tiep_theo.Size = new System.Drawing.Size(88, 34);
            this.btn_buoc_tiep_theo.TabIndex = 20;
            this.btn_buoc_tiep_theo.Text = "Bước tiếp theo";
            this.btn_buoc_tiep_theo.UseVisualStyleBackColor = false;
            this.btn_buoc_tiep_theo.Click += new System.EventHandler(this.btn_buoc_tiep_theo_Click);
            // 
            // b6_thong_tin_von
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_huy_dang_ky);
            this.Controls.Add(this.btn_quay_lai);
            this.Controls.Add(this.btn_luu_tam);
            this.Controls.Add(this.btn_buoc_tiep_theo);
            this.Name = "b6_thong_tin_von";
            this.Text = "b6_thon_tin_von";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_huy_dang_ky;
        private System.Windows.Forms.Button btn_quay_lai;
        private System.Windows.Forms.Button btn_luu_tam;
        private System.Windows.Forms.Button btn_buoc_tiep_theo;
    }
}