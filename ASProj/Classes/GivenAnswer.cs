using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class GivenAnswer
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public GivenAnswer( Question Question, string ChosenAnswer)
        {
            this.Question = Question;
            this.ChosenAnswer = ChosenAnswer;
        }

        // DA 10/7/22 Properties
        public Question Question { get; }
        public string ChosenAnswer { get; }
        public string CorrectAnswer { get { return Question.CorrectAnswer; } }
        public bool IsCorrect { get { return (ChosenAnswer == CorrectAnswer); } }
    }
}
