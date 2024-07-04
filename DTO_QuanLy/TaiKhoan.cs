using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{

    public class TaiKhoan
    {
        public string TAIKHOAN { get; set; }
        public string MATKHAU { get; set; }
        public int MAQUYEN { get; set; }
        public string HOTEN { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }
        public bool GIOITINH { get; set; }
        public string SODIENTHOAI { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(string taiKhoan, string matKhau, int maQuyen, string hoTen, DateTime ngaySinh, 
                        string diaChi, string email, bool gioiTinh, string soDienThoai)
        {
            this.TAIKHOAN = taiKhoan;
            this.MATKHAU = matKhau;
            this.MAQUYEN = maQuyen;
            this.HOTEN = hoTen;
            this.NGAYSINH = ngaySinh;
            this.DIACHI = diaChi;
            this.EMAIL = email;
            this.GIOITINH = gioiTinh;
            this.SODIENTHOAI = soDienThoai;
        }

        public TaiKhoan(DataRow row)
        {
            this.TAIKHOAN = row["TAIKHOAN"].ToString();
            this.MATKHAU = row["MATKHAU"].ToString();
            this.MAQUYEN = int.Parse(row["MAQUYEN"].ToString());
            this.HOTEN = row["TAIKHOAN"].ToString();
            this.NGAYSINH = DateTime.Parse(row["TAIKHOAN"].ToString());
            this.DIACHI = row["DIACHI"].ToString();
            this.EMAIL = row["EMAIL"].ToString();
            this.GIOITINH = bool.Parse(row["GIOITINH"].ToString());
            this.SODIENTHOAI = row["SODIENTHOAI"].ToString();
        }
    }
}
