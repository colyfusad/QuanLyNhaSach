namespace GUI_QuanLy
{
    partial class FormQuanLiSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_danhSachSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_maSach = new System.Windows.Forms.TextBox();
            this.txb_tenSach = new System.Windows.Forms.TextBox();
            this.txb_maLoai = new System.Windows.Forms.TextBox();
            this.txb_namXuatBan = new System.Windows.Forms.TextBox();
            this.txb_tacGia = new System.Windows.Forms.TextBox();
            this.txb_gia = new System.Windows.Forms.TextBox();
            this.txb_soLuong = new System.Windows.Forms.TextBox();
            this.lb_maSach = new System.Windows.Forms.Label();
            this.lb_tenSach = new System.Windows.Forms.Label();
            this.lb_maLoai = new System.Windows.Forms.Label();
            this.lb_namXuatBan = new System.Windows.Forms.Label();
            this.lb_tacGia = new System.Windows.Forms.Label();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_soLuong = new System.Windows.Forms.Label();
            this.btn_themSach = new System.Windows.Forms.Button();
            this.btn_xoaSach = new System.Windows.Forms.Button();
            this.btn_capNhatSach = new System.Windows.Forms.Button();
            this.btn_lamMoiSach = new System.Windows.Forms.Button();
            this.grb_locTheoLoaiSach = new System.Windows.Forms.GroupBox();
            this.cbb_loaiSach = new System.Windows.Forms.ComboBox();
            this.btn_locTheoLoaiSach = new System.Windows.Forms.Button();
            this.grb_locTheoTenSach = new System.Windows.Forms.GroupBox();
            this.txb_locTheoTenSach = new System.Windows.Forms.TextBox();
            this.btn_locTheoTenSach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhSachSach)).BeginInit();
            this.grb_locTheoLoaiSach.SuspendLayout();
            this.grb_locTheoTenSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_danhSachSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dtgv_danhSachSach
            // 
            this.dtgv_danhSachSach.AllowUserToDeleteRows = false;
            this.dtgv_danhSachSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_danhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_danhSachSach.Location = new System.Drawing.Point(8, 19);
            this.dtgv_danhSachSach.Name = "dtgv_danhSachSach";
            this.dtgv_danhSachSach.ReadOnly = true;
            this.dtgv_danhSachSach.Size = new System.Drawing.Size(753, 237);
            this.dtgv_danhSachSach.TabIndex = 0;
            this.dtgv_danhSachSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_danhSachSach_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lí sách";
            // 
            // txb_maSach
            // 
            this.txb_maSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_maSach.Location = new System.Drawing.Point(112, 379);
            this.txb_maSach.Name = "txb_maSach";
            this.txb_maSach.Size = new System.Drawing.Size(132, 22);
            this.txb_maSach.TabIndex = 3;
            // 
            // txb_tenSach
            // 
            this.txb_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tenSach.Location = new System.Drawing.Point(112, 409);
            this.txb_tenSach.Name = "txb_tenSach";
            this.txb_tenSach.Size = new System.Drawing.Size(132, 22);
            this.txb_tenSach.TabIndex = 4;
            // 
            // txb_maLoai
            // 
            this.txb_maLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_maLoai.Location = new System.Drawing.Point(112, 439);
            this.txb_maLoai.Name = "txb_maLoai";
            this.txb_maLoai.Size = new System.Drawing.Size(132, 22);
            this.txb_maLoai.TabIndex = 5;
            // 
            // txb_namXuatBan
            // 
            this.txb_namXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_namXuatBan.Location = new System.Drawing.Point(112, 469);
            this.txb_namXuatBan.Name = "txb_namXuatBan";
            this.txb_namXuatBan.Size = new System.Drawing.Size(132, 22);
            this.txb_namXuatBan.TabIndex = 6;
            // 
            // txb_tacGia
            // 
            this.txb_tacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tacGia.Location = new System.Drawing.Point(367, 379);
            this.txb_tacGia.Name = "txb_tacGia";
            this.txb_tacGia.Size = new System.Drawing.Size(132, 22);
            this.txb_tacGia.TabIndex = 6;
            // 
            // txb_gia
            // 
            this.txb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gia.Location = new System.Drawing.Point(367, 409);
            this.txb_gia.Name = "txb_gia";
            this.txb_gia.Size = new System.Drawing.Size(132, 22);
            this.txb_gia.TabIndex = 7;
            // 
            // txb_soLuong
            // 
            this.txb_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soLuong.Location = new System.Drawing.Point(367, 439);
            this.txb_soLuong.Name = "txb_soLuong";
            this.txb_soLuong.Size = new System.Drawing.Size(132, 22);
            this.txb_soLuong.TabIndex = 8;
            // 
            // lb_maSach
            // 
            this.lb_maSach.AutoSize = true;
            this.lb_maSach.BackColor = System.Drawing.Color.Transparent;
            this.lb_maSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maSach.Location = new System.Drawing.Point(10, 381);
            this.lb_maSach.Name = "lb_maSach";
            this.lb_maSach.Size = new System.Drawing.Size(65, 18);
            this.lb_maSach.TabIndex = 9;
            this.lb_maSach.Text = "Mã sách";
            // 
            // lb_tenSach
            // 
            this.lb_tenSach.AutoSize = true;
            this.lb_tenSach.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenSach.Location = new System.Drawing.Point(10, 411);
            this.lb_tenSach.Name = "lb_tenSach";
            this.lb_tenSach.Size = new System.Drawing.Size(69, 18);
            this.lb_tenSach.TabIndex = 10;
            this.lb_tenSach.Text = "Tên sách";
            // 
            // lb_maLoai
            // 
            this.lb_maLoai.AutoSize = true;
            this.lb_maLoai.BackColor = System.Drawing.Color.Transparent;
            this.lb_maLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maLoai.Location = new System.Drawing.Point(10, 441);
            this.lb_maLoai.Name = "lb_maLoai";
            this.lb_maLoai.Size = new System.Drawing.Size(56, 18);
            this.lb_maLoai.TabIndex = 11;
            this.lb_maLoai.Text = "Mã loại";
            // 
            // lb_namXuatBan
            // 
            this.lb_namXuatBan.AutoSize = true;
            this.lb_namXuatBan.BackColor = System.Drawing.Color.Transparent;
            this.lb_namXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namXuatBan.Location = new System.Drawing.Point(10, 471);
            this.lb_namXuatBan.Name = "lb_namXuatBan";
            this.lb_namXuatBan.Size = new System.Drawing.Size(99, 18);
            this.lb_namXuatBan.TabIndex = 12;
            this.lb_namXuatBan.Text = "Năm xuất bản";
            // 
            // lb_tacGia
            // 
            this.lb_tacGia.AutoSize = true;
            this.lb_tacGia.BackColor = System.Drawing.Color.Transparent;
            this.lb_tacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tacGia.Location = new System.Drawing.Point(291, 382);
            this.lb_tacGia.Name = "lb_tacGia";
            this.lb_tacGia.Size = new System.Drawing.Size(56, 18);
            this.lb_tacGia.TabIndex = 13;
            this.lb_tacGia.Text = "Tác giả";
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.BackColor = System.Drawing.Color.Transparent;
            this.lb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.Location = new System.Drawing.Point(291, 412);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(31, 18);
            this.lb_gia.TabIndex = 14;
            this.lb_gia.Text = "Giá";
            // 
            // lb_soLuong
            // 
            this.lb_soLuong.AutoSize = true;
            this.lb_soLuong.BackColor = System.Drawing.Color.Transparent;
            this.lb_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soLuong.Location = new System.Drawing.Point(291, 442);
            this.lb_soLuong.Name = "lb_soLuong";
            this.lb_soLuong.Size = new System.Drawing.Size(67, 18);
            this.lb_soLuong.TabIndex = 15;
            this.lb_soLuong.Text = "Số lượng";
            // 
            // btn_themSach
            // 
            this.btn_themSach.BackColor = System.Drawing.Color.Lime;
            this.btn_themSach.FlatAppearance.BorderSize = 0;
            this.btn_themSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themSach.Location = new System.Drawing.Point(533, 378);
            this.btn_themSach.Name = "btn_themSach";
            this.btn_themSach.Size = new System.Drawing.Size(74, 34);
            this.btn_themSach.TabIndex = 16;
            this.btn_themSach.Text = "Thêm";
            this.btn_themSach.UseVisualStyleBackColor = false;
            this.btn_themSach.Click += new System.EventHandler(this.btn_themSach_Click);
            // 
            // btn_xoaSach
            // 
            this.btn_xoaSach.BackColor = System.Drawing.Color.Red;
            this.btn_xoaSach.FlatAppearance.BorderSize = 0;
            this.btn_xoaSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaSach.Location = new System.Drawing.Point(533, 431);
            this.btn_xoaSach.Name = "btn_xoaSach";
            this.btn_xoaSach.Size = new System.Drawing.Size(74, 34);
            this.btn_xoaSach.TabIndex = 17;
            this.btn_xoaSach.Text = "Xóa";
            this.btn_xoaSach.UseVisualStyleBackColor = false;
            this.btn_xoaSach.Click += new System.EventHandler(this.btn_xoaSach_Click);
            // 
            // btn_capNhatSach
            // 
            this.btn_capNhatSach.BackColor = System.Drawing.Color.Yellow;
            this.btn_capNhatSach.FlatAppearance.BorderSize = 0;
            this.btn_capNhatSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhatSach.Location = new System.Drawing.Point(634, 378);
            this.btn_capNhatSach.Name = "btn_capNhatSach";
            this.btn_capNhatSach.Size = new System.Drawing.Size(94, 34);
            this.btn_capNhatSach.TabIndex = 18;
            this.btn_capNhatSach.Text = "Cập nhật";
            this.btn_capNhatSach.UseVisualStyleBackColor = false;
            this.btn_capNhatSach.Click += new System.EventHandler(this.btn_capNhatSach_Click);
            // 
            // btn_lamMoiSach
            // 
            this.btn_lamMoiSach.BackColor = System.Drawing.Color.Blue;
            this.btn_lamMoiSach.FlatAppearance.BorderSize = 0;
            this.btn_lamMoiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lamMoiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoiSach.Location = new System.Drawing.Point(634, 432);
            this.btn_lamMoiSach.Name = "btn_lamMoiSach";
            this.btn_lamMoiSach.Size = new System.Drawing.Size(94, 34);
            this.btn_lamMoiSach.TabIndex = 19;
            this.btn_lamMoiSach.Text = "Làm mới";
            this.btn_lamMoiSach.UseVisualStyleBackColor = false;
            this.btn_lamMoiSach.Click += new System.EventHandler(this.btn_lamMoiSach_Click);
            // 
            // grb_locTheoLoaiSach
            // 
            this.grb_locTheoLoaiSach.Controls.Add(this.cbb_loaiSach);
            this.grb_locTheoLoaiSach.Controls.Add(this.btn_locTheoLoaiSach);
            this.grb_locTheoLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_locTheoLoaiSach.Location = new System.Drawing.Point(12, 49);
            this.grb_locTheoLoaiSach.Name = "grb_locTheoLoaiSach";
            this.grb_locTheoLoaiSach.Size = new System.Drawing.Size(335, 49);
            this.grb_locTheoLoaiSach.TabIndex = 20;
            this.grb_locTheoLoaiSach.TabStop = false;
            this.grb_locTheoLoaiSach.Text = "Lọc theo loại sách";
            // 
            // cbb_loaiSach
            // 
            this.cbb_loaiSach.FormattingEnabled = true;
            this.cbb_loaiSach.Location = new System.Drawing.Point(35, 19);
            this.cbb_loaiSach.Name = "cbb_loaiSach";
            this.cbb_loaiSach.Size = new System.Drawing.Size(197, 24);
            this.cbb_loaiSach.TabIndex = 4;
            // 
            // btn_locTheoLoaiSach
            // 
            this.btn_locTheoLoaiSach.BackColor = System.Drawing.Color.Lime;
            this.btn_locTheoLoaiSach.FlatAppearance.BorderSize = 0;
            this.btn_locTheoLoaiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_locTheoLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_locTheoLoaiSach.Location = new System.Drawing.Point(252, 14);
            this.btn_locTheoLoaiSach.Name = "btn_locTheoLoaiSach";
            this.btn_locTheoLoaiSach.Size = new System.Drawing.Size(77, 30);
            this.btn_locTheoLoaiSach.TabIndex = 3;
            this.btn_locTheoLoaiSach.Text = "Lọc";
            this.btn_locTheoLoaiSach.UseVisualStyleBackColor = false;
            this.btn_locTheoLoaiSach.Click += new System.EventHandler(this.btn_locTheoLoaiSach_Click);
            // 
            // grb_locTheoTenSach
            // 
            this.grb_locTheoTenSach.Controls.Add(this.txb_locTheoTenSach);
            this.grb_locTheoTenSach.Controls.Add(this.btn_locTheoTenSach);
            this.grb_locTheoTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_locTheoTenSach.Location = new System.Drawing.Point(431, 49);
            this.grb_locTheoTenSach.Name = "grb_locTheoTenSach";
            this.grb_locTheoTenSach.Size = new System.Drawing.Size(335, 49);
            this.grb_locTheoTenSach.TabIndex = 21;
            this.grb_locTheoTenSach.TabStop = false;
            this.grb_locTheoTenSach.Text = "Lọc theo tên sách";
            // 
            // txb_locTheoTenSach
            // 
            this.txb_locTheoTenSach.Location = new System.Drawing.Point(40, 19);
            this.txb_locTheoTenSach.Name = "txb_locTheoTenSach";
            this.txb_locTheoTenSach.Size = new System.Drawing.Size(193, 22);
            this.txb_locTheoTenSach.TabIndex = 4;
            this.txb_locTheoTenSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_locTheoTenSach_KeyPress);
            // 
            // btn_locTheoTenSach
            // 
            this.btn_locTheoTenSach.BackColor = System.Drawing.Color.Lime;
            this.btn_locTheoTenSach.FlatAppearance.BorderSize = 0;
            this.btn_locTheoTenSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_locTheoTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_locTheoTenSach.Location = new System.Drawing.Point(252, 14);
            this.btn_locTheoTenSach.Name = "btn_locTheoTenSach";
            this.btn_locTheoTenSach.Size = new System.Drawing.Size(77, 30);
            this.btn_locTheoTenSach.TabIndex = 3;
            this.btn_locTheoTenSach.Text = "Lọc";
            this.btn_locTheoTenSach.UseVisualStyleBackColor = false;
            this.btn_locTheoTenSach.Click += new System.EventHandler(this.btn_locTheoTenSach_Click);
            // 
            // FormQuanLiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.grb_locTheoTenSach);
            this.Controls.Add(this.grb_locTheoLoaiSach);
            this.Controls.Add(this.btn_lamMoiSach);
            this.Controls.Add(this.btn_capNhatSach);
            this.Controls.Add(this.btn_xoaSach);
            this.Controls.Add(this.btn_themSach);
            this.Controls.Add(this.lb_soLuong);
            this.Controls.Add(this.lb_gia);
            this.Controls.Add(this.lb_tacGia);
            this.Controls.Add(this.lb_namXuatBan);
            this.Controls.Add(this.lb_maLoai);
            this.Controls.Add(this.lb_tenSach);
            this.Controls.Add(this.lb_maSach);
            this.Controls.Add(this.txb_soLuong);
            this.Controls.Add(this.txb_gia);
            this.Controls.Add(this.txb_tacGia);
            this.Controls.Add(this.txb_namXuatBan);
            this.Controls.Add(this.txb_maLoai);
            this.Controls.Add(this.txb_tenSach);
            this.Controls.Add(this.txb_maSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLiSach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.FormQuanLiSach_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_danhSachSach)).EndInit();
            this.grb_locTheoLoaiSach.ResumeLayout(false);
            this.grb_locTheoTenSach.ResumeLayout(false);
            this.grb_locTheoTenSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_danhSachSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_maSach;
        private System.Windows.Forms.TextBox txb_tenSach;
        private System.Windows.Forms.TextBox txb_maLoai;
        private System.Windows.Forms.TextBox txb_namXuatBan;
        private System.Windows.Forms.TextBox txb_tacGia;
        private System.Windows.Forms.TextBox txb_gia;
        private System.Windows.Forms.TextBox txb_soLuong;
        private System.Windows.Forms.Label lb_maSach;
        private System.Windows.Forms.Label lb_tenSach;
        private System.Windows.Forms.Label lb_maLoai;
        private System.Windows.Forms.Label lb_namXuatBan;
        private System.Windows.Forms.Label lb_tacGia;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_soLuong;
        private System.Windows.Forms.Button btn_themSach;
        private System.Windows.Forms.Button btn_xoaSach;
        private System.Windows.Forms.Button btn_capNhatSach;
        private System.Windows.Forms.Button btn_lamMoiSach;
        private System.Windows.Forms.GroupBox grb_locTheoLoaiSach;
        private System.Windows.Forms.ComboBox cbb_loaiSach;
        private System.Windows.Forms.Button btn_locTheoLoaiSach;
        private System.Windows.Forms.GroupBox grb_locTheoTenSach;
        private System.Windows.Forms.TextBox txb_locTheoTenSach;
        private System.Windows.Forms.Button btn_locTheoTenSach;
    }
}