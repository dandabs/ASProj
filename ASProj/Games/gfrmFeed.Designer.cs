using System.Windows.Forms;

namespace ASProj.Games
{
    partial class gfrmFeed
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
            this.pbxCharacter = new System.Windows.Forms.PictureBox();
            this.tmrGameplay = new System.Windows.Forms.Timer(this.components);
            this.mqlQuestion = new ASProj.Controls.MarqueeLabel();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.lblAnswer5 = new System.Windows.Forms.Label();
            this.lblAnswer6 = new System.Windows.Forms.Label();
            this.pnlMenu = new ASProj.Controls.RoundedPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlEndGame = new ASProj.Controls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEndGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.TheresaMay_070622_F3EN1K_jpg;
            this.pbxCharacter.Location = new System.Drawing.Point(1303, 205);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(5);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(427, 610);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCharacter.TabIndex = 0;
            this.pbxCharacter.TabStop = false;
            // 
            // tmrGameplay
            // 
            this.tmrGameplay.Interval = 1000;
            this.tmrGameplay.Tick += new System.EventHandler(this.tmrGameplay_Tick);
            // 
            // mqlQuestion
            // 
            this.mqlQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.mqlQuestion.Font = new System.Drawing.Font("Pokemon GB", 15.75F);
            this.mqlQuestion.ForeColor = System.Drawing.Color.White;
            this.mqlQuestion.Location = new System.Drawing.Point(0, 1037);
            this.mqlQuestion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mqlQuestion.Name = "mqlQuestion";
            this.mqlQuestion.Size = new System.Drawing.Size(1824, 82);
            this.mqlQuestion.TabIndex = 1;
            this.mqlQuestion.Text = "What does the word isskápur mean?";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer1.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer1.ForeColor = System.Drawing.Color.White;
            this.lblAnswer1.Location = new System.Drawing.Point(98, 243);
            this.lblAnswer1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer1.TabIndex = 0;
            this.lblAnswer1.Text = "answer 1";
            this.lblAnswer1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer1_MouseDown);
            this.lblAnswer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer1_MouseMove);
            this.lblAnswer1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer1_MouseUp);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer2.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer2.ForeColor = System.Drawing.Color.White;
            this.lblAnswer2.Location = new System.Drawing.Point(1275, 907);
            this.lblAnswer2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer2.TabIndex = 2;
            this.lblAnswer2.Text = "answer 2";
            this.lblAnswer2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer2_MouseDown);
            this.lblAnswer2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer2_MouseMove);
            this.lblAnswer2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer2_MouseUp);
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer3.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer3.ForeColor = System.Drawing.Color.White;
            this.lblAnswer3.Location = new System.Drawing.Point(1553, 130);
            this.lblAnswer3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer3.TabIndex = 3;
            this.lblAnswer3.Text = "answer 3";
            this.lblAnswer3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer3_MouseDown);
            this.lblAnswer3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer3_MouseMove);
            this.lblAnswer3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer3_MouseUp);
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer4.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer4.ForeColor = System.Drawing.Color.White;
            this.lblAnswer4.Location = new System.Drawing.Point(682, 447);
            this.lblAnswer4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer4.TabIndex = 4;
            this.lblAnswer4.Text = "answer 4";
            this.lblAnswer4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer4_MouseDown);
            this.lblAnswer4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer4_MouseMove);
            this.lblAnswer4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer4_MouseUp);
            // 
            // lblAnswer5
            // 
            this.lblAnswer5.AutoSize = true;
            this.lblAnswer5.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer5.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer5.ForeColor = System.Drawing.Color.White;
            this.lblAnswer5.Location = new System.Drawing.Point(842, 15);
            this.lblAnswer5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer5.Name = "lblAnswer5";
            this.lblAnswer5.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer5.TabIndex = 5;
            this.lblAnswer5.Text = "answer 5";
            this.lblAnswer5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer5_MouseDown);
            this.lblAnswer5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer5_MouseMove);
            this.lblAnswer5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer5_MouseUp);
            // 
            // lblAnswer6
            // 
            this.lblAnswer6.AutoSize = true;
            this.lblAnswer6.BackColor = System.Drawing.Color.Transparent;
            this.lblAnswer6.Font = new System.Drawing.Font("Pokemon GB", 9F);
            this.lblAnswer6.ForeColor = System.Drawing.Color.White;
            this.lblAnswer6.Location = new System.Drawing.Point(48, 942);
            this.lblAnswer6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnswer6.Name = "lblAnswer6";
            this.lblAnswer6.Size = new System.Drawing.Size(204, 26);
            this.lblAnswer6.TabIndex = 6;
            this.lblAnswer6.Text = "answer 6";
            this.lblAnswer6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAnswer6_MouseDown);
            this.lblAnswer6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAnswer6_MouseMove);
            this.lblAnswer6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAnswer6_MouseUp);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.lblGoal);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.lblGameName);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.Location = new System.Drawing.Point(260, 62);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1372, 938);
            this.pnlMenu.TabIndex = 14;
            this.pnlMenu.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.White;
            this.lblGoal.Location = new System.Drawing.Point(86, 112);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(336, 59);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Drag the word ...";
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
            this.lblGameName.Size = new System.Drawing.Size(126, 59);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Feed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASProj.Properties.Resources.controls_feed;
            this.pictureBox1.Location = new System.Drawing.Point(43, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.pnlEndGame.Location = new System.Drawing.Point(261, 53);
            this.pnlEndGame.Name = "pnlEndGame";
            this.pnlEndGame.Size = new System.Drawing.Size(1372, 938);
            this.pnlEndGame.TabIndex = 15;
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
            // gfrmFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ASProj.Properties.Resources.a46c81229e41a8a4c365ce467fb23d5b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
            this.Controls.Add(this.pnlEndGame);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.lblAnswer6);
            this.Controls.Add(this.lblAnswer5);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.mqlQuestion);
            this.Controls.Add(this.pbxCharacter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmFeed";
            this.Text = "gfrmFeed";
            this.Load += new System.EventHandler(this.gfrmFeed_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gfrmFeed_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEndGame.ResumeLayout(false);
            this.pnlEndGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxCharacter;
        private System.Windows.Forms.Timer tmrGameplay;
        private Controls.MarqueeLabel mqlQuestion;
        private Label lblAnswer1;
        private Label lblAnswer2;
        private Label lblAnswer3;
        private Label lblAnswer4;
        private Label lblAnswer5;
        private Label lblAnswer6;
        private Controls.RoundedPanel pnlMenu;
        private Label lblGoal;
        private Label label2;
        private Label lblGameName;
        private PictureBox pictureBox1;
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