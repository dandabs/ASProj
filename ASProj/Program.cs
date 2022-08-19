using ASProj.Classes;
using ASProj.Utils;

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
            GenericUtils.updateDebug(ref isDebug);

            /*if (isDebug)
            {
                Application.Run(new frmLogin());

                // DA 10/7/22 Adding the default avatar values to the database
                //UserImage i = new UserImage(@"C:\\Users\\okoskinen\\Documents\\740ecb78aa4c10cb0a2170ea2350c337.jpg");
                //i.Save();

            } else Application.Run(new frmLogin());*/

            if (!Directory.Exists(FileHandler.dir)) Directory.CreateDirectory(FileHandler.dir);

            if (!File.Exists(Path.Combine(FileHandler.dir, "users.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "users.json"), "[]");
            if (!File.Exists(Path.Combine(FileHandler.dir, "games.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "games.json"), "[]");
            if (!File.Exists(Path.Combine(FileHandler.dir, "images.json"))) File.WriteAllText(Path.Combine(FileHandler.dir, "images.json"), "[{\"Blob\":\" / 9j / 4AAQSkZJRgABAQEASABIAAD / 2wBDAAYEBQYFBAYGBQYHBwYIChAKCgkJChQODwwQFxQYGBcUFhYaHSUfGhsjHBYWICwgIyYnKSopGR8tMC0oMCUoKSj / 2wBDAQcHBwoIChMKChMoGhYaKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCgoKCj / wgARCAEAAQADASIAAhEBAxEB / 8QAGgABAAIDAQAAAAAAAAAAAAAAAAUGAQMEAv / EABkBAQADAQEAAAAAAAAAAAAAAAABAgMEBf / aAAwDAQACEAMQAAABog15QAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD1LzWGWzqtjSV25SppiJrt5EWAAAAAAAAAAbddqtns68NuEEAOTrRNL1WqrZd2BXQAAAAAAAACSs8bJbcIWyAAAVizxtdawMe4AAAAAAAAey47To80EAAANW0mjPfjn9EEgAAAAAAN + jfMXPGcb + aAAAAMlM0b9GHpBEgAAAAAAPXkXjPD3b + cE1AAAYzwxNW8mHpAAAAAAAAAd1qo8hfC0uXr15MGUYAOVPTVc8GXWFNwAAAAAAAAAG / QRIe4xNZPXwDfoIsCQAAAAAAAAADusFsq9IzmNOfg39Cc + bT3iFjbYjSjLbAZ9HCK6gAAAAAAAJ3ZM6cuBpzAAAAAQcFeYfPprwz6gAAAAAEvHXG + HvBrxgAAAAAAV2Iu9Py7NApuAAAAPRYJfz6384JqAAAAAAAiJfzFqQ9ecfRCAAACRjpy2c6NuAAAAAAAAACrR83CY94V0A//EACUQAAEDBAICAgMBAAAAAAAAAAMBAgQAEjBAERMFMxQgITFQcP/aAAgBAQABBQL/AGxqKqihKqNjCbVjasbToonUWE5KciouuNikcALRJ9jgaZCMVjtaIHqZglh7WasEd5cU4dhdSAy0GKe3kOoJLR4ipcPTanLsj0tdpA92Q/u0ge7If3aTV4ci8piVeEcvLtOG+8GKY+wGpEN1PReUwKvCSjdr9WNJUVDOMn3Kdg6kSXF2Wle2kllSvmlr5padKKtOK939ocYj6bASkiCSugddAqWIGnwUokYjNcEZ5aFHGPCWOMlHjPFqRYlJ+MkmJpRI1ueXGu0IILl0JwLVyhZ2Ea1Gt0HNRzTM6yZPHi4ZpeQHyzG1LnNS1uk5tzXJa7FBbdI1JzbT4vGpq+S/f1//xAAgEQABBAICAwEAAAAAAAAAAAABAAIDERIwIDEQIUFQ/9oACAEDAQE/Af1nPDe0ZwhOE14dskfgETfkGulG/Ia5XWeMTqOoo8Qhpd1zb1qcKPFos65YsvYRaR5AJUUWPs7KtYNWDUBWx8oajOSsysyhMQmSh2qWX4OcUvw6Jn0K0wyX65vdkdLDib5SGm64zbfP/8QAHxEAAgICAwADAAAAAAAAAAAAAQIRMAAgEiExEEBQ/9oACAECAQE/Af1gJzhnDCIsUTqRFajrVh19E0jc1DU1q0as02yck2hZwKMjIziMKxUq7stCilhsMHVJE7L7W3vz/8QALRAAAQEGAwcDBQAAAAAAAAAAAQACETAxQFESITIDICJBYXGRQoGhM1BicJL/2gAIAQEABj8C/djhNP2hd0Wl/daR4WkeFpd2T9nxdE4zqMLKynff63WFqn/Izg5ahTPMmYbxI0r7w32pWR0htC4pAIpFqNjvFb70bHeK33owYpNILjKGbnKlz0lPEF5kstIlTOObKyPtv5n2TpM2qcmyp+V6V6fC1OXE2fvUnd1xN+Fp+VoZX02VL5XA15Wl46U9mbrIPNzBzDjdXZvSYtr4i4tl/NFj2k+Qj42J8xQY2pCVDjZlzjBkIMiVC4yRZi4zM0YbExEAHNAWoyDzRFoY6Z0p6w2zSsb3/8QAKRAAAQIFBAEDBQEAAAAAAAAAAQARITAxQEFRYXGBoSCx0RBQcJHB8P/aAAgBAQABPyH82BQSSwEPcGqsd3RIBEEi2sCZu4kNdZqRUEgMG4HQOSs7Z+tGMFEdQWwiYIASRm2SRlIZhuqVtedDuXDzL3axhU3lnbZvalL1ASyhqkFoYZksgGDSzEJ1ak1n4Gb5Gz8DN8jZ6kAumAiIMtwJoE5FSXtB8lSx8EWvRgoQiAg5EkRyMESV1YtkDNnThUzfVX1h4ZOiqgCrcqNe1r/gv8B9EP8AsBV89/eqE1rAsy6LNDygCP5Ik+BFZjgllI4Kr7iK3YD2JUgfrQJwPQtKIOPmgAMICWYhjRV+Q/CyhwbzE+PD7ywhdEg3sYExmDQzi5hUoTLAGFiZDiDFFOYpxNetIHFntwDxMPURMhhaA1mKmgZFI1JpcYYWpxDB5Z3wwFqMaGfV/9oADAMBAAIAAwAAABD333333333333333333333333333333333333333333333333333333K9Lj33333333332Fzzz5n33333333317zzzyrz33333333rXzzzzzf33333332hTzzzzhT3333333377zzzz/7333333333z37z3b333333333339+//wD9999999998zdPvM/899999998vc8888878999999688888888y99999+X88888888r89999t8888888888999/8QAHxEBAAICAgMBAQAAAAAAAAAAAQARMDEgYRAhQUBQ/9oACAEDAQE/EP6wVqC0RWyAWOQeyO7fLu4Pux3fXGr7xKi47V4ukYrBw7I74k0YUsqIg8UMIFFYuwRCk8VFKCdgyI2JZ8gHwgaGT0+2ar1F/sD0zfe56f7+BxrCvpm3DVts5LRcRVw0og2XxuMdA+f/xAAfEQEAAgICAgMAAAAAAAAAAAABABEwMSBBECFQUWH/2gAIAQIBAT8Q+WXSW7lom2S1AD0eUEpl7HVxXYhuGuL7MTbnthGorL4qi4t4tRgjryobmgZBSEv2lrkeBbgDqI+otqPidrz7TBe24a2zmFKw0K5CxjFLz//EACkQAQABAgUCBgMBAQAAAAAAAAERACEwMUBBUXGBYZGhsdHwIMHhUHD/2gAIAQEAAT8Q/wCn25q3OsRukAS1GgpkT3bUTA7PMfFQAJxCkoVHOyikqXkDSKxJsiVYao2E1EhhdjrQ8G0+fQ/NiQPIlzrRaQ0eD00xQBKsAb0LqC4X8GCBCCQ2cUikEJZHnShHSE+OB7+WGCxDjxyPZ76WAK67S36w+N1ZuNv2eWkibVEDCMZTGHEXAJymKiLaPPXIdVqA4EYYkOSKfNoXZ/mj+/5KcT7/AJdH9/yU4ZX3/Lo3DyQ7UTIBImGSYAVWwRTopUuq6Qgkg8vI8owyTZi5nP0nS3K4OjxQUmkuGCOIsiwFNKotHu949DTIMivtaCQMycn8m01lVFrqpFtUgZ93UvsHERceTRYRJwV93919v9UObRsQUtIcRBAjof7O4GdDi7n2Z1Al87AerUNKTkvQwIjk0IiA8Vkke9BSicmtIelNMheE+a3jfTMwz55HYo2e4zgkL2VfimYePYyzO+jCUC7tUhZs/q9KECAQAWDDIwCiEcoq0L6PopEUSHjQBLBm0QmWSD1+PtjkIMlg9Hj70kMOeOHIob8u0aHL9ZGTfOMq8SyMjdq0qINDIuUHhV8YWbdZOKAi/wBAfL7aMhV2zuvh98TIEA7tGvAAdDRkFcI8Gs5sLthmhINZzl+9KeSCv5y/WHbbIL43fjS9Nh47fl//2Q==\",\"Id\":\"618e90d6-1516-4149-ab34-c82955667396\",\"CreatedAt\":\"2022-07-10T13:46:55.9346859+01:00\"}]");

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
                    } else
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

        public static User? CurrentSession = null;

        // DA 8/7/22 TODO update these values once the file saving system has been implemented
        public static readonly Guid DefaultUserAvatar = Guid.Parse("618e90d6-1516-4149-ab34-c82955667396");
        public static readonly Guid DefaultUserBanner = Guid.Empty;

        public static readonly Guid DefaultUserTheme = Guid.Empty;

        // DA 12/07/22 This will change depending on the game that is being played. Change this before opening the game form
        public static Game? CurrentGame = null;
    }
}
