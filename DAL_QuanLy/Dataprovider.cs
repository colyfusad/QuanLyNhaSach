using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class Dataprovider
    {
        // Singleton Pattern
        private static Dataprovider instance;

        public static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; }
        }

        private Dataprovider() { }

        private string connectionSTR = "Data Source=DESKTOP-3BOCCS6;Initial Catalog=QL_NHASACH;Integrated Security=True";

        // thực hiện câu select
        // trả ra kết quả một cái DataTable
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // thay thế Dispose()
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // thực hiện việc kết nối dữ liệu
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // chạy câu truy vấn

                // thực hiện câu proceduce
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command); // thằng trung gian lấy dữ liệu ra từ câu truy vấn

                adapter.Fill(data); // đổ dữ liệu ra datatable

                connection.Close();
            }
            return data;
        }

        // thực hiện câu update, delete, insert
        // trả ra số dòng được thực thi
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // thực hiện việc kết nối dữ liệu
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); // chạy câu truy vấn

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                try
                {
                    data = command.ExecuteNonQuery();
                }
                catch
                {
                    return 0;
                }

                connection.Close();
            }
            return data;
        }

        // thực hiện câu select count(*)
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) 
            {
                connection.Open(); // mở connection

                SqlCommand command = new SqlCommand(query, connection); 

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
