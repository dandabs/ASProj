using ASProj.Classes;
using Newtonsoft.Json;
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
using ASProj.Utils;

namespace ASProj
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
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

            decimal pil = ScoreUtils.PointsInLevel(Convert.ToInt32(level) + 1);
            decimal value = (decimal)Program.CurrentSession.Points / pil;
            lblToGoPercent.Text = (value * 100) + "%";
            pbToGo.Value = value;

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

            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            for (int i = 0; i < games.Length; i++)
            {
                Game game = games[i];
                if (i <= 6)
                {
                    this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlGames", false)[0].Controls.Find("lblGameIcon" + (i + 1), false)[0].Text   = game.Icon.ToString();
                    this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlGames", false)[0].Controls.Find("lblGameName" + (i + 1), false)[0].Text = game.Name;
                    this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlGames", false)[0].Controls.Find("lblGameGenre" + (i + 1), false)[0].Text = game.Genre;
                    int points = 0;
                    foreach (Question q in game.Questions)
                    {
                        points += q.Points;
                    }
                    this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlGames", false)[0].Controls.Find("lblGamePoints" + (i + 1), false)[0].Text = Convert.ToString(points);
                }
            }

            User[] users = JsonConvert.DeserializeObject<User[]>(FileHandler.Select("users.json"));
            List<GameRecord> records = new List<GameRecord>();
            foreach (User u in users)
            {
                if (u.Records != null)
                {
                    foreach (GameRecord gr in u.Records)
                    {
                        records.Add(gr);
                    }
                }
            }
            List<GameRecord> sortedRecords = records.OrderByDescending(gr=>gr.Points).ToList();
            if (sortedRecords.Count != 0)
            {
                for (int i = 0; i <= 6; i++)
                {
                    if (sortedRecords.Count >= i)
                    {
                        try
                        {
                            GameRecord gr = sortedRecords[i];
                            User u = User.Search(gr.User);
                            this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlScores", false)[0].Controls.Find("lblTopScoreName" + (i + 1), false)[0].Text = u.Username + "#" + u.Discriminator;
                            this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlScores", false)[0].Controls.Find("lblTopScoreDesc" + (i + 1), false)[0].Text = gr.Points + " on " + gr.Date.Day + "/" + gr.Date.Month + "/" + gr.Date.Year;
                            ((PictureBox)this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlScores", false)[0].Controls.Find("pbxTopScore" + (i + 1), false)[0]).Image = UserImage.Search(u.GetAvatar()).ToBitmap();
                        } catch (Exception) { }
                        }
                }
            }

            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
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

        private void pbxHairCarola_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "carola";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairGaga_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "gaga";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairMatthias_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "hatari";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairPetra_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "petra";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairSanna_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "sanna";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairTheresa_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "theresa";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxHairTheo_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Hair = "theo";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceCarola_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "carola";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceGaga_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "gaga";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceMatthias_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "hatari";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFacePetra_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "petra";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceSanna_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "sanna";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceTheresa_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "theresa";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxFaceTheo_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Head = "theo";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyCarola_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "carola";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyGaga_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "gaga";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyMatthias_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "hatari";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyPetra_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "petra";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodySanna_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "sanna";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyTheresa_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "theresa";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxBodyTheo_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Body = "theo";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsCarola_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "carola";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsGaga_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "gaga";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsMatthias_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "hatari";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsPetra_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "petra";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsSanna_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "sanna";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsTheresa_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "theresa";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void pbxLegsTheo_Click(object sender, EventArgs e)
        {
            Program.CurrentSession.Character.Legs = "theo";
            Program.CurrentSession.Save();
            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();
        }

        private void menuListIconButton2_Click(object sender, EventArgs e)
        {
            pnlOverview.Show(); btnOverview.Selected = true;
            pnlAvatar.Hide(); btnAvatar.Selected = false;
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlAvatar.Show(); btnAvatar.Selected = true;
        }

        private void btnCustomizeCharacter_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlAvatar.Show(); btnAvatar.Selected = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            // DA 12/07/22 TODO change this to a random game selector
            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            Program.CurrentGame = games[0];

            Hide();
            Form gfrmSwim = new Games.gfrmSwim();
            gfrmSwim.Show();
            gfrmSwim.SetDesktopLocation(Location.X, Location.Y);
        }
    }
}
