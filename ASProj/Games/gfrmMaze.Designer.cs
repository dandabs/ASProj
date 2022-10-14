using System.Windows.Forms;

namespace ASProj.Games
{
    partial class gfrmMaze
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.tmrGameplay = new System.Windows.Forms.Timer(this.components);
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA5 = new System.Windows.Forms.Label();
            this.lblA6 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.pnlEndGame = new ASProj.Controls.RoundedPanel();
            this.pnlMenu = new ASProj.Controls.RoundedPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.pnlEndGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel1.Location = new System.Drawing.Point(0, 652);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Tag = "wall";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel2.Location = new System.Drawing.Point(315, 513);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 34);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "wall";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel3.Location = new System.Drawing.Point(476, 547);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 400);
            this.panel3.TabIndex = 2;
            this.panel3.Tag = "wall";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel4.Location = new System.Drawing.Point(644, 652);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 168);
            this.panel4.TabIndex = 3;
            this.panel4.Tag = "wall";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel5.Location = new System.Drawing.Point(684, 786);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 34);
            this.panel5.TabIndex = 2;
            this.panel5.Tag = "wall";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel6.Location = new System.Drawing.Point(899, 786);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(41, 127);
            this.panel6.TabIndex = 4;
            this.panel6.Tag = "wall";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(360, 314);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(0, 0);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel8.Location = new System.Drawing.Point(125, 252);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(41, 400);
            this.panel8.TabIndex = 3;
            this.panel8.Tag = "wall";
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel9.Location = new System.Drawing.Point(0, 104);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(975, 34);
            this.panel9.TabIndex = 2;
            this.panel9.Tag = "wall";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel10.Location = new System.Drawing.Point(427, 370);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(41, 44);
            this.panel10.TabIndex = 4;
            this.panel10.Tag = "wall";
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel11.Location = new System.Drawing.Point(165, 335);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(810, 34);
            this.panel11.TabIndex = 3;
            this.panel11.Tag = "wall";
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel12.Location = new System.Drawing.Point(612, 471);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(41, 44);
            this.panel12.TabIndex = 5;
            this.panel12.Tag = "wall";
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel13.Location = new System.Drawing.Point(797, 370);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(41, 44);
            this.panel13.TabIndex = 6;
            this.panel13.Tag = "wall";
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel14.Location = new System.Drawing.Point(353, 130);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(41, 98);
            this.panel14.TabIndex = 4;
            this.panel14.Tag = "wall";
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel15.Location = new System.Drawing.Point(1646, -2);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(41, 372);
            this.panel15.TabIndex = 4;
            this.panel15.Tag = "wall";
            // 
            // panel16
            // 
            this.panel16.Location = new System.Drawing.Point(1066, 437);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(0, 0);
            this.panel16.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel17.Location = new System.Drawing.Point(1333, 165);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(41, 558);
            this.panel17.TabIndex = 5;
            this.panel17.Tag = "wall";
            // 
            // panel18
            // 
            this.panel18.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel18.Location = new System.Drawing.Point(822, 642);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(667, 34);
            this.panel18.TabIndex = 3;
            this.panel18.Tag = "wall";
            // 
            // panel19
            // 
            this.panel19.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel19.Location = new System.Drawing.Point(1092, 675);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(41, 139);
            this.panel19.TabIndex = 5;
            this.panel19.Tag = "wall";
            // 
            // panel20
            // 
            this.panel20.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel20.Location = new System.Drawing.Point(1146, -3);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(41, 401);
            this.panel20.TabIndex = 5;
            this.panel20.Tag = "wall";
            // 
            // panel21
            // 
            this.panel21.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel21.Location = new System.Drawing.Point(623, 252);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(41, 98);
            this.panel21.TabIndex = 5;
            this.panel21.Tag = "wall";
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.arny_fjola;
            this.pbxCharacter.Location = new System.Drawing.Point(25, 765);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(98, 78);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCharacter.TabIndex = 7;
            this.pbxCharacter.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel22.Location = new System.Drawing.Point(1259, 839);
            this.panel22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(41, 139);
            this.panel22.TabIndex = 6;
            this.panel22.Tag = "wall";
            // 
            // panel23
            // 
            this.panel23.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel23.Location = new System.Drawing.Point(1449, 667);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(41, 140);
            this.panel23.TabIndex = 6;
            this.panel23.Tag = "wall";
            // 
            // panel24
            // 
            this.panel24.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel24.Location = new System.Drawing.Point(1632, 826);
            this.panel24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(41, 102);
            this.panel24.TabIndex = 6;
            this.panel24.Tag = "wall";
            // 
            // panel25
            // 
            this.panel25.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel25.Location = new System.Drawing.Point(1629, 502);
            this.panel25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(41, 191);
            this.panel25.TabIndex = 7;
            this.panel25.Tag = "wall";
            // 
            // panel26
            // 
            this.panel26.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel26.Location = new System.Drawing.Point(1662, 584);
            this.panel26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(353, 34);
            this.panel26.TabIndex = 1;
            this.panel26.Tag = "wall";
            // 
            // panel27
            // 
            this.panel27.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel27.Location = new System.Drawing.Point(1506, 488);
            this.panel27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(166, 34);
            this.panel27.TabIndex = 2;
            this.panel27.Tag = "wall";
            // 
            // panel28
            // 
            this.panel28.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel28.Location = new System.Drawing.Point(1518, 333);
            this.panel28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(166, 34);
            this.panel28.TabIndex = 3;
            this.panel28.Tag = "wall";
            // 
            // panel29
            // 
            this.panel29.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel29.Location = new System.Drawing.Point(1367, 193);
            this.panel29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(157, 34);
            this.panel29.TabIndex = 4;
            this.panel29.Tag = "wall";
            // 
            // panel30
            // 
            this.panel30.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel30.Location = new System.Drawing.Point(1182, 165);
            this.panel30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(166, 34);
            this.panel30.TabIndex = 5;
            this.panel30.Tag = "wall";
            // 
            // panel31
            // 
            this.panel31.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel31.Location = new System.Drawing.Point(1479, 104);
            this.panel31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(41, 123);
            this.panel31.TabIndex = 6;
            this.panel31.Tag = "wall";
            // 
            // panel32
            // 
            this.panel32.BackgroundImage = global::ASProj.Properties.Resources.brickwall;
            this.panel32.Location = new System.Drawing.Point(-17, 902);
            this.panel32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(1971, 245);
            this.panel32.TabIndex = 3;
            this.panel32.Tag = "wall";
            // 
            // tmrGameplay
            // 
            this.tmrGameplay.Interval = 1000;
            this.tmrGameplay.Tick += new System.EventHandler(this.tmrGameplay_Tick);
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.BackColor = System.Drawing.Color.Transparent;
            this.lblA1.ForeColor = System.Drawing.Color.White;
            this.lblA1.Location = new System.Drawing.Point(25, 31);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(93, 25);
            this.lblA1.TabIndex = 8;
            this.lblA1.Text = "answer1";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.BackColor = System.Drawing.Color.Transparent;
            this.lblA2.ForeColor = System.Drawing.Color.White;
            this.lblA2.Location = new System.Drawing.Point(768, 849);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(93, 25);
            this.lblA2.TabIndex = 9;
            this.lblA2.Text = "answer2";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.BackColor = System.Drawing.Color.Transparent;
            this.lblA3.ForeColor = System.Drawing.Color.White;
            this.lblA3.Location = new System.Drawing.Point(12, 593);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(93, 25);
            this.lblA3.TabIndex = 10;
            this.lblA3.Text = "answer3";
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.BackColor = System.Drawing.Color.Transparent;
            this.lblA4.ForeColor = System.Drawing.Color.White;
            this.lblA4.Location = new System.Drawing.Point(1221, 104);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(93, 25);
            this.lblA4.TabIndex = 11;
            this.lblA4.Text = "answer4";
            // 
            // lblA5
            // 
            this.lblA5.AutoSize = true;
            this.lblA5.BackColor = System.Drawing.Color.Transparent;
            this.lblA5.ForeColor = System.Drawing.Color.White;
            this.lblA5.Location = new System.Drawing.Point(1221, 234);
            this.lblA5.Name = "lblA5";
            this.lblA5.Size = new System.Drawing.Size(93, 25);
            this.lblA5.TabIndex = 12;
            this.lblA5.Text = "answer5";
            // 
            // lblA6
            // 
            this.lblA6.AutoSize = true;
            this.lblA6.BackColor = System.Drawing.Color.Transparent;
            this.lblA6.ForeColor = System.Drawing.Color.White;
            this.lblA6.Location = new System.Drawing.Point(1703, 642);
            this.lblA6.Name = "lblA6";
            this.lblA6.Size = new System.Drawing.Size(93, 25);
            this.lblA6.TabIndex = 13;
            this.lblA6.Text = "answer6";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.BackColor = System.Drawing.Color.Transparent;
            this.lblFinish.Font = new System.Drawing.Font("Manrope ExtraBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ForeColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(1707, 30);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(105, 37);
            this.lblFinish.TabIndex = 14;
            this.lblFinish.Text = "FINISH";
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
            this.pnlEndGame.TabIndex = 15;
            this.pnlEndGame.Click += new System.EventHandler(this.pnlEndGame_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.lblGoal);
            this.pnlMenu.Controls.Add(this.lblQuestion);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.lblGameName);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.Location = new System.Drawing.Point(229, 73);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1372, 938);
            this.pnlMenu.TabIndex = 13;
            this.pnlMenu.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.White;
            this.lblGoal.Location = new System.Drawing.Point(86, 112);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(350, 59);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Go to the word ...";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(86, 171);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(275, 59);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Click to Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(522, 851);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click to Start";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(33, 37);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(134, 59);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Maze";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASProj.Properties.Resources.controls_maze;
            this.pictureBox1.Location = new System.Drawing.Point(43, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.lblGameName2.Size = new System.Drawing.Size(249, 59);
            this.lblGameName2.TabIndex = 0;
            this.lblGameName2.Text = "Platformer";
            // 
            // gfrmMaze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ASProj.Properties.Resources.tumblr_b95fc3c386f44f7b45e0ab738c952a0e_08b15f0f_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEndGame);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblA6);
            this.Controls.Add(this.lblA5);
            this.Controls.Add(this.lblA4);
            this.Controls.Add(this.lblA3);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.panel32);
            this.Controls.Add(this.panel31);
            this.Controls.Add(this.panel30);
            this.Controls.Add(this.panel29);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.panel25);
            this.Controls.Add(this.panel24);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmMaze";
            this.Tag = "wall";
            this.Text = "gfrmMaze";
            this.Load += new System.EventHandler(this.gfrmMaze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gfrmMaze_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.pnlEndGame.ResumeLayout(false);
            this.pnlEndGame.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private PictureBox pbxCharacter;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Panel panel25;
        private Panel panel26;
        private Panel panel27;
        private Panel panel28;
        private Panel panel29;
        private Panel panel30;
        private Panel panel31;
        private Panel panel32;
        private Timer tmrGameplay;
        private Label lblA1;
        private Label lblA2;
        private Label lblA3;
        private Label lblA4;
        private Label lblA5;
        private Label lblA6;
        private Label lblFinish;
        private Controls.RoundedPanel pnlEndGame;
        private Label label1;
        private Label lblAverageTime;
        private Label lblTotalTime;
        private Label lblIncorrect;
        private Label lblCorrect;
        private Label lblPoints;
        private Label label4;
        private Label lblGameName2;
        private Controls.RoundedPanel pnlMenu;
        private Label lblGoal;
        private Label lblQuestion;
        private Label label2;
        private Label lblGameName;
        private PictureBox pictureBox1;
    }
}