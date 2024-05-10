namespace ProgettoTreno
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static Gestore gestore;
        [STAThread]
        static void Main()
        {
           
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
            Form1 form1 = new Form1();
            gestore = new Gestore();
            //form1.Show();
            gestore.Show();
            Application.Run();
            
        }
    }
}