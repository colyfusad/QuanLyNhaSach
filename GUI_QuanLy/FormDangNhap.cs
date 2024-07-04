using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class FormDangNhap : Form
    {
        public static string taiKhoan;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string username = txb_taiKhoan.Text;
            string pass = txb_matKhau.Text;
            string checkUser = tkBUS.checkLogin(username, pass); 
            switch (checkUser)
            {
                case "require_user":
                    MessageBox.Show(this, "Hãy nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "require_pass":
                    MessageBox.Show(this, "Hãy nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "incorrect_user_or_pass":
                    MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Thiết lập vị trí cho Message Box
            int x = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(x, y);
            this.Hide();
            taiKhoan = txb_taiKhoan.Text;
            Form formIndex = new FormQuanLy();
            formIndex.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txb_matKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // is Enter?
            {
                e.Handled = true; // Ngăn chặn ký tự Enter xuất hiện trong TextBox
                btn_dangNhap.PerformClick();
            }
        }
    }
}
