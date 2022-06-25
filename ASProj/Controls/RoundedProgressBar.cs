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
    public partial class RoundedProgressBar : UserControl
    {
        private decimal value = 0;
        public decimal Value
        {
            get { return value; }
            set { this.value = value; reloadBar(); }
        }
        public RoundedProgressBar()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Controls.Add(new Panel()
            {
                Name = "progress",
                BackColor = this.ForeColor,
                Height = this.Height,
                Width = (int)Math.Floor(this.Width * value)
            });
        }
        private void reloadBar()
        {
            ((Panel)Controls.Find("progress", true)[0]).Width = (int)Math.Floor(this.Width * value);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(Utils.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            reloadBar();
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            ((Panel)Controls.Find("progress", true)[0]).BackColor = this.ForeColor;
        }
    }
}
