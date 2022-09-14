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
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.TheresaMay_070622_F3EN1K_jpg;
            this.pbxCharacter.Location = new System.Drawing.Point(1303, 205);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            // gfrmFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ASProj.Properties.Resources.a46c81229e41a8a4c365ce467fb23d5b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1118);
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
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1824, 1118);
            this.MinimumSize = new System.Drawing.Size(1824, 1118);
            this.Name = "gfrmFeed";
            this.Text = "gfrmFeed";
            this.Load += new System.EventHandler(this.gfrmFeed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
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
    }
}