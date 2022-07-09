using ASProj.Classes;

namespace ASProj
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

            bool isDebug = false;
            Utils.updateDebug(ref isDebug);

            if (isDebug)
            {
                Application.Run(new frmDashboard());
            } else Application.Run(new frmLogin());
    }

        // DA 8/7/22 TODO update these values once the file saving system has been implemented
        public static Guid DefaultUserAvatar = Guid.Empty;
        public static Guid DefaultUserBanner = Guid.Empty;

        public static Guid DefaultUserCharacter = Guid.Empty;

        public static Guid DefaultUserTheme = Guid.Empty;
    }
}
