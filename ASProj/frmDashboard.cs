using ASProj.Classes;
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
            // DA 9/7/22 Testing that serialization + deserialization work
            /*List<User> usrs = new List<User>();
            usrs.Add(new User("dandabs"));
            usrs.Add(new User("frithiof07"));

            string str = User.Serialize(usrs);
            MessageBox.Show(str);

            List<User> str2 = User.Deserialize(str);
            MessageBox.Show(str2.Count + "");*/

            lblUsername.Text = Program.CurrentSession.Username;
            lblDiscriminator.Text = "#" + Program.CurrentSession.Discriminator;
            pbxAvatar.Image = UserImage.Search(Program.CurrentSession.GetAvatar()).ToBitmap();

            lblTotalPoints.Text = Convert.ToString(Program.CurrentSession.Points);

            int transCount = Program.CurrentSession.Transactions.Count;
            for (int i = 0; i < transCount; i++)
            {
                Transaction t = Program.CurrentSession.Transactions[i];
                if (i == (transCount - 1))
                {
                    lblTransDesc1.Text = t.Description;
                    lblTransPoints1.Text = Convert.ToString(t.Points);
                } else if (i == (transCount - 2))
                {
                    lblTransDesc2.Text = t.Description;
                    lblTransPoints2.Text = Convert.ToString(t.Points);
                }
            }
            if (transCount == 0)
            {
                lblTransDesc1.Text = "No activity yet";
                lblTransPoints1.Text = "-";
                lblTransDesc2.Text = "No activity yet";
                lblTransPoints2.Text = "-";
            }
            if (transCount == 1)
            {
                lblTransDesc2.Text = "No activity yet";
                lblTransPoints2.Text = "-";
            }

            string level = Convert.ToString(ScoreUtils.GetLevel(Program.CurrentSession.Points));
            lblLevel.Text = level.Length > 1 ? level : "0" + level;
            lblToGo.Text = ScoreUtils.ToNextLevel(Program.CurrentSession.Points) + " to go";
            lblToGoPercent.Text = (Program.CurrentSession.Points / ScoreUtils.PointsInLevel(Convert.ToInt32(level) + 1)) * 100 + "%";
            pbToGo.Value = Program.CurrentSession.Points / ScoreUtils.PointsInLevel(Convert.ToInt32(level) + 1);

            int incorrect = 0;
            int incorrectnew = 0;

            int timeplayed = 0;
            foreach (GameRecord r in Program.CurrentSession.Records)
            {
                if (r.CompletionTime != null) timeplayed += (int)r.CompletionTime;
                foreach (GivenAnswer ga in r.Answers)
                {
                    if (!ga.IsCorrect) incorrect++;
                    if (r == Program.CurrentSession.Records[Program.CurrentSession.Records.Count - 1]) incorrectnew++; // DA 10/7/22 If most recent game
                }
            }
            lblIncorrect.Text = Convert.ToString(incorrect);
            lblIncorrectNew.Text = "+" + incorrectnew;

            TimeSpan ts = TimeSpan.FromSeconds(timeplayed);
            lblTimePlayed.Text = ts.ToString(@"hh\:mm\:ss");
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

        private void pbxAvatar_Click(object sender, EventArgs e)
        {
            ofdAvatar.InitialDirectory = FileHandler.dir;
            if (ofdAvatar.ShowDialog() == DialogResult.OK)
            {
                // DA 10/7/22 Create image object and save it to the database
                UserImage img = new UserImage(ofdAvatar.FileName);
                img.Save();
                pbxAvatar.Image = img.ToBitmap();

                // DA 10/7/22 Update user object with the new avatar and save it to the database
                Program.CurrentSession.Avatar = img.Id;
                Program.CurrentSession.Save();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            File.Delete(Path.Combine(FileHandler.dir, ".session"));

            Hide();
            Form frmLogin = new frmLogin();
            frmLogin.Show();
            frmLogin.SetDesktopLocation(Location.X, Location.Y);
        }
    }
}
