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
    public partial class gfrmMaze : Form
    {
        public gfrmMaze()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private int _time = 0;
        private int _points = 0;
        private Question _currentquestion = null;
        private Game _currentgame = Program.CurrentGame;

        private Point _initlocation;

        private int _questionindex = -1;

        private GameRecord _record = new GameRecord(Program.CurrentGame, Program.CurrentSession.Id);

        private void askQuestion(Question q)
        {
            lblQuestion.Text = q.Description;
            pbxCharacter.Location = _initlocation;
            pnlMenu.Visible = true;

            lblA1.Visible = true;
            lblA2.Visible = true;
            lblA3.Visible = true;
            lblA4.Visible = true;
            lblA5.Visible = true;
            lblA6.Visible = true;

            for (int i = 0; i < q.Answers.Length; i++)
            {
                String a = q.Answers[i];

                ((Label)Controls.Find("lblA" + (i + 1), true)[0]).Text = a;
            }

            _currentquestion = q;
            _questionindex++;

            tmrGameplay.Enabled = true;
        }

        private void handleAnswer(int i)
        {
            tmrGameplay.Enabled = false;

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

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        Label _selected = null;

        private void gfrmMaze_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tmrGameplay.Enabled = false;
                pnlMenu.Visible = true;
            }

            if (e.KeyCode == Keys.B)
            {
                if (_selected != null)
                {
                    Controls.Find(_selected.Name, true)[0].Visible = true;
                    //Controls.Find(_selected.Name, true)[0].Location = pbxCharacter.Location;
                    _selected = null;
                } 

                foreach (Control c1 in Controls)
                {
                    if (c1.Name.StartsWith("lblA") && c1.Bounds.IntersectsWith(pbxCharacter.Bounds)) _selected = (Label)c1;
                }

                if (_selected != null)
                {
                    Controls.Find(_selected.Name, true)[0].Visible = false;
                }
            }

            bool canMove = true;
            foreach (Control c1 in Controls)
            {
                Rectangle potentialBounds = pbxCharacter.Bounds;

                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left, potentialBounds.Top - 10);
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left, potentialBounds.Top + 10);
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left - 10, potentialBounds.Top);
                }
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left + 10, potentialBounds.Top);
                }

                bool doesIntersect = c1.Bounds.IntersectsWith(potentialBounds);

                if ((string)c1.Tag == "wall" && doesIntersect)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    pbxCharacter.Top -= 10;
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    pbxCharacter.Top += 10;
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    pbxCharacter.Left -= 10;
                }
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    pbxCharacter.Left += 10;
                }
            }
            if (pbxCharacter.Bounds.IntersectsWith(lblFinish.Bounds) && _selected != null)
            {
                handleAnswer(Convert.ToInt32(_selected.Name.Split('A')[1]) - 1);
            }
        }

        private void tmrGameplay_Tick(object sender, EventArgs e)
        {
            _time++;
        }

        private void gfrmMaze_Load(object sender, EventArgs e)
        {
            _initlocation = pbxCharacter.Location;
            pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            askQuestion(_currentgame.Questions[0]);
            pnlMenu.Visible = true;
            pnlEndGame.Visible = false;
            lblGameName.Text = _currentgame.Name;
            lblGameName2.Text = _currentgame.Name;
            lblGoal.Text = _currentgame.Goal;
        }

        private void pnlEndGame_Click(object sender, EventArgs e)
        {
            Form frmDashboard = new frmDashboard();
            frmDashboard.Show();
            frmDashboard.SetDesktopLocation(Location.X, Location.Y);
            Close();
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            tmrGameplay.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlMenu_Click(sender, e);
        }
    }
}
