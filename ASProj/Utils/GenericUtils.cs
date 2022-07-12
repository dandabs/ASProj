using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Utils
{
    public class GenericUtils
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
            var ar = opa1 + opa2 - opa1 * opa2;
            var asr = opa2 / ar;
            var a1 = 1 - asr;
            var a2 = asr * (1 - opa1);
            var ab = asr * opa1;
            var r = (byte)(c1.R * a1 + c2.R * a2 + c2.R * ab);
            var g = (byte)(c1.G * a1 + c2.G * a2 + c2.G * ab);
            var b = (byte)(c1.B * a1 + c2.B * a2 + c2.B * ab);
            return Color.FromArgb((byte)(ar * 255), r, g, b);
        }

        [Conditional("DEBUG")]
        public static void updateDebug(ref bool isDebug)
        {
            isDebug = true;
        }

        public static void Wait(int ms)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (ms == 0 || ms < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = ms;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
