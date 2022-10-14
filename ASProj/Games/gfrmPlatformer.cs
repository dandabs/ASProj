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
    public partial class gfrmPlatformer : Form
    {
        public gfrmPlatformer()
        {
            InitializeComponent();
        }

        Point _charDefault;

        private int _time = 0;
        private int _points = 0;
        private Question _currentquestion = null;
        private Game _currentgame = Program.CurrentGame;

        private int _questionindex = -1;

        private GameRecord _record = new GameRecord(Program.CurrentGame, Program.CurrentSession.Id);

        private int _selectedindex = -1;

        private void gfrmPlatformer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pnlMenu.Visible = true;
                tmrGameplay.Enabled = false;
            }

            if (e.KeyCode == Keys.B)
            {
                foreach (Control c in Controls)
                    if (c.Name.StartsWith("lblA"))
                        if (c.Bounds.IntersectsWith(pbxCharacter.Bounds))
                        {
                            lblA1.Visible = true;
                            lblA2.Visible = true;
                            lblA3.Visible = true;
                            lblA4.Visible = true;
                            lblA5.Visible = true;
                            lblA6.Visible = true;

                            _selectedindex = Convert.ToInt32(c.Name.Substring(4, 1));
                            c.Visible = false;
                        }
                return;
            }

            int charY = 0;
            int charX = 0;
            switch (e.KeyCode)
            {
                case Keys.A:
                    charX = -5;
                    break;
                case Keys.D:
                    charX = 5;
                    break;
                case Keys.Space:
                    charY = -15;
                    break;
                default:
                    break;
            }
            Rectangle p = new Rectangle(
                new Point(pbxCharacter.Location.X + charX, pbxCharacter.Location.Y + charY),
                pbxCharacter.Size
            );
            bool doMove = true;
            bool canDown = true;
            foreach (Control c in Controls)
            {
                if ((string)c.Tag == "solid")
                    if (c.Bounds.IntersectsWith(new Rectangle(new Point(pbxCharacter.Location.X, pbxCharacter.Location.Y + 5), pbxCharacter.Size)))
                        canDown = false;
                if ((string)c.Tag == "solid" && c.Bounds.IntersectsWith(p))
                {
                    doMove = false;
                }
            }

            if (pnlMenu.Visible == true) doMove = false;

            if ((e.KeyCode == Keys.D || e.KeyCode == Keys.A) && !canDown) doMove = true;
            if (doMove) { pbxCharacter.Left += charX; pbxCharacter.Top += charY; } 
        }

        private void tmrFall_Tick(object sender, EventArgs e)
        {
            Rectangle p = new Rectangle(
                new Point(pbxCharacter.Location.X, pbxCharacter.Location.Y - 1),
                pbxCharacter.Size
            );
            bool doMove = true;
            foreach (Control c in Controls)
            {
                if ((string) c.Tag == "solid" && c.Bounds.IntersectsWith(p))
                {
                    doMove = false;
                    if (c.Name == "pnlStart" && _selectedindex != -1) 
                    { 
                        handleAnswer(_selectedindex - 1); _selectedindex = -1;
                    }
                }
            }
            if (doMove) pbxCharacter.Top += 1;
            if (pbxCharacter.Bounds.IntersectsWith(pnlBottom.Bounds)) pbxCharacter.Location = _charDefault;
        }

        private void gfrmPlatformer_Load(object sender, EventArgs e)
        {
            pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            _charDefault = pbxCharacter.Location;
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            askQuestion(Program.CurrentGame.Questions[0]);
            lblGameName.Text = Program.CurrentGame.Name;
            lblGoal.Text = Program.CurrentGame.Goal;
            pnlEndGame.Visible = false;
            pnlMenu.Visible = true;
        }

        private void tmrGameplay_Tick(object sender, EventArgs e)
        {
            _time++;
        }

        private void askQuestion(Question q)
        {
            lblQuestion.Text = q.Description;
            pnlMenu.Visible = true;

            for (int i = 0; i < q.Answers.Length; i++)
            {
                String a = q.Answers[i];

                ((Label)Controls.Find("lblA" + (i + 1), true)[0]).Text = a;
            }

            _currentquestion = q;
            _questionindex++;
        }
        
        private void handleAnswer(int i)
        {
            tmrGameplay.Enabled = false;

            lblA1.Visible = true;
            lblA2.Visible = true;
            lblA3.Visible = true;
            lblA4.Visible = true;
            lblA5.Visible = true;
            lblA6.Visible = true;

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

            pnlEndGame.Visible = true;
            lblGameName2.Text = Program.CurrentGame.Name;
            lblPoints.Text = "You scored " + _record.Points + " points.";

            int correct = 0;
            int incorrect = 0;

            foreach (GivenAnswer a in _record.Answers) if (a.IsCorrect) { correct++; } else incorrect++;

            lblCorrect.Text = "You answered " + correct + " questions correctly.";
            lblIncorrect.Text = "You answered " + incorrect + " questions incorrectly.";

            lblTotalTime.Text = "It took you " + _record.CompletionTime + " seconds in total.";
            lblAverageTime.Text = "An average of " + (_record.CompletionTime / _record.Answers.Count) + " seconds per question.";
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            tmrGameplay.Enabled = true;
        }

        private void pnlEndGame_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new frmDashboard();
            frmDashboard.Show();
            frmDashboard.SetDesktopLocation(Location.X, Location.Y);
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlMenu_Click(sender, e);
        }
    }
}
