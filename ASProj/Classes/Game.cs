using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class Game
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public Game(string Id, char Icon, string Author, string Genre, string Goal, Question[] Questions)
        {
            this.Id = Id;
            this.Icon = Icon;
            this.Author = Author;
            this.Genre = Genre;
            this.Goal = Goal;
            this.Questions = Questions;
        }
        // DA 10/7/22 Properties
        public string Id { get; }     // DA 10/7/22 Users wont be bothered to create a valid GUID/UUID, so we'll make this a string for ease of use
        public char Icon { get; }     // DA 10/7/22 Font-awesome icon glyph (or letter)
        public string Author { get; } // DA 10/7/22 For example, "Daniel Adams"
        public string Genre { get; }  // DA 10/7/22 For example, "Space"
        public string Goal { get; }   // DA 10/7/22 For example, "Match the following words!"
        public Question[] Questions { get; }
    }
}
