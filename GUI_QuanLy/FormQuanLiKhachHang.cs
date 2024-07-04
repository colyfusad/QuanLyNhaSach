using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_QuanLy
{
    public partial class FormQuanLiKhachHang : Form
    {
        KhachHangBUS khBUS = new KhachHangBUS();

        public FormQuanLiKhachHang()
        {
            InitializeComponent();
        }

        // Load Data Customer to 'dtgv_noiDung' from Database
        public void loadGridCustomer()
        {
            DataTable dt = khBUS.loadDataCustomer();
            dtgv_noiDung.DataSource = dt;
            formatColumsOfListCustomer();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadGridCustomer();
        }

        // Format column names of 'dtgv_noiDung'
        public void formatColumsOfListCustomer()
        {
            dtgv_noiDung.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgv_noiDung.Columns["MAKHACHHANG"].HeaderText = "Mã khách hàng";
            dtgv_noiDung.Columns["HODEM"].HeaderText = "Họ đệm";
            dtgv_noiDung.Columns["TEN"].HeaderText = "Tên";
            dtgv_noiDung.Columns["SODIENTHOAI"].HeaderText = "Số điện thoại";
            dtgv_noiDung.Columns["CHUNGMINHTHU"].HeaderText = "Chứng minh thư";
            dtgv_noiDung.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dtgv_noiDung.Columns["UUDAI"].HeaderText = "Ưu đãi";
        }

        // Process click on 'dtgv_noiDung'
        private void dtgv_noiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_noiDung.CurrentCell.RowIndex;
            txb_maKhachHang.Text = dtgv_noiDung.Rows[i].Cells[0].Value.ToString();
            txb_hoDem.Text = dtgv_noiDung.Rows[i].Cells[1].Value.ToString();
            txb_ten.Text = dtgv_noiDung.Rows[i].Cells[2].Value.ToString();
            txb_soDienThoai.Text = dtgv_noiDung.Rows[i].Cells[3].Value.ToString();
            txb_chungMinhThu.Text = dtgv_noiDung.Rows[i].Cells[4].Value.ToString();
            txb_diaChi.Text = dtgv_noiDung.Rows[i].Cells[5].Value.ToString();
            txb_uuDai.Text = dtgv_noiDung.Rows[i].Cells[6].Value.ToString();
        }

        // Delete all Textbox in Form
        public void clearAllTextbox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        // Hover searching
        private void txb_timKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // is Enter?
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_timKiem.PerformClick();
            }
        }

        // Reload 'dtgv_noiDung' when search
        public void loadGridCustomerByName()
        {
            string name = txb_timKiem.Text;
            DataTable dt = khBUS.loadDataCustomerByName(name);
            dtgv_noiDung.DataSource = dt;
            formatColumsOfListCustomer();
        }

        // Function: search by name
        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadGridCustomerByName();
        }

        // Check data of Textbox
        public bool notNullorEmptyOfTextbox()
        {
            return (!string.IsNullOrEmpty(txb_maKhachHang.Text) && !string.IsNullOrEmpty(txb_hoDem.Text) &&
                !string.IsNullOrEmpty(txb_ten.Text) && !string.IsNullOrEmpty(txb_soDienThoai.Text) &&
                !string.IsNullOrEmpty(txb_chungMinhThu.Text) && !string.IsNullOrEmpty(txb_diaChi.Text) &&
                !string.IsNullOrEmpty(txb_uuDai.Text));
        }

        // Check data int of 'SĐT', 'CMT', 'UUDAI'
        public bool checkFormat()
        {
            string uuDai = txb_uuDai.Text;
            string sdt = txb_soDienThoai.Text;
            string cmt = txb_chungMinhThu.Text;
            return (int.TryParse(uuDai, out int number) && int.TryParse(sdt, out int number1) && int.TryParse(cmt, out int number2));
        }

        // Add Customer
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (notNullorEmptyOfTextbox())
            {
                if (checkFormat())
                {
                    MessageBox.Show("Nhập lại định dạng ô 'Số điện thoại' hoặc 'Chứng minh thư' hoặc 'Ưu đãi' dạng số");
                    return;
                }
                KhachHang kh = new KhachHang(txb_maKhachHang.Text, txb_hoDem.Text, txb_ten.Text,
                    txb_soDienThoai.Text, txb_chungMinhThu.Text, txb_diaChi.Text, int.Parse(txb_uuDai.Text));

                if (khBUS.addCustomer(kh))
                {
                    clearAllTextbox();
                    loadGridCustomer();
                    MessageBox.Show("Thêm khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin khách hàng");
            }
        }

        // Update Customer
        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            if (notNullorEmptyOfTextbox())
            {
                if (checkFormat())
                {
                    MessageBox.Show("Nhập lại định dạng ô 'Số điện thoại' hoặc 'Chứng minh thư' hoặc 'Ưu đãi' dạng số");
                    return;
                }

                KhachHang kh = new KhachHang(txb_maKhachHang.Text, txb_hoDem.Text, txb_ten.Text,
                txb_soDienThoai.Text, txb_chungMinhThu.Text, txb_diaChi.Text, int.Parse(txb_uuDai.Text));

                if (khBUS.updateCustomer(kh))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng không thành công");
                }
                clearAllTextbox();
                loadGridCustomer();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin để cập nhật");
            }
        }

        // Delete Customer
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maKH = txb_maKhachHang.Text;
            if (!string.IsNullOrEmpty(maKH))
            {

                if (khBUS.deleteCustomer(maKH))
                {
                    clearAllTextbox();
                    loadGridCustomer();
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng muốn xóa trong danh sách hoặc nhập mã khách hàng");
            }
        }

        // Reset form
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            clearAllTextbox();
            loadGridCustomer();
        }
    }
}
