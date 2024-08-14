using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Items_Load);
            LoadItemTbl();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadItemTbl()
        {

            // Truy vấn SQL để lấy tất cả dữ liệu từ bảng CategoryTbl
            string query = "SELECT * FROM ItemTbl";

            // Khởi tạo đối tượng Functions để sử dụng chuỗi kết nối và thực thi truy vấn
            Functions func = new Functions();

            // Sử dụng SqlConnection và SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(func.ConStr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); // Đổ dữ liệu vào DataTable

                    // Đặt nguồn dữ liệu cho DataGridView
                    guna2DataGridView1.DataSource = dt;
                }
            }

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue != null)
            {
                string selectedCatName = comboBox1.Text;  // Lấy tên danh mục được chọn
                MessageBox.Show($"Selected Category: {selectedCatName}");
            }
        }
        private void Items_Load(object sender, EventArgs e)
        {
            // Tạo đối tượng từ lớp Functions
            Functions func = new Functions();

            // Câu lệnh SQL để lấy danh sách danh mục
            string query = "SELECT CatCode, CatName FROM CategoryTbl";

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = func.getData(query);

            // Gán dữ liệu vào ComboBox
            comboBox1.DisplayMember = "CatName"; // Hiển thị tên danh mục
            comboBox1.ValueMember = "CatCode";   // Giá trị là mã danh mục
            comboBox1.DataSource = dt;           // Gán dữ liệu vào ComboBox
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
