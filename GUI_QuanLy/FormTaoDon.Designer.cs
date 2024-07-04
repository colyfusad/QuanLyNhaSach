namespace GUI_QuanLy
{
    partial class FormTaoDon
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
            this.txb_timKiem = new System.Windows.Forms.TextBox();
            this.dtgv_thongTinSach = new System.Windows.Forms.DataGridView();
            this.dtgv_chiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xuatDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_maSach = new System.Windows.Forms.TextBox();
            this.txb_tenSach = new System.Windows.Forms.TextBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_soLuong = new System.Windows.Forms.TextBox();
            this.txb_gia = new System.Windows.Forms.TextBox();
            this.txb_soLuongKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_tongDon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_hangDuocChon = new System.Windows.Forms.TextBox();
            this.lb_maKhachHang = new System.Windows.Forms.Label();
            this.txb_maKhachHang = new System.Windows.Forms.TextBox();
            this.btn_kiemTraMaKhachHang = new System.Windows.Forms.Button();
            this.lb_tenKhachHang = new System.Windows.Forms.Label();
            this.lb_uuDai = new System.Windows.Forms.Label();
            this.txb_tenKhachHang = new System.Windows.Forms.TextBox();
            this.txb_uuDai = new System.Windows.Forms.TextBox();
            this.saveFileDialog_exportPDF = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongTinSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chiTietHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_timKiem
            // 
            this.txb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_timKiem.Location = new System.Drawing.Point(177, 40);
            this.txb_timKiem.Name = "txb_timKiem";
            this.txb_timKiem.Size = new System.Drawing.Size(325, 24);
            this.txb_timKiem.TabIndex = 0;
            this.txb_timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_timKiem_KeyPress);
            // 
            // dtgv_thongTinSach
            // 
            this.dtgv_thongTinSach.AllowUserToAddRows = false;
            this.dtgv_thongTinSach.AllowUserToDeleteRows = false;
            this.dtgv_thongTinSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_thongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongTinSach.Location = new System.Drawing.Point(6, 19);
            this.dtgv_thongTinSach.Name = "dtgv_thongTinSach";
            this.dtgv_thongTinSach.ReadOnly = true;
            this.dtgv_thongTinSach.Size = new System.Drawing.Size(750, 130);
            this.dtgv_thongTinSach.TabIndex = 1;
            this.dtgv_thongTinSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thongTinSach_CellClick);
            // 
            // dtgv_chiTietHoaDon
            // 
            this.dtgv_chiTietHoaDon.AllowUserToDeleteRows = false;
            this.dtgv_chiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_chiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_chiTietHoaDon.Location = new System.Drawing.Point(6, 23);
            this.dtgv_chiTietHoaDon.Name = "dtgv_chiTietHoaDon";
            this.dtgv_chiTietHoaDon.ReadOnly = true;
            this.dtgv_chiTietHoaDon.Size = new System.Drawing.Size(750, 140);
            this.dtgv_chiTietHoaDon.TabIndex = 2;
            this.dtgv_chiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_chiTietHoaDon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_chiTietHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 169);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tạo đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_thongTinSach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 155);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // btn_xuatDon
            // 
            this.btn_xuatDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_xuatDon.FlatAppearance.BorderSize = 0;
            this.btn_xuatDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuatDon.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatDon.Location = new System.Drawing.Point(657, 524);
            this.btn_xuatDon.Name = "btn_xuatDon";
            this.btn_xuatDon.Size = new System.Drawing.Size(105, 31);
            this.btn_xuatDon.TabIndex = 2;
            this.btn_xuatDon.Text = "Xuất đơn";
            this.btn_xuatDon.UseVisualStyleBackColor = false;
            this.btn_xuatDon.Click += new System.EventHandler(this.btn_xuatDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập mã sách cần tìm";
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(508, 39);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 27);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(687, 265);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 27);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(243, 466);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 27);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã sách và tên sách được chọn:";
            // 
            // txb_maSach
            // 
            this.txb_maSach.Enabled = false;
            this.txb_maSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_maSach.Location = new System.Drawing.Point(243, 233);
            this.txb_maSach.Name = "txb_maSach";
            this.txb_maSach.Size = new System.Drawing.Size(118, 24);
            this.txb_maSach.TabIndex = 12;
            // 
            // txb_tenSach
            // 
            this.txb_tenSach.Enabled = false;
            this.txb_tenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tenSach.Location = new System.Drawing.Point(378, 233);
            this.txb_tenSach.Name = "txb_tenSach";
            this.txb_tenSach.Size = new System.Drawing.Size(178, 24);
            this.txb_tenSach.TabIndex = 13;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.Location = new System.Drawing.Point(604, 39);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 27);
            this.btn_lamMoi.TabIndex = 14;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhập số lượng:";
            // 
            // txb_soLuong
            // 
            this.txb_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soLuong.Location = new System.Drawing.Point(575, 266);
            this.txb_soLuong.Name = "txb_soLuong";
            this.txb_soLuong.Size = new System.Drawing.Size(104, 24);
            this.txb_soLuong.TabIndex = 16;
            this.txb_soLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_soLuong_KeyPress);
            // 
            // txb_gia
            // 
            this.txb_gia.Enabled = false;
            this.txb_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gia.Location = new System.Drawing.Point(243, 266);
            this.txb_gia.Name = "txb_gia";
            this.txb_gia.Size = new System.Drawing.Size(100, 24);
            this.txb_gia.TabIndex = 17;
            // 
            // txb_soLuongKho
            // 
            this.txb_soLuongKho.Enabled = false;
            this.txb_soLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soLuongKho.Location = new System.Drawing.Point(356, 266);
            this.txb_soLuongKho.Name = "txb_soLuongKho";
            this.txb_soLuongKho.Size = new System.Drawing.Size(76, 24);
            this.txb_soLuongKho.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá và số lượng sách trong kho:";
            // 
            // lb_tongDon
            // 
            this.lb_tongDon.AutoSize = true;
            this.lb_tongDon.BackColor = System.Drawing.Color.Transparent;
            this.lb_tongDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongDon.Location = new System.Drawing.Point(504, 497);
            this.lb_tongDon.Name = "lb_tongDon";
            this.lb_tongDon.Size = new System.Drawing.Size(146, 20);
            this.lb_tongDon.TabIndex = 20;
            this.lb_tongDon.Text = "Tổng tiền: 0 VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Hàng đang được chọn:";
            // 
            // txb_hangDuocChon
            // 
            this.txb_hangDuocChon.Enabled = false;
            this.txb_hangDuocChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_hangDuocChon.Location = new System.Drawing.Point(157, 467);
            this.txb_hangDuocChon.Name = "txb_hangDuocChon";
            this.txb_hangDuocChon.Size = new System.Drawing.Size(76, 24);
            this.txb_hangDuocChon.TabIndex = 22;
            // 
            // lb_maKhachHang
            // 
            this.lb_maKhachHang.AutoSize = true;
            this.lb_maKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lb_maKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maKhachHang.Location = new System.Drawing.Point(0, 499);
            this.lb_maKhachHang.Name = "lb_maKhachHang";
            this.lb_maKhachHang.Size = new System.Drawing.Size(171, 18);
            this.lb_maKhachHang.TabIndex = 23;
            this.lb_maKhachHang.Text = "Nhập mã khách hàng:";
            // 
            // txb_maKhachHang
            // 
            this.txb_maKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_maKhachHang.Location = new System.Drawing.Point(177, 497);
            this.txb_maKhachHang.Name = "txb_maKhachHang";
            this.txb_maKhachHang.Size = new System.Drawing.Size(104, 24);
            this.txb_maKhachHang.TabIndex = 24;
            this.txb_maKhachHang.TextChanged += new System.EventHandler(this.txb_maKhachHang_TextChanged);
            this.txb_maKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_maKhachHang_KeyPress);
            // 
            // btn_kiemTraMaKhachHang
            // 
            this.btn_kiemTraMaKhachHang.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_kiemTraMaKhachHang.FlatAppearance.BorderSize = 0;
            this.btn_kiemTraMaKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kiemTraMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kiemTraMaKhachHang.Location = new System.Drawing.Point(287, 496);
            this.btn_kiemTraMaKhachHang.Name = "btn_kiemTraMaKhachHang";
            this.btn_kiemTraMaKhachHang.Size = new System.Drawing.Size(84, 25);
            this.btn_kiemTraMaKhachHang.TabIndex = 26;
            this.btn_kiemTraMaKhachHang.Text = "Kiểm tra";
            this.btn_kiemTraMaKhachHang.UseVisualStyleBackColor = false;
            this.btn_kiemTraMaKhachHang.Click += new System.EventHandler(this.btn_kiemTraMaKhachHang_Click);
            // 
            // lb_tenKhachHang
            // 
            this.lb_tenKhachHang.AutoSize = true;
            this.lb_tenKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenKhachHang.Location = new System.Drawing.Point(3, 531);
            this.lb_tenKhachHang.Name = "lb_tenKhachHang";
            this.lb_tenKhachHang.Size = new System.Drawing.Size(117, 18);
            this.lb_tenKhachHang.TabIndex = 27;
            this.lb_tenKhachHang.Text = "Tên khách hàng:";
            // 
            // lb_uuDai
            // 
            this.lb_uuDai.AutoSize = true;
            this.lb_uuDai.BackColor = System.Drawing.Color.Transparent;
            this.lb_uuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uuDai.Location = new System.Drawing.Point(367, 531);
            this.lb_uuDai.Name = "lb_uuDai";
            this.lb_uuDai.Size = new System.Drawing.Size(54, 18);
            this.lb_uuDai.TabIndex = 28;
            this.lb_uuDai.Text = "Ưu đãi:";
            // 
            // txb_tenKhachHang
            // 
            this.txb_tenKhachHang.Enabled = false;
            this.txb_tenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tenKhachHang.Location = new System.Drawing.Point(126, 528);
            this.txb_tenKhachHang.Name = "txb_tenKhachHang";
            this.txb_tenKhachHang.Size = new System.Drawing.Size(235, 24);
            this.txb_tenKhachHang.TabIndex = 29;
            // 
            // txb_uuDai
            // 
            this.txb_uuDai.Enabled = false;
            this.txb_uuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_uuDai.Location = new System.Drawing.Point(417, 528);
            this.txb_uuDai.Name = "txb_uuDai";
            this.txb_uuDai.Size = new System.Drawing.Size(76, 24);
            this.txb_uuDai.TabIndex = 30;
            this.txb_uuDai.TextChanged += new System.EventHandler(this.txb_uuDai_TextChanged);
            // 
            // saveFileDialog_exportPDF
            // 
            this.saveFileDialog_exportPDF.Filter = "PDF|*.pdf";
            // 
            // FormTaoDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.txb_uuDai);
            this.Controls.Add(this.txb_tenKhachHang);
            this.Controls.Add(this.lb_uuDai);
            this.Controls.Add(this.lb_tenKhachHang);
            this.Controls.Add(this.btn_kiemTraMaKhachHang);
            this.Controls.Add(this.txb_maKhachHang);
            this.Controls.Add(this.lb_maKhachHang);
            this.Controls.Add(this.txb_hangDuocChon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_tongDon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_soLuongKho);
            this.Controls.Add(this.txb_gia);
            this.Controls.Add(this.txb_soLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.txb_tenSach);
            this.Controls.Add(this.txb_maSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xuatDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txb_timKiem);
            this.Name = "FormTaoDon";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Tạo đơn";
            this.Load += new System.EventHandler(this.FormTaoDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongTinSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_chiTietHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_timKiem;
        private System.Windows.Forms.DataGridView dtgv_thongTinSach;
        private System.Windows.Forms.DataGridView dtgv_chiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xuatDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_maSach;
        private System.Windows.Forms.TextBox txb_tenSach;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_soLuong;
        private System.Windows.Forms.TextBox txb_gia;
        private System.Windows.Forms.TextBox txb_soLuongKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_tongDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_hangDuocChon;
        private System.Windows.Forms.Label lb_maKhachHang;
        private System.Windows.Forms.TextBox txb_maKhachHang;
        private System.Windows.Forms.Button btn_kiemTraMaKhachHang;
        private System.Windows.Forms.Label lb_tenKhachHang;
        private System.Windows.Forms.Label lb_uuDai;
        private System.Windows.Forms.TextBox txb_tenKhachHang;
        private System.Windows.Forms.TextBox txb_uuDai;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_exportPDF;
    }
}