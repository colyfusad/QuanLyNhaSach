using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class FormAdmin : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            loadListAccount();
        }

        public void formatColumns()
        {
            dtgv_nhanSu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgv_nhanSu.Columns["TAIKHOAN"].HeaderText = "TÀI KHOẢN";
            dtgv_nhanSu.Columns["MATKHAU"].HeaderText = "MẬT KHẨU";
            dtgv_nhanSu.Columns["MAQUYEN"].HeaderText = "MÃ QUYỀN";
            dtgv_nhanSu.Columns["HOTEN"].HeaderText = "HỌ TÊN";
            dtgv_nhanSu.Columns["NGAYSINH"].HeaderText = "NGÀY SINH";
            dtgv_nhanSu.Columns["DIACHI"].HeaderText = "ĐỊA CHỈ";
            dtgv_nhanSu.Columns["GIOITINH"].HeaderText = "GIỚI TÍNH";
            dtgv_nhanSu.Columns["SODIENTHOAI"].HeaderText = "SỐ ĐIỆN THOẠI";
        }

        public enum Gender
        {
            Nam,
            Nữ
        }
        List<Gender> genders = new List<Gender>();

        public void loadListAccount()
        {
            dtgv_nhanSu.DataSource = tkBUS.loadListAccount();
            genders.Add(Gender.Nam);
            genders.Add(Gender.Nữ);
            cbb_gioiTinh.DisplayMember = "Gender";
            cbb_gioiTinh.ValueMember = "Gender";
            cbb_gioiTinh.DataSource = genders;
            cbb_gioiTinh.Text = "Chọn giới tính";
            cbb_quyen.DataSource = tkBUS.getAccess();
            cbb_quyen.DisplayMember = "TENQUYEN";
            cbb_quyen.ValueMember = "MAQUYEN";
            cbb_quyen.Text = "Chọn quyền";
            formatColumns();
        }

        int i;
        private void dtgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtgv_nhanSu.CurrentCell.RowIndex;
            txb_taiKhoan.Text = dtgv_nhanSu.Rows[i].Cells[1].Value.ToString();
            txb_matKhau.Text = dtgv_nhanSu.Rows[i].Cells[2].Value.ToString();
            cbb_quyen.Text = int.Parse(dtgv_nhanSu.Rows[i].Cells[3].Value.ToString()) == 1? "User": "Admin";
            txb_hoTen.Text = dtgv_nhanSu.Rows[i].Cells[4].Value.ToString();
            string dateString = dtgv_nhanSu.Rows[i].Cells[5].Value.ToString();
            DateTime date = DateTime.Parse(dateString);
            dtp_ngaySinh.Value = date;
            txb_diaChi.Text = dtgv_nhanSu.Rows[i].Cells[6].Value.ToString();
            txb_email.Text = dtgv_nhanSu.Rows[i].Cells[7].Value.ToString();
            cbb_gioiTinh.Text = bool.Parse(dtgv_nhanSu.Rows[i].Cells[8].Value.ToString()) == true? "Nam": "Nữ";
            txb_soDienThoai.Text = dtgv_nhanSu.Rows[i].Cells[9].Value.ToString();
        }

        public void deleteAllTextbox()
        {
            foreach (Control control in grb_thongTinNhanVien.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            txb_timKiem.Clear();
        }

        public bool notNullOrEmptyOfTextbox()
        {
            return (!string.IsNullOrEmpty(txb_taiKhoan.Text) && !string.IsNullOrEmpty(txb_matKhau.Text) && cbb_quyen.Text != "Chọn quyền" &&
                    !string.IsNullOrEmpty(txb_hoTen.Text) && !string.IsNullOrEmpty(txb_diaChi.Text) && !string.IsNullOrEmpty(txb_email.Text) &&
                    cbb_gioiTinh.Text != "Chọn giới tính" && !string.IsNullOrEmpty(txb_soDienThoai.Text));
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (notNullOrEmptyOfTextbox())
            {
                int quyen = cbb_quyen.Text == "User" ? 1 : 2;
                bool gioiTinh = cbb_gioiTinh.Text == "Nam"? true: false;
                DateTime date = dtp_ngaySinh.Value;
                TaiKhoan taiKhoan = new TaiKhoan(txb_taiKhoan.Text, txb_matKhau.Text, quyen, txb_hoTen.Text, date, txb_diaChi.Text, 
                    txb_email.Text, gioiTinh, txb_soDienThoai.Text);
                if (tkBUS.addAccount(taiKhoan))
                {
                    loadListAccount();
                    deleteAllTextbox();
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin tài khoản");
            }
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (notNullOrEmptyOfTextbox())
            {
                string taiKhoanCu = dtgv_nhanSu.Rows[i].Cells[1].Value.ToString();
                int quyen = cbb_quyen.Text == "User" ? 1 : 2;
                bool gioiTinh = cbb_gioiTinh.Text == "Nam" ? true : false;
                DateTime date = dtp_ngaySinh.Value;
                TaiKhoan taiKhoan = new TaiKhoan(txb_taiKhoan.Text, txb_matKhau.Text, quyen, txb_hoTen.Text, date, txb_diaChi.Text,
                    txb_email.Text, gioiTinh, txb_soDienThoai.Text);
                if (tkBUS.updateAccount(taiKhoan, taiKhoanCu))
                {
                    deleteAllTextbox();
                    loadListAccount();
                    MessageBox.Show("Cập nhật tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin tài khoản");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string taiKhoan = txb_taiKhoan.Text;
            if (!string.IsNullOrEmpty(taiKhoan))
            {
                if (tkBUS.deleteAccount(taiKhoan))
                {
                    deleteAllTextbox();
                    loadListAccount();
                    MessageBox.Show("Xóa tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tài khoản vào ô hoặc chọn hàng tài khoản cần xóa trong 'Danh sách'");
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            loadListAccount();
            cbb_gioiTinh.Text = "Chọn giới tính";
            cbb_quyen.Text = "Chọn quyền";
            dtp_ngaySinh.Value = DateTime.Now;
            deleteAllTextbox();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            string hoTen = txb_timKiem.Text;
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Nhập họ tên cần tìm kiếm");
                return;
            }
            DataTable dt = tkBUS.loadListAccountByName(hoTen);
            dtgv_nhanSu.DataSource = dt;
            formatColumns();
        }

        private void txb_timKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // is Enter?
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_timKiem.PerformClick();
            }
        }
    }
}
