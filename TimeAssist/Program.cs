namespace TimeAssist
{
    internal static class Program
    {
        public const string connectionString = "Data Source=DESKTOP-HGIJ7RM\\M164SQLSERVER; Initial Catalog=TimeAssist; Integrated Security=True";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new home());
        }
    }
}