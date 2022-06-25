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
    public partial class HorizontalLine : Label
    {
        private Color bordercolor;
        public Color BorderColor
        {
            get { return bordercolor; }
            set { bordercolor = value; }
        }
        public HorizontalLine()
        {
            InitializeComponent();
            Text = "";
            BorderStyle = BorderStyle.Fixed3D;
            AutoSize = false;
            Height = 2;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, bordercolor, ButtonBorderStyle.Solid);
        }
    }
}
