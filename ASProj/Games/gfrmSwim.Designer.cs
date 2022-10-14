using System.Windows.Forms;

namespace ASProj.Games
{
    partial class gfrmSwim
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
            this.tmrMoveDown = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new ASProj.Controls.RoundedPanel();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlEndGame = new ASProj.Controls.RoundedPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlEndGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.TheresaMay_070622_F3EN1K_jpg;
            this.pbxCharacter.Location = new System.Drawing.Point(812, 714);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(237, 273);
            this.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCharacter.TabIndex = 0;
            this.pbxCharacter.TabStop = false;
            // 
            // tmrGameplay
            // 
            this.tmrGameplay.Interval = 1000;
            this.tmrGameplay.Tick += new System.EventHandler(this.tmrGameplay_Tick);
            // 
            // tmrMoveDown
            // 
            this.tmrMoveDown.Interval = 1000;
            this.tmrMoveDown.Tick += new System.EventHandler(this.tmrMoveDown_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.lblGoal);
            this.pnlMenu.Controls.Add(this.lblQuestion);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.lblGameName);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMenu.Location = new System.Drawing.Point(226, 90);
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
            this.lblGoal.Size = new System.Drawing.Size(435, 59);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Swim to the correct...";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(522, 851);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click to Start";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Manrope", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(33, 37);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(139, 59);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Swim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASProj.Properties.Resources.controls_swim;
            this.pictureBox1.Location = new System.Drawing.Point(43, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1724, 1069);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pnlEndGame
            // 
            this.pnlEndGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlEndGame.Controls.Add(this.lblAverageTime);
            this.pnlEndGame.Controls.Add(this.lblTotalTime);
            this.pnlEndGame.Controls.Add(this.lblIncorrect);
            this.pnlEndGame.Controls.Add(this.lblCorrect);
            this.pnlEndGame.Controls.Add(this.lblPoints);
            this.pnlEndGame.Controls.Add(this.label4);
            this.pnlEndGame.Controls.Add(this.lblGameName2);
            this.pnlEndGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEndGame.Location = new System.Drawing.Point(234, 98);
            this.pnlEndGame.Name = "pnlEndGame";
            this.pnlEndGame.Size = new System.Drawing.Size(1372, 938);
            this.pnlEndGame.TabIndex = 15;
            this.pnlEndGame.Click += new System.EventHandler(this.pnlEndGame_Click);
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
            // gfrmSwim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ASProj.Properties.Resources.ezgif_com_gif_maker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
            this.Controls.Add(this.pnlEndGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pbxCharacter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmSwim";
            this.Text = "frmSwim";
            this.Load += new System.EventHandler(this.gfrmSwim_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSwim_KeyDown);
            this.Resize += new System.EventHandler(this.gfrmSwim_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlEndGame.ResumeLayout(false);
            this.pnlEndGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbxCharacter;
        private System.Windows.Forms.Timer tmrGameplay;
        private System.Windows.Forms.Timer tmrMoveDown;
        private Label label1;
        private Controls.RoundedPanel pnlMenu;
        private Label lblGoal;
        private Label lblQuestion;
        private Label label3;
        private Label lblGameName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Controls.RoundedPanel pnlEndGame;
        private Label lblAverageTime;
        private Label lblTotalTime;
        private Label lblIncorrect;
        private Label lblCorrect;
        private Label lblPoints;
        private Label label4;
        private Label lblGameName2;
    }
}