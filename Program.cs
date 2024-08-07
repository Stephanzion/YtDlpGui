namespace YtDlpGui
{
    internal static class Program
    {
        public static string YtDlpBinPath = "bin/yt-dlp.exe";
        public static string Aria2BinPath = "bin/aria2c_unlim.exe";
        public static bool Debug = false;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}