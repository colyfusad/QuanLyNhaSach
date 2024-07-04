using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class TaiKhoanDAL
    {
        private static TaiKhoanDAL instance;

        public static TaiKhoanDAL Instance
        {
            get { 
                if (instance == null) 
                    instance = new TaiKhoanDAL(); 
                return instance; 
            }
            private set { instance = value; }
        }

        private TaiKhoanDAL() { }

        public bool checkLogin(string username, string password)
        {
            string query = "procedure_login @userName , @password";
            string query1 = "SELECT * FROM TB_TAIKHOAN WHERE TAIKHOAN = '" + username + "' AND MATKHAU = '" + password + "'";
            DataTable dataTable = Dataprovider.Instance.ExcuteQuery(query, new object[] {username, password});
            return dataTable.Rows.Count > 0;
        }

        // Get data for dtgv_nhanSu
        public DataTable loadListAccount()
        {
            string sql_query = "SELECT * FROM TB_TAIKHOAN";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        // Get access for cbb_quyen
        public DataTable getAccess()
        {
            string sql_query = "SELECT * FROM TB_QUYEN";
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        public bool addAccount(TaiKhoan taiKhoan)
        {
            DateTime dateTime = Convert.ToDateTime(taiKhoan.NGAYSINH);
            string date = dateTime.ToString("yyyy-MM-dd");
            int gioiTinh = taiKhoan.GIOITINH == true? 1 : 0;
            string sql_insert = string.Format("INSERT INTO TB_TAIKHOAN(TAIKHOAN, MATKHAU, MAQUYEN, HOTEN, NGAYSINH, DIACHI, EMAIL, GIOITINH, SODIENTHOAI) " +
                "VALUES('{0}', '{1}', '{2}', N'{3}', '{4}', N'{5}', '{6}', {7}, '{8}')", taiKhoan.TAIKHOAN, taiKhoan.MATKHAU, taiKhoan.MAQUYEN,
                taiKhoan.HOTEN, date, taiKhoan.DIACHI, taiKhoan.EMAIL, gioiTinh, taiKhoan.SODIENTHOAI);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_insert) == 1)
                return true;
            return false;
        }

        public bool updateAccount(TaiKhoan taiKhoan, string taiKhoanCu)
        {
            DateTime dateTime = Convert.ToDateTime(taiKhoan.NGAYSINH);
            string date = dateTime.ToString("yyyy-MM-dd");
            int gioiTinh = taiKhoan.GIOITINH == true ? 1 : 0;
            string sql_update = string.Format("UPDATE TB_TAIKHOAN SET TAIKHOAN = '{0}', MATKHAU = '{1}', MAQUYEN = '{2}', HOTEN = N'{3}', NGAYSINH = '{4}', " +
                "DIACHI = N'{5}', EMAIL = '{6}', GIOITINH = {7}, SODIENTHOAI = '{8}' WHERE TAIKHOAN = '{9}'", taiKhoan.TAIKHOAN, taiKhoan.MATKHAU, taiKhoan.MAQUYEN,
                taiKhoan.HOTEN, date, taiKhoan.DIACHI, taiKhoan.EMAIL, gioiTinh, taiKhoan.SODIENTHOAI, taiKhoanCu);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_update) == 1) 
                return true;
            return false;
        }

        public bool deleteAccount(string taiKhoan)
        {
            string sql_delete = string.Format("DELETE FROM TB_TAIKHOAN WHERE TAIKHOAN = '{0}'", taiKhoan);
            if (Dataprovider.Instance.ExcuteNonQuery(sql_delete) == 1)
                return true;
            return false;
        }

        // Search
        public DataTable loadListAccountByName(string name)
        {
            string sql_query = string.Format("SELECT * FROM TB_TAIKHOAN WHERE HOTEN LIKE N'%{0}%'", name);
            return Dataprovider.Instance.ExcuteQuery(sql_query);
        }

        public int checkAccess(string taiKhoan)
        {
            string sql_query = "SELECT * FROM TB_TAIKHOAN WHERE TAIKHOAN = '" + taiKhoan + "'";
            DataTable dt = Dataprovider.Instance.ExcuteQuery(sql_query);
            int a =  Convert.ToInt32(dt.Rows[0][3]);
            return a;
        }
    }
}
