using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class GameRecord // DA 10/7/22 Create a GameRecord when the game starts, then add the answers to it during gameplay, and competiontime at the end
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public GameRecord(Guid Id, Game Game, Guid User, DateTime Date, int? CompletionTime, List<GivenAnswer> Answers, int? Points)
        {
            this.Id = Id;
            this.Game = Game;
            this.User = User;
            this.Date = Date;
            this.CompletionTime = CompletionTime;
            this.Answers = Answers;
            this.Points = Points;
        }
        public GameRecord(Game Game, Guid User)
        {
            Id = Guid.NewGuid();
            this.Game = Game;
            this.User = User;
            Date = DateTime.Now;
            Answers = new List<GivenAnswer>();
        }

        // DA 10/7/22 Properties
        public Guid Id { get; }
        public Game Game { get; }
        public Guid User { get; }
        public DateTime Date { get; }
        public int? CompletionTime { get; set; } // DA 10/7/22 Time to complete the game (in seconds)
        public List<GivenAnswer> Answers { get; set; }
        public int? Points { get; set; }
    }
}
