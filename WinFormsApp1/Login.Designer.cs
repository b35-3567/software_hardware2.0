namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            textBoxUserName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxPassWord = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(385, 26);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 1;
            label1.Text = "HardWare Shop";
            label1.Click += label1_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(317, 219);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(288, 27);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextChanged += username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(317, 181);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "UserName";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(317, 268);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "PassWord";
            label3.Click += label3_Click;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(317, 309);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.PasswordChar = '*';
            textBoxPassWord.Size = new Size(288, 27);
            textBoxPassWord.TabIndex = 5;
            textBoxPassWord.TextChanged += password_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkTurquoise;
            button1.Location = new Point(396, 356);
            button1.Name = "button1";
            button1.Size = new Size(145, 44);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += login_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(396, 406);
            button2.Name = "button2";
            button2.Size = new Size(135, 32);
            button2.TabIndex = 8;
            button2.Text = "Rest";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(690, 12);
            button3.Name = "button3";
            button3.Size = new Size(57, 32);
            button3.TabIndex = 9;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(628, 309);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "show_Pass";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassWord);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxUserName);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox textBoxPassWord;
        private Label label3;
        private Label label2;
        private TextBox textBoxUserName;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
    }
}
