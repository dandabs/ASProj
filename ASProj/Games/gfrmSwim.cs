using ASProj.Classes;
using ASProj.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj.Games
{
    public partial class gfrmSwim : Form
    {
        public gfrmSwim()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private int _downtime = 0;

        private int _time = 0;
        private int _points = 0;
        private Question _currentquestion = null;
        private Game _currentgame = Program.CurrentGame;

        private Point _pbxCharacterDefault;

        private int _questionindex = -1;

        private GameRecord _record = new GameRecord(Program.CurrentGame, Program.CurrentSession.Id);

        public Image RotateImage(Image img)
        {
            var bmp = new Bitmap(img);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(Color.Transparent);
                gfx.DrawImage(img, 0, 0, img.Width, img.Height);
            }

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return bmp;
        }

        private void tmrGameplay_Tick(object sender, EventArgs e)
        {
            _time++;
        }

        private void askQuestion(Question q)
        {
            lblQuestion.Text = q.Description;

            for (int i = 0; i < q.Answers.Length; i++)
            {
                String a = q.Answers[i];

                Label lbl = new Label();
                lbl.Text = a;
                lbl.Location = new Point(i % 2 != 0 ? 249 : 1468, -30);
                lbl.Parent = this;
                lbl.Name = "albl_" + q.Id + "i" + (i - (i % 2)) / 2 + "_" + a + "_" + i;
                lbl.Size = new Size(100, 35);
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.White;
                Controls.Add(lbl);
            }
            _downtime = 0;
            tmrMoveDown.Enabled = true;

            _currentquestion = q;
            _questionindex++;

            tmrGameplay.Enabled = true;
        }

        private void tmrMoveDown_Tick(object sender, EventArgs e)
        {
            _downtime++;
            foreach (Control c in Controls)
            {
                if (c.Name.StartsWith("albl_" + _currentquestion.Id))
                {
                    int level = Convert.ToInt32(c.Name.Split('_')[1].Substring(2));
                    if ((level == 0) || (level == 1 && _downtime >= 10) || (level == 2 && _downtime >= 20))
                    {
                        c.Location = new Point(c.Location.X, c.Location.Y + 40);
                    }
                } else if (c.Name.StartsWith("albl_"))
                {
                    Controls.Remove(c);
                }
            }
        }

        private void handleAnswer(int i)
        {
            tmrGameplay.Enabled = false;
            tmrMoveDown.Enabled = false;
            _downtime = 0;

            foreach (Control c in Controls)
            {
                if (c.Name.StartsWith("albl_" + _currentquestion.Id)) Controls.Remove(c);
            }

            GivenAnswer ga = new GivenAnswer(_currentquestion, _currentquestion.Answers[i]);
            _record.Answers.Add(ga);
            if (ga.IsCorrect)
            {
                _points += _currentquestion.Points;
            }

            if (_currentgame.Questions.Length - 1 == _questionindex)
            {
                endGame();
            }
            else
            {
                askQuestion(_currentgame.Questions[_questionindex + 1]);
            }

        }

        private void endGame()
        {
            _record.CompletionTime = _time;
            _record.Points = _points;
            Program.CurrentSession.Records.Add(_record);

            Program.CurrentSession.Transactions.Add(new Transaction(_points, "Completed a game: " + _currentgame.Name));

            Program.CurrentSession.Points += _points;

            Program.CurrentSession.Save();

            Form frmDashboard = new frmDashboard();
            frmDashboard.Show();
            frmDashboard.SetDesktopLocation(Location.X, Location.Y);
            Close();
        }

        private void frmSwim_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.Name.StartsWith("albl_" + _currentquestion.Id) && c.Bounds.IntersectsWith(pbxCharacter.Bounds))
                {
                    Controls.Remove(c);
                    handleAnswer(Convert.ToInt32(c.Name.Split('_')[3]));
                    pbxCharacter.Location = _pbxCharacterDefault;
                }
            }

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                pbxCharacter.Location = new Point(pbxCharacter.Location.X, pbxCharacter.Location.Y - 20);
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                pbxCharacter.Location = new Point(pbxCharacter.Location.X, pbxCharacter.Location.Y + 20);
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                pbxCharacter.Location = new Point(pbxCharacter.Location.X - 20, pbxCharacter.Location.Y);
                pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                pbxCharacter.Location = new Point(pbxCharacter.Location.X + 20, pbxCharacter.Location.Y);
                pbxCharacter.Image = RotateImage(Program.CurrentSession.Character.GetBitmap());
            }
        }

        private void gfrmSwim_Load(object sender, EventArgs e)
        {
            pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            _pbxCharacterDefault = pbxCharacter.Location;
            askQuestion(_currentgame.Questions[0]);
        }
    }
}
