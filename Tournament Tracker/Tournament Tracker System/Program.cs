using Tournament_Tracker_Library;

namespace Tournament_Tracker
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

            // Initialize the database connections
            GlobalConfig.InitialzeConnections(DatabaseType.Sql);

            Application.Run(new DashboardForm());
        }
    }
}