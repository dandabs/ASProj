using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASProj
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void socialIcon1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit(); // always use application.exit() opposed to environment - runs cleanup code
        }

        private void lblRegisterTitle_Click(object sender, EventArgs e)
        {
            bool registerAlreadySelected = lblRegisterTitle.ForeColor == Color.White ? true : false;
            if (!registerAlreadySelected) // go to register page
            {
                lblRegisterTitle.ForeColor = Color.White;
                lblLoginTitle.ForeColor = Color.FromArgb(255, 61, 73, 82);
                lblRegisterTitle.Cursor = Cursors.Default;
                lblLoginTitle.Cursor = Cursors.Hand;
                pnlRegister.Visible = true;
                pnlLogin.Visible = false;
            }
        }

        private void lblLoginTitle_Click(object sender, EventArgs e)
        {
            bool loginAlreadySelected = lblLoginTitle.ForeColor == Color.White ? true : false;
            if (!loginAlreadySelected) // go to login page
            {
                lblRegisterTitle.ForeColor = Color.FromArgb(255, 61, 73, 82);
                lblLoginTitle.ForeColor = Color.White;
                lblRegisterTitle.Cursor = Cursors.Hand;
                lblLoginTitle.Cursor = Cursors.Default;
                pnlRegister.Visible = false;
                pnlLogin.Visible = true;
            }
        }
    }
}
