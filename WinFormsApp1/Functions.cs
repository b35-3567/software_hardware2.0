using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        public string ConStr;
        private SqlDataAdapter Sda;

        public Functions()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu của bạn
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\USER\DOCUMENTS\HARDWAREDB.MDF;Integrated Security=True";
            Con = new SqlConnection(ConStr);
        }

        public int setData(string Query)
        {
            int Cnt = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Khởi tạo đối tượng SqlCommand
                Cmd = new SqlCommand(Query, Con);
                Cnt = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Log or display the error
                Console.WriteLine("Error: " + ex.Message);
                 // Log lỗi chi tiết
        MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Cnt;
        }
        public int getDataCount(string Query)
        {
            int count = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Khởi tạo đối tượng SqlCommand
                Cmd = new SqlCommand(Query, Con);

                // Thực thi câu lệnh và lấy kết quả
                count = (int)Cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Log hoặc hiển thị lỗi
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return count;
        }
        public DataTable getData(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Khởi tạo đối tượng SqlDataAdapter
                Sda = new SqlDataAdapter(Query, Con);

                // Đổ dữ liệu vào DataTable
                Sda.Fill(dt);
            }
            catch (Exception ex)
            {
                // Log hoặc hiển thị lỗi
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return dt;
        }

    }
}
