using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Utils
{
    public class ScoreUtils
    {
        public static int GetLevel(int points)
        {
            string sP = Convert.ToString(points);
            if (sP.Length != 3) return 1;
            char[] sPP = sP.ToCharArray();
            int s = Convert.ToInt32(sPP[0]) - 48;
            return s + 1;
        }

        public static int ToNextLevel(int points)
        {
            int nextLevel = GetLevel(points) + 1;
            int nextLevelPoints = nextLevel * 100;
            return nextLevelPoints - points;
        }
        public static int PointsInLevel(int level)
        {
            return level * 100;
        }
    }
}
