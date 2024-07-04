namespace GUI_QuanLy
{
    partial class FormQuanLiKhachHang
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
            this.dtgv_noiDung = new System.Windows.Forms.DataGridView();
            this.txb_maKhachHang = new System.Windows.Forms.TextBox();
            this.txb_hoDem = new System.Windows.Forms.TextBox();
            this.txb_ten = new System.Windows.Forms.TextBox();
            this.txb_soDienThoai = new System.Windows.Forms.TextBox();
            this.txb_chungMinhThu = new System.Windows.Forms.TextBox();
            this.txb_diaChi = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_uuDai = new System.Windows.Forms.TextBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.txb_timKiem = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.lb_timKiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_noiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_noiDung
            // 
            this.dtgv_noiDung.AllowUserToDeleteRows = false;
            this.dtgv_noiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_noiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_noiDung.Location = new System.Drawing.Point(279, 58);
            this.dtgv_noiDung.Name = "dtgv_noiDung";
            this.dtgv_noiDung.ReadOnly = true;
            this.dtgv_noiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_noiDung.Size = new System.Drawing.Size(489, 390);
            this.dtgv_noiDung.TabIndex = 0;
            this.dtgv_noiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_noiDung_CellClick);
            // 
            // txb_maKhachHang
            // 
            this.txb_maKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_maKhachHang.Location = new System.Drawing.Point(131, 58);
            this.txb_maKhachHang.Name = "txb_maKhachHang";
            this.txb_maKhachHang.Size = new System.Drawing.Size(142, 26);
            this.txb_maKhachHang.TabIndex = 1;
            // 
            // txb_hoDem
            // 
            this.txb_hoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_hoDem.Location = new System.Drawing.Point(131, 98);
            this.txb_hoDem.Name = "txb_hoDem";
            this.txb_hoDem.Size = new System.Drawing.Size(142, 26);
            this.txb_hoDem.TabIndex = 2;
            // 
            // txb_ten
            // 
            this.txb_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ten.Location = new System.Drawing.Point(131, 135);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(142, 26);
            this.txb_ten.TabIndex = 3;
            // 
            // txb_soDienThoai
            // 
            this.txb_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_soDienThoai.Location = new System.Drawing.Point(131, 170);
            this.txb_soDienThoai.Name = "txb_soDienThoai";
            this.txb_soDienThoai.Size = new System.Drawing.Size(142, 26);
            this.txb_soDienThoai.TabIndex = 4;
            // 
            // txb_chungMinhThu
            // 
            this.txb_chungMinhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_chungMinhThu.Location = new System.Drawing.Point(131, 208);
            this.txb_chungMinhThu.Name = "txb_chungMinhThu";
            this.txb_chungMinhThu.Size = new System.Drawing.Size(142, 26);
            this.txb_chungMinhThu.TabIndex = 5;
            // 
            // txb_diaChi
            // 
            this.txb_diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_diaChi.Location = new System.Drawing.Point(131, 247);
            this.txb_diaChi.Name = "txb_diaChi";
            this.txb_diaChi.Size = new System.Drawing.Size(142, 26);
            this.txb_diaChi.TabIndex = 6;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(29, 333);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 35);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BackColor = System.Drawing.Color.Yellow;
            this.btn_capNhat.FlatAppearance.BorderSize = 0;
            this.btn_capNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.ForeColor = System.Drawing.Color.Black;
            this.btn_capNhat.Location = new System.Drawing.Point(154, 333);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(83, 35);
            this.btn_capNhat.TabIndex = 8;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = false;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(29, 391);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 35);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "CMND/CCCD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ưu đãi";
            // 
            // txb_uuDai
            // 
            this.txb_uuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_uuDai.Location = new System.Drawing.Point(131, 286);
            this.txb_uuDai.Name = "txb_uuDai";
            this.txb_uuDai.Size = new System.Drawing.Size(142, 26);
            this.txb_uuDai.TabIndex = 17;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_lamMoi.FlatAppearance.BorderSize = 0;
            this.btn_lamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.ForeColor = System.Drawing.Color.Black;
            this.btn_lamMoi.Location = new System.Drawing.Point(154, 391);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(83, 35);
            this.btn_lamMoi.TabIndex = 19;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // txb_timKiem
            // 
            this.txb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_timKiem.Location = new System.Drawing.Point(443, 19);
            this.txb_timKiem.Name = "txb_timKiem";
            this.txb_timKiem.Size = new System.Drawing.Size(208, 22);
            this.txb_timKiem.TabIndex = 20;
            this.txb_timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_timKiem_KeyPress);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(657, 16);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(75, 27);
            this.btn_timKiem.TabIndex = 21;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.BackColor = System.Drawing.Color.Transparent;
            this.lb_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(279, 22);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(161, 20);
            this.lb_timKiem.TabIndex = 22;
            this.lb_timKiem.Text = "Nhập tên khách hàng";
            // 
            // FormQuanLiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txb_timKiem);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_uuDai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txb_diaChi);
            this.Controls.Add(this.txb_chungMinhThu);
            this.Controls.Add(this.txb_soDienThoai);
            this.Controls.Add(this.txb_ten);
            this.Controls.Add(this.txb_hoDem);
            this.Controls.Add(this.txb_maKhachHang);
            this.Controls.Add(this.dtgv_noiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuanLiKhachHang";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_noiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_noiDung;
        private System.Windows.Forms.TextBox txb_maKhachHang;
        private System.Windows.Forms.TextBox txb_hoDem;
        private System.Windows.Forms.TextBox txb_ten;
        private System.Windows.Forms.TextBox txb_soDienThoai;
        private System.Windows.Forms.TextBox txb_chungMinhThu;
        private System.Windows.Forms.TextBox txb_diaChi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_uuDai;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.TextBox txb_timKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Label lb_timKiem;
    }
}