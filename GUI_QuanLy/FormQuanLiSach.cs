using BUS_QuanLy;
using DTO_QuanLy;
using iTextSharp.text.pdf.codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_QuanLy
{
    public partial class FormQuanLiSach : Form
    {
        SachBUS sachBUS = new SachBUS();

        public FormQuanLiSach()
        {
            InitializeComponent();
        }

        private void FormQuanLiSach_Load(object sender, EventArgs e)
        {
            loadGridListBooks();
        }

        // Format column names of 'dtgv_danhSachSach'
        public void formatColumnsOfListBooks()
        {
            dtgv_danhSachSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgv_danhSachSach.Columns["MASACH"].HeaderText = "Mã sách";
            dtgv_danhSachSach.Columns["TENSACH"].HeaderText = "Tên sách";
            dtgv_danhSachSach.Columns["MALOAI"].HeaderText = "Mã loại";
            dtgv_danhSachSach.Columns["NAMXUATBAN"].HeaderText = "Năm xuất bản";
            dtgv_danhSachSach.Columns["TACGIA"].HeaderText = "Tác giả";
            dtgv_danhSachSach.Columns["GIA"].HeaderText = "Giá";
            dtgv_danhSachSach.Columns["SOLUONG"].HeaderText = "Số lượng";
        }

        // Load Data Book to 'dtgv_danhSachSach' and Data BookType to 'cbb_loaiSach' from Database
        public void loadGridListBooks()
        {
            cbb_loaiSach.DataSource = sachBUS.getTypeBook();
            cbb_loaiSach.DisplayMember = "TENLOAI";
            cbb_loaiSach.ValueMember = "MALOAI";
            cbb_loaiSach.Text = "Chọn loại sách";
            DataTable dt = sachBUS.loadDataListBook();
            dtgv_danhSachSach.DataSource = dt;
            formatColumnsOfListBooks();
        }

        // Process click on 'dtgv_danhSachSach'
        int i;
        private void dtgv_danhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtgv_danhSachSach.CurrentCell.RowIndex;
            txb_maSach.Text = dtgv_danhSachSach.Rows[i].Cells[0].Value.ToString();
            txb_tenSach.Text = dtgv_danhSachSach.Rows[i].Cells[1].Value.ToString();
            txb_maLoai.Text = dtgv_danhSachSach.Rows[i].Cells[2].Value.ToString();
            txb_namXuatBan.Text = dtgv_danhSachSach.Rows[i].Cells[3].Value.ToString();
            txb_tacGia.Text = dtgv_danhSachSach.Rows[i].Cells[4].Value.ToString();
            txb_gia.Text = dtgv_danhSachSach.Rows[i].Cells[5].Value.ToString();
            txb_soLuong.Text = dtgv_danhSachSach.Rows[i].Cells[6].Value.ToString();
        }

        // Reset all textbox
        public void resetAllTextbox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        // Check NullOrEmpty of Textbox
        public bool notNullOrEmptyOfTextbox()
        {
            return (!string.IsNullOrEmpty(txb_maSach.Text) && !string.IsNullOrEmpty(txb_tenSach.Text) &&
                !string.IsNullOrEmpty(txb_maLoai.Text) && !string.IsNullOrEmpty(txb_namXuatBan.Text) &&
                !string.IsNullOrEmpty(txb_tacGia.Text) && !string.IsNullOrEmpty(txb_gia.Text) &&
                !string.IsNullOrEmpty(txb_soLuong.Text));
        }

        // Function: search 
        public void loadGridCustomerByBookType()
        {
            if (cbb_loaiSach.Text == "Chọn loại sách")
            {
                MessageBox.Show("Hãy chọn loại sách để lọc!");
            }
            else
            {
                string bookType = cbb_loaiSach.SelectedValue.ToString();
                DataTable dt = sachBUS.loadDataBookByBookType(bookType);
                dtgv_danhSachSach.DataSource = dt;
                formatColumnsOfListBooks();
            }
        }

        public void loadGridCustomerByBookTitle()
        {
            string bookTitle = txb_locTheoTenSach.Text;
            if (string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Nhập tên sách cần lọc");
                return;
            }
            DataTable dt = sachBUS.loadDataBookByBookTitle(bookTitle);
            dtgv_danhSachSach.DataSource = dt;
            formatColumnsOfListBooks();
        }

        private void btn_locTheoLoaiSach_Click(object sender, EventArgs e)
        {
            loadGridCustomerByBookType();
        }

        private void btn_locTheoTenSach_Click(object sender, EventArgs e)
        {
            loadGridCustomerByBookTitle();
        }

        // Function: add
        private void btn_themSach_Click(object sender, EventArgs e)
        {
            if (notNullOrEmptyOfTextbox())
            {
                Sach sach = new Sach(txb_maSach.Text, txb_tenSach.Text, txb_maLoai.Text, 
                                    int.Parse(txb_namXuatBan.Text), txb_tacGia.Text, 
                                    float.Parse(txb_gia.Text), int.Parse(txb_soLuong.Text));

                if (sachBUS.addBook(sach))
                {
                    resetAllTextbox();
                    txb_locTheoTenSach.Clear();
                    loadGridListBooks();
                    MessageBox.Show("Thêm sách thành công");
                }
                else
                {
                    MessageBox.Show("Thêm sách không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin sách");
            }
        }

        // Function: update
        private void btn_capNhatSach_Click(object sender, EventArgs e)
        {
            if (notNullOrEmptyOfTextbox())
            {
                Sach sach = new Sach(txb_maSach.Text, txb_tenSach.Text, txb_maLoai.Text, int.Parse(txb_namXuatBan.Text), 
                            txb_tacGia.Text, float.Parse(txb_gia.Text), int.Parse(txb_soLuong.Text));

                if (sachBUS.updateBook(sach))
                {
                    resetAllTextbox();
                    txb_locTheoTenSach.Clear();
                    loadGridListBooks();
                    MessageBox.Show("Cập nhật sách thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật sách không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin sách");
            }
        }

        // Function: delete
        private void btn_xoaSach_Click(object sender, EventArgs e)
        {
            string maSach = txb_maSach.Text;
            if (!string.IsNullOrEmpty(maSach))
            {
                if (sachBUS.deleteBook(maSach))
                {
                    resetAllTextbox();
                    txb_locTheoTenSach.Clear();
                    loadGridListBooks();
                    MessageBox.Show("Xóa sách thành công");
                }
                else  
                {
                    MessageBox.Show("Xóa sách không thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã sách vào ô hoặc chọn hàng sách cần xóa trong 'Danh sách'");
            }
        }

        // Function reset
        private void btn_lamMoiSach_Click(object sender, EventArgs e)
        {
            txb_locTheoTenSach.Clear();
            resetAllTextbox();
            loadGridListBooks();
        }

        // Hover searching
        private void txb_locTheoTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // is Enter?
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_locTheoTenSach.PerformClick();
            }
        }
    }
}
