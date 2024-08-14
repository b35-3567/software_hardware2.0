namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //   Application.Run(new Login());
            // Kh?i t?o form duy nh?t b?n mu?n hi?n th?
            // Application.Run(new Categories()); // Thay 'Categories' b?ng tên form b?n mu?n ch?y

            // Application.Run(new demo());
            Application.Run(new Items());
        }
    }
}