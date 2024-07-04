using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class Sach
    {
        public string _maSach, _tenSach, _maLoai, _tacGia;
        public int _namXuatBan, _soLuong;
        public float _gia;

        public string MASACH{get; set;}
        public string TENSACH{ get; set; }
        public string MALOAI{ get; set; }
        public string TACGIA { get; set; }
        public int NAMXUATBAN { get; set; }
        public float GIA { get; set; }
        public int SOLUONG { get; set; }

        public Sach() { }

        public Sach(string maSach, string tenSach, string maLoai, int namXuatBan, string tacGia, float gia, int soLuong)
        {
            this.MASACH = maSach;
            this.TENSACH = tenSach;
            this.MALOAI = maLoai;
            this.TACGIA = tacGia;
            this.NAMXUATBAN = namXuatBan;
            this.GIA = gia;
            this.SOLUONG = soLuong;
        }

        public Sach(DataRow row)
        {
            this.MASACH = row["MASACH"].ToString();
            this.TENSACH = row["TENSACH"].ToString();
            this.MALOAI = row["MALOAI"].ToString();
            this.TACGIA = row["TACGIA"].ToString();
            this.NAMXUATBAN = int.Parse(row["NAMXUATBAN"].ToString());
            this.GIA = int.Parse(row["GIA"].ToString());
            this.SOLUONG = int.Parse(row["SOLUONG"].ToString());
        }
    }
}
