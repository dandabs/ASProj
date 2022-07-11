using ASProj.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Classes
{
    public class Character
    {
        // DA 10/7/22 Constructor
        [JsonConstructor]
        public Character(String hair, String head, String body, String legs)
        {
            Hair = hair;
            Head = head;
            Body = body;
            Legs = legs;
        }
        public Character()
        {
            Hair = "theresa";
            Head = "theresa";
            Body = "theresa";
            Legs = "theresa";
        }

        // DA 10/7/22 Properties
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string Legs { get; set; }

        // DA 11/7/22 Methods
        public Bitmap GetBitmap()
        {
            return CharUtils.Combine(CharUtils.GetHair(Hair), CharUtils.GetFace(Head), CharUtils.GetBody(Body), CharUtils.GetLegs(Legs));
        }
    }
}
