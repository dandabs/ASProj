using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Controls
{
    class SocialMediaIcon : UserControl
    {
        public string Icon {
            get { return Icon; }
            set { Icon = value; centerText(); }
        }
        public SocialMediaIcon()
        {
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
            this.Controls.Add(new Label()
            {
                Name = "icon",
                Font = new Font("Font Awesome 6 Free Solid", 12),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            });
            Cursor = Cursors.Hand;
        }
        private void centerText()
        {
            // place the label in the middle of the textbox
            /*height*/
            ((Label)Controls.Find("icon", true)[0]).Top = (Height / 2) - (Controls.Find("icon", true)[0].PreferredSize.Height / 2);
            /*width*/
            ((Label)Controls.Find("icon", true)[0]).Left = (Width / 2) - (Controls.Find("icon", true)[0].PreferredSize.Width / 2);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
            centerText();
        }
    }
}
