using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp;
using System.Globalization;

namespace GUI_QuanLy
{
    public partial class FormTaoDon : Form
    {
        SachBUS sachBUS = new SachBUS();
        KhachHangBUS khBUS = new KhachHangBUS();

        private DataTable dataTable = new DataTable();

        public FormTaoDon()
        {
            InitializeComponent();

            // Khởi tạo cấu trúc DataTable
            dataTable.Columns.Add("Mã sách", typeof(string));
            dataTable.Columns.Add("Tên sách", typeof(string));
            dataTable.Columns.Add("Giá", typeof(float));
            dataTable.Columns.Add("Số lượng", typeof(int));
            dataTable.Columns.Add("Tổng", typeof(float));
        }

        private void FormTaoDon_Load(object sender, EventArgs e)
        {
            loadGridSach();
        }

        // Format columns name of 'dtgv_thongTinSach' and 'dtgv_chiTietHoaDon'
        public void format()
        {
            dtgv_thongTinSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Load data book
        public void loadGridSach()
        {
            DataTable dt = sachBUS.loadDataListBook();
            dtgv_thongTinSach.DataSource = dt;
        }

        // Reload data book when search
        public void loadGridSachByKey()
        {
            string maSach = txb_timKiem.Text;
            DataTable dt = sachBUS.upDataByKey(maSach);
            dtgv_thongTinSach.DataSource = dt;
        }

        // Function: search
        private void btn_tim_Click(object sender, EventArgs e)
        {
            loadGridSachByKey();
        }

        // Reser All Textbox in Form
        public void xoaAllTextbox()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        // Function: reset
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            xoaAllTextbox();
            loadGridSach();
            // Update 'dtgv_thongTinSach'
            foreach (DataGridViewRow row1 in dtgv_chiTietHoaDon.Rows)
            {
                if (row1.Cells["Mã sách"].Value == null)
                {
                    break;
                }
                foreach (DataGridViewRow row2 in dtgv_thongTinSach.Rows)
                {
                    if (row1.Cells["Mã sách"].Value.ToString() == row2.Cells["MASACH"].Value.ToString())
                    {
                        int soLuongSach = Convert.ToInt32(row2.Cells["SOLUONG"].Value); 
                        int soLuongBan = Convert.ToInt32(row1.Cells["Số lượng"].Value); 
                        row2.Cells["SOLUONG"].Value = soLuongSach - soLuongBan;
                        break;
                    }
                }
            }
        }

        // Process click on 'dtgv_thongTinSach'
        private void dtgv_thongTinSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgv_thongTinSach.CurrentCell.RowIndex;
            txb_maSach.Text = dtgv_thongTinSach.Rows[index].Cells[0].Value.ToString();
            txb_tenSach.Text = dtgv_thongTinSach.Rows[index].Cells[1].Value.ToString();
            txb_gia.Text = dtgv_thongTinSach.Rows[index].Cells[5].Value.ToString();
            txb_soLuongKho.Text = dtgv_thongTinSach.Rows[index].Cells[6].Value.ToString();
        }

