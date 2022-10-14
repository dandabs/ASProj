using System.Windows.Forms;

namespace ASProj.Games
{
    partial class gfrmConversation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxUsrHealth1 = new System.Windows.Forms.PictureBox();
            this.pnlHUD = new System.Windows.Forms.Panel();
            this.pbxOppHealth1 = new System.Windows.Forms.PictureBox();
            this.pbxOppHealth2 = new System.Windows.Forms.PictureBox();
            this.pbxOppHealth3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxUsrHealth3 = new System.Windows.Forms.PictureBox();
            this.pbxUsrHealth2 = new System.Windows.Forms.PictureBox();
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.pbxArny = new System.Windows.Forms.PictureBox();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.tmrArnyAnim1 = new System.Windows.Forms.Timer(this.components);
            this.pbxAttack = new System.Windows.Forms.PictureBox();
            this.tmrGameplay = new System.Windows.Forms.Timer(this.components);
            this.ansSix = new ASProj.Controls.RoundedPanel();
            this.lblAnsSix = new System.Windows.Forms.Label();
            this.ansFive = new ASProj.Controls.RoundedPanel();
            this.lblAnsFive = new System.Windows.Forms.Label();
            this.ansFour = new ASProj.Controls.RoundedPanel();
            this.lblAnsFour = new System.Windows.Forms.Label();
            this.ansThree = new ASProj.Controls.RoundedPanel();
            this.lblAnsThree = new System.Windows.Forms.Label();
            this.ansTwo = new ASProj.Controls.RoundedPanel();
            this.lblAnsTwo = new System.Windows.Forms.Label();
            this.ansOne = new ASProj.Controls.RoundedPanel();
            this.lblAnsOne = new System.Windows.Forms.Label();
            this.pnlAnswer = new ASProj.Controls.PillPanel();
            this.pnlName = new ASProj.Controls.RoundedPanel();
            this.lblMessageName = new System.Windows.Forms.Label();
            this.pnlMessage = new ASProj.Controls.PillPanel();
            this.pnlEndGame = new ASProj.Controls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth1)).BeginInit();
            this.pnlHUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttack)).BeginInit();
            this.ansSix.SuspendLayout();
            this.ansFive.SuspendLayout();
            this.ansFour.SuspendLayout();
            this.ansThree.SuspendLayout();
            this.ansTwo.SuspendLayout();
            this.ansOne.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlEndGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxUsrHealth1
            // 
            this.pbxUsrHealth1.BackColor = System.Drawing.Color.Transparent;
            this.pbxUsrHealth1.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxUsrHealth1.Location = new System.Drawing.Point(1704, 5);
            this.pbxUsrHealth1.Margin = new System.Windows.Forms.Padding(5);
            this.pbxUsrHealth1.Name = "pbxUsrHealth1";
            this.pbxUsrHealth1.Size = new System.Drawing.Size(74, 67);
            this.pbxUsrHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsrHealth1.TabIndex = 0;
            this.pbxUsrHealth1.TabStop = false;
            // 
            // pnlHUD
            // 
            this.pnlHUD.BackColor = System.Drawing.Color.Transparent;
            this.pnlHUD.Controls.Add(this.pbxOppHealth1);
            this.pnlHUD.Controls.Add(this.pbxOppHealth2);
            this.pnlHUD.Controls.Add(this.pbxOppHealth3);
            this.pnlHUD.Controls.Add(this.label3);
            this.pnlHUD.Controls.Add(this.pbxUsrHealth3);
            this.pnlHUD.Controls.Add(this.pbxUsrHealth2);
            this.pnlHUD.Controls.Add(this.pbxUsrHealth1);
            this.pnlHUD.Location = new System.Drawing.Point(21, 20);
            this.pnlHUD.Margin = new System.Windows.Forms.Padding(5);
            this.pnlHUD.Name = "pnlHUD";
            this.pnlHUD.Size = new System.Drawing.Size(1783, 78);
            this.pnlHUD.TabIndex = 1;
            // 
            // pbxOppHealth1
            // 
            this.pbxOppHealth1.BackColor = System.Drawing.Color.Transparent;
            this.pbxOppHealth1.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxOppHealth1.Location = new System.Drawing.Point(94, 5);
            this.pbxOppHealth1.Margin = new System.Windows.Forms.Padding(5);
            this.pbxOppHealth1.Name = "pbxOppHealth1";
            this.pbxOppHealth1.Size = new System.Drawing.Size(74, 67);
            this.pbxOppHealth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOppHealth1.TabIndex = 6;
            this.pbxOppHealth1.TabStop = false;
            // 
            // pbxOppHealth2
            // 
            this.pbxOppHealth2.BackColor = System.Drawing.Color.Transparent;
            this.pbxOppHealth2.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxOppHealth2.Location = new System.Drawing.Point(178, 5);
            this.pbxOppHealth2.Margin = new System.Windows.Forms.Padding(5);
            this.pbxOppHealth2.Name = "pbxOppHealth2";
            this.pbxOppHealth2.Size = new System.Drawing.Size(74, 67);
            this.pbxOppHealth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOppHealth2.TabIndex = 5;
            this.pbxOppHealth2.TabStop = false;
            // 
            // pbxOppHealth3
            // 
            this.pbxOppHealth3.BackColor = System.Drawing.Color.Transparent;
            this.pbxOppHealth3.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxOppHealth3.Location = new System.Drawing.Point(262, 5);
            this.pbxOppHealth3.Margin = new System.Windows.Forms.Padding(5);
            this.pbxOppHealth3.Name = "pbxOppHealth3";
            this.pbxOppHealth3.Size = new System.Drawing.Size(74, 67);
            this.pbxOppHealth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOppHealth3.TabIndex = 4;
            this.pbxOppHealth3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Font Awesome 6 Free Solid", 30F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 80);
            this.label3.TabIndex = 3;
            this.label3.Text = "";
            // 
            // pbxUsrHealth3
            // 
            this.pbxUsrHealth3.BackColor = System.Drawing.Color.Transparent;
            this.pbxUsrHealth3.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxUsrHealth3.Location = new System.Drawing.Point(1536, 5);
            this.pbxUsrHealth3.Margin = new System.Windows.Forms.Padding(5);
            this.pbxUsrHealth3.Name = "pbxUsrHealth3";
            this.pbxUsrHealth3.Size = new System.Drawing.Size(74, 67);
            this.pbxUsrHealth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsrHealth3.TabIndex = 2;
            this.pbxUsrHealth3.TabStop = false;
            // 
            // pbxUsrHealth2
            // 
            this.pbxUsrHealth2.BackColor = System.Drawing.Color.Transparent;
            this.pbxUsrHealth2.Image = global::ASProj.Properties.Resources.heart_full;
            this.pbxUsrHealth2.Location = new System.Drawing.Point(1620, 5);
            this.pbxUsrHealth2.Margin = new System.Windows.Forms.Padding(5);
            this.pbxUsrHealth2.Name = "pbxUsrHealth2";
            this.pbxUsrHealth2.Size = new System.Drawing.Size(74, 67);
            this.pbxUsrHealth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUsrHealth2.TabIndex = 1;
            this.pbxUsrHealth2.TabStop = false;
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.TheresaMay_070622_F3EN1K1;
            this.pbxCharacter.Location = new System.Drawing.Point(1270, 230);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(466, 833);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCharacter.TabIndex = 2;
            this.pbxCharacter.TabStop = false;
            // 
            // pbxArny
            // 
            this.pbxArny.BackColor = System.Drawing.Color.Transparent;
            this.pbxArny.Image = global::ASProj.Properties.Resources.arny_fjola;
            this.pbxArny.Location = new System.Drawing.Point(-514, 108);
            this.pbxArny.Margin = new System.Windows.Forms.Padding(5);
            this.pbxArny.Name = "pbxArny";
            this.pbxArny.Size = new System.Drawing.Size(482, 833);
            this.pbxArny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArny.TabIndex = 3;
            this.pbxArny.TabStop = false;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.lblMessageText.Font = new System.Drawing.Font("Pokemon GB", 16F);
            this.lblMessageText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.lblMessageText.Location = new System.Drawing.Point(374, 875);
            this.lblMessageText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(1181, 132);
            this.lblMessageText.TabIndex = 7;
            this.lblMessageText.Text = "Hello, PM Theresa May.\r\nI would like to beat you\r\nover the head. Let\'s fight!";
            this.lblMessageText.Click += new System.EventHandler(this.lblMessageText_Click);
            // 
            // tmrArnyAnim1
            // 
            this.tmrArnyAnim1.Interval = 2;
            this.tmrArnyAnim1.Tick += new System.EventHandler(this.tmrArnyAnim1_Tick);
            // 
            // pbxAttack
            // 
            this.pbxAttack.BackColor = System.Drawing.Color.Transparent;
            this.pbxAttack.Image = global::ASProj.Properties.Resources.FireBall;
            this.pbxAttack.Location = new System.Drawing.Point(417, 320);
            this.pbxAttack.Margin = new System.Windows.Forms.Padding(5);
            this.pbxAttack.Name = "pbxAttack";
            this.pbxAttack.Size = new System.Drawing.Size(895, 455);
            this.pbxAttack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAttack.TabIndex = 12;
            this.pbxAttack.TabStop = false;
            this.pbxAttack.Visible = false;
            // 
            // tmrGameplay
            // 
            this.tmrGameplay.Interval = 1000;
            this.tmrGameplay.Tick += new System.EventHandler(this.tmrGameplay_Tick);
            // 
            // ansSix
            // 
            this.ansSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansSix.Controls.Add(this.lblAnsSix);
            this.ansSix.Location = new System.Drawing.Point(732, 653);
            this.ansSix.Margin = new System.Windows.Forms.Padding(5);
            this.ansSix.Name = "ansSix";
            this.ansSix.Size = new System.Drawing.Size(382, 57);
            this.ansSix.TabIndex = 11;
            this.ansSix.Click += new System.EventHandler(this.ansSix_Click);
            // 
            // lblAnsSix
            // 
            this.lblAnsSix.AutoSize = true;
            this.lblAnsSix.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsSix.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsSix.ForeColor = System.Drawing.Color.White;
            this.lblAnsSix.Location = new System.Drawing.Point(69, 17);
            this.lblAnsSix.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsSix.Name = "lblAnsSix";
            this.lblAnsSix.Size = new System.Drawing.Size(264, 28);
            this.lblAnsSix.TabIndex = 0;
            this.lblAnsSix.Text = "AnswerSix";
            this.lblAnsSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansFive
            // 
            this.ansFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansFive.Controls.Add(this.lblAnsFive);
            this.ansFive.Location = new System.Drawing.Point(732, 587);
            this.ansFive.Margin = new System.Windows.Forms.Padding(5);
            this.ansFive.Name = "ansFive";
            this.ansFive.Size = new System.Drawing.Size(382, 57);
            this.ansFive.TabIndex = 10;
            this.ansFive.Click += new System.EventHandler(this.ansFive_Click);
            // 
            // lblAnsFive
            // 
            this.lblAnsFive.AutoSize = true;
            this.lblAnsFive.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsFive.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsFive.ForeColor = System.Drawing.Color.White;
            this.lblAnsFive.Location = new System.Drawing.Point(69, 17);
            this.lblAnsFive.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsFive.Name = "lblAnsFive";
            this.lblAnsFive.Size = new System.Drawing.Size(292, 28);
            this.lblAnsFive.TabIndex = 0;
            this.lblAnsFive.Text = "AnswerFive";
            this.lblAnsFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansFour
            // 
            this.ansFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansFour.Controls.Add(this.lblAnsFour);
            this.ansFour.Location = new System.Drawing.Point(732, 520);
            this.ansFour.Margin = new System.Windows.Forms.Padding(5);
            this.ansFour.Name = "ansFour";
            this.ansFour.Size = new System.Drawing.Size(382, 57);
            this.ansFour.TabIndex = 9;
            this.ansFour.Click += new System.EventHandler(this.ansFour_Click);
            // 
            // lblAnsFour
            // 
            this.lblAnsFour.AutoSize = true;
            this.lblAnsFour.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsFour.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsFour.ForeColor = System.Drawing.Color.White;
            this.lblAnsFour.Location = new System.Drawing.Point(69, 17);
            this.lblAnsFour.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsFour.Name = "lblAnsFour";
            this.lblAnsFour.Size = new System.Drawing.Size(292, 28);
            this.lblAnsFour.TabIndex = 0;
            this.lblAnsFour.Text = "AnswerFour";
            this.lblAnsFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansThree
            // 
            this.ansThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansThree.Controls.Add(this.lblAnsThree);
            this.ansThree.Location = new System.Drawing.Point(732, 453);
            this.ansThree.Margin = new System.Windows.Forms.Padding(5);
            this.ansThree.Name = "ansThree";
            this.ansThree.Size = new System.Drawing.Size(382, 57);
            this.ansThree.TabIndex = 8;
            this.ansThree.Click += new System.EventHandler(this.ansThree_Click);
            // 
            // lblAnsThree
            // 
            this.lblAnsThree.AutoSize = true;
            this.lblAnsThree.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsThree.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsThree.ForeColor = System.Drawing.Color.White;
            this.lblAnsThree.Location = new System.Drawing.Point(69, 17);
            this.lblAnsThree.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsThree.Name = "lblAnsThree";
            this.lblAnsThree.Size = new System.Drawing.Size(320, 28);
            this.lblAnsThree.TabIndex = 0;
            this.lblAnsThree.Text = "AnswerThree";
            this.lblAnsThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansTwo
            // 
            this.ansTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansTwo.Controls.Add(this.lblAnsTwo);
            this.ansTwo.Location = new System.Drawing.Point(732, 387);
            this.ansTwo.Margin = new System.Windows.Forms.Padding(5);
            this.ansTwo.Name = "ansTwo";
            this.ansTwo.Size = new System.Drawing.Size(382, 57);
            this.ansTwo.TabIndex = 7;
            this.ansTwo.Click += new System.EventHandler(this.ansTwo_Click);
            // 
            // lblAnsTwo
            // 
            this.lblAnsTwo.AutoSize = true;
            this.lblAnsTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsTwo.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsTwo.ForeColor = System.Drawing.Color.White;
            this.lblAnsTwo.Location = new System.Drawing.Point(69, 17);
            this.lblAnsTwo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsTwo.Name = "lblAnsTwo";
            this.lblAnsTwo.Size = new System.Drawing.Size(264, 28);
            this.lblAnsTwo.TabIndex = 0;
            this.lblAnsTwo.Text = "AnswerTwo";
            this.lblAnsTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansOne
            // 
            this.ansOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.ansOne.Controls.Add(this.lblAnsOne);
            this.ansOne.Location = new System.Drawing.Point(732, 320);
            this.ansOne.Margin = new System.Windows.Forms.Padding(5);
            this.ansOne.Name = "ansOne";
            this.ansOne.Size = new System.Drawing.Size(382, 57);
            this.ansOne.TabIndex = 6;
            this.ansOne.Click += new System.EventHandler(this.ansOne_Click);
            this.ansOne.Paint += new System.Windows.Forms.PaintEventHandler(this.ansOne_Paint);
            // 
            // lblAnsOne
            // 
            this.lblAnsOne.AutoSize = true;
            this.lblAnsOne.BackColor = System.Drawing.Color.Transparent;
            this.lblAnsOne.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblAnsOne.ForeColor = System.Drawing.Color.White;
            this.lblAnsOne.Location = new System.Drawing.Point(69, 17);
            this.lblAnsOne.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsOne.Name = "lblAnsOne";
            this.lblAnsOne.Size = new System.Drawing.Size(264, 28);
            this.lblAnsOne.TabIndex = 0;
            this.lblAnsOne.Text = "AnswerOne";
            this.lblAnsOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.pnlAnswer.Location = new System.Drawing.Point(708, 275);
            this.pnlAnswer.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(432, 470);
            this.pnlAnswer.TabIndex = 8;
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(66)))), ((int)(((byte)(90)))));
            this.pnlName.Controls.Add(this.lblMessageName);
            this.pnlName.Location = new System.Drawing.Point(461, 797);
            this.pnlName.Margin = new System.Windows.Forms.Padding(5);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(269, 57);
            this.pnlName.TabIndex = 5;
            // 
            // lblMessageName
            // 
            this.lblMessageName.AutoSize = true;
            this.lblMessageName.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageName.Font = new System.Drawing.Font("Pokemon GB", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessageName.ForeColor = System.Drawing.Color.White;
            this.lblMessageName.Location = new System.Drawing.Point(9, 15);
            this.lblMessageName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMessageName.Name = "lblMessageName";
            this.lblMessageName.Size = new System.Drawing.Size(276, 28);
            this.lblMessageName.TabIndex = 0;
            this.lblMessageName.Text = "Árný Fjóla";
            // 
            // pnlMessage
            // 
            this.pnlMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(219)))), ((int)(((byte)(203)))));
            this.pnlMessage.Location = new System.Drawing.Point(336, 825);
            this.pnlMessage.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMessage.Name = "pnlMessage";
            this.pnlMessage.Size = new System.Drawing.Size(1107, 213);
            this.pnlMessage.TabIndex = 6;
            this.pnlMessage.Click += new System.EventHandler(this.pnlMessage_Click);
            // 
            // pnlEndGame
            // 
            this.pnlEndGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlEndGame.Controls.Add(this.label1);
            this.pnlEndGame.Controls.Add(this.lblAverageTime);
            this.pnlEndGame.Controls.Add(this.lblTotalTime);
            this.pnlEndGame.Controls.Add(this.lblIncorrect);
            this.pnlEndGame.Controls.Add(this.lblCorrect);
            this.pnlEndGame.Controls.Add(this.lblPoints);
            this.pnlEndGame.Controls.Add(this.label4);
            this.pnlEndGame.Controls.Add(this.lblGameName2);
            this.pnlEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEndGame.Location = new System.Drawing.Point(226, 90);
            this.pnlEndGame.Name = "pnlEndGame";
            this.pnlEndGame.Size = new System.Drawing.Size(1372, 938);
            this.pnlEndGame.TabIndex = 16;
            this.pnlEndGame.Click += new System.EventHandler(this.pnlEndGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Congratulations!";
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageTime.ForeColor = System.Drawing.Color.White;
            this.lblAverageTime.Location = new System.Drawing.Point(86, 492);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(780, 59);
            this.lblAverageTime.TabIndex = 8;
            this.lblAverageTime.Text = "An average of 13 seconds per question.";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(86, 422);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(630, 59);
            this.lblTotalTime.TabIndex = 7;
            this.lblTotalTime.Text = "It took you 120 seconds in total.";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.White;
            this.lblIncorrect.Location = new System.Drawing.Point(86, 281);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(725, 59);
            this.lblIncorrect.TabIndex = 6;
            this.lblIncorrect.Text = "You answered 1 question incorrectly.";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.White;
            this.lblCorrect.Location = new System.Drawing.Point(86, 211);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(721, 59);
            this.lblCorrect.TabIndex = 5;
            this.lblCorrect.Text = "You answered 2 questions correctly.";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(86, 146);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(440, 59);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "You scored 40 points.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(534, 843);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 59);
            this.label4.TabIndex = 2;
            this.label4.Text = "Click to End";
            // 
            // lblGameName2
            // 
            this.lblGameName2.AutoSize = true;
            this.lblGameName2.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName2.ForeColor = System.Drawing.Color.White;
            this.lblGameName2.Location = new System.Drawing.Point(33, 37);
            this.lblGameName2.Name = "lblGameName2";
            this.lblGameName2.Size = new System.Drawing.Size(134, 59);
            this.lblGameName2.TabIndex = 0;
            this.lblGameName2.Text = "Maze";
            // 
            // gfrmConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BackgroundImage = global::ASProj.Properties.Resources.pokemon_landscape_by_brainblower_d8i3udq_fullview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
            this.Controls.Add(this.pnlEndGame);
            this.Controls.Add(this.ansSix);
            this.Controls.Add(this.ansFive);
            this.Controls.Add(this.ansFour);
            this.Controls.Add(this.ansThree);
            this.Controls.Add(this.ansTwo);
            this.Controls.Add(this.ansOne);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.pbxAttack);
            this.Controls.Add(this.lblMessageText);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlMessage);
            this.Controls.Add(this.pbxArny);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.pnlHUD);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmConversation";
            this.Text = "gfrmConversation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gfrmConversation_FormClosing);
            this.Load += new System.EventHandler(this.gfrmConversation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfrmConversation_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth1)).EndInit();
            this.pnlHUD.ResumeLayout(false);
            this.pnlHUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOppHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsrHealth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttack)).EndInit();
            this.ansSix.ResumeLayout(false);
            this.ansSix.PerformLayout();
            this.ansFive.ResumeLayout(false);
            this.ansFive.PerformLayout();
            this.ansFour.ResumeLayout(false);
            this.ansFour.PerformLayout();
            this.ansThree.ResumeLayout(false);
            this.ansThree.PerformLayout();
            this.ansTwo.ResumeLayout(false);
            this.ansTwo.PerformLayout();
            this.ansOne.ResumeLayout(false);
            this.ansOne.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlEndGame.ResumeLayout(false);
            this.pnlEndGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxUsrHealth1;
        private Panel pnlHUD;
        private PictureBox pbxUsrHealth3;
        private PictureBox pbxUsrHealth2;
        private PictureBox pbxCharacter;
        private PictureBox pbxArny;
        private Controls.RoundedPanel pnlName;
        private Label lblMessageName;
        private Controls.PillPanel pnlMessage;
        private Label label3;
        private Label lblMessageText;
        private System.Windows.Forms.Timer tmrArnyAnim1;
        private PictureBox pbxOppHealth1;
        private PictureBox pbxOppHealth2;
        private PictureBox pbxOppHealth3;
        private Controls.PillPanel pnlAnswer;
        private Controls.RoundedPanel ansOne;
        private Label lblAnsOne;
        private Label lblAnsTwo;
        private Controls.RoundedPanel ansTwo;
        private Controls.RoundedPanel ansThree;
        private Label lblAnsThree;
        private Controls.RoundedPanel ansFour;
        private Label lblAnsFour;
        private Controls.RoundedPanel ansFive;
        private Label lblAnsFive;
        private Controls.RoundedPanel ansSix;
        private Label lblAnsSix;
        private PictureBox pbxAttack;
        private System.Windows.Forms.Timer tmrGameplay;
        private Controls.RoundedPanel pnlEndGame;
        private Label label1;
        private Label lblAverageTime;
        private Label lblTotalTime;
        private Label lblIncorrect;
        private Label lblCorrect;
        private Label lblPoints;
        private Label label4;
        private Label lblGameName2;
    }
}