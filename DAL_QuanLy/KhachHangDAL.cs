using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QuanLy
{
    public class KhachHangDAL
    {
        /* For '1. Manage Customer' - DAL */
        // Load data from TB_KHANGHANG to DataGridView
        public DataTable loadDataCustomer()
        {
            string sql_query = "SELECT * FROM TB_KHACHHANG";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        // Load data from TB_KHANGHANG to DataGridView by 'name'
        public DataTable loadDataCustomerByName(string name)
        {
            string sql_query = "SELECT * FROM TB_KHACHHANG WHERE TEN LIKE N'%"+name+"%'";
            return Dataprovider.Instance.ExcuteQuery(sql_query); ;
        }

        public bool addCustomer(KhachHang kh) 
        {
            string sql_insert = string.Format("INSERT INTO TB_KHACHHANG VALUES ('{0}', N'{1}', N'{2}', '{3}', '{4}', N'{5}', {6})",
                            kh.MAKHACHHANG, kh.HODEM, kh.TEN, kh.SODIENTHOAI, kh.CHUNGMINHTHU, kh.DIACHI, kh.UUDAI);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_insert) == 1)
                return true;
            return false;
        }

        public bool updateCustomer(KhachHang kh)
        {
            string query_update = string.Format("UPDATE TB_KHACHHANG SET HODEM = N'{0}', TEN = N'{1}', SODIENTHOAI = '{2}', CHUNGMINHTHU = '{3}', DIACHI = N'{4}', UUDAI = {5} " +
                "WHERE MAKHACHHANG = '{6}'", kh.HODEM, kh.TEN, kh.SODIENTHOAI, kh.CHUNGMINHTHU, kh.DIACHI, kh.UUDAI, kh.MAKHACHHANG);
            if (Dataprovider.Instance.ExcuteNonQuery(query_update) != 0)
                return true;
            return false;
        }

        public bool deleteCustomer(string maKH) 
        {
            string sql_delete = string.Format("DELETE FROM TB_KHACHHANG WHERE MAKHACHHANG = '{0}'", maKH);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_delete) != 0)
                return true;
            return false;
        }

        // For '3. Create order' - DAL: check Customer
        public KhachHang getCustomerByKey(string key)
        {
            string sql_query = string.Format("SELECT * FROM TB_KHACHHANG WHERE MAKHACHHANG = '{0}'", key);
            DataTable dt = Dataprovider.Instance.ExcuteQuery(sql_query);
            if (dt.Rows.Count == 0)
                return null;
            DataRow row = dt.Rows[0];
            KhachHang kh = new KhachHang(row);
            return kh;
        }
    }
}
