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
using System.IO;
using System.Reflection;

namespace ASProj
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void menuListIconButton2_Load(object sender, EventArgs e)
        {

        }

        private void copyControl(Control sourceControl, Control targetControl)
        {
            // make sure these are the same
            if (sourceControl.GetType() != targetControl.GetType())
            {
                throw new Exception("Incorrect control types");
            }

            foreach (PropertyInfo sourceProperty in sourceControl.GetType().GetProperties())
            {
                object newValue = sourceProperty.GetValue(sourceControl, null);

                MethodInfo mi = sourceProperty.GetSetMethod(true);
                if (mi != null)
                {
                    sourceProperty.SetValue(targetControl, newValue, null);
                }
            }
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

            pnlProfile.Hide();
            pnlSearch.Hide();
            pnlIncorrect.Hide();

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
                }
                else if (i == (transCount - 2))
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
                    this.Controls.Find("pnlOverview", false)[0].Controls.Find("pnlGames", false)[0].Controls.Find("lblGameIcon" + (i + 1), false)[0].Text = game.Icon.ToString();
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
                cbxUserList.Items.Add(u.Username + "#" + u.Discriminator);
            }
            List<GameRecord> sortedRecords = records.OrderByDescending(gr => gr.Points).ToList();
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
                        }
                        catch (Exception) { }
                    }
                }
            }

            pbxFullCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            pbxSmallAvatar.Image = Program.CurrentSession.Character.GetBitmap();

            foreach (GameRecord r in Program.CurrentSession.Records)
            {
                foreach (GivenAnswer ga in r.Answers)
                {
                    if (!ga.IsCorrect)
                    {

                        ASProj.Controls.RoundedPanel rpl = new ASProj.Controls.RoundedPanel();
                        Label lblQ = new Label();
                        Label lblIA = new Label();
                        Label lblCA = new Label();

                        copyControl(rplTemp, rpl);

                        rpl.Size = rplTemp.Size;
                        rpl.Visible = true;

                        ((Label)lblQ).Text = ga.Question.Description;
                        ((Label)lblIA).Text = "You said: " + ga.ChosenAnswer;
                        ((Label)lblCA).Text = "Correct answer: " + ga.CorrectAnswer;

                        lblQ.Location = rplTemp.Controls[2].Location;
                        lblIA.Location = rplTemp.Controls[1].Location;
                        lblCA.Location = rplTemp.Controls[0].Location;

                        lblQ.ForeColor = Color.White;
                        lblIA.ForeColor = Color.White;
                        lblCA.ForeColor = Color.White;

                        lblQ.Size = new Size(lblQ.Size.Width * 2, lblQ.Size.Height);
                        lblIA.Size = new Size(lblIA.Size.Width * 2, lblIA.Size.Height);
                        lblCA.Size = new Size(lblCA.Size.Width * 2, lblCA.Size.Height);

                        lblQ.Parent = rpl;
                        lblIA.Parent = rpl;
                        lblCA.Parent = rpl;

                        /*ASProj.Controls.RoundedPanel rpl = new ASProj.Controls.RoundedPanel();
                        Label lblQ = new Label();
                        Label lblIA = new Label();
                        Label lblCA = new Label();

                        rpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(77)))));
                        rpl.Location = new System.Drawing.Point(3, 1020);
                        rpl.Name = "roundedPanel21";
                        rpl.Size = rplTemp.Size;

                        lblQ.AutoSize = true;
                        lblQ.Font = new System.Drawing.Font("Manrope Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblQ.ForeColor = System.Drawing.Color.White;
                        lblQ.Location = new System.Drawing.Point(45, 39);
                        lblQ.Name = "label9";
                        lblQ.Size = new System.Drawing.Size(277, 28);
                        lblQ.TabIndex = 0;
                        lblQ.Text = "What does Ísskápur mean?";
                        lblQ.Parent = rpl;

                        lblIA.AutoSize = true;
                        lblIA.Font = new System.Drawing.Font("Manrope Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblIA.ForeColor = System.Drawing.Color.White;
                        lblIA.Location = new System.Drawing.Point(602, 39);
                        lblIA.Name = "label12";
                        lblIA.Size = new System.Drawing.Size(143, 28);
                        lblIA.TabIndex = 1;
                        lblIA.Text = "You said: dog";
                        lblIA.Parent = rpl;

                        lblCA.AutoSize = true;
                        lblCA.Font = new System.Drawing.Font("Manrope Medium", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblCA.ForeColor = System.Drawing.Color.White;
                        lblCA.Location = new System.Drawing.Point(1067, 39);
                        lblCA.Name = "label14";
                        lblCA.Size = new System.Drawing.Size(235, 28);
                        lblCA.TabIndex = 2;
                        lblCA.Text = "Correct answer: fridge";
                        lblCA.Parent = rpl;*/

                        flpAnswers.Controls.Add(rpl);
                    }
                }
            }
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
            pnlIncorrect.Hide(); btnIncorrect.Selected = false;
            pnlSearch.Hide(); btnSearch.Selected = false;
            pnlAvatar.Hide(); btnAvatar.Selected = false;
            pnlProfile.Hide();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlIncorrect.Hide(); btnIncorrect.Selected = false;
            pnlSearch.Hide(); btnSearch.Selected = false;
            pnlAvatar.Show(); btnAvatar.Selected = true;
            pnlProfile.Hide();
        }

        private void btnCustomizeCharacter_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlIncorrect.Hide(); btnIncorrect.Selected = false;
            pnlSearch.Hide(); btnSearch.Selected = false;
            pnlAvatar.Show(); btnAvatar.Selected = true;
            pnlProfile.Hide();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            // DA 12/07/22 TODO change this to a random game selector
            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            Program.CurrentGame = games[0];

            Hide();
            Form gfrmSwim = new Games.gfrmPlatformer();
            gfrmSwim.Show();
            gfrmSwim.SetDesktopLocation(Location.X, Location.Y);
        }

        private void lblGameIcon1_Click(object sender, EventArgs e)
        {
            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            for (int i = 1; i < (games.Length + 1); i++)
            {
                Game game = games[i - 1];
                if (i == 1)
                {
                    // DA 6/9/22 TODO change method to loop through each game and click method depending on that game
                    Program.CurrentGame = game;

                    Hide();
                    Form gfrmGame = new Games.gfrmConversation();
                    gfrmGame.Show();
                    gfrmGame.SetDesktopLocation(Location.X, Location.Y);
                }
            }
        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGameIcon2_Click(object sender, EventArgs e)
        {
            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            for (int i = 1; i < (games.Length + 1); i++)
            {
                Game game = games[i - 1];
                if (i == 1)
                {
                    // DA 6/9/22 TODO change method to loop through each game and click method depending on that game
                    Program.CurrentGame = game;

                    Hide();
                    Form gfrmGame = new Games.gfrmFeed();
                    gfrmGame.Show();
                    gfrmGame.SetDesktopLocation(Location.X, Location.Y);
                }
            }
        }

        private void lblGameIcon3_Click(object sender, EventArgs e)
        {
            Game[] games = JsonConvert.DeserializeObject<Game[]>(FileHandler.Select("games.json"));
            for (int i = 1; i < (games.Length + 1); i++)
            {
                Game game = games[i - 1];
                if (i == 1)
                {
                    // DA 6/9/22 TODO change method to loop through each game and click method depending on that game
                    Program.CurrentGame = game;

                    Hide();
                    Form gfrmGame = new Games.gfrmSwim();
                    gfrmGame.Show();
                    gfrmGame.SetDesktopLocation(Location.X, Location.Y);
                }
            }
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlAvatar.Hide(); btnAvatar.Selected = false;
            pnlSearch.Hide(); btnSearch.Selected = false;
            pnlIncorrect.Show(); btnIncorrect.Selected = true;
            pnlProfile.Hide();
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSearch.Hide();
            pnlProfile.Show();

            User[] users = JsonConvert.DeserializeObject<User[]>(FileHandler.Select("users.json"));
            List<GameRecord> records = new List<GameRecord>();
            foreach (User u in users)
            {
                if (u.Username + "#" + u.Discriminator == cbxUserList.Text)
                {
                    lblProfileUsername.Text = u.Username + "#" + u.Discriminator;
                    lblProfileId.Text = u.Id.ToString();
                    pbxProfilePhoto.Image = UserImage.Search(u.GetAvatar()).ToBitmap();
                    lblProfilePoints.Text = u.Points.ToString();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlOverview.Hide(); btnOverview.Selected = false;
            pnlAvatar.Hide(); btnAvatar.Selected = false;
            pnlIncorrect.Hide(); btnIncorrect.Selected = false;
            pnlProfile.Hide();
            pnlSearch.Show(); btnSearch.Selected = true;
        }
    }
}
