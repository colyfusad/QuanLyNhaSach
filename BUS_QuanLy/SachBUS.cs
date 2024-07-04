using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class SachBUS
    {
        SachDAL sachDAL = new SachDAL();

        //public Sach upInfoOne(string maSach)
        //{
        //    return sachDAL.upInfoOne(maSach);
        //}

        // Load bookType for Combobox - BUS
        public DataTable getTypeBook()
        {
            return sachDAL.getTypeBook();
        }

        /* For '2. Manage Book' - BUS */
        // Load Data Book
        public DataTable loadDataListBook()
        {
            return sachDAL.loadDataListBook();
        }

        // Load data when search of book type
        public DataTable loadDataBookByBookType(string maLoai)
        {
            return sachDAL.loadDataBookByBookType(maLoai);
        }

        // Load data when search of book title
        public DataTable loadDataBookByBookTitle(string bookTitle)
        {
            return sachDAL.loadDataBookByBookTitle(bookTitle);
        }

        // Add book
        public bool addBook(Sach sach)
        {
            return sachDAL.addBook(sach);
        }

        // Update book
        public bool updateBook(Sach sach)
        {
            return sachDAL.updateBook(sach);
        }

        // Delete book
        public bool deleteBook(string maSach)
        {
            return sachDAL.deleTeBook(maSach);
        }

        /* For '3. Create order' - BUS */
        // Load data book when search
        public DataTable upDataByKey(string maSach)
        {
            return sachDAL.upDataByKey(maSach);
        }

        public bool createBill(string maKH, string[] maSach, int[] soLuong, float tongTien)
        {
           return sachDAL.createBill(maKH, maSach, soLuong, tongTien);
        }

        /* For '4. Sale History' - BUS */
        // Load data 'History Sale'
        public DataTable upDataHistory()
        {
            return sachDAL.upDataHistory();
        }

        public DataTable upDataHistoryByKey(string tu, string den)
        {
            return sachDAL.upDataHistoryByKey(tu, den);
        }

        public DataTable upDataHistoryByKey(string tu, string den, string maLoai)
        {
            return sachDAL.upDataHistoryByKey(tu, den, maLoai);
        }
    }
}
