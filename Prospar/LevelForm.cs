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
    public partial class LevelForm : Form
    {
        bool isScrollingRight = false;
        bool isScrollingLeft = false;
        public LevelForm()
        {
            InitializeComponent();
        }

        private void LevelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isScrollingRight = true;
                tmrScroll.Enabled = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                isScrollingLeft = true;
                tmrScroll.Enabled = true;
            }
        }

        private void LevelForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isScrollingRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                isScrollingLeft = false;
            }

            tmrScroll.Enabled = isScrollingRight || isScrollingLeft;
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
            if (isScrollingRight)
            {
                Globals.game.OnScrollingRight();
            }
            if (isScrollingLeft)
            {
                Globals.game.OnScrollingLeft();
            }
        }
    }
}
