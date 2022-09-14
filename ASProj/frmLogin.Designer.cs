using ASProj.Controls;
using System.Windows.Forms;

namespace ASProj
{
    partial class frmLogin
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
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxDiscriminatorLogin = new ASProj.Controls.SquareTextBox();
            this.socialIcon6 = new ASProj.Controls.SocialIcon();
            this.socialIcon7 = new ASProj.Controls.SocialIcon();
            this.socialIcon8 = new ASProj.Controls.SocialIcon();
            this.tbxUsernameLogin = new ASProj.Controls.SquareTextBox();
            this.socialIcon9 = new ASProj.Controls.SocialIcon();
            this.socialIcon10 = new ASProj.Controls.SocialIcon();
            this.tbxPasswordLogin = new ASProj.Controls.SquareTextBox();
            this.btnLogin = new ASProj.Controls.SquareButton();
            this.socialIcon1 = new ASProj.Controls.SocialIcon();
            this.socialIcon5 = new ASProj.Controls.SocialIcon();
            this.socialIcon4 = new ASProj.Controls.SocialIcon();
            this.tbxUsername = new ASProj.Controls.SquareTextBox();
            this.socialIcon3 = new ASProj.Controls.SocialIcon();
            this.socialIcon2 = new ASProj.Controls.SocialIcon();
            this.tbxPassword = new ASProj.Controls.SquareTextBox();
            this.btnRegister = new ASProj.Controls.SquareButton();
            this.cbxAge = new ASProj.Controls.FlatCheckBox();
            this.pnlRegister.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Manrope ExtraBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRegisterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.lblRegisterTitle.Location = new System.Drawing.Point(1116, 213);
            this.lblRegisterTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(227, 58);
            this.lblRegisterTitle.TabIndex = 1;
            this.lblRegisterTitle.Text = "REGISTER";
            this.lblRegisterTitle.Click += new System.EventHandler(this.lblRegisterTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Manrope ExtraBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1326, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "/";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTitle.Font = new System.Drawing.Font("Manrope ExtraBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitle.Location = new System.Drawing.Point(1356, 213);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(153, 58);
            this.lblLoginTitle.TabIndex = 3;
            this.lblLoginTitle.Text = "LOGIN";
            this.lblLoginTitle.Click += new System.EventHandler(this.lblLoginTitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Manrope", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(62, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Manrope", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(62, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 41);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(644, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 10);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.panel2.Location = new System.Drawing.Point(606, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 10);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.panel3.Location = new System.Drawing.Point(532, 238);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 10);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.panel4.Location = new System.Drawing.Point(570, 238);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 10);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.panel5.Location = new System.Drawing.Point(494, 238);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(34, 10);
            this.panel5.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Font Awesome 6 Free Solid", 20.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.linkLabel1.Location = new System.Drawing.Point(1770, 27);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 54);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(73)))), ((int)(((byte)(82)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Manrope Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(244, 591);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 41);
            this.label6.TabIndex = 15;
            this.label6.Text = "or via social network";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Manrope Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(114, 362);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(598, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "I am at least 13 years old and have read and accept";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Manrope Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(354, 391);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 34);
            this.label8.TabIndex = 18;
            this.label8.Text = "and";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Manrope Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.linkLabel2.Location = new System.Drawing.Point(116, 391);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(269, 34);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Terms and Conditions";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Manrope Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.linkLabel3.Location = new System.Drawing.Point(402, 391);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(172, 34);
            this.linkLabel3.TabIndex = 20;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Privacy Policy";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Manrope Medium", 9.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(550, 393);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 34);
            this.label9.TabIndex = 21;
            this.label9.Text = ".";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.socialIcon1);
            this.pnlRegister.Controls.Add(this.socialIcon5);
            this.pnlRegister.Controls.Add(this.label4);
            this.pnlRegister.Controls.Add(this.socialIcon4);
            this.pnlRegister.Controls.Add(this.tbxUsername);
            this.pnlRegister.Controls.Add(this.socialIcon3);
            this.pnlRegister.Controls.Add(this.label5);
            this.pnlRegister.Controls.Add(this.socialIcon2);
            this.pnlRegister.Controls.Add(this.tbxPassword);
            this.pnlRegister.Controls.Add(this.panel1);
            this.pnlRegister.Controls.Add(this.label9);
            this.pnlRegister.Controls.Add(this.panel2);
            this.pnlRegister.Controls.Add(this.linkLabel3);
            this.pnlRegister.Controls.Add(this.panel4);
            this.pnlRegister.Controls.Add(this.linkLabel2);
            this.pnlRegister.Controls.Add(this.panel3);
            this.pnlRegister.Controls.Add(this.label8);
            this.pnlRegister.Controls.Add(this.panel5);
            this.pnlRegister.Controls.Add(this.label7);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.cbxAge);
            this.pnlRegister.Controls.Add(this.label6);
            this.pnlRegister.Location = new System.Drawing.Point(1062, 295);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(758, 828);
            this.pnlRegister.TabIndex = 27;
            this.pnlRegister.Visible = false;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label12);
            this.pnlLogin.Controls.Add(this.tbxDiscriminatorLogin);
            this.pnlLogin.Controls.Add(this.linkLabel4);
            this.pnlLogin.Controls.Add(this.socialIcon6);
            this.pnlLogin.Controls.Add(this.socialIcon7);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.socialIcon8);
            this.pnlLogin.Controls.Add(this.tbxUsernameLogin);
            this.pnlLogin.Controls.Add(this.socialIcon9);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.socialIcon10);
            this.pnlLogin.Controls.Add(this.tbxPasswordLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.label13);
            this.pnlLogin.Location = new System.Drawing.Point(1062, 295);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(758, 828);
            this.pnlLogin.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Manrope", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(488, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 41);
            this.label12.TabIndex = 29;
            this.label12.Text = "#";
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Manrope", 10.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.linkLabel4.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel4.Location = new System.Drawing.Point(244, 422);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(300, 38);
            this.linkLabel4.TabIndex = 27;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Forgotten password?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Manrope", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Manrope", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(62, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Manrope Medium", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(244, 591);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(301, 41);
            this.label13.TabIndex = 15;
            this.label13.Text = "or via social network";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::ASProj.Properties.Resources.HD_wallpaper_anime_bird_anime_bird_cartoon_nature;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(-2, -2);
            this.panel6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1026, 1197);
            this.panel6.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Manrope ExtraBold", 20.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(515, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(485, 77);
            this.label11.TabIndex = 30;
            this.label11.Text = "LAST SCORE 549";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Manrope ExtraBold", 25.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(410, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(598, 95);
            this.label10.TabIndex = 29;
            this.label10.Text = "HIGH SCORE 732";
            // 
            // tbxDiscriminatorLogin
            // 
            this.tbxDiscriminatorLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.tbxDiscriminatorLogin.Font = new System.Drawing.Font("Manrope Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.tbxDiscriminatorLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxDiscriminatorLogin.Location = new System.Drawing.Point(532, 93);
            this.tbxDiscriminatorLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxDiscriminatorLogin.Name = "tbxDiscriminatorLogin";
            this.tbxDiscriminatorLogin.PasswordChar = '\0';
            this.tbxDiscriminatorLogin.Size = new System.Drawing.Size(148, 70);
            this.tbxDiscriminatorLogin.TabIndex = 28;
            // 
            // socialIcon6
            // 
            this.socialIcon6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon6.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon6.IconText = "";
            this.socialIcon6.Location = new System.Drawing.Point(66, 648);
            this.socialIcon6.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon6.Name = "socialIcon6";
            this.socialIcon6.Size = new System.Drawing.Size(102, 100);
            this.socialIcon6.TabIndex = 22;
            // 
            // socialIcon7
            // 
            this.socialIcon7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon7.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon7.IconText = "";
            this.socialIcon7.Location = new System.Drawing.Point(582, 648);
            this.socialIcon7.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon7.Name = "socialIcon7";
            this.socialIcon7.Size = new System.Drawing.Size(102, 100);
            this.socialIcon7.TabIndex = 26;
            // 
            // socialIcon8
            // 
            this.socialIcon8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon8.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon8.IconText = "";
            this.socialIcon8.Location = new System.Drawing.Point(452, 648);
            this.socialIcon8.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon8.Name = "socialIcon8";
            this.socialIcon8.Size = new System.Drawing.Size(102, 100);
            this.socialIcon8.TabIndex = 25;
            // 
            // tbxUsernameLogin
            // 
            this.tbxUsernameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.tbxUsernameLogin.Font = new System.Drawing.Font("Manrope Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.tbxUsernameLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxUsernameLogin.Location = new System.Drawing.Point(66, 93);
            this.tbxUsernameLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxUsernameLogin.Name = "tbxUsernameLogin";
            this.tbxUsernameLogin.PasswordChar = '\0';
            this.tbxUsernameLogin.Size = new System.Drawing.Size(420, 70);
            this.tbxUsernameLogin.TabIndex = 5;
            // 
            // socialIcon9
            // 
            this.socialIcon9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon9.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon9.IconText = "";
            this.socialIcon9.Location = new System.Drawing.Point(324, 648);
            this.socialIcon9.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon9.Name = "socialIcon9";
            this.socialIcon9.Size = new System.Drawing.Size(102, 100);
            this.socialIcon9.TabIndex = 24;
            // 
            // socialIcon10
            // 
            this.socialIcon10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon10.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon10.IconText = "";
            this.socialIcon10.Location = new System.Drawing.Point(196, 648);
            this.socialIcon10.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon10.Name = "socialIcon10";
            this.socialIcon10.Size = new System.Drawing.Size(102, 100);
            this.socialIcon10.TabIndex = 23;
            // 
            // tbxPasswordLogin
            // 
            this.tbxPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.tbxPasswordLogin.Font = new System.Drawing.Font("Manrope Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.tbxPasswordLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPasswordLogin.Location = new System.Drawing.Point(66, 259);
            this.tbxPasswordLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxPasswordLogin.Name = "tbxPasswordLogin";
            this.tbxPasswordLogin.PasswordChar = '•';
            this.tbxPasswordLogin.Size = new System.Drawing.Size(614, 70);
            this.tbxPasswordLogin.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Manrope ExtraBold", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(66, 475);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(614, 68);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LOG IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // socialIcon1
            // 
            this.socialIcon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon1.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon1.IconText = "";
            this.socialIcon1.Location = new System.Drawing.Point(66, 648);
            this.socialIcon1.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon1.Name = "socialIcon1";
            this.socialIcon1.Size = new System.Drawing.Size(102, 100);
            this.socialIcon1.TabIndex = 22;
            this.socialIcon1.Load += new System.EventHandler(this.socialIcon1_Load);
            // 
            // socialIcon5
            // 
            this.socialIcon5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon5.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon5.IconText = "";
            this.socialIcon5.Location = new System.Drawing.Point(582, 648);
            this.socialIcon5.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon5.Name = "socialIcon5";
            this.socialIcon5.Size = new System.Drawing.Size(102, 100);
            this.socialIcon5.TabIndex = 26;
            // 
            // socialIcon4
            // 
            this.socialIcon4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon4.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon4.IconText = "";
            this.socialIcon4.Location = new System.Drawing.Point(452, 648);
            this.socialIcon4.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon4.Name = "socialIcon4";
            this.socialIcon4.Size = new System.Drawing.Size(102, 100);
            this.socialIcon4.TabIndex = 25;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.tbxUsername.Font = new System.Drawing.Font("Manrope Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.tbxUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxUsername.Location = new System.Drawing.Point(66, 93);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.Size = new System.Drawing.Size(614, 70);
            this.tbxUsername.TabIndex = 5;
            // 
            // socialIcon3
            // 
            this.socialIcon3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon3.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon3.IconText = "";
            this.socialIcon3.Location = new System.Drawing.Point(324, 648);
            this.socialIcon3.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon3.Name = "socialIcon3";
            this.socialIcon3.Size = new System.Drawing.Size(102, 100);
            this.socialIcon3.TabIndex = 24;
            // 
            // socialIcon2
            // 
            this.socialIcon2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.socialIcon2.Font = new System.Drawing.Font("Font Awesome 6 Brands Regular", 18F);
            this.socialIcon2.IconText = "";
            this.socialIcon2.Location = new System.Drawing.Point(196, 648);
            this.socialIcon2.Margin = new System.Windows.Forms.Padding(16, 5, 16, 5);
            this.socialIcon2.Name = "socialIcon2";
            this.socialIcon2.Size = new System.Drawing.Size(102, 100);
            this.socialIcon2.TabIndex = 23;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.tbxPassword.Font = new System.Drawing.Font("Manrope Medium", 10.75F, System.Drawing.FontStyle.Bold);
            this.tbxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.Location = new System.Drawing.Point(66, 259);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(614, 70);
            this.tbxPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Manrope ExtraBold", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(66, 475);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(614, 68);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbxAge
            // 
            this.cbxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.cbxAge.Checked = false;
            this.cbxAge.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(176)))), ((int)(((byte)(210)))));
            this.cbxAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAge.Location = new System.Drawing.Point(66, 368);
            this.cbxAge.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(40, 38);
            this.cbxAge.TabIndex = 16;
            this.cbxAge.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1852, 1184);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegisterTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(1852, 1184);
            this.MinimumSize = new System.Drawing.Size(1852, 1184);
            this.Name = "frmLogin";
            this.Text = "+";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRegisterTitle;
        private Label label2;
        private Label lblLoginTitle;
        private Label label4;
        private Controls.SquareTextBox tbxUsername;
        private Controls.SquareTextBox tbxPassword;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private LinkLabel linkLabel1;
        private SquareButton btnRegister;
        private Label label6;
        private Controls.FlatCheckBox cbxAge;
        private Label label7;
        private Label label8;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label9;
        private SocialIcon socialIcon1;
        private SocialIcon socialIcon2;
        private SocialIcon socialIcon3;
        private SocialIcon socialIcon4;
        private SocialIcon socialIcon5;
        private Panel pnlRegister;
        private Panel pnlLogin;
        private SocialIcon socialIcon6;
        private SocialIcon socialIcon7;
        private Label label1;
        private SocialIcon socialIcon8;
        private SquareTextBox tbxUsernameLogin;
        private SocialIcon socialIcon9;
        private Label label3;
        private SocialIcon socialIcon10;
        private SquareTextBox tbxPasswordLogin;
        private SquareButton btnLogin;
        private Label label13;
        private LinkLabel linkLabel4;
        private Panel panel6;
        private Label label11;
        private Label label10;
        private Label label12;
        private SquareTextBox tbxDiscriminatorLogin;
    }
}