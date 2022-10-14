using ASProj.Classes;
using ASProj.Utils;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj.Games
{
    public partial class gfrmFeed : Form
    {
        public gfrmFeed()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private int _time = 0;
        private int _points = 0;
        private Question _currentquestion = null;
        private Game _currentgame = Program.CurrentGame;

        private int _questionindex = -1;

        private GameRecord _record = new GameRecord(Program.CurrentGame, Program.CurrentSession.Id);

        private Point loc1;
        private Point loc2;
        private Point loc3;
        private Point loc4;
        private Point loc5;
        private Point loc6;

        private void gfrmFeed_Load(object sender, EventArgs e)
        {
            loc1 = lblAnswer1.Location;
            loc2 = lblAnswer2.Location;
            loc3 = lblAnswer3.Location;
            loc4 = lblAnswer4.Location;
            loc5 = lblAnswer5.Location;
            loc6 = lblAnswer6.Location;

            MusicPlayer.playResource(Properties.Resources.The_Days_In_Swordcraft_Academy2, 0.5f);
            pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();
            askQuestion(_currentgame.Questions[0]);

            pnlMenu.Visible = true;
            pnlEndGame.Visible = false;
        }

        private void tmrGameplay_Tick(object sender, EventArgs e)
        {
            _time++;
        }

        private void lblAnswer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer1.Left = e.X + lblAnswer1.Left;
                lblAnswer1.Top = e.Y + lblAnswer1.Top;
            }
        }

        private void handleAnswer(int i)
        {
            tmrGameplay.Enabled = false;

            lblAnswer1.Visible = false;
            lblAnswer2.Visible = false;
            lblAnswer3.Visible = false;
            lblAnswer4.Visible = false;
            lblAnswer5.Visible = false;
            lblAnswer6.Visible = false;

            GivenAnswer ga = new GivenAnswer(_currentquestion, _currentquestion.Answers[i]);
            _record.Answers.Add(ga);
            if (ga.IsCorrect)
            {
                _points += _currentquestion.Points;
            }

            if (_currentgame.Questions.Length - 1 == _questionindex)
            {
                endGame();
            } else
            {
                askQuestion(_currentgame.Questions[_questionindex + 1]);
            }
        }

        private void askQuestion(Question q)
        {
            lblAnswer1.Visible = true;
            lblAnswer2.Visible = true;
            lblAnswer3.Visible = true;
            lblAnswer4.Visible = true;
            lblAnswer5.Visible = true;
            lblAnswer6.Visible = true;

            lblAnswer1.Text = q.Answers[0];
            lblAnswer2.Text = q.Answers[1];
            lblAnswer3.Text = q.Answers[2];
            lblAnswer4.Text = q.Answers[3];
            lblAnswer5.Text = q.Answers[4];
            lblAnswer6.Text = q.Answers[5];

            lblAnswer1.Location = loc1;
            lblAnswer2.Location = loc2;
            lblAnswer3.Location = loc3;
            lblAnswer4.Location = loc4;
            lblAnswer5.Location = loc5;
            lblAnswer6.Location = loc6;

            mqlQuestion.Text = q.Description;

            _currentquestion = q;
            _questionindex++;

            tmrGameplay.Enabled = true;
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

        private void lblAnswer2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer2.Left = e.X + lblAnswer2.Left;
                lblAnswer2.Top = e.Y + lblAnswer2.Top;
            }
        }

        private void lblAnswer3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer3.Left = e.X + lblAnswer3.Left;
                lblAnswer3.Top = e.Y + lblAnswer3.Top;
            }
        }

        private void lblAnswer4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer4.Left = e.X + lblAnswer4.Left;
                lblAnswer4.Top = e.Y + lblAnswer4.Top;
            }
        }

        private void lblAnswer5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer5.Left = e.X + lblAnswer5.Left;
                lblAnswer5.Top = e.Y + lblAnswer5.Top;
            }
        }

        private void lblAnswer6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblAnswer6.Left = e.X + lblAnswer6.Left;
                lblAnswer6.Top = e.Y + lblAnswer6.Top;
            }
        }

        private void lblAnswer2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer4_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer5_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void lblAnswer1_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer1.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(0);
            }
        }

        private void lblAnswer2_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer2.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(1);
            }
        }

        private void lblAnswer3_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer3.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(2);
            }
        }

        private void lblAnswer4_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer4.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(3);
            }
        }

        private void lblAnswer5_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer5.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(4);
            }
        }

        private void lblAnswer6_MouseUp(object sender, MouseEventArgs e)
        {
            if (lblAnswer6.Bounds.IntersectsWith(pbxCharacter.Bounds))
            {
                handleAnswer(5);
            }
        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            tmrGameplay.Enabled = true;
            pnlMenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlMenu_Click(sender, e);
        }

        private void gfrmFeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tmrGameplay.Enabled = false;
                pnlMenu.Visible = true;
            }
        }

        private void pnlEndGame_Click(object sender, EventArgs e)
        {
            MusicPlayer.stopResource();

            Form frmDashboard = new frmDashboard();
            frmDashboard.Show();
            frmDashboard.SetDesktopLocation(Location.X, Location.Y);
            Close();
        }
    }
}
