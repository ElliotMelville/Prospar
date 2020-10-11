using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospar
{
    public partial class ExitDialogue : Form
    {
        int timePassedSinceExit = 0;

        public ExitDialogue()
        {
            InitializeComponent();
            picExiting.Width = 206;
            picExiting.Visible = false;
        }

        private void hoverButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hbtnYes_Click(object sender, EventArgs e)
        {
            picAvatar.Image = Properties.Resources.Hero_die_big;
            tmrDeathAnimation.Enabled = true;

            picExiting.Visible = true;
        }

        private void tmrDeathAnimation_Tick(object sender, EventArgs e)
        {
            if(timePassedSinceExit == 20)
            {
                picExiting.Width = 231;
            }
            if (timePassedSinceExit == 40)
            {
                picExiting.Width = 261;
            }
            if (timePassedSinceExit == 55)
            {
                picExiting.Width = 285;
            }

            if (timePassedSinceExit == 60)
            {
                tmrDeathAnimation.Enabled = false;

                Environment.Exit(0);
            }

            timePassedSinceExit++;
        }
    }
}
