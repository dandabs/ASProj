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
        public HorizontalLine()
        {
            InitializeComponent();
            Text = "";
            BorderStyle = BorderStyle.Fixed3D;
            AutoSize = false;
            Height = 2;
        }
    }
}
