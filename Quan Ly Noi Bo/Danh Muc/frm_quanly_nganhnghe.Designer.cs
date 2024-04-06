namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc
{
    partial class frm_quanly_nganhnghe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancelchange = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_createsave = new System.Windows.Forms.Button();
            this.txt_ten_nganh_nghe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_nganh_nghe = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nganh_nghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panMainFormBody.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nganh_nghe)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục ngành nghề";
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Controls.Add(this.grid_nganh_nghe);
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(320, 41);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(480, 409);
            this.panMainFormBody.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancelchange);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_createsave);
            this.panel2.Controls.Add(this.txt_ten_nganh_nghe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 409);
            this.panel2.TabIndex = 4;
            // 
            // btn_cancelchange
            // 
            this.btn_cancelchange.Location = new System.Drawing.Point(209, 92);
            this.btn_cancelchange.Name = "btn_cancelchange";
            this.btn_cancelchange.Size = new System.Drawing.Size(90, 36);
            this.btn_cancelchange.TabIndex = 18;
            this.btn_cancelchange.Text = "Hủy thay đổi";
            this.btn_cancelchange.UseVisualStyleBackColor = true;
            this.btn_cancelchange.Click += new System.EventHandler(this.btn_cancelchange_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(113, 92);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 36);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Xóa ngành nghề";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_createsave
            // 
            this.btn_createsave.Location = new System.Drawing.Point(17, 92);
            this.btn_createsave.Name = "btn_createsave";
            this.btn_createsave.Size = new System.Drawing.Size(90, 36);
            this.btn_createsave.TabIndex = 20;
            this.btn_createsave.Text = "Thêm ngành nghề";
            this.btn_createsave.UseVisualStyleBackColor = true;
            this.btn_createsave.Click += new System.EventHandler(this.btn_createsave_Click);
            // 
            // txt_ten_nganh_nghe
            // 
            this.txt_ten_nganh_nghe.Location = new System.Drawing.Point(17, 45);
            this.txt_ten_nganh_nghe.Name = "txt_ten_nganh_nghe";
            this.txt_ten_nganh_nghe.Size = new System.Drawing.Size(282, 20);
            this.txt_ten_nganh_nghe.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngành nghề kinh doanh";
            // 
            // grid_nganh_nghe
            // 
            this.grid_nganh_nghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_nganh_nghe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten_nganh_nghe});
            this.grid_nganh_nghe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_nganh_nghe.Location = new System.Drawing.Point(0, 0);
            this.grid_nganh_nghe.Name = "grid_nganh_nghe";
            this.grid_nganh_nghe.Size = new System.Drawing.Size(480, 409);
            this.grid_nganh_nghe.TabIndex = 0;
            this.grid_nganh_nghe.DoubleClick += new System.EventHandler(this.grid_nganh_nghe_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten_nganh_nghe
            // 
            this.ten_nganh_nghe.DataPropertyName = "ten_nganh_nghe";
            this.ten_nganh_nghe.HeaderText = "Tên ngành nghề kinh doanh";
            this.ten_nganh_nghe.Name = "ten_nganh_nghe";
            this.ten_nganh_nghe.ReadOnly = true;
            // 
            // frm_quanly_nganhnghe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_nganhnghe";
            this.Text = "Danh mục ngành nghề";
            this.Load += new System.EventHandler(this.frm_quanly_nganhnghe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panMainFormBody.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_nganh_nghe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancelchange;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_createsave;
        private System.Windows.Forms.TextBox txt_ten_nganh_nghe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_nganh_nghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nganh_nghe;
    }
}