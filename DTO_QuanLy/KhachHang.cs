using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO_QuanLy
{
    public class KhachHang
    {
        public string _maKhachHang;
        public string _hoDem;
        public string _ten;
        public string _soDienThoai;
        public string _chungMinhThu;
        public string _diaChi;
        public int _uuDai;

        public string MAKHACHHANG { get; set; }
        public string HODEM { get; set; }
        public string TEN { get; set; }
        public string SODIENTHOAI { get; set; }
        public string CHUNGMINHTHU { get; set; }
        public string DIACHI { get; set; }
        public int UUDAI { get; set; }

        public KhachHang() { }

        public KhachHang(DataRow row)
        {
            this.MAKHACHHANG = row["MAKHACHHANG"].ToString();
            this.HODEM = row["HODEM"].ToString();
            this.TEN = row["TEN"].ToString();
            this.SODIENTHOAI = row["SODIENTHOAI"].ToString();
            this.CHUNGMINHTHU = row["CHUNGMINHTHU"].ToString();
            this.DIACHI = row["DIACHI"].ToString();
            this.UUDAI = int.Parse(row["UUDAI"].ToString());
            
        }

        public KhachHang(string maKhachHang, string hoDem, string ten, string soDienThoai, string chungMinhThu, string diaChi, int uuDai)
        {
            this.MAKHACHHANG = maKhachHang;
            this.HODEM = hoDem;
            this.TEN = ten;
            this.SODIENTHOAI = soDienThoai;
            this.CHUNGMINHTHU = chungMinhThu;
            this.DIACHI = diaChi;
            this.UUDAI = uuDai;
        }
    }
}
