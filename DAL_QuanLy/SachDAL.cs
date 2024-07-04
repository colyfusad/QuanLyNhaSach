using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class SachDAL
    {
        //public Sach upInfoOne(string maSach)
        //{
        //    string sql_query = "SELECT * FROM TB_SACH WHERE MASACH = '" +maSach + "'";
        //    DataTable data = Dataprovider.Instance.ExcuteQuery(sql_query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        Sach kh = new Sach(item);
        //        return kh;
        //    }
        //    return null;
        //}

        // Up data for Combobox 'LOẠI SÁCH'
        public DataTable getTypeBook()
        {
            string sql_query = "SELECT * FROM TB_THELOAI";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        /* For '2. Manage books' - DAL */
        // Up data of table TB_SACH to Datagridview
        public DataTable loadDataListBook()
        {
            string sql_query = "SELECT * FROM TB_SACH";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        // Load data when search of book type
        public DataTable loadDataBookByBookType(string bookType)
        {
            string sqlQuery = "SELECT * FROM TB_SACH WHERE MALOAI = '" + bookType + "'";
            return Dataprovider.Instance.ExcuteQuery(sqlQuery);
        }

        // Load data when search of book title
        public DataTable loadDataBookByBookTitle(string bookTitle)
        {
            string sqlQuery = "SELECT * FROM TB_SACH WHERE TENSACH LIKE N'%" + bookTitle + "%'";
            return Dataprovider.Instance.ExcuteQuery(sqlQuery);
        }

        public bool addBook(Sach sach)
        {
            string sql_insert = string.Format("INSERT INTO TB_SACH VALUES ('{0}', N'{1}', '{2}', {3}, N'{4}', {5}, {6})",
                            sach.MASACH, sach.TENSACH, sach.MALOAI, sach.NAMXUATBAN, sach.TACGIA, sach.GIA, sach.SOLUONG);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_insert) == 1)
                return true;
            return false;
        }

        // Update book
        public bool updateBook(Sach sach)
        {
            string query_update = string.Format("UPDATE TB_SACH SET MASACH = '{0}', TENSACH = N'{1}', MALOAI = '{2}', NAMXUATBAN = {3}, TACGIA = N'{4}', GIA = {5}, SOLUONG = {6} " +
                "WHERE MASACH = '{7}'", 
                sach.MASACH, sach.TENSACH, sach.MALOAI, sach.NAMXUATBAN, sach.TACGIA, sach.GIA, sach.SOLUONG, sach.MASACH);
            if (Dataprovider.Instance.ExcuteNonQuery(query_update) != 0)
                return true;
            return false;
        }

        public bool deleTeBook(string maSach)
        {
            string sql_delete = string.Format("DELETE FROM TB_SACH WHERE MASACH = '{0}'", maSach);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_delete) != 0)
                return true;
            return false;
        }

        public bool createBill(string maKH, string[] maSach, int[] soLuong, float tongTien)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.000");
            string sql_query1;
            if (maKH == "NULL")
            {
                sql_query1 = string.Format("INSERT INTO TB_HOADON(NGAYTAO, MAKHACHHANG, TONG, TONGSAUUUDAI) VALUES('{0}', {1}, '{2}', '{3}')", time, maKH, 0, tongTien);
            }
            else
            {
                sql_query1 = string.Format("INSERT INTO TB_HOADON(NGAYTAO, MAKHACHHANG, TONG, TONGSAUUUDAI) VALUES('{0}', '{1}', '{2}', '{3}')", time, maKH, 0, tongTien);
            }
            bool check1 = Dataprovider.Instance.ExcuteNonQuery(sql_query1) == 1;
            string sql_soHoaDon = "SELECT * FROM TB_HOADON WHERE SOHOADON = (SELECT MAX(SOHOADON) FROM TB_HOADON)";
            DataTable dt = Dataprovider.Instance.ExcuteQuery(sql_soHoaDon);
            int soHoaDon;
            if (dt.Rows.Count == 0)
                soHoaDon = 1;
            else
            {
                soHoaDon = int.Parse(dt.Rows[0][0].ToString());
            }
            bool check2 = false;
            int n = maSach.Length - 1;
            for (int i = 0; i < n; i++)
            {
                string sql_query2 = string.Format("INSERT INTO TB_CHITIETHOADON VALUES('{0}', '{1}', '{2}')", soHoaDon, maSach[i], soLuong[i]);
                string sql_update = string.Format("UPDATE TB_SACH SET SOLUONG = SOLUONG - {0} WHERE MASACH = '{1}'", soLuong[i], maSach[i]);
                if (Dataprovider.Instance.ExcuteNonQuery(sql_query2) != -1 && Dataprovider.Instance.ExcuteNonQuery(sql_update) != -1)
                {
                    check2 = true;
                }
                else
                {
                    check2 = false;
                    break;
                }
            }
            if (check1 && check2)
                return true;
            return false;
        }

        /* For '3. Create order' : search - DAL */
        public DataTable upDataByKey(string maSach)
        {
            string sql_query = "SELECT * FROM TB_SACH WHERE MASACH LIKE '%" + maSach + "%'";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        /* For '4. Sale history' - DAL */
        // Up CHITIETHOADON when load
        public DataTable upDataHistory()
        {
            string sqlQuery = "SELECT TB_HOADON.SOHOADON, NGAYTAO, MAKHACHHANG, TB_CHITIETHOADON.MASACH, TB_SACH.TENSACH AS TS, TB_SACH.GIA AS G, " +
                            "TB_CHITIETHOADON.SOLUONG,  (TB_CHITIETHOADON.SOLUONG*GIA) AS TONGGIA, TONG, TONGSAUUUDAI " +
                            "FROM TB_HOADON, TB_CHITIETHOADON, TB_SACH " +
                            "WHERE TB_HOADON.SOHOADON = TB_CHITIETHOADON.SOHOADON AND TB_SACH.MASACH = TB_CHITIETHOADON.MASACH";
            return Dataprovider.Instance.ExcuteQuery(sqlQuery);
        }

        // Up CHITIETHOADON when filter
        public DataTable upDataHistoryByKey(string tu, string den) // no have 'maLoai'
        {
            string sqlQuery = "SELECT TB_HOADON.SOHOADON, NGAYTAO, MAKHACHHANG, TB_CHITIETHOADON.MASACH, TB_SACH.TENSACH AS TS, " +
                "TB_SACH.GIA AS G, TB_CHITIETHOADON.SOLUONG,  (TB_CHITIETHOADON.SOLUONG*GIA) AS TONGGIA, TONG, TONGSAUUUDAI " +
                "FROM TB_HOADON, TB_CHITIETHOADON, TB_SACH " +
                "WHERE TB_HOADON.SOHOADON = TB_CHITIETHOADON.SOHOADON AND TB_SACH.MASACH = TB_CHITIETHOADON.MASACH " +
                "AND NGAYTAO BETWEEN '" + tu + "' AND '" + den + "'";
            return Dataprovider.Instance.ExcuteQuery(sqlQuery);
        }

        public DataTable upDataHistoryByKey(string tu, string den, string maLoai) // have 'maLoai'
        {
            string sqlQuery = "SELECT TB_HOADON.SOHOADON, NGAYTAO, MAKHACHHANG, TB_CHITIETHOADON.MASACH, TB_SACH.TENSACH AS TS, " +
                "TB_SACH.GIA AS G, TB_CHITIETHOADON.SOLUONG,  (TB_CHITIETHOADON.SOLUONG*GIA) AS TONGGIA, TONG, TONGSAUUUDAI " +
                "FROM TB_HOADON, TB_CHITIETHOADON, TB_SACH WHERE TB_HOADON.SOHOADON = TB_CHITIETHOADON.SOHOADON " +
                "AND TB_SACH.MASACH = TB_CHITIETHOADON.MASACH AND MALOAI = '" + maLoai + "' " +
                "AND NGAYTAO BETWEEN '" + tu + "' AND '" + den + "'";
            return Dataprovider.Instance.ExcuteQuery(sqlQuery);
        }
    }
}

