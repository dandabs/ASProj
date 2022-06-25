using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private void menuListIconButton2_Load(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
            //using (LinearGradientBrush b = new LinearGradientBrush(ClientRectangle, /*Color.FromArgb(255, 100, 37, 52), Color.FromArgb(255, 30, 44, 83)*/ Color.FromArgb(255, 18, 176, 210), Color.FromArgb(255, 255, 219, 214), 0F))
            //{
            //    e.Graphics.FillRectangle(b, ClientRectangle);
            //}
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pill1_Load(object sender, EventArgs e)
        {

        }
    }
}
