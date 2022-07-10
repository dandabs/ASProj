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
                Application.Run(new frmLogin());

                // DA 10/7/22 Adding the default avatar values to the database
                //UserImage i = new UserImage(@"C:\\Users\\okoskinen\\Documents\\740ecb78aa4c10cb0a2170ea2350c337.jpg");
                //i.Save();

            } else Application.Run(new frmLogin());
        }

        public static User? CurrentSession = null;

        // DA 8/7/22 TODO update these values once the file saving system has been implemented
        public static Guid DefaultUserAvatar = Guid.Parse("618e90d6-1516-4149-ab34-c82955667396");
        public static Guid DefaultUserBanner = Guid.Empty;

        public static Guid DefaultUserCharacter = Guid.Empty;

        public static Guid DefaultUserTheme = Guid.Empty;
    }
}
