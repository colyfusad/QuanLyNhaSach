using BUS_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class FormLichSu : Form
    {
        SachBUS sachBUS = new SachBUS();

        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            loadHistory();
        }

        // Format column names of 'dtgv_noiDung'
        public void formatColumn()
        {
            dtgv_noiDung.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgv_noiDung.Columns["SOHOADON"].HeaderText = "Số hóa đơn";
            dtgv_noiDung.Columns["NGAYTAO"].HeaderText = "Ngày tạo";
            dtgv_noiDung.Columns["MAKHACHHANG"].HeaderText = "Mã khách hàng";
            dtgv_noiDung.Columns["MASACH"].HeaderText = "Mã sách";
            dtgv_noiDung.Columns["TS"].HeaderText = "Tên sách";
            dtgv_noiDung.Columns["G"].HeaderText = "Giá";
            dtgv_noiDung.Columns["SOLUONG"].HeaderText = "Số lượng";
            dtgv_noiDung.Columns["TONGGIA"].HeaderText = "Tổng 1 loại sách";
            dtgv_noiDung.Columns["TONG"].HeaderText = "Tổng đơn";
            dtgv_noiDung.Columns["TONGSAUUUDAI"].HeaderText = "Tổng đơn sau ưu đãi";
        }

        // Load data Sale History
        public void loadHistory()
        {
            DataTable dt = sachBUS.upDataHistory();
            dtgv_noiDung.DataSource = dt;
            formatColumn();
            cbb_maLoai.DataSource = sachBUS.getTypeBook();
            cbb_maLoai.DisplayMember = "TENLOAI";
            cbb_maLoai.ValueMember = "MALOAI";
            cbb_maLoai.Text = "Chọn loại sách";

        }

        // Reload data when search
        public void loadHistoryByKey()
        {
            DateTime tu = dtp_tu.Value;
            DateTime den = dtp_den.Value;
            den = den.AddDays(1);
            string from = tu.ToString("yyyy-MM-dd");
            string to = den.ToString("yyyy-MM-dd");
            if (cbb_maLoai.Text == "Chọn loại sách")
            {
                DataTable dt = sachBUS.upDataHistoryByKey(from, to);
                dtgv_noiDung.DataSource = dt;
            }
            else
            {
                string maLoai = cbb_maLoai.SelectedValue.ToString();
                DataTable dt = sachBUS.upDataHistoryByKey(from, to, maLoai);
                dtgv_noiDung.DataSource = dt;
            }
            formatColumn();
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {
            loadHistoryByKey();
        }

        // Function: reset
        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            dtp_tu.Value = DateTime.Now;
            dtp_den.Value = DateTime.Now;
            loadHistory();
        }

        public void exportExcel(string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            try
            {
                sheet.Name = "Lịch sử bán hàng";
                // Export header
                for (int i = 0; i < dtgv_noiDung.Columns.Count; i++)
                {
                    sheet.Cells[1, i + 1] = dtgv_noiDung.Columns[i].HeaderText;
                }

                // Export content
                for (int i = 0; i < dtgv_noiDung.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgv_noiDung.Columns.Count; j++)
                    {
                        sheet.Cells[i + 2, j + 1] = dtgv_noiDung.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất lịch sử bán hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                sheet = null;
            }
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            if(saveFileDialog_exportExcel.ShowDialog() == DialogResult.OK)
            {
                exportExcel(saveFileDialog_exportExcel.FileName);
            }
        }
    }
}
