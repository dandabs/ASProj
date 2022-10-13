
namespace ASProj.Games
{
    partial class gfrmPlatformer
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
            this.tmrFall = new System.Windows.Forms.Timer(this.components);
            this.pnlStart = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblA6 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA3 = new System.Windows.Forms.Label();
            this.lblA4 = new System.Windows.Forms.Label();
            this.lblA5 = new System.Windows.Forms.Label();
            this.tmrGameplay = new System.Windows.Forms.Timer(this.components);
            this.pnlEndGame = new ASProj.Controls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameName2 = new System.Windows.Forms.Label();
            this.pnlMenu = new ASProj.Controls.RoundedPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.pnlEndGame.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.arny_fjola;
            this.pbxCharacter.Location = new System.Drawing.Point(89, 640);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(147, 221);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCharacter.TabIndex = 0;
            this.pbxCharacter.TabStop = false;
            // 
            // tmrFall
            // 
            this.tmrFall.Enabled = true;
            this.tmrFall.Interval = 10;
            this.tmrFall.Tick += new System.EventHandler(this.tmrFall_Tick);
            // 
            // pnlStart
            // 
            this.pnlStart.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.pnlStart.Location = new System.Drawing.Point(46, 907);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(221, 219);
            this.pnlStart.TabIndex = 1;
            this.pnlStart.Tag = "solid";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel2.Location = new System.Drawing.Point(538, 683);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 443);
            this.panel2.TabIndex = 2;
            this.panel2.Tag = "solid";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel3.Location = new System.Drawing.Point(1036, 811);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 630);
            this.panel3.TabIndex = 3;
            this.panel3.Tag = "solid";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel4.Location = new System.Drawing.Point(1618, 631);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 561);
            this.panel4.TabIndex = 4;
            this.panel4.Tag = "solid";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Location = new System.Drawing.Point(-16, 1081);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1858, 80);
            this.pnlBottom.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel5.Location = new System.Drawing.Point(951, 361);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 123);
            this.panel5.TabIndex = 3;
            this.panel5.Tag = "solid";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel6.Location = new System.Drawing.Point(46, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 123);
            this.panel6.TabIndex = 4;
            this.panel6.Tag = "solid";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::ASProj.Properties.Resources.photo_1616108738832_504f7b6addf2;
            this.panel8.Location = new System.Drawing.Point(1375, 156);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(437, 123);
            this.panel8.TabIndex = 4;
            this.panel8.Tag = "solid";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.BackColor = System.Drawing.Color.Transparent;
            this.lblA1.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA1.ForeColor = System.Drawing.Color.White;
            this.lblA1.Location = new System.Drawing.Point(128, 163);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(93, 44);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "lblA1";
            // 
            // lblA6
            // 
            this.lblA6.AutoSize = true;
            this.lblA6.BackColor = System.Drawing.Color.Transparent;
            this.lblA6.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold);
            this.lblA6.ForeColor = System.Drawing.Color.White;
            this.lblA6.Location = new System.Drawing.Point(584, 631);
            this.lblA6.Name = "lblA6";
            this.lblA6.Size = new System.Drawing.Size(114, 44);
            this.lblA6.TabIndex = 7;
            this.lblA6.Text = "label2";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.BackColor = System.Drawing.Color.Transparent;
            this.lblA2.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold);
            this.lblA2.ForeColor = System.Drawing.Color.White;
            this.lblA2.Location = new System.Drawing.Point(1086, 305);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(114, 44);
            this.lblA2.TabIndex = 8;
            this.lblA2.Text = "label3";
            // 
            // lblA3
            // 
            this.lblA3.AutoSize = true;
            this.lblA3.BackColor = System.Drawing.Color.Transparent;
            this.lblA3.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold);
            this.lblA3.ForeColor = System.Drawing.Color.White;
            this.lblA3.Location = new System.Drawing.Point(1501, 109);
            this.lblA3.Name = "lblA3";
            this.lblA3.Size = new System.Drawing.Size(114, 44);
            this.lblA3.TabIndex = 9;
            this.lblA3.Text = "label4";
            // 
            // lblA4
            // 
            this.lblA4.AutoSize = true;
            this.lblA4.BackColor = System.Drawing.Color.Transparent;
            this.lblA4.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold);
            this.lblA4.ForeColor = System.Drawing.Color.White;
            this.lblA4.Location = new System.Drawing.Point(1647, 584);
            this.lblA4.Name = "lblA4";
            this.lblA4.Size = new System.Drawing.Size(114, 44);
            this.lblA4.TabIndex = 10;
            this.lblA4.Text = "label5";
            // 
            // lblA5
            // 
            this.lblA5.AutoSize = true;
            this.lblA5.BackColor = System.Drawing.Color.Transparent;
            this.lblA5.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold);
            this.lblA5.ForeColor = System.Drawing.Color.White;
            this.lblA5.Location = new System.Drawing.Point(1072, 764);
            this.lblA5.Name = "lblA5";
            this.lblA5.Size = new System.Drawing.Size(115, 44);
            this.lblA5.TabIndex = 11;
            this.lblA5.Text = "label6";
            // 
            // tmrGameplay
            // 
            this.tmrGameplay.Interval = 1000;
            this.tmrGameplay.Tick += new System.EventHandler(this.tmrGameplay_Tick);
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
            this.pnlEndGame.Location = new System.Drawing.Point(243, 134);
            this.pnlEndGame.Name = "pnlEndGame";
            this.pnlEndGame.Size = new System.Drawing.Size(1372, 938);
            this.pnlEndGame.TabIndex = 13;
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
            this.lblGameName2.Size = new System.Drawing.Size(249, 59);
            this.lblGameName2.TabIndex = 0;
            this.lblGameName2.Text = "Platformer";
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
            this.pnlMenu.Location = new System.Drawing.Point(243, 137);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1372, 938);
            this.pnlMenu.TabIndex = 12;
            this.pnlMenu.Click += new System.EventHandler(this.pnlMenu_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Manrope Light", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.ForeColor = System.Drawing.Color.White;
            this.lblGoal.Location = new System.Drawing.Point(86, 112);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(274, 59);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Match the ....";
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
            this.lblGameName.Size = new System.Drawing.Size(249, 59);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Platformer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASProj.Properties.Resources.controls_platformer;
            this.pictureBox1.Location = new System.Drawing.Point(43, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gfrmPlatformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ASProj.Properties.Resources._8b40d0ff8c8592393ceffcbb0e9654d3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEndGame);
            this.Controls.Add(this.lblA5);
            this.Controls.Add(this.lblA4);
            this.Controls.Add(this.lblA3);
            this.Controls.Add(this.lblA2);
            this.Controls.Add(this.lblA6);
            this.Controls.Add(this.lblA1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pbxCharacter);
            this.Controls.Add(this.pnlBottom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmPlatformer";
            this.Text = "gfrmPlatformer";
            this.Load += new System.EventHandler(this.gfrmPlatformer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gfrmPlatformer_KeyDown);
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

        private System.Windows.Forms.PictureBox pbxCharacter;
        private System.Windows.Forms.Timer tmrFall;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblA6;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblA5;
        private System.Windows.Forms.Timer tmrGameplay;
        private Controls.RoundedPanel pnlMenu;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGoal;
        private Controls.RoundedPanel pnlEndGame;
        private System.Windows.Forms.Label lblIncorrect;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGameName2;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label1;
    }
}