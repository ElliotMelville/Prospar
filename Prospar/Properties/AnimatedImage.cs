using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace Prospar.Properties
{
    enum HeroState
    {
        WalkingRight, //0
        WalkingLeft, //1
        Idle, //2
        Death, //3
        Hurt, //4
        Attack, //5
        WalkingUp, //6
        WalkingDown //7
    }

    class AnimatedImage : PictureBox
    {
        Timer timer;
        int frame = 0;
        Image gif;
        FrameDimension dimension;

        public HeroState state = HeroState.Idle;

        int endFrame = 0;
        int startFrame = 0;
        int speed = 0;

        bool isFacingRight = false;
        bool isFacingLeft = false;

        bool loopOnce = false;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.DesignMode)
            {
                return;
            }
            this.gif = Properties.Resources.HeroAnimations;
            this.dimension = new FrameDimension(this.gif.FrameDimensionsList[0]);
            Enabled = false;

            InitialiseTimer();

            this.ChangeState(Properties.HeroState.Idle);
        }

        private void InitialiseTimer()
        {
            this.timer = new Timer();
            this.timer.Interval = 100;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if(this.frame == 0)
            {
                this.frame = startFrame;
            }
            else if(this.frame > endFrame)
            {
                this.frame = startFrame;
                if (loopOnce)
                {
                    this.ChangeState(HeroState.Idle);
                    return;
                }
            }

            this.gif.SelectActiveFrame(this.dimension, this.frame - 1);
            this.Image = (Image)this.gif.Clone();
            frame++;
        }

        public void ChangeState(HeroState newState)
        {
            if (newState == state)
            {
                return;
            }

            if(newState == HeroState.WalkingRight)
            {
                SetState(newState, 17, 22, 200);
                isFacingRight = true;
                isFacingLeft = false;
                loopOnce = false;
            }
            else if (newState == HeroState.WalkingLeft)
            {
                SetState(newState, 23, 28, 200);
                isFacingLeft = true;
                isFacingRight = false;
                loopOnce = false;
            }
            else if (newState == HeroState.WalkingUp || newState == HeroState.WalkingDown)
            {
                if (isFacingRight)
                {
                    SetState(newState, 17, 22, 200);
                }
                else if (isFacingLeft)
                {
                    SetState(newState, 23, 28, 200);
                }

                loopOnce = false;
            }

            else if(newState == HeroState.Idle)
            {
                if (isFacingRight)
                {
                    SetState(newState, 29, 30, 500);
                }
                else if (isFacingLeft)
                {
                    SetState(newState, 31, 32, 500);
                }

                loopOnce = false;
            }
            else if(newState == HeroState.Attack)
            {
                if (isFacingRight)
                {
                    SetState(newState, 1, 8, 100);
                }
                else if (isFacingLeft)
                {
                    SetState(newState, 9, 16, 100);
                }

                loopOnce = true;
            }

            else if (newState == HeroState.Death)
            {
                if (isFacingRight)
                {
                    SetState(newState, 35, 49, 100);
                }
                else if (isFacingLeft)
                {
                    SetState(newState, 50, 64, 100);
                }

                loopOnce = true;
            }

            if (this.speed == 0)
            {
                this.timer.Enabled = false;
                return;
            }

            this.frame = 0;
            this.timer.Interval = this.speed;
            this.timer.Enabled = true;
            this.OnTimerTick(null, null);
        }

        private void SetState(HeroState newState, int startFrame, int endFrame, int speed)
        {
            //speed is in milliseconds

            this.state = newState;
            this.startFrame = startFrame;
            this.endFrame = endFrame;
            this.speed = speed;
        }
    }
}
