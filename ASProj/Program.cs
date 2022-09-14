using ASProj.Classes;
using ASProj.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isDebug = false;
            GenericUtils.updateDebug(ref isDebug);

            /*if (isDebug)
            {
                Application.Run(new frmLogin());

                // DA 10/7/22 Adding the default avatar values to the database
                //UserImage i = new UserImage(@"C:\\Users\\okoskinen\\Documents\\740ecb78aa4c10cb0a2170ea2350c337.jpg");
                //i.Save();

            } else Application.Run(new frmLogin());*/

            if (!Directory.Exists(FileHandler.dir)) Directory.CreateDirectory(FileHandler.dir);

            if (!File.Exists(Path.Combine(FileHandler.dir, "users.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "users.json"), Properties.Resources.default_users);
            if (!File.Exists(Path.Combine(FileHandler.dir, "games.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "games.json"), Properties.Resources.default_games);
            if (!File.Exists(Path.Combine(FileHandler.dir, "images.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "images.json"), Properties.Resources.default_images);

            if (File.Exists(Path.Combine(FileHandler.dir, ".session")))
            {
                try // DA 10/7/22 If user isn't found, or GUID fails to parse, then we'll not throw an error and simply ask for login details
                {
                    string session = File.ReadAllText(Path.Combine(FileHandler.dir, ".session"));
                    string Id = session.Split(':')[0];
                    string Token = session.Split(':')[1];

                    Guid Uid = Guid.Parse(Id);
                    User user = User.Search(Uid);

                    // DA 10/7/22 Check password
                    if (user.Password == Token)
                    {
                        CurrentSession = user;
                        Application.Run(new frmDashboard()); // DA 10/7/22 Go directly to the dashboard
                    }
                    else
                    {
                        File.Delete(Path.Combine(FileHandler.dir, ".session"));
                        Application.Run(new frmLogin());
                    }
                }
                catch (Exception)
                {
                    File.Delete(Path.Combine(FileHandler.dir, ".session"));
                    Application.Run(new frmLogin());
                }
            }
            else Application.Run(new frmLogin());

        }

        public static User CurrentSession = null;

        // DA 8/7/22 TODO update these values once the file saving system has been implemented
        public static readonly Guid DefaultUserAvatar = Guid.Parse("618e90d6-1516-4149-ab34-c82955667396");
        public static readonly Guid DefaultUserBanner = Guid.Empty;

        public static readonly Guid DefaultUserTheme = Guid.Empty;

        // DA 12/07/22 This will change depending on the game that is being played. Change this before opening the game form
        public static Game CurrentGame = null;
    }
}
