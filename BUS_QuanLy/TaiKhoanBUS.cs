using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class TaiKhoanBUS
    {
        public string checkLogin(string username, string pass)
        {
            // Kiểm tra nghiệp vụ
            if (string.IsNullOrEmpty(username))
            {
                return "require_user";
            }
            
            if (string.IsNullOrEmpty(pass))
            {
                return "require_pass";
            }

            bool check = TaiKhoanDAL.Instance.checkLogin(username, pass);

            if (!check)
            {
                return "incorrect_user_or_pass";
            }
            return "correct";
        }

        public DataTable loadListAccount()
        {
            return TaiKhoanDAL.Instance.loadListAccount();
        }

        public DataTable getAccess()
        {
            return TaiKhoanDAL.Instance.getAccess();
        }

        public bool addAccount(TaiKhoan taiKhoan)
        {
            return TaiKhoanDAL.Instance.addAccount(taiKhoan);
        }

        public bool updateAccount(TaiKhoan taiKhoan, string taiKhoanCu)
        {
            return TaiKhoanDAL.Instance.updateAccount(taiKhoan, taiKhoanCu);
        }

        public bool deleteAccount(string taiKhoan)
        {
            return TaiKhoanDAL.Instance.deleteAccount(taiKhoan);
        }

        public DataTable loadListAccountByName(string name)
        {
            return TaiKhoanDAL.Instance.loadListAccountByName(name);
        }

        public int checkAccess(string taiKhoan)
        {
            return TaiKhoanDAL.Instance.checkAccess(taiKhoan);
        }
    }
}
