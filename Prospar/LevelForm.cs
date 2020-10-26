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

        bool isMovingUp = false;
        bool isMovingLeft = false;
        bool isMovingDown = false;
        bool isMovingRight = false;

        public int speed = 5;
        public LevelForm()
        {
            InitializeComponent();
            picAvatar.Parent = gameCanvas;
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

            if (e.KeyCode == Keys.W)
            {
                isMovingUp = true;
                picAvatar.ChangeState(Properties.HeroState.WalkingUp);
            }
            if (e.KeyCode == Keys.A)
            {
                isMovingLeft = true;
                picAvatar.ChangeState(Properties.HeroState.WalkingLeft);
            }
            if (e.KeyCode == Keys.S)
            {
                isMovingDown = true;
                picAvatar.ChangeState(Properties.HeroState.WalkingDown);
            }
            if (e.KeyCode == Keys.D)
            {
                isMovingRight = true;
                picAvatar.ChangeState(Properties.HeroState.WalkingRight);
            }

            //attacking
            if (e.KeyCode == Keys.Q && !isMovingUp && !isMovingLeft && !isMovingDown && !isMovingRight)
            {
                picAvatar.ChangeState(Properties.HeroState.Attack);
            }

            //dying
            if (e.KeyCode == Keys.Delete && !isMovingUp && !isMovingLeft && !isMovingDown && !isMovingRight)
            {
                picAvatar.ChangeState(Properties.HeroState.Death);
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

            if (e.KeyCode == Keys.W)
            {
                isMovingUp = false;
            }
            if (e.KeyCode == Keys.A)
            {
                isMovingLeft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                isMovingDown = false;
            }
            if (e.KeyCode == Keys.D)
            {
                isMovingRight = false;
            }

            tmrScroll.Enabled = isScrollingRight || isScrollingLeft;

            if (!isMovingUp && !isMovingLeft && !isMovingDown && !isMovingRight && picAvatar.state != Properties.HeroState.Attack && picAvatar.state != Properties.HeroState.Death)
            {
                picAvatar.ChangeState(Properties.HeroState.Idle);
            }
        }


        private void tmrMovement_Tick(object sender, EventArgs e)
        {
            int top = picAvatar.Top;
            int left = picAvatar.Left;

            if (isMovingUp)
            {
                top -= speed;
            }
            if (isMovingLeft)
            {
                left -= speed;
            }
            if (isMovingDown)
            {
                top += speed;
            }
            if (isMovingRight)
            {
                left += speed;
            }

            if(!ScrollVerticallyIfNeeded(top))
            {
                picAvatar.Top = top;
            }
            if (!ScrollHorizontallyIfNeeded(left))
            {
                picAvatar.Left = left;
            }
        }

        private bool ScrollVerticallyIfNeeded(int top)
        {
            bool hasScrolled = false;

            if(top <= 150)
            {
                Globals.game.OnScrollingUp();
                hasScrolled = true;
            }
            if ((top + picAvatar.Height) >= (gameCanvas.Height - 150))
            {
                Globals.game.OnScrollingDown();
                hasScrolled = true;
            }

            return hasScrolled;
        }
        private bool ScrollHorizontallyIfNeeded(int left)
        {
            bool hasScrolled = false;

            if (left <= 150)
            {
                Globals.game.OnScrollingLeft();
                hasScrolled = true;
            }
            if ((left + picAvatar.Width) >= (gameCanvas.Width - 150))
            {
                Globals.game.OnScrollingRight();
                hasScrolled = true;
            }

            return hasScrolled;
        }

        private void tmrScroll_Tick(object sender, EventArgs e)
        {
        //    if (isScrollingRight)
        //    {
        //        Globals.game.OnScrollingRight();
        //    }
        //    if (isScrollingLeft)
        //    {
        //        Globals.game.OnScrollingLeft();
        //    }
        }


    }
}
