using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class KhachHangBUS
    {
        KhachHangDAL khDAL = new KhachHangDAL();

        /* For '1. Manage Customer' - BUS */
        // Load data customer from Database
        public DataTable loadDataCustomer()
        {
            return khDAL.loadDataCustomer();
        }

        // Load data when search by 'name'
        public DataTable loadDataCustomerByName(string name)
        {
            return khDAL.loadDataCustomerByName(name);
        }

        public bool addCustomer(KhachHang kh)
        {
            return khDAL.addCustomer(kh);
        }

        public bool updateCustomer(KhachHang kh)
        {
            return khDAL.updateCustomer(kh);
        }

        public bool deleteCustomer(string maKH)
        {
            return khDAL.deleteCustomer(maKH);
        }

        /* Check customer of '3. Create order' */
        public KhachHang getCustomerByKey(string key)
        {
            return khDAL.getCustomerByKey(key);
        }
    }
}
