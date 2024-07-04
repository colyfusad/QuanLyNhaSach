using System.Windows.Forms;

namespace GUI_QuanLy
{
    partial class FormAdmin
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
            this.grb_thongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.txb_soDienThoai = new System.Windows.Forms.TextBox();
            this.cbb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txb_diaChi = new System.Windows.Forms.TextBox();
            this.txb_hoTen = new System.Windows.Forms.TextBox();
            this.cbb_quyen = new System.Windows.Forms.ComboBox();
            this.txb_matKhau = new System.Windows.Forms.TextBox();
            this.txb_taiKhoan = new System.Windows.Forms.TextBox();
            this.lb_soDienThoai = new System.Windows.Forms.Label();
            this.lb_gioiTinh = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.lb_diaChi = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.lb_taiKhoan = new System.Windows.Forms.Label();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.grb_chucNang = new System.Windows.Forms.GroupBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtgv_nhanSu = new System.Windows.Forms.DataGridView();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.txb_timKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.grb_thongTinNhanVien.SuspendLayout();
            this.grb_chucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_thongTinNhanVien
            // 
            this.grb_thongTinNhanVien.Controls.Add(this.txb_soDienThoai);
            this.grb_thongTinNhanVien.Controls.Add(this.cbb_gioiTinh);
            this.grb_thongTinNhanVien.Controls.Add(this.txb_email);
            this.grb_thongTinNhanVien.Controls.Add(this.dtp_ngaySinh);
            this.grb_thongTinNhanVien.Controls.Add(this.txb_diaChi);
            this.grb_thongTinNhanVien.Controls.Add(this.txb_hoTen);
            this.grb_thongTinNhanVien.Controls.Add(this.cbb_quyen);
            this.grb_thongTinNhanVien.Controls.Add(this.txb_matKhau);
            this.grb_thongTinNhanVien.Controls.Add(this.txb_taiKhoan);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_soDienThoai);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_gioiTinh);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_email);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_ngaySinh);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_diaChi);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_hoTen);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_quyen);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_matKhau);
            this.grb_thongTinNhanVien.Controls.Add(this.lb_taiKhoan);
            this.grb_thongTinNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongTinNhanVien.Location = new System.Drawing.Point(10, 50);
            this.grb_thongTinNhanVien.Name = "grb_thongTinNhanVien";
            this.grb_thongTinNhanVien.Size = new System.Drawing.Size(554, 239);
            this.grb_thongTinNhanVien.TabIndex = 0;
            this.grb_thongTinNhanVien.TabStop = false;
            this.grb_thongTinNhanVien.Text = "Thông tin nhân sự";
            // 
            // txb_soDienThoai
            // 
            this.txb_soDienThoai.Location = new System.Drawing.Point(388, 159);
            this.txb_soDienThoai.Name = "txb_soDienThoai";
            this.txb_soDienThoai.Size = new System.Drawing.Size(157, 24);
            this.txb_soDienThoai.TabIndex = 21;
            // 
            // cbb_gioiTinh
            // 
            this.cbb_gioiTinh.FormattingEnabled = true;
            this.cbb_gioiTinh.Location = new System.Drawing.Point(388, 121);
            this.cbb_gioiTinh.Name = "cbb_gioiTinh";
            this.cbb_gioiTinh.Size = new System.Drawing.Size(157, 26);
            this.cbb_gioiTinh.TabIndex = 20;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(388, 80);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(157, 24);
            this.txb_email.TabIndex = 19;
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.Location = new System.Drawing.Point(380, 36);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(165, 24);
            this.dtp_ngaySinh.TabIndex = 18;
            // 
            // txb_diaChi
            // 
            this.txb_diaChi.Location = new System.Drawing.Point(97, 202);
            this.txb_diaChi.Name = "txb_diaChi";
            this.txb_diaChi.Size = new System.Drawing.Size(448, 24);
            this.txb_diaChi.TabIndex = 17;
            // 
            // txb_hoTen
            // 
            this.txb_hoTen.Location = new System.Drawing.Point(97, 159);
            this.txb_hoTen.Name = "txb_hoTen";
            this.txb_hoTen.Size = new System.Drawing.Size(157, 24);
            this.txb_hoTen.TabIndex = 16;
            // 
            // cbb_quyen
            // 
            this.cbb_quyen.FormattingEnabled = true;
            this.cbb_quyen.Location = new System.Drawing.Point(97, 121);
            this.cbb_quyen.Name = "cbb_quyen";
            this.cbb_quyen.Size = new System.Drawing.Size(157, 26);
            this.cbb_quyen.TabIndex = 15;
            // 
            // txb_matKhau
            // 
            this.txb_matKhau.Location = new System.Drawing.Point(97, 82);
            this.txb_matKhau.Name = "txb_matKhau";
            this.txb_matKhau.Size = new System.Drawing.Size(157, 24);
            this.txb_matKhau.TabIndex = 14;
            // 
            // txb_taiKhoan
            // 
            this.txb_taiKhoan.Location = new System.Drawing.Point(97, 38);
            this.txb_taiKhoan.Name = "txb_taiKhoan";
            this.txb_taiKhoan.Size = new System.Drawing.Size(157, 24);
            this.txb_taiKhoan.TabIndex = 13;
            // 
            // lb_soDienThoai
            // 
            this.lb_soDienThoai.AutoSize = true;
            this.lb_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soDienThoai.Location = new System.Drawing.Point(282, 160);
            this.lb_soDienThoai.Name = "lb_soDienThoai";
            this.lb_soDienThoai.Size = new System.Drawing.Size(94, 18);
            this.lb_soDienThoai.TabIndex = 12;
            this.lb_soDienThoai.Text = "Số điện thoại";
            // 
            // lb_gioiTinh
            // 
            this.lb_gioiTinh.AutoSize = true;
            this.lb_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioiTinh.Location = new System.Drawing.Point(282, 122);
            this.lb_gioiTinh.Name = "lb_gioiTinh";
            this.lb_gioiTinh.Size = new System.Drawing.Size(62, 18);
            this.lb_gioiTinh.TabIndex = 11;
            this.lb_gioiTinh.Text = "Giới tính";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(282, 83);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(45, 18);
            this.lb_email.TabIndex = 10;
            this.lb_email.Text = "Email";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaySinh.Location = new System.Drawing.Point(282, 39);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(73, 18);
            this.lb_ngaySinh.TabIndex = 9;
            this.lb_ngaySinh.Text = "Ngày sinh";
            // 
            // lb_diaChi
            // 
            this.lb_diaChi.AutoSize = true;
            this.lb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diaChi.Location = new System.Drawing.Point(18, 203);
            this.lb_diaChi.Name = "lb_diaChi";
            this.lb_diaChi.Size = new System.Drawing.Size(53, 18);
            this.lb_diaChi.TabIndex = 8;
            this.lb_diaChi.Text = "Địa chỉ";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoTen.Location = new System.Drawing.Point(18, 160);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(71, 18);
            this.lb_hoTen.TabIndex = 7;
            this.lb_hoTen.Text = "Họ và tên";
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.Location = new System.Drawing.Point(18, 122);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(51, 18);
            this.lb_quyen.TabIndex = 6;
            this.lb_quyen.Text = "Quyền";
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matKhau.Location = new System.Drawing.Point(18, 83);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(69, 18);
            this.lb_matKhau.TabIndex = 5;
            this.lb_matKhau.Text = "Mật khẩu";
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.AutoSize = true;
            this.lb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taiKhoan.Location = new System.Drawing.Point(18, 39);
            this.lb_taiKhoan.Name = "lb_taiKhoan";
            this.lb_taiKhoan.Size = new System.Drawing.Size(73, 18);
            this.lb_taiKhoan.TabIndex = 4;
            this.lb_taiKhoan.Text = "Tài khoản";
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lb_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.Location = new System.Drawing.Point(301, 9);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(178, 25);
            this.lb_tieuDe.TabIndex = 1;
            this.lb_tieuDe.Text = "Quản lí nhân sự";
            // 
            // grb_chucNang
            // 
            this.grb_chucNang.Controls.Add(this.btn_lamMoi);
            this.grb_chucNang.Controls.Add(this.btn_xoa);
            this.grb_chucNang.Controls.Add(this.btn_capNhat);
            this.grb_chucNang.Controls.Add(this.btn_them);
            this.grb_chucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_chucNang.Location = new System.Drawing.Point(584, 50);
            this.grb_chucNang.Name = "grb_chucNang";
            this.grb_chucNang.Size = new System.Drawing.Size(178, 239);
            this.grb_chucNang.TabIndex = 2;
            this.grb_chucNang.TabStop = false;
            this.grb_chucNang.Text = "Chức năng";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.Color.Blue;
            this.btn_lamMoi.FlatAppearance.BorderSize = 0;
            this.btn_lamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.Location = new System.Drawing.Point(35, 192);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(109, 34);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(35, 133);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 34);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.Color.Yellow;
            this.btn_capNhat.FlatAppearance.BorderSize = 0;
            this.btn_capNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.Location = new System.Drawing.Point(35, 83);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(109, 34);
            this.btn_capNhat.TabIndex = 1;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(35, 28);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(109, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtgv_nhanSu
            // 
            this.dtgv_nhanSu.AllowUserToAddRows = false;
            this.dtgv_nhanSu.AllowUserToDeleteRows = false;
            this.dtgv_nhanSu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_nhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nhanSu.Location = new System.Drawing.Point(10, 340);
            this.dtgv_nhanSu.Name = "dtgv_nhanSu";
            this.dtgv_nhanSu.ReadOnly = true;
            this.dtgv_nhanSu.Size = new System.Drawing.Size(752, 217);
            this.dtgv_nhanSu.TabIndex = 3;
            this.dtgv_nhanSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nhanVien_CellClick);
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.BackColor = System.Drawing.Color.Transparent;
            this.lb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(12, 310);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(155, 18);
            this.lb_timKiem.TabIndex = 4;
            this.lb_timKiem.Text = "Nhập tên cần tìm kiếm";
            // 
            // txb_timKiem
            // 
            this.txb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_timKiem.Location = new System.Drawing.Point(173, 307);
            this.txb_timKiem.Name = "txb_timKiem";
            this.txb_timKiem.Size = new System.Drawing.Size(250, 24);
            this.txb_timKiem.TabIndex = 5;
            this.txb_timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_timKiem_KeyPress);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackColor = System.Drawing.Color.Aqua;
            this.btn_timKiem.FlatAppearance.BorderSize = 0;
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(438, 304);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(87, 30);
            this.btn_timKiem.TabIndex = 4;
            this.btn_timKiem.Text = "Tìm";
            this.btn_timKiem.UseVisualStyleBackColor = false;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txb_timKiem);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.dtgv_nhanSu);
            this.Controls.Add(this.grb_chucNang);
            this.Controls.Add(this.lb_tieuDe);
            this.Controls.Add(this.grb_thongTinNhanVien);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.grb_thongTinNhanVien.ResumeLayout(false);
            this.grb_thongTinNhanVien.PerformLayout();
            this.grb_chucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhanSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_thongTinNhanVien;
        private System.Windows.Forms.ComboBox cbb_quyen;
        private System.Windows.Forms.TextBox txb_matKhau;
        private System.Windows.Forms.TextBox txb_taiKhoan;
        private System.Windows.Forms.Label lb_soDienThoai;
        private System.Windows.Forms.Label lb_gioiTinh;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label lb_diaChi;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_quyen;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.Label lb_taiKhoan;
        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.GroupBox grb_chucNang;
        private System.Windows.Forms.DataGridView dtgv_nhanSu;
        private System.Windows.Forms.TextBox txb_diaChi;
        private System.Windows.Forms.TextBox txb_hoTen;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lb_timKiem;
        private System.Windows.Forms.TextBox txb_timKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txb_soDienThoai;
        private System.Windows.Forms.ComboBox cbb_gioiTinh;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
    }
}