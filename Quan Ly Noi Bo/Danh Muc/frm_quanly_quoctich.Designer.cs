namespace QuanLyDangKyDoanhNghiep.Quan_Ly_Noi_Bo.Danh_Muc
{
    partial class frm_quanly_quoctich
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panMainFormBody = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ten_quoc_tich = new System.Windows.Forms.TextBox();
            this.btn_cancelchange = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_createsave = new System.Windows.Forms.Button();
            this.grid_quoc_tich = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_quoc_tich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panMainFormBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_quoc_tich)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục quốc tịch";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancelchange);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_createsave);
            this.panel2.Controls.Add(this.txt_ten_quoc_tich);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 409);
            this.panel2.TabIndex = 2;
            // 
            // panMainFormBody
            // 
            this.panMainFormBody.Controls.Add(this.grid_quoc_tich);
            this.panMainFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMainFormBody.Location = new System.Drawing.Point(322, 41);
            this.panMainFormBody.Name = "panMainFormBody";
            this.panMainFormBody.Size = new System.Drawing.Size(478, 409);
            this.panMainFormBody.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên quốc gia";
            // 
            // txt_ten_quoc_tich
            // 
            this.txt_ten_quoc_tich.Location = new System.Drawing.Point(114, 24);
            this.txt_ten_quoc_tich.Name = "txt_ten_quoc_tich";
            this.txt_ten_quoc_tich.Size = new System.Drawing.Size(185, 20);
            this.txt_ten_quoc_tich.TabIndex = 1;
            // 
            // btn_cancelchange
            // 
            this.btn_cancelchange.Location = new System.Drawing.Point(210, 72);
            this.btn_cancelchange.Name = "btn_cancelchange";
            this.btn_cancelchange.Size = new System.Drawing.Size(90, 23);
            this.btn_cancelchange.TabIndex = 5;
            this.btn_cancelchange.Text = "Hủy thay đổi";
            this.btn_cancelchange.UseVisualStyleBackColor = true;
            this.btn_cancelchange.Click += new System.EventHandler(this.btn_cancelchange_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(114, 72);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Xóa quốc gia";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_createsave
            // 
            this.btn_createsave.Location = new System.Drawing.Point(18, 72);
            this.btn_createsave.Name = "btn_createsave";
            this.btn_createsave.Size = new System.Drawing.Size(90, 23);
            this.btn_createsave.TabIndex = 7;
            this.btn_createsave.Text = "Thêm quốc gia";
            this.btn_createsave.UseVisualStyleBackColor = true;
            this.btn_createsave.Click += new System.EventHandler(this.btn_createsave_Click);
            // 
            // grid_quoc_tich
            // 
            this.grid_quoc_tich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_quoc_tich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten_quoc_tich});
            this.grid_quoc_tich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_quoc_tich.Location = new System.Drawing.Point(0, 0);
            this.grid_quoc_tich.Name = "grid_quoc_tich";
            this.grid_quoc_tich.Size = new System.Drawing.Size(478, 409);
            this.grid_quoc_tich.TabIndex = 0;
            this.grid_quoc_tich.DoubleClick += new System.EventHandler(this.grid_quoc_tich_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ten_quoc_tich
            // 
            this.ten_quoc_tich.DataPropertyName = "ten_quoc_tich";
            this.ten_quoc_tich.HeaderText = "Quốc Gia";
            this.ten_quoc_tich.Name = "ten_quoc_tich";
            this.ten_quoc_tich.ReadOnly = true;
            // 
            // frm_quanly_quoctich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMainFormBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_quanly_quoctich";
            this.Text = "Danh mục quốc tịch";
            this.Load += new System.EventHandler(this.frm_quanly_quoctich_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panMainFormBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_quoc_tich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panMainFormBody;
        private System.Windows.Forms.TextBox txt_ten_quoc_tich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelchange;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_createsave;
        private System.Windows.Forms.DataGridView grid_quoc_tich;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_quoc_tich;
    }
}