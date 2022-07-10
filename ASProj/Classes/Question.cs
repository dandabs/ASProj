using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class Question
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public Question(int Id, string Description, string[] Answers, string CorrectAnswer, int Points)
        {
            this.Id = Id;
            this.Description = Description;
            this.Answers = Answers;
            this.CorrectAnswer = CorrectAnswer;
            this.Points = Points;
        }
        // DA 10/7/22 Properties
        public int Id { get; }
        public string Description { get; }   // DA 10/7/22 For example, "isskápur"
        public string[] Answers { get; }     // DA 10/7/22 For example, ["freezer", "fridge", "oven", "microwave"]
        public string CorrectAnswer { get; } // DA 10/7/22 For example, "fridge"
        public int Points { get; }           // DA 10/7/22 For example, 20
    }
}
