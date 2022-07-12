using ASProj.Classes;
using ASProj.Utils;
using NAudio.Wave;
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
    public partial class gfrmConversation : Form
    {
        public gfrmConversation()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private GameRecord record = new GameRecord(Program.CurrentGame, Program.CurrentSession.Id);

        private string _typewrite = "";

        private int _state = 0; // DA 12/07/22 0-started, 1-readyforresponse, 2-typingresponse, 3-readyforplay, 4-nextquestion, 5-gameend, 6-readytoend

        private Question? _currentquestion = null;

        private int _time = 0;
        private int _points = 0;

        private void typewrite()
        {
            int i = 0;
            string s = _typewrite;
            while (i < _typewrite.Length)
            {
                if (s.Length >= i + 1)
                {
                    if (s[i] != ' ') Thread.Sleep(50);
                    lblMessageText.Invoke(new Action(() =>
                    {
                        lblMessageText.Text += s[i];
                    }));
                    i++;
                    if (i == _typewrite.Length - 1)
                    {
                        if (_state == 6)
                        {
                            _state = 7;
                        }
                    }
                }
            }
            if (_state == 2)
            {
                _state = 3;
            }
            
        }

        private void typewriteText(string author, string message, Cursor csr)
        {
            lblMessageName.Text = author;
            lblMessageText.Text = "";
            _typewrite = message;
            new Thread(new ThreadStart(this.typewrite)).Start();

            pnlMessage.Cursor = csr;
            lblMessageText.Cursor = csr;
        }

        private void showMessageBubble(bool visibility)
        {
            pnlName.Visible = visibility;
            pnlMessage.Visible = visibility;
            lblMessageText.Visible = visibility;
        }

        private void showAnswerBubble(bool visiblity)
        {
            pnlAnswer.Visible = visiblity;
            ansOne.Visible = visiblity;
            ansTwo.Visible = visiblity;
            ansThree.Visible = visiblity;
            ansFour.Visible = visiblity;
            ansFive.Visible = visiblity;
            ansSix.Visible = visiblity;
        }

        private void playSound(byte[] resource, float volume)
        {
            IWavePlayer wOut = new WaveOut();
            MemoryStream mp3 = new MemoryStream(resource);
            Mp3FileReader reader = new Mp3FileReader(mp3);
            wOut.Volume = volume;
            wOut.Init(reader);
            wOut.Play();

            FormClosing += (s, a) => { wOut.Stop(); };
        }

        private void gfrmConversation_Load(object sender, EventArgs e)
        {
            showAnswerBubble(false);

            showMessageBubble(false);
            lblMessageText.Text = "";
            lblMessageName.Text = "";

            pbxCharacter.Image = Program.CurrentSession.Character.GetBitmap();

            playSound(Properties.Resources.PokemonDiamond, 0.5f);

            pbxArny.Left = -300;
            tmrArnyAnim1.Enabled = true;
        }

        private void tmrArnyAnim1_Tick(object sender, EventArgs e)
        {
            if (pbxArny.Left < 28)
            {
                pbxArny.Left += 1;
            }
            else
            {
                tmrArnyAnim1.Enabled = false;

                showMessageBubble(true);
                _state = 1;

                typewriteText(
                    "Árný Fjóla",
                    "Hello, " + Program.CurrentSession.Username + "!" + Environment.NewLine + "I would like to beat you" + Environment.NewLine + "over the head. Let's fight!",
                    Cursors.Hand
                    );
            }
        }

        private void lblMessageText_Click(object sender, EventArgs e)
        {
            pnlMessage_Click(sender, e);
        }

        private void pnlMessage_Click(object sender, EventArgs e)
        {
            if (_state == 1)
            {
                pnlMessage.Cursor = Cursors.Default;
                lblMessageText.Cursor = Cursors.Default;
                _state = 2;

                typewriteText(
                    Program.CurrentSession.Username,
                    "Let's do this!",
                    Cursors.Hand
                    );
            }
            if (_state == 3)
            {
                pnlMessage.Cursor = Cursors.Default;
                lblMessageText.Cursor = Cursors.Default;

                askQuestion(Program.CurrentGame.Questions[0]);
            }
            if (_state == 4)
            {
                Random r = new Random();

                Question random = _currentquestion;
                while (random == _currentquestion)
                {
                    random = Program.CurrentGame.Questions[r.Next(0, (Program.CurrentGame.Questions.Length))];
                }
                askQuestion(random);
            }
            if (_state == 5)
            {
                if (_arnyhealth == 0) // you win
                {
                    typewriteText(
                    "Árný Fjóla",
                    "Noooooo! How could you do\r\nthis to me?? I can't believe\r\nthat I lost!",
                    Cursors.Hand
                    );
                    _state = 6;
                } else // you lose
                {
                    typewriteText(
                    "Árný Fjóla",
                    "Yesss!!! I always knew I\r\nwould win! Better luck next\r\ntime, nerd!!!",
                    Cursors.Hand
                    );
                    _state = 6;
                }
            }
            if (_state == 7)
            {

                Program.CurrentSession.Transactions.Add(new Transaction(_points, "Completed a game: " + Program.CurrentGame.Name));
                Program.CurrentSession.Points += _points;

                record.Points = _points;
                record.CompletionTime = _time;

                Program.CurrentSession.Records.Add(record);
                Program.CurrentSession.Save();

                Hide();
                Form frmDashboard = new frmDashboard();
                frmDashboard.Show();
                frmDashboard.SetDesktopLocation(Location.X, Location.Y);

            }
        }

        private int _yourhealth = 4;
        private int _arnyhealth = 4;

        private void askQuestion(Question q)
        {
            pbxAttack.Visible = false;
            _currentquestion = q;

            typewriteText(
                    "Árný Fjóla",
                    q.Description,
                    Cursors.Default
                    );

            showAnswerBubble(true);
            tmrGameplay.Enabled = true;
            
            for (int i = 0; i < q.Answers.Length; i++)
            {
                if (i <= 6)
                {
                    string num = "";
                    switch (i + 1)
                    {
                        case 1:
                            num = "One";
                            break;
                        case 2:
                            num = "Two";
                            break;
                        case 3:
                            num = "Three";
                            break;
                        case 4:
                            num = "Four";
                            break;
                        case 5:
                            num = "Five";
                            break;
                        case 6:
                            num = "Six";
                            break;
                    }
                    Controls.Find("lblAns" + num, true)[0].Text   = q.Answers[i];
                    Controls.Find("lblAns" + num, true)[0].Cursor = Cursors.Hand;
                    Controls.Find("ans" + num, true)[0].Cursor    = Cursors.Hand;
                }
            }

            if (q.Answers.Length < 6)
            {
                switch (q.Answers.Length)
                {
                    case 5:
                        ansSix.Visible = false;
                        break;
                    case 4:
                        ansSix.Visible = false;
                        ansFive.Visible = false;
                        break;
                    case 3:
                        ansSix.Visible = false;
                        ansFive.Visible = false;
                        ansFour.Visible = false;
                        break;
                    case 2:
                        ansSix.Visible = false;
                        ansFive.Visible = false;
                        ansFour.Visible = false;
                        ansThree.Visible = false;
                        break;
                    case 1:
                        ansSix.Visible = false;
                        ansFive.Visible = false;
                        ansFour.Visible = false;
                        ansThree.Visible = false;
                        ansTwo.Visible = false;
                        break;
                }
            }
        }

        private void removeHealth(int who)
        {
            if (who == 0) // from arny
            {
                _arnyhealth--;
                switch (_arnyhealth)
                {
                    case 3:
                        pbxOppHealth3.Image = Properties.Resources.heart_empty;
                        break;
                    case 2:
                        pbxOppHealth3.Image = Properties.Resources.heart_empty;
                        pbxOppHealth2.Image = Properties.Resources.heart_empty;
                        break;
                    case 1:
                        pbxOppHealth3.Image = Properties.Resources.heart_empty;
                        pbxOppHealth2.Image = Properties.Resources.heart_empty;
                        pbxOppHealth1.Image = Properties.Resources.heart_empty;
                        break;
                    case 0:
                        _state = 5;
                        break;
                }
            } else if (who == 1) // from the player
            {
                _yourhealth--;
                switch (_yourhealth)
                {
                    case 3:
                        pbxUsrHealth3.Image = Properties.Resources.heart_empty;
                        break;
                    case 2:
                        pbxUsrHealth3.Image = Properties.Resources.heart_empty;
                        pbxUsrHealth2.Image = Properties.Resources.heart_empty;
                        break;
                    case 1:
                        pbxUsrHealth3.Image = Properties.Resources.heart_empty;
                        pbxUsrHealth2.Image = Properties.Resources.heart_empty;
                        pbxUsrHealth1.Image = Properties.Resources.heart_empty;
                        break;
                    case 0:
                        _state = 5;
                        break;
                }
            }
        }

        private void handleAnswer(int i)
        {
            tmrGameplay.Enabled = false;
            showAnswerBubble(false);

            playSound(Properties.Resources.Hit_Super_Effective, 1f);

            pbxAttack.Visible = true;

            GivenAnswer ga = new GivenAnswer(_currentquestion, _currentquestion.Answers[i]);
            record.Answers.Add(ga);

            if (ga.IsCorrect)
            {
                pbxAttack.Image = Properties.Resources.FireBallAttack;
                removeHealth(0);
                typewriteText(
                    "Árný Fjóla",
                    "Fokkaðu þér! I promise that\r\nI will win next time! Don't\r\nunderestimate my power!",
                    Cursors.Hand
                    );
                _points += _currentquestion.Points;
            }
            else
            {
                pbxAttack.Image = Properties.Resources.FireBall;
                removeHealth(1);
                typewriteText(
                    "Árný Fjóla",
                    "Hahahaha! Sucks to be you!\r\nI'm going to win this game.\r\nYou don't stand a chance!",
                    Cursors.Hand
                    );
            }

            if (_state != 5) _state = 4;

        }

        private void ansOne_Click(object sender, EventArgs e)
        {
            handleAnswer(0);
        }

        private void ansTwo_Click(object sender, EventArgs e)
        {
            handleAnswer(1);
        }

        private void ansThree_Click(object sender, EventArgs e)
        {
            handleAnswer(2);
        }

        private void ansFour_Click(object sender, EventArgs e)
        {
            handleAnswer(3);
        }

        private void ansFive_Click(object sender, EventArgs e)
        {
            handleAnswer(4);
        }

        private void ansSix_Click(object sender, EventArgs e)
        {
            handleAnswer(5);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void gfrmConversation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tmrGameplay_Tick(object sender, EventArgs e)
        {
            _time++;
        }
    }
}
