using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ASProj
{
    public class Utils
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        // A cache of all opacity values (0-255) scaled down to 0-1 for performance
        private static readonly float[] _opacities = Enumerable.Range(0, 256)
                                              .Select(o => o / 255f)
                                              .ToArray();

        public static Color AlphaComposite(Color c1, Color c2)
        {
            var opa1 = _opacities[c1.A];
            var opa2 = _opacities[c2.A];
            var ar = opa1 + opa2 - (opa1 * opa2);
            var asr = opa2 / ar;
            var a1 = 1 - asr;
            var a2 = asr * (1 - opa1);
            var ab = asr * opa1;
            var r = (byte)(c1.R * a1 + c2.R * a2 + c2.R * ab);
            var g = (byte)(c1.G * a1 + c2.G * a2 + c2.G * ab);
            var b = (byte)(c1.B * a1 + c2.B * a2 + c2.B * ab);
            return Color.FromArgb((byte)(ar * 255), r, g, b);
        }

        public static long argbToLong(int a, int r, int g, int b)
        {
            new[] { a, r, g, b }.Select((v, i) => new { Name = "argb"[i].ToString(), Value = v }).ToList()
                .ForEach(arg =>
                {
                    if (arg.Value > 255 || arg.Value < 0)
                        throw new ArgumentOutOfRangeException();
                });
            long al = (a << 24) & 0xFF000000;
            long rl = (r << 16) & 0x00FF0000;
            long gl = (g << 8) & 0x0000FF00;
            long bl = b & 0x000000FF;
            return al | rl | gl | bl;
        }

        public static Tuple<int, int, int, int> longToArgb(long argb)
        {
            var max = Math.Pow(16, 8) - 1;
            if (argb < 0 || argb > max)
                throw new ArgumentOutOfRangeException();
            int a = (int)((argb & 0xFF000000) >> 24);
            int r = (int)((argb & 0x00FF0000) >> 16);
            int g = (int)((argb & 0x0000FF00) >> 8);
            int b = (int)(argb & 0x000000FF);
            return new Tuple<int, int, int, int>(a, r, g, b);
        }
    }
}
