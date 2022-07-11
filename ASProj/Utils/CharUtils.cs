using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Utils
{
    public class CharUtils
    {
        public static Bitmap GetHair(string type)
        {
            switch (type)
            {
                case "hatari":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0000_hatari);
                    break;
                case "theo":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0001_theo);
                    break;
                case "petra":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0002_petra);
                    break;
                case "gaga":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0003_gaga);
                    break;
                case "carola":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0004_carola);
                    break;
                case "sanna":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0005_sanna);
                    break;
                case "theresa":
                    return new Bitmap(Properties.Resources.hair_0000s_0000s_0006_teresa);
                    break;
                default:
                    throw new Exception("That type doesn't appear to exist");
                    break;
            }
        }
        public static Bitmap GetFace(string type)
        {
            switch (type)
            {
                case "hatari":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0000_hatari);
                    break;
                case "theo":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0001_theo);
                    break;
                case "petra":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0002_petra);
                    break;
                case "gaga":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0003_gaga);
                    break;
                case "carola":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0004_carola);
                    break;
                case "sanna":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0005_sanna);
                    break;
                case "theresa":
                    return new Bitmap(Properties.Resources.hair_0000s_0001s_0006_teresa);
                    break;
                default:
                    throw new Exception("That type doesn't appear to exist");
                    break;
            }
        }
        public static Bitmap GetBody(string type)
        {
            switch (type)
            {
                case "hatari":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0000_hatari);
                    break;
                case "theo":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0001_theo);
                    break;
                case "petra":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0002_petra);
                    break;
                case "gaga":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0003_gaga);
                    break;
                case "carola":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0004_carola);
                    break;
                case "sanna":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0005_sanna);
                    break;
                case "theresa":
                    return new Bitmap(Properties.Resources.hair_0000s_0002s_0006_teresa);
                    break;
                default:
                    throw new Exception("That type doesn't appear to exist");
                    break;
            }
        }
        public static Bitmap GetLegs(string type)
        {
            switch (type)
            {
                case "hatari":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0000_hatari);
                    break;
                case "theo":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0001_theo);
                    break;
                case "petra":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0002_petra);
                    break;
                case "gaga":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0003_gaga);
                    break;
                case "carola":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0004_carola);
                    break;
                case "sanna":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0005_sanna);
                    break;
                case "theresa":
                    return new Bitmap(Properties.Resources.hair_0000s_0003s_0006_teresa);
                    break;
                default:
                    throw new Exception("That type doesn't appear to exist");
                    break;
            }
        }

        public static Bitmap Combine(Bitmap hair, Bitmap face, Bitmap body, Bitmap legs)
        {
            Bitmap bmp = new Bitmap(289, 506, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CompositingMode = CompositingMode.SourceOver;

            g.DrawImage(legs, 0, 0);
            g.DrawImage(body, 0, 0);
            g.DrawImage(face, 0, 0);
            g.DrawImage(hair, 0, 0);

            return bmp;
        }
    }
}
