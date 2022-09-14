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
            bool canMove = true;
            foreach (Control c1 in Controls)
            {
                Rectangle potentialBounds = pbxCharacter.Bounds;

                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left, potentialBounds.Top - 10);
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left, potentialBounds.Top + 10);
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left - 10, potentialBounds.Top);
                }
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    potentialBounds.Location = new Point(potentialBounds.Left + 10, potentialBounds.Top);
                }

                bool doesIntersect = c1.Bounds.IntersectsWith(potentialBounds);

                if ((string)c1.Tag == "wall" && doesIntersect)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    pbxCharacter.Top -= 10;
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    pbxCharacter.Top += 10;
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    pbxCharacter.Left -= 10;
                }
                if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    pbxCharacter.Left += 10;
                }
            }
        }
    }
}
