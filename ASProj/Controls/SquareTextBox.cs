using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASProj.Controls
{
    public partial class SquareTextBox : UserControl
    {
        public SquareTextBox()
        {
            InitializeComponent();
            this.Controls.Add(new TextBox()
            {
                Name = "value",
                Left = 10,
                Width = Width - 15,
                BackColor = this.BackColor,
                BorderStyle = BorderStyle.None,
                ForeColor = Color.DarkGray
            });
            Controls.Find("value", true)[0].Top = (Height - Controls.Find("value", true)[0].Height) / 2;
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
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
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            Controls.Find("value", true)[0].BackColor = BackColor;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Controls.Find("value", true)[0].Font = Font;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            Controls.Find("value", true)[0].Top = (Height - Controls.Find("value", true)[0].Height) / 2;
            Controls.Find("value", true)[0].Width = Width - 15;
        }
    }
}
