using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASProj.Utils;

namespace ASProj.Controls
{
    public partial class FlatCheckBox : UserControl
    {
        public bool Checked { get; set; }
        public Color UncheckedColor { get; set; }
        public Color CheckedColor { get; set; }
        public FlatCheckBox()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            this.Controls.Add(new Label()
            {
                Name = "check",
                Font = new Font("Font Awesome 6 Free Solid", 8),
                ForeColor = Color.White,
                BackColor = Color.Transparent
            });
            Cursor = Cursors.Hand;
            ((Label)Controls.Find("check", true)[0]).Click += new EventHandler(Control_Click);
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
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            centerText();
        }
        private void Control_Click(object? sender, EventArgs e)
        {
            this.OnClick(e);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checked = Checked ? false : true; // toggle value of Checked boolean (emulate real checkbox)
            if (Checked)
            {
                BackColor = CheckedColor;
                ((Label)Controls.Find("check", true)[0]).Text = "";
                centerText();
            } else
            {
                BackColor = UncheckedColor;
                ((Label)Controls.Find("check", true)[0]).Text = "";
                centerText();
            }
        }
    }
}
