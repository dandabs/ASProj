using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj.Controls
{
    public partial class Pill : UserControl
    {
        private Color iconcolor;
        private char icon;
        private string text = "";
        public Color IconColor
        {
            get { return iconcolor; }
            set { iconcolor = value; updateIcon(); }
        }
        public char Icon
        {
            get { return icon; }
            set { icon = value; updateIcon(); }
        }
        public string Val
        {
            get { return text; }
            set { text = value; updateIcon(); }
        }
        public Pill()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Controls.Add(new Label()
            {
                Name = "icon",
                BackColor = Color.Transparent,
                Font = new Font("Font Awesome 6 Free Solid", this.Font.Size),
                Left = Margin.Left,
                Top = 2
            });
            this.Controls.Add(new Label()
            {
                Name = "text",
                BackColor = Color.Transparent,
                ForeColor = ForeColor,
                Font = Font,
                Left = ((Label)Controls.Find("icon", true)[0]).PreferredWidth,
                Top = 2
            });
        }
        private void updateIcon()
        {
            ((Label)Controls.Find("icon", true)[0]).ForeColor = iconcolor;
            ((Label)Controls.Find("icon", true)[0]).Text = icon.ToString();
            ((Label)Controls.Find("text", true)[0]).Text = text;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ((Label)Controls.Find("text", true)[0]).Font = Font;
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            ((Label)Controls.Find("text", true)[0]).ForeColor = ForeColor;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ((Label)Controls.Find("text", true)[0]).Left = ((Label)Controls.Find("icon", true)[0]).PreferredWidth + 10;
        }
    }
}
