using System.Drawing;

namespace GUI_QuanLy
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_taiKhoan = new System.Windows.Forms.Label();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.txb_taiKhoan = new System.Windows.Forms.TextBox();
            this.txb_matKhau = new System.Windows.Forms.TextBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(193, 15);
            this.lb_title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(126, 28);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Đăng nhập";
            // 
            // lb_taiKhoan
            // 
            this.lb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taiKhoan.Location = new System.Drawing.Point(25, 45);
            this.lb_taiKhoan.Name = "lb_taiKhoan";
            this.lb_taiKhoan.Size = new System.Drawing.Size(84, 26);
            this.lb_taiKhoan.TabIndex = 1;
            this.lb_taiKhoan.Text = "Tài khoản";
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matKhau.Location = new System.Drawing.Point(25, 92);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(84, 26);
            this.lb_matKhau.TabIndex = 2;
            this.lb_matKhau.Text = "Mật khẩu";
            // 
            // txb_taiKhoan
            // 
            this.txb_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_taiKhoan.Location = new System.Drawing.Point(128, 42);
            this.txb_taiKhoan.Name = "txb_taiKhoan";
            this.txb_taiKhoan.Size = new System.Drawing.Size(168, 26);
            this.txb_taiKhoan.TabIndex = 3;
            // 
            // txb_matKhau
            // 
            this.txb_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_matKhau.Location = new System.Drawing.Point(128, 89);
            this.txb_matKhau.Name = "txb_matKhau";
            this.txb_matKhau.PasswordChar = '*';
            this.txb_matKhau.Size = new System.Drawing.Size(168, 26);
            this.txb_matKhau.TabIndex = 4;
            this.txb_matKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_matKhau_KeyPress);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AutoSize = true;
            this.btn_dangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dangNhap.FlatAppearance.BorderSize = 0;
            this.btn_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(105, 139);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(98, 32);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.txb_taiKhoan);
            this.groupBox1.Controls.Add(this.btn_dangNhap);
            this.groupBox1.Controls.Add(this.lb_taiKhoan);
            this.groupBox1.Controls.Add(this.txb_matKhau);
            this.groupBox1.Controls.Add(this.lb_matKhau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSize = true;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(236, 139);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(60, 32);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(511, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_taiKhoan;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.TextBox txb_matKhau;
        private System.Windows.Forms.TextBox txb_taiKhoan;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
    }
}