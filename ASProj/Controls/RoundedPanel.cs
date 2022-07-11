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
    public partial class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            InitializeComponent();
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Region = Region.FromHrgn(GenericUtils.CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
    }
}
