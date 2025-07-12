namespace Project_PTTK
{

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Get the parent of bin\Debug\netX.X\ etc.
            // Only in debug mode, adjust as necessary for release builds.
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            #if DEBUG
            string filePath = projectRoot;
            #else
            string filePath = AppDomain.CurrentDomain.BaseDirectory;
            #endif

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Example: Set the path to your SQL file using the root path

            // Initialize the database
            DBHelper.RunBatch(Path.Join(filePath,"database.sql"));

            // Run the main form of the application
            Application.Run(new MH_TAOPHIEUDANGKY1());
        }
    }
}