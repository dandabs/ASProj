using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj.Games
{
    public partial class gfrmMaze : Form
    {
        public gfrmMaze()
        {
            InitializeComponent();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gfrmMaze_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Control c1 in Controls)
            {
                if (!((!c1.Equals(pbxCharacter)) && c1.Bounds.IntersectsWith(pbxCharacter.Bounds) && c1.Tag.ToString() == "wall"))
                {
                    if (e.KeyCode == Keys.W)
                    {
                        pbxCharacter.Top -= 20;
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        pbxCharacter.Top += 20;
                    }
                    if (e.KeyCode == Keys.A)
                    {
                        pbxCharacter.Left -= 20;
                    }
                    if (e.KeyCode == Keys.D)
                    {
                        pbxCharacter.Left += 20;
                    }
                }
            }
        }
    }
}
