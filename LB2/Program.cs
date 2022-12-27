namespace LB2
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
            string projectPath = Directory
                .GetParent(Directory.GetCurrentDirectory())
                .Parent.FullName;
            string folderName = Path.Combine(projectPath, "Studio");
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
