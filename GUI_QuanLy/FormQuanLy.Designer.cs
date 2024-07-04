namespace GUI_QuanLy
{
    partial class FormQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_lichSu = new System.Windows.Forms.Button();
            this.btn_taoDon = new System.Windows.Forms.Button();
            this.btn_quanLiSach = new System.Windows.Forms.Button();
            this.btn_quanLiKhachHang = new System.Windows.Forms.Button();
            this.ptb_icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_tenTaiKhoan = new System.Windows.Forms.Label();
            this.lb_tenNhaSach = new System.Windows.Forms.Label();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.pn_body = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.btn_admin);
            this.panel1.Controls.Add(this.btn_lichSu);
            this.panel1.Controls.Add(this.btn_taoDon);
            this.panel1.Controls.Add(this.btn_quanLiSach);
            this.panel1.Controls.Add(this.btn_quanLiKhachHang);
            this.panel1.Controls.Add(this.ptb_icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 661);
            this.panel1.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Red;
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(0, 575);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(110, 86);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.IndianRed;
            this.btn_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.Location = new System.Drawing.Point(0, 480);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(110, 95);
            this.btn_admin.TabIndex = 6;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_lichSu
            // 
            this.btn_lichSu.BackColor = System.Drawing.Color.Gray;
            this.btn_lichSu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_lichSu.FlatAppearance.BorderSize = 0;
            this.btn_lichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lichSu.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichSu.Location = new System.Drawing.Point(0, 385);
            this.btn_lichSu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lichSu.Name = "btn_lichSu";
            this.btn_lichSu.Size = new System.Drawing.Size(110, 95);
            this.btn_lichSu.TabIndex = 5;
            this.btn_lichSu.Text = "Lịch sử";
            this.btn_lichSu.UseVisualStyleBackColor = false;
            this.btn_lichSu.Click += new System.EventHandler(this.btn_lichSu_Click);
            // 
            // btn_taoDon
            // 
            this.btn_taoDon.BackColor = System.Drawing.Color.Lime;
            this.btn_taoDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_taoDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_taoDon.FlatAppearance.BorderSize = 0;
            this.btn_taoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_taoDon.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoDon.Location = new System.Drawing.Point(0, 290);
            this.btn_taoDon.Margin = new System.Windows.Forms.Padding(0);
            this.btn_taoDon.Name = "btn_taoDon";
            this.btn_taoDon.Size = new System.Drawing.Size(110, 95);
            this.btn_taoDon.TabIndex = 4;
            this.btn_taoDon.Text = "Tạo đơn";
            this.btn_taoDon.UseVisualStyleBackColor = false;
            this.btn_taoDon.Click += new System.EventHandler(this.btn_taoDon_Click);
            // 
            // btn_quanLiSach
            // 
            this.btn_quanLiSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_quanLiSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quanLiSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLiSach.FlatAppearance.BorderSize = 0;
            this.btn_quanLiSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLiSach.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLiSach.Location = new System.Drawing.Point(0, 195);
            this.btn_quanLiSach.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quanLiSach.Name = "btn_quanLiSach";
            this.btn_quanLiSach.Size = new System.Drawing.Size(110, 95);
            this.btn_quanLiSach.TabIndex = 3;
            this.btn_quanLiSach.Text = "Quản lý sách";
            this.btn_quanLiSach.UseVisualStyleBackColor = false;
            this.btn_quanLiSach.Click += new System.EventHandler(this.btn_quanLiSach_Click);
            // 
            // btn_quanLiKhachHang
            // 
            this.btn_quanLiKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_quanLiKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quanLiKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLiKhachHang.FlatAppearance.BorderSize = 0;
            this.btn_quanLiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLiKhachHang.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quanLiKhachHang.Location = new System.Drawing.Point(0, 100);
            this.btn_quanLiKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quanLiKhachHang.Name = "btn_quanLiKhachHang";
            this.btn_quanLiKhachHang.Size = new System.Drawing.Size(110, 95);
            this.btn_quanLiKhachHang.TabIndex = 2;
            this.btn_quanLiKhachHang.Text = "Quản lý khách hàng";
            this.btn_quanLiKhachHang.UseVisualStyleBackColor = false;
            this.btn_quanLiKhachHang.Click += new System.EventHandler(this.btn_quanLiKhachHang_Click);
            // 
            // ptb_icon
            // 
            this.ptb_icon.BackgroundImage = global::GUI_QuanLy.Properties.Resources.favicon;
            this.ptb_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptb_icon.Location = new System.Drawing.Point(0, 0);
            this.ptb_icon.Name = "ptb_icon";
            this.ptb_icon.Size = new System.Drawing.Size(110, 100);
            this.ptb_icon.TabIndex = 0;
            this.ptb_icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lb_tenTaiKhoan);
            this.panel2.Controls.Add(this.lb_tenNhaSach);
            this.panel2.Controls.Add(this.lb_tieuDe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(110, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 100);
            this.panel2.TabIndex = 1;
            // 
            // lb_tenTaiKhoan
            // 
            this.lb_tenTaiKhoan.AutoSize = true;
            this.lb_tenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenTaiKhoan.Location = new System.Drawing.Point(525, 71);
            this.lb_tenTaiKhoan.Name = "lb_tenTaiKhoan";
            this.lb_tenTaiKhoan.Size = new System.Drawing.Size(82, 18);
            this.lb_tenTaiKhoan.TabIndex = 0;
            this.lb_tenTaiKhoan.Text = "Tài khoản";
            // 
            // lb_tenNhaSach
            // 
            this.lb_tenNhaSach.AutoSize = true;
            this.lb_tenNhaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenNhaSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_tenNhaSach.Location = new System.Drawing.Point(57, 9);
            this.lb_tenNhaSach.Name = "lb_tenNhaSach";
            this.lb_tenNhaSach.Size = new System.Drawing.Size(717, 42);
            this.lb_tenNhaSach.TabIndex = 3;
            this.lb_tenNhaSach.Text = "Nhà sách Coly - \"Bán Không Cho Thuê\"";
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.ForeColor = System.Drawing.Color.Red;
            this.lb_tieuDe.Location = new System.Drawing.Point(20, 65);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(104, 24);
            this.lb_tieuDe.TabIndex = 2;
            this.lb_tieuDe.Text = "Welcome!";
            // 
            // pn_body
            // 
            this.pn_body.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.pn_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_body.Location = new System.Drawing.Point(110, 100);
            this.pn_body.Name = "pn_body";
            this.pn_body.Size = new System.Drawing.Size(774, 561);
            this.pn_body.TabIndex = 2;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.pn_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptb_icon;
        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.Button btn_quanLiKhachHang;
        private System.Windows.Forms.Label lb_tenNhaSach;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_lichSu;
        private System.Windows.Forms.Button btn_taoDon;
        private System.Windows.Forms.Button btn_quanLiSach;
        private System.Windows.Forms.Panel pn_body;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lb_tenTaiKhoan;
    }
}