namespace QuanLyDangKyDoanhNghiep.Doanh_Nghiep.Dang_ky_moi
{
    partial class b9_nop_ho_so
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
            this.btn_luu_tam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_nop_ho_so = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nộp hồ sơ";
            // 
            // btn_luu_tam
            // 
            this.btn_luu_tam.Location = new System.Drawing.Point(247, 3);
            this.btn_luu_tam.Name = "btn_luu_tam";
            this.btn_luu_tam.Size = new System.Drawing.Size(88, 34);
            this.btn_luu_tam.TabIndex = 19;
            this.btn_luu_tam.Text = "Lưu tạm";
            this.btn_luu_tam.UseVisualStyleBackColor = true;
            this.btn_luu_tam.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_luu_tam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.btn_nop_ho_so);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 369);
            this.panel3.TabIndex = 22;
            // 
            // btn_nop_ho_so
            // 
            this.btn_nop_ho_so.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_nop_ho_so.Location = new System.Drawing.Point(17, 145);
            this.btn_nop_ho_so.Name = "btn_nop_ho_so";
            this.btn_nop_ho_so.Size = new System.Drawing.Size(170, 48);
            this.btn_nop_ho_so.TabIndex = 0;
            this.btn_nop_ho_so.Text = "Nộp hồ sơ điện tử";
            this.btn_nop_ho_so.UseVisualStyleBackColor = false;
            this.btn_nop_ho_so.Click += new System.EventHandler(this.btn_nop_ho_so_Click);
            // 
            // b9_nop_ho_so
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "b9_nop_ho_so";
            this.Text = "b9_bao_hiem_xa_hoi";
            this.Load += new System.EventHandler(this.b9_nop_ho_so_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_luu_tam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_nop_ho_so;
    }
}