        // Process click on 'dtgv_chiTietHoaDon'
        private void dtgv_chiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_chiTietHoaDon.CurrentCell.RowIndex;
            txb_hangDuocChon.Text = (++i).ToString();
        }

        // Get total bill after have 'uuDai'
        public float getBillTotalAfterHaveDiscount()
        {
            float tongTien = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tongTien += float.Parse(dataRow["Tổng"].ToString());
            }
            if (!string.IsNullOrEmpty(txb_uuDai.Text))
            {
                float uuDai = tongTien / 100.0f * float.Parse(txb_uuDai.Text);
                tongTien -= uuDai;
            }
            return tongTien;
        }

        // Update total bill
        public void capNhatTongDon()
        {
            float tongTien = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                tongTien += float.Parse(dataRow["Tổng"].ToString());
            }
            if (!string.IsNullOrEmpty(txb_uuDai.Text))
            {
                float uuDai = tongTien / 100.0f * float.Parse(txb_uuDai.Text);
                tongTien -= uuDai;
            }
            lb_tongDon.Text = $"Tổng tiền: {tongTien.ToString("N0")} VNĐ"; // Format giá trị thành số có dấu phân cách ngàn
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_maSach.Text))
            {
                MessageBox.Show("Vui lòng chọn mục sách cần mua trong 'Thông tin sách'!");
                return;
            }

            if (string.IsNullOrEmpty(txb_soLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng mua!");
                return;
            }

            int soLuongKho = int.Parse(txb_soLuongKho.Text);
            int soLuong = int.Parse(txb_soLuong.Text);
            if (soLuong > soLuongKho)
            {
                MessageBox.Show($"Số lượng sách mua ({soLuong}) lớn hơn số lượng trong kho ({soLuongKho})!");
                return;
            }

            // Thêm dữ liệu vào DataTable và cập nhật DataSource của DataGridView
            string maS = txb_maSach.Text;
            string tenSach = txb_tenSach.Text;
            float gia = float.Parse(txb_gia.Text);
            float tong = soLuong * gia;

            bool check = true;
            foreach (DataGridViewRow r in dtgv_chiTietHoaDon.Rows)
            {
                if (string.IsNullOrEmpty(r.Cells[0].Value?.ToString()))
                    continue;
                if (r.Cells[0].Value.ToString() == maS)
                {
                    int soLuongHienTai = Convert.ToInt32(r.Cells[3].Value.ToString());
                    r.Cells[3].Value = soLuong + soLuongHienTai;
                    check = false;
                    break;
                }
            }

            if (check)
            {
                DataRow row = dataTable.NewRow();
                row["Mã sách"] = maS;
                row["Tên sách"] = tenSach;
                row["Giá"] = gia;
                row["Số lượng"] = soLuong;
                row["Tổng"] = tong;
                dataTable.Rows.Add(row);
            }

            //Tìm kiếm và cập nhật số lượng tương ứng của sách trong dtgv_thongTinSach
            foreach (DataGridViewRow r in dtgv_thongTinSach.Rows)
            {
                if (r.Cells[0].Value.ToString() == maS)
                {
                    r.Cells[6].Value = soLuongKho - soLuong;
                    break;
                }
            }

            // Delete essential textbox
            txb_timKiem.Clear();
            txb_maSach.Clear();
            txb_tenSach.Clear();
            txb_gia.Clear();
            txb_soLuong.Clear();
            txb_soLuongKho.Clear();
            txb_hangDuocChon.Clear();
            dtgv_chiTietHoaDon.DataSource = dataTable;
            capNhatTongDon();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_hangDuocChon.Text == dtgv_chiTietHoaDon.Rows.Count.ToString())
            {
                MessageBox.Show("Đang chọn hàng trống, hãy chọn lại hàng phù hợp để xóa!");
                return;
            }
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dtgv_chiTietHoaDon.CurrentRow == null || txb_hangDuocChon.Text == "" 
                || int.Parse(txb_hangDuocChon.Text) == dtgv_chiTietHoaDon.Rows.Count)
            {
                MessageBox.Show("Vui lòng chọn một hàng trong 'Chi tiết hóa đơn' để xóa!");
                return;
            }

            int i = dtgv_chiTietHoaDon.CurrentCell.RowIndex; // lấy chỉ số hàng hiện tại được chọn
            string maSach = dtgv_chiTietHoaDon.Rows[i].Cells[0].Value.ToString();
            
            // Tìm kiếm và cập nhật số lượng tương ứng của sách trong dtgv_thongTinSach
            int soLuong = Convert.ToInt32(dtgv_chiTietHoaDon.Rows[i].Cells[3].Value);
            foreach (DataGridViewRow row in dtgv_thongTinSach.Rows)
            {
                if (row.Cells[0].Value.ToString() == maSach)
                {
                    int soLuongKho = (int)row.Cells[6].Value;
                    int soLuongConLai = soLuongKho + soLuong;
                    row.Cells[6].Value = soLuongConLai;
                    break;
                }
            }
            int rowIndex = int.Parse(txb_hangDuocChon.Text);
            rowIndex--;

            dataTable.Rows.RemoveAt(rowIndex);

            dtgv_chiTietHoaDon.DataSource = dataTable;

            txb_hangDuocChon.Clear();
            capNhatTongDon();
        }

        public void exportPDF(string fileName)
        {
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            doc.Open();

            // Sử dụng font Times New Roman để hiển thị tiếng Việt
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 14);

            Paragraph p1 = new Paragraph("Hóa đơn - Nhà sách Coly", font);
            p1.Alignment = Element.ALIGN_CENTER;
            doc.Add(p1);

            if (!string.IsNullOrEmpty(txb_maKhachHang.Text))
            {
                Paragraph p2 = new Paragraph("Mã khách hàng: " + txb_maKhachHang.Text, font);
                doc.Add(p2);
            }

            Paragraph tmp = new Paragraph("\n");
            doc.Add(tmp);

            PdfPTable table = new PdfPTable(dtgv_chiTietHoaDon.Columns.Count);
            for (int i = 0; i < dtgv_chiTietHoaDon.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dtgv_chiTietHoaDon.Columns[i].HeaderText, font));
            }
            table.HeaderRows = 1;

            for (int i = 0; i < dtgv_chiTietHoaDon.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgv_chiTietHoaDon.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dtgv_chiTietHoaDon.Rows[i].Cells[j].Value.ToString(), font));
                }
            }

            table.HorizontalAlignment = Element.ALIGN_LEFT;
            doc.Add(table);

            string uuDai = string.IsNullOrEmpty(txb_uuDai.Text) ? "0" : txb_uuDai.Text;
            string tong = (getBillTotalAfterHaveDiscount() / (100 - int.Parse(uuDai)) * 100).ToString("N0");

            Paragraph p3 = new Paragraph("Tổng: " + tong + " VNĐ", font);
            Paragraph p4 = new Paragraph("Ưu đãi: " + uuDai + "%", font);
            Paragraph p5 = new Paragraph("Tổng sau ưu đãi: " + getBillTotalAfterHaveDiscount().ToString("N0") + " VNĐ", font);
            Paragraph p6 = new Paragraph("Ngày lập: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy"), font);
            Paragraph p7 = new Paragraph("Cảm ơn quý khách đã đến với nhà sách Coly", font);
            p7.Alignment = Element.ALIGN_CENTER;

            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Add(p7);

            doc.Close();
        }

        // Function: invoice
        private void btn_xuatDon_Click(object sender, EventArgs e)
        {
            float tongTien = getBillTotalAfterHaveDiscount();
            if (lb_tongDon.Text == "Tổng tiền: 0 VNĐ")
            {
                MessageBox.Show("Hóa đơn trống! Không thể tạo đơn!");
                return;
            }
            string maKH = string.IsNullOrEmpty(txb_maKhachHang.Text)? "NULL": txb_maKhachHang.Text;
            int soSach = dtgv_chiTietHoaDon.RowCount;
            string[] maSach = new string[soSach];
            int[] soLuong = new int[soSach];
            int index = 0;
            foreach(DataGridViewRow row in dtgv_chiTietHoaDon.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    maSach[index] = row.Cells[0].Value.ToString();
                    soLuong[index++] = int.Parse(row.Cells[3].Value.ToString());
                }
            }
            if (sachBUS.createBill(maKH, maSach, soLuong, tongTien))
            {
                if(saveFileDialog_exportPDF.ShowDialog() == DialogResult.OK)
                {
                    exportPDF(saveFileDialog_exportPDF.FileName);
                    MessageBox.Show("Xuất đơn thành công!");
                    loadGridSach();
                    dataTable.Clear();
                    xoaAllTextbox();
                    lb_tongDon.Text = "Tổng tiền: 0 VNĐ";
                }
            }
            else
            {
                MessageBox.Show("Xuất đơn không thành công!");
            }
        }

        // Check 'customer's code'
        private void btn_kiemTraMaKhachHang_Click(object sender, EventArgs e)
        {   
            if(string.IsNullOrEmpty(txb_maKhachHang.Text))
            {
                MessageBox.Show("Hãy nhập mã khách hàng để kiểm tra!");
                return;
            }
            else
            {
                KhachHang khachHang = khBUS.getCustomerByKey(txb_maKhachHang.Text);
                if (khachHang == null)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                    return;
                }
                else
                {
                    txb_tenKhachHang.Text = khachHang.HODEM.ToString() + " " + khachHang.TEN.ToString();
                    txb_uuDai.Text = khachHang.UUDAI.ToString();
                }
            }
        }

        private void txb_uuDai_TextChanged(object sender, EventArgs e)
        {
            capNhatTongDon();
        }

        private void txb_maKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txb_maKhachHang.Text))
            {
                xoaAllTextbox();
                capNhatTongDon();
            }
        }

        // Hover searching
        private void txb_timKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Kiểm tra nếu phím nhấn là phím Enter
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_tim.PerformClick();
            }
        }

        // Hover when enter 'number of quanity'
        private void txb_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Kiểm tra nếu phím nhấn là phím Enter
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_them.PerformClick();
            }
        }

        // Hover when enter 'customer code'
        private void txb_maKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Kiểm tra nếu phím nhấn là phím Enter
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_kiemTraMaKhachHang.PerformClick();
            }
        }
    }
}
