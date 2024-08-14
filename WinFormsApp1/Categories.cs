using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void nhapCategoryName_TextChanged(object sender, EventArgs e)
        {
            // Xử lý khi văn bản trong TextBox thay đổi (nếu cần)
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (guna2DataGridView1.CurrentRow == null || guna2DataGridView1.CurrentRow.Cells["CatCode"].Value == null)
            {
                MessageBox.Show("Please select a category to delete.");
                return;
            }

            // Lấy tên danh mục từ dòng được chọn trong DataGridView
            string categoryName = guna2DataGridView1.CurrentRow.Cells["CatName"].Value.ToString();
            int categoryCode = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["CatCode"].Value);

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the category '{categoryName}'?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // Nếu người dùng chọn "Yes", thì xóa danh mục
            if (result == DialogResult.Yes)
            {
                // Chuỗi truy vấn để xóa danh mục
                string query = "DELETE FROM CategoryTbl WHERE CatCode = @CatCode";
                Functions func = new Functions();

                try
                {
                    // Mở kết nối
                    using (SqlConnection con = new SqlConnection(func.ConStr))
                    {
                        con.Open();

                        // Tạo câu lệnh SQL với tham số
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Gán giá trị cho tham số
                            cmd.Parameters.AddWithValue("@CatCode", categoryCode);

                            // Thực thi câu lệnh và kiểm tra kết quả
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Category deleted successfully.");
                                LoadCategories(); // Tải lại danh sách category sau khi xóa
                                nhapCategoryName.Clear(); // Xóa văn bản sau khi xóa
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete category.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string categoryName = nhapCategoryName.Text.Trim();

            if (guna2DataGridView1.CurrentRow == null || guna2DataGridView1.CurrentRow.Cells["CatCode"].Value == null)
            {
                MessageBox.Show("Please select a category to edit.");
                return;
            }

            // Lấy CatCode từ dòng hiện tại được chọn trong DataGridView
            int categoryCode = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["CatCode"].Value);

            // Kiểm tra xem người dùng đã nhập tên danh mục mới chưa
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a new category name.");
                return;
            }

            // Chuỗi truy vấn để cập nhật dữ liệu
            string query = "UPDATE CategoryTbl SET CatName = @CatName WHERE CatCode = @CatCode";
            Functions func = new Functions();

            try
            {
                // Mở kết nối
                using (SqlConnection con = new SqlConnection(func.ConStr))
                {
                    con.Open();

                    // Tạo câu lệnh SQL với tham số
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Gán giá trị cho các tham số
                        cmd.Parameters.AddWithValue("@CatName", categoryName);
                        cmd.Parameters.AddWithValue("@CatCode", categoryCode);

                        // Thực thi câu lệnh và kiểm tra kết quả
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category updated successfully.");
                            LoadCategories(); // Tải lại danh sách category sau khi chỉnh sửa
                            nhapCategoryName.Clear(); // Xóa văn bản sau khi chỉnh sửa
                        }
                        else
                        {
                            MessageBox.Show("Failed to update category.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void AddItem_Click(object sender, EventArgs e)
        {
            string categoryName = nhapCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            string query = "INSERT INTO CategoryTbl (CatName) VALUES (@CatName)";
            Functions func = new Functions();

            try
            {
                // Mở kết nối
                using (SqlConnection con = new SqlConnection(func.ConStr))
                {
                    con.Open();

                    // Tạo câu lệnh SQL với tham số
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Gán giá trị cho tham số
                        cmd.Parameters.AddWithValue("@CatName", categoryName);

                        // Thực thi câu lệnh và kiểm tra kết quả
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Category added successfully.");
                            LoadCategories(); // Tải lại danh sách category sau khi thêm
                            nhapCategoryName.Clear(); // Xóa văn bản sau khi thêm
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void LoadCategories()
        {

            // Truy vấn SQL để lấy tất cả dữ liệu từ bảng CategoryTbl
            string query = "SELECT * FROM CategoryTbl";

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


        private void categoryDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Hiển thị giá trị CatName lên TextBox nhapCategoryName
                nhapCategoryName.Text = row.Cells["CatName"].Value.ToString();
            }
        }


        private void Categories_Load(object sender, EventArgs e)
        {


        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
