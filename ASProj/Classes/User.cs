using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class User
    {
        // DA 8/7/22 Constructor
        public User(string username)
        {
            Username = username.Trim();

            Id = Guid.NewGuid();

            // DA 8/7/22 Generate random 4 digit discriminator
            // DA 8/7/22 TODO check if already exists and throw error
            Random rnd = new Random();
            Discriminator = rnd.Next(1000, 9999); // DA 8/7/22 Only generates 4 digit number

            CreatedAt = DateTime.Now;
        }

        // DA 8/7/22 Base Properties (things that define who the user is)
        public Guid Id { get; }
        public string Username { get; }
        public int Discriminator { get; }
        public DateTime CreatedAt { get; }

        // DA 8/7/22 Avatar Properties (things that the user can customize)
        public Guid? Avatar { get; set; }
        public Guid? Banner { get; set; }
        public Guid? Character { get; set; }
        public Guid? Theme { get; set; } // DA 8/7/22 TODO player can customise their profile theme music
        public string? Status { get; set; }

        // DA 8/7/22 Property Methods (methods to return values for potentially nullable properties)
        public Guid GetAvatar()
        {
            if (Avatar.HasValue)
            {
                return this.Avatar.Value;
            }
            else return Program.DefaultUserAvatar;
        }
        public Guid GetBanner()
        {
            if (Banner.HasValue)
            {
                return this.Banner.Value;
            }
            else return Program.DefaultUserBanner;
        }
        public Guid GetCharacter()
        {
            if (Character.HasValue)
            {
                return this.Character.Value;
            }
            else return Program.DefaultUserCharacter;
        }
        public Guid GetTheme()
        {
            if (Theme.HasValue)
            {
                return Theme.Value;
            }
            else return Program.DefaultUserTheme;
        }
        public string GetStatus()
        {
            if (!String.IsNullOrEmpty(Status))
            {
                return Status;
            }
            else return "";
        }
    }
}
