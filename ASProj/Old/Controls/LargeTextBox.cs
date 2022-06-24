using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Controls
{
    class LargeTextBox : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public LargeTextBox()
        {
            LargeTextBox temp = this;
            this.Controls.Add(new Label()
            {
                Name = "icon",
                Left = 15,
                ForeColor = Color.Silver,
                BackColor = Color.Transparent,
                Text = "",
                Font = new Font("Font Awesome 6 Free Solid", 14),
                Height = Height
            });
            this.Controls.Add(new TransparentTextBox()
            {
                Name = "value",
                Width = Width,
                //BackColor = Color.Transparent,
                BorderStyle = BorderStyle.None,
            });
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            Margin = new Padding(10);
            this.SetAutoSizeMode(AutoSizeMode.GrowOnly);

            base.CreateParams.ExStyle |= 0x20;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, false);
            BackColor = Color.FromArgb(0x50, 0xFF, 0xFF, 0xFF);
        }

        public string PlaceholderText
        {
            get { return ((TextBox)Controls.Find("value", true)[0]).PlaceholderText; }
            set { ((TextBox)Controls.Find("value", true)[0]).PlaceholderText = value; }
        }

        public char PasswordChar
        {
            get { return ((TextBox)Controls.Find("value", true)[0]).PasswordChar; }
            set { ((TextBox)Controls.Find("value", true)[0]).PasswordChar = value; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            Controls.Find("value", true)[0].Width = Width;
            Controls.Find("value", true)[0].Height = Height;

            ((Label)Controls.Find("icon", true)[0]).Top = (Height / 2) - (Controls.Find("icon", true)[0].PreferredSize.Height / 2);

            ((TextBox)Controls.Find("value", true)[0]).Left = Controls.Find("icon", true)[0].PreferredSize.Width + 15;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            //Controls.Find("value", true)[0].BackColor = BackColor;
        }

        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.FromArgb(0xFF, 0xC0, 0xC0, 0xC0), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(0xFF, 0xC0, 0xC0, 0xC0), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(0xFF, 0xC0, 0xC0, 0xC0), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(0xFF, 0xC0, 0xC0, 0xC0), 1, ButtonBorderStyle.Solid
            );
        }*/
    }
}
