using ASProj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private void socialIcon1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit(); // always use application.exit() opposed to environment - runs cleanup code
        }

        private void lblRegisterTitle_Click(object sender, EventArgs e)
        {
            bool registerAlreadySelected = lblRegisterTitle.ForeColor == Color.White ? true : false;
            if (!registerAlreadySelected) // go to register page
            {
                lblRegisterTitle.ForeColor = Color.White;
                lblLoginTitle.ForeColor = Color.FromArgb(255, 61, 73, 82);
                lblRegisterTitle.Cursor = Cursors.Default;
                lblLoginTitle.Cursor = Cursors.Hand;
                pnlRegister.Visible = true;
                pnlLogin.Visible = false;
            }
        }

        private void lblLoginTitle_Click(object sender, EventArgs e)
        {
            bool loginAlreadySelected = lblLoginTitle.ForeColor == Color.White ? true : false;
            if (!loginAlreadySelected) // go to login page
            {
                lblRegisterTitle.ForeColor = Color.FromArgb(255, 61, 73, 82);
                lblLoginTitle.ForeColor = Color.White;
                lblRegisterTitle.Cursor = Cursors.Hand;
                lblLoginTitle.Cursor = Cursors.Default;
                pnlRegister.Visible = false;
                pnlLogin.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(tbxUsername.Text, "^(?=.{4,16}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$").Success)
                // DA 9/7/22 Between 4-16 characters, no _ or . at start or end, allowed a-z, 0-9, . and _
            {
                MessageBox.Show("Invalid username! Please check it complies with the username requirements and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // DA 9/7/22 Do not continue forward
            }
            if (!Regex.Match(tbxPassword.Text, "^\\w{6,}$").Success)
                // DA 9/7/22 Minimum 6 characters
            {
                MessageBox.Show("Invalid password! Please check it complies with the password requirements and try again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // DA 9/7/22 Do not continue forward
            }

            // DA 9/7/22 If entered username and password are valid
            User newUser = new User(tbxUsername.Text, tbxPassword.Text);
            newUser.Save();

            Program.CurrentSession = newUser;

            Hide();
            Form frmDashboard = new frmDashboard();// DA 9/7/22 Can use Form as the object here instead of frmDashboard (as advised by CCEA), permitting the object conforms with the Liskov substitution principle
            frmDashboard.Show();
            frmDashboard.SetDesktopLocation(Location.X, Location.Y);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
