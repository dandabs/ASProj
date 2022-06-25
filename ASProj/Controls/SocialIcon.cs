using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj.Controls
{
    public partial class SocialIcon : UserControl
    {
        public string IconText
        {
            get { return ((Label)Controls.Find("check", true)[0]).Text; }
            set { ((Label)Controls.Find("check", true)[0]).Text = value; centerText(); }
        }
        public SocialIcon()
        {
            InitializeComponent();
            this.Controls.Add(new Label()
            {
                Name = "check",
                Font = new Font("Font Awesome 6 Brands", 12),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            });
            ((Label)Controls.Find("check", true)[0]).Font = Font;
            ((Label)Controls.Find("check", true)[0]).Text = IconText;
            centerText();
        }
        private void centerText()
        {
            // place the label in the middle of the textbox
            /*height*/
            ((Label)Controls.Find("check", true)[0]).Top = (Height / 2) - (Controls.Find("check", true)[0].PreferredSize.Height / 2);
            /*width*/
            ((Label)Controls.Find("check", true)[0]).Left = (Width / 2) - (Controls.Find("check", true)[0].PreferredSize.Width / 2);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ((Label)Controls.Find("check", true)[0]).Font = Font;
        }
    }
}
