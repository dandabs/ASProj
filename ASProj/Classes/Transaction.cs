using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class Transaction
    {
        // DA 8/7/22 Constructor
        [JsonConstructor]
        public Transaction(DateTime Time, int Points, string Description)
        {
            this.Time = Time;
            this.Points = Points;
            this.Description = Description;
        }
        public Transaction(int Points, string Description)
        {
            this.Time = DateTime.Now;
            this.Points = Points;
            this.Description = Description;
        }

        // DA 8/7/22 Properties
        public DateTime Time { get; }
        public int Points { get; }
        public string Description { get; }
    }
}
