namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc
{
    partial class frm_quanly_loaihinh
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
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.grid_loai_hinh = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelchange = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_createsave = new System.Windows.Forms.Button();
            this.txt_ten_loai_hinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_loai_hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panMainFormBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_loai_hinh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục loại hình";
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Controls.Add(this.grid_loai_hinh);
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(317, 41);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(483, 409);
            this.panMainFormBody.TabIndex = 5;
            // 
            // grid_loai_hinh
            // 
            this.grid_loai_hinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_loai_hinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten_loai_hinh});
            this.grid_loai_hinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_loai_hinh.Location = new System.Drawing.Point(0, 0);
            this.grid_loai_hinh.Name = "grid_loai_hinh";
            this.grid_loai_hinh.Size = new System.Drawing.Size(483, 409);
            this.grid_loai_hinh.TabIndex = 0;
            this.grid_loai_hinh.DoubleClick += new System.EventHandler(this.grid_loai_hinh_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancelchange);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_createsave);
            this.panel2.Controls.Add(this.txt_ten_loai_hinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 409);
            this.panel2.TabIndex = 4;
            // 
            // btn_cancelchange
            // 
            this.btn_cancelchange.Location = new System.Drawing.Point(209, 107);
            this.btn_cancelchange.Name = "btn_cancelchange";
            this.btn_cancelchange.Size = new System.Drawing.Size(90, 36);
            this.btn_cancelchange.TabIndex = 13;
            this.btn_cancelchange.Text = "Hủy thay đổi";
            this.btn_cancelchange.UseVisualStyleBackColor = true;
            this.btn_cancelchange.Click += new System.EventHandler(this.btn_cancelchange_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(113, 107);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 36);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Xóa loại hình kinh doanh";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_createsave
            // 
            this.btn_createsave.Location = new System.Drawing.Point(17, 107);
            this.btn_createsave.Name = "btn_createsave";
            this.btn_createsave.Size = new System.Drawing.Size(90, 36);
            this.btn_createsave.TabIndex = 15;
            this.btn_createsave.Text = "Thêm loại hình kinh doanh";
            this.btn_createsave.UseVisualStyleBackColor = true;
            this.btn_createsave.Click += new System.EventHandler(this.btn_createsave_Click);
            // 
            // txt_ten_loai_hinh
            // 
            this.txt_ten_loai_hinh.Location = new System.Drawing.Point(17, 60);
            this.txt_ten_loai_hinh.Name = "txt_ten_loai_hinh";
            this.txt_ten_loai_hinh.Size = new System.Drawing.Size(282, 20);
            this.txt_ten_loai_hinh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại hình kinh doanh";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten_loai_hinh
            // 
            this.ten_loai_hinh.DataPropertyName = "ten_loai_hinh";
            this.ten_loai_hinh.HeaderText = "Loại hình kinh doanh";
            this.ten_loai_hinh.Name = "ten_loai_hinh";
            this.ten_loai_hinh.ReadOnly = true;
            // 
            // frm_quanly_loaihinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_loaihinh";
            this.Text = "Danh mục loại hình";
            this.Load += new System.EventHandler(this.frm_quanly_loaihinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMainFormBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_loai_hinh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ten_loai_hinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelchange;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_createsave;
        private System.Windows.Forms.DataGridView grid_loai_hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_loai_hinh;
    }
}