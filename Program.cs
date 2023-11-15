namespace CarApp
{
    internal static class Program
    {
        public static ApplicationContext myAppCxt;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            myAppCxt = new ApplicationContext(new LoginForm());
            Application.Run(myAppCxt);
        }
    }
}