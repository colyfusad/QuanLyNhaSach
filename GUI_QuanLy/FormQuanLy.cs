using BUS_QuanLy;
using DTO_QuanLy;
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
    public partial class FormQuanLy : Form
    {
        string tk = FormDangNhap.taiKhoan;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        public FormQuanLy()
        {
            InitializeComponent();
        }
       
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_body.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_quanLiKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiKhachHang());
            lb_tieuDe.Text = btn_quanLiKhachHang.Text;
        }

        private void btn_quanLiSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLiSach());
            lb_tieuDe.Text = btn_quanLiSach.Text;
        }

        private void btn_taoDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaoDon());
            lb_tieuDe.Text = btn_taoDon.Text;
        }

        private void btn_lichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLichSu());
            lb_tieuDe.Text = btn_lichSu.Text;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            int maQuyen = tkBUS.checkAccess(tk);
            if (maQuyen == 1)
            {
                OpenChildForm(new FormAdmin());
                lb_tieuDe.Text = btn_admin.Text;
            }
            else
            {
                MessageBox.Show("Không có quyền truy cập");
                return;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            lb_tenTaiKhoan.Text = "Tài khoản: "+tk+"!";
        }
    }
}
