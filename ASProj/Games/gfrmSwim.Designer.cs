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
            this.lblQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCharacter
            // 
            this.pbxCharacter.BackColor = System.Drawing.Color.Transparent;
            this.pbxCharacter.Image = global::ASProj.Properties.Resources.TheresaMay_070622_F3EN1K_jpg;
            this.pbxCharacter.Location = new System.Drawing.Point(880, 920);
            this.pbxCharacter.Margin = new System.Windows.Forms.Padding(6);
            this.pbxCharacter.Name = "pbxCharacter";
            this.pbxCharacter.Size = new System.Drawing.Size(257, 350);
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
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(22, 1276);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1053, 130);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "This is a sample question, what does it mean?\r\nAnd with two lines?";
            // 
            // gfrmSwim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASProj.Properties.Resources.ezgif_com_gif_maker;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1976, 1431);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pbxCharacter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "gfrmSwim";
            this.Text = "frmSwim";
            this.Load += new System.EventHandler(this.gfrmSwim_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSwim_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxCharacter;
        private System.Windows.Forms.Timer tmrGameplay;
        private System.Windows.Forms.Timer tmrMoveDown;
        private Label lblQuestion;
        private Label label1;
    }
}