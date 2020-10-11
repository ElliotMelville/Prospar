using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Prospar.Properties
{
    public class Chest : PictureBox
    {
        Timer timer;

        int currentFrame = 0;
        bool isUnlocked = false;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Image = Properties.Resources.Chest_Idle;
            Width = 50;
            Height = 50;
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void Unlock()
        {
            this.timer = new Timer();
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);

            this.timer.Enabled = true;
        }

        protected void OnTimerTick(object sender, EventArgs e)
        {
            currentFrame++;

            if (currentFrame == 1)
            {
                Image = Properties.Resources.chest_open_1;
            }
            if (currentFrame == 2)
            {
                Image = Properties.Resources.chest_open_2;
            }
            if (currentFrame == 3)
            {
                Image = Properties.Resources.chest_open_3;
            }
            if (currentFrame == 4)
            {
                Image = Properties.Resources.chest_open_4;
            }
            if(currentFrame > 4)
            {
                timer.Enabled = false;
                isUnlocked = true;
            }
        }
    }
}
