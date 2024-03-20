namespace _22133047_LeVanSang_Anh
{
    partial class Form1
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
            this.lbl_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.pic_Anh = new System.Windows.Forms.PictureBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.btn_ChonAnh = new System.Windows.Forms.Button();
            this.btn_XemDanhSach = new System.Windows.Forms.Button();
            this.dg_DanhSach = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ThongTinNhanVien
            // 
            this.lbl_ThongTinNhanVien.Location = new System.Drawing.Point(46, 9);
            this.lbl_ThongTinNhanVien.Name = "lbl_ThongTinNhanVien";
            this.lbl_ThongTinNhanVien.Size = new System.Drawing.Size(173, 25);
            this.lbl_ThongTinNhanVien.TabIndex = 0;
            this.lbl_ThongTinNhanVien.Text = "Thông tin nhân viên";
            this.lbl_ThongTinNhanVien.Click += new System.EventHandler(this.lbl_ThongTinNhanVien_Click);
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.Location = new System.Drawing.Point(46, 79);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(81, 25);
            this.lbl_MaNV.TabIndex = 1;
            this.lbl_MaNV.Text = "Mã NV:";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.Location = new System.Drawing.Point(46, 125);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(81, 25);
            this.lbl_TenNV.TabIndex = 2;
            this.lbl_TenNV.Text = "Tên NV:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ảnh:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(103, 37);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(102, 30);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // pic_Anh
            // 
            this.pic_Anh.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pic_Anh.Location = new System.Drawing.Point(58, 196);
            this.pic_Anh.Name = "pic_Anh";
            this.pic_Anh.Size = new System.Drawing.Size(271, 192);
            this.pic_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Anh.TabIndex = 5;
            this.pic_Anh.TabStop = false;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(150, 79);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(125, 22);
            this.txt_MaNV.TabIndex = 6;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(150, 125);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(125, 22);
            this.txt_TenNV.TabIndex = 7;
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.Location = new System.Drawing.Point(130, 408);
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.Size = new System.Drawing.Size(102, 30);
            this.btn_ChonAnh.TabIndex = 8;
            this.btn_ChonAnh.Text = "Chọn ảnh";
            this.btn_ChonAnh.UseVisualStyleBackColor = true;
            this.btn_ChonAnh.Click += new System.EventHandler(this.btn_ChonAnh_Click);
            // 
            // btn_XemDanhSach
            // 
            this.btn_XemDanhSach.Location = new System.Drawing.Point(531, 71);
            this.btn_XemDanhSach.Name = "btn_XemDanhSach";
            this.btn_XemDanhSach.Size = new System.Drawing.Size(102, 30);
            this.btn_XemDanhSach.TabIndex = 9;
            this.btn_XemDanhSach.Text = "Xem DS";
            this.btn_XemDanhSach.UseVisualStyleBackColor = true;
            this.btn_XemDanhSach.Click += new System.EventHandler(this.btn_XemDanhSach_Click);
            // 
            // dg_DanhSach
            // 
            this.dg_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Anh});
            this.dg_DanhSach.Location = new System.Drawing.Point(367, 125);
            this.dg_DanhSach.Name = "dg_DanhSach";
            this.dg_DanhSach.RowHeadersWidth = 51;
            this.dg_DanhSach.RowTemplate.Height = 24;
            this.dg_DanhSach.Size = new System.Drawing.Size(471, 263);
            this.dg_DanhSach.TabIndex = 10;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.Width = 125;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 125;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Anh.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this.dg_DanhSach);
            this.Controls.Add(this.btn_XemDanhSach);
            this.Controls.Add(this.btn_ChonAnh);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.pic_Anh);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lbl_ThongTinNhanVien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ThongTinNhanVien;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.PictureBox pic_Anh;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Button btn_ChonAnh;
        private System.Windows.Forms.Button btn_XemDanhSach;
        private System.Windows.Forms.DataGridView dg_DanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
    }
}

