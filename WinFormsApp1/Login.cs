namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            // L?y thông tin t? textBox
            string userName = textBoxUserName.Text.Trim();
            string password = textBoxPassWord.Text.Trim();

            // Ghi log thông tin username và password vào console
            Console.WriteLine($"Username: {userName}");
            Console.WriteLine($"Password: {password}");

            // Ki?m tra thông tin ng??i dùng có nh?p ??y ?? không
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Chu?i truy v?n ki?m tra thông tin ??ng nh?p
            string query = $"SELECT COUNT(*) FROM Users WHERE Username = '{userName}' AND Password = '{password}'";

            // S? d?ng class Functions ?? th?c thi truy v?n
            Functions func = new Functions();
            int userCount = 0;

            try
            {
                // Th?c thi truy v?n và l?y k?t qu?
                userCount = func.getDataCount(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Ki?m tra k?t qu?
            if (userCount > 0)
            {
                MessageBox.Show("Login successful!");
                // Chuy?n sang form khác ho?c th?c hi?n hành ??ng sau khi ??ng nh?p thành công
                // ?n form hi?n t?i
                
        this.Hide();
        
        // M? form Items
        Items itemsForm = new Items();
        itemsForm.ShowDialog();

        // ?óng form Login sau khi Items ?óng
        this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            // N?u checkbox ???c chon, hien thi mat khau
              if (checkBox1.Checked)
    
            {
                textBoxPassWord.PasswordChar = '\0'; // \0 là ký t? null, ngh?a là hi?n th? ký t? g?c
            }
            else
            {
                textBoxPassWord.PasswordChar = '*'; // ?n m?t kh?u
            }
        }
    }
}
