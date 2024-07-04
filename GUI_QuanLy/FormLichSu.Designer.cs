namespace GUI_QuanLy
{
    partial class FormLichSu
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
            this.grb_noiDung = new System.Windows.Forms.GroupBox();
            this.dtgv_noiDung = new System.Windows.Forms.DataGridView();
            this.dtp_tu = new System.Windows.Forms.DateTimePicker();
            this.dtp_den = new System.Windows.Forms.DateTimePicker();
            this.lb_from = new System.Windows.Forms.Label();
            this.lb_to = new System.Windows.Forms.Label();
            this.btn_loc = new System.Windows.Forms.Button();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.grb_loc = new System.Windows.Forms.GroupBox();
            this.cbb_maLoai = new System.Windows.Forms.ComboBox();
            this.lb_loaiSach = new System.Windows.Forms.Label();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.saveFileDialog_exportExcel = new System.Windows.Forms.SaveFileDialog();
            this.grb_noiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_noiDung)).BeginInit();
            this.grb_loc.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_noiDung
            // 
            this.grb_noiDung.Controls.Add(this.dtgv_noiDung);
            this.grb_noiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_noiDung.Location = new System.Drawing.Point(12, 165);
            this.grb_noiDung.Name = "grb_noiDung";
            this.grb_noiDung.Size = new System.Drawing.Size(750, 329);
            this.grb_noiDung.TabIndex = 0;
            this.grb_noiDung.TabStop = false;
            this.grb_noiDung.Text = "Lịch sử bán hàng";
            // 
            // dtgv_noiDung
            // 
            this.dtgv_noiDung.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgv_noiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_noiDung.Location = new System.Drawing.Point(6, 19);
            this.dtgv_noiDung.Name = "dtgv_noiDung";
            this.dtgv_noiDung.Size = new System.Drawing.Size(738, 304);
            this.dtgv_noiDung.TabIndex = 0;
            // 
            // dtp_tu
            // 
            this.dtp_tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tu.Location = new System.Drawing.Point(60, 63);
            this.dtp_tu.Name = "dtp_tu";
            this.dtp_tu.Size = new System.Drawing.Size(180, 26);
            this.dtp_tu.TabIndex = 1;
            // 
            // dtp_den
            // 
            this.dtp_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_den.Location = new System.Drawing.Point(312, 64);
            this.dtp_den.Name = "dtp_den";
            this.dtp_den.Size = new System.Drawing.Size(183, 24);
            this.dtp_den.TabIndex = 2;
            // 
            // lb_from
            // 
            this.lb_from.Font = new System.Drawing.Font(".VnArial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from.Location = new System.Drawing.Point(14, 66);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(40, 22);
            this.lb_from.TabIndex = 3;
            this.lb_from.Text = "Từ";
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font(".VnArial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to.Location = new System.Drawing.Point(255, 67);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(42, 22);
            this.lb_to.TabIndex = 4;
            this.lb_to.Text = "Đến";
            // 
            // btn_loc
            // 
            this.btn_loc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loc.Location = new System.Drawing.Point(525, 60);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(79, 29);
            this.btn_loc.TabIndex = 5;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.BackColor = System.Drawing.Color.Transparent;
            this.lb_tieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.Location = new System.Drawing.Point(287, 9);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(206, 29);
            this.lb_tieuDe.TabIndex = 6;
            this.lb_tieuDe.Text = "Lịch sử bán sách";
            // 
            // grb_loc
            // 
            this.grb_loc.Controls.Add(this.cbb_maLoai);
            this.grb_loc.Controls.Add(this.lb_loaiSach);
            this.grb_loc.Controls.Add(this.btn_lamMoi);
            this.grb_loc.Controls.Add(this.dtp_den);
            this.grb_loc.Controls.Add(this.dtp_tu);
            this.grb_loc.Controls.Add(this.btn_loc);
            this.grb_loc.Controls.Add(this.lb_from);
            this.grb_loc.Controls.Add(this.lb_to);
            this.grb_loc.Location = new System.Drawing.Point(18, 52);
            this.grb_loc.Name = "grb_loc";
            this.grb_loc.Size = new System.Drawing.Size(738, 107);
            this.grb_loc.TabIndex = 7;
            this.grb_loc.TabStop = false;
            // 
            // cbb_maLoai
            // 
            this.cbb_maLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_maLoai.FormattingEnabled = true;
            this.cbb_maLoai.Location = new System.Drawing.Point(164, 19);
            this.cbb_maLoai.Name = "cbb_maLoai";
            this.cbb_maLoai.Size = new System.Drawing.Size(172, 28);
            this.cbb_maLoai.TabIndex = 9;
            // 
            // lb_loaiSach
            // 
            this.lb_loaiSach.AutoSize = true;
            this.lb_loaiSach.BackColor = System.Drawing.Color.Transparent;
            this.lb_loaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiSach.Location = new System.Drawing.Point(21, 22);
            this.lb_loaiSach.Name = "lb_loaiSach";
            this.lb_loaiSach.Size = new System.Drawing.Size(137, 20);
            this.lb_loaiSach.TabIndex = 8;
            this.lb_loaiSach.Text = "Lọc theo loại sách";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.Location = new System.Drawing.Point(629, 60);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(90, 29);
            this.btn_lamMoi.TabIndex = 6;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_xuat.FlatAppearance.BorderSize = 0;
            this.btn_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.Location = new System.Drawing.Point(334, 513);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(139, 36);
            this.btn_xuat.TabIndex = 8;
            this.btn_xuat.Text = "Xuất lịch sử";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // saveFileDialog_exportExcel
            // 
            this.saveFileDialog_exportExcel.Filter = "Excel 2003|*.xls| Excel 2007|*.xlsx|Excel 2016|*.xlsx";
            // 
            // FormLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 561);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.grb_loc);
            this.Controls.Add(this.lb_tieuDe);
            this.Controls.Add(this.grb_noiDung);
            this.Name = "FormLichSu";
            this.Text = "Lịch sử";
            this.Load += new System.EventHandler(this.FormLichSu_Load);
            this.grb_noiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_noiDung)).EndInit();
            this.grb_loc.ResumeLayout(false);
            this.grb_loc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_noiDung;
        private System.Windows.Forms.DataGridView dtgv_noiDung;
        private System.Windows.Forms.DateTimePicker dtp_tu;
        private System.Windows.Forms.DateTimePicker dtp_den;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Label lb_tieuDe;
        private System.Windows.Forms.GroupBox grb_loc;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.ComboBox cbb_maLoai;
        private System.Windows.Forms.Label lb_loaiSach;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_exportExcel;
    }
}