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

namespace Prospar
{
    public partial class Home : Form
    {
        protected SoundPlayer homeMusicPlayer;

        int timeSinceLoad = 0;

        bool isPlayingIntro = false;


        public Home()
        {
            InitializeComponent();

            hbtnStart.Parent = picTitleScreen;
            hbtnHelp.Parent = picTitleScreen;
            hbtnExit.Parent = picTitleScreen;

            hbtnExit.Visible = false;
            hbtnHelp.Visible = false;
            hbtnStart.Visible = false;
            picTitleScreen.Visible = false;
            picFloorModelAvatar.Visible = false;
            floorModelChest1.Visible = false;
            floorModelChest2.Visible = false;

            picSerniGames.Left = (0 - picSerniGames.Width);
            picPresents.Left = (0 - picPresents.Width);

            hbtnStart.SetSounds(Properties.Resources.select_002, Properties.Resources.select_003);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            homeMusicPlayer = new SoundPlayer(Properties.Resources.HomeMusic);
            homeMusicPlayer.Load();

            isPlayingIntro = true;
            tmrIntro.Enabled = true;
            //StopIntro();
        }

        private void tmrIntro_Tick(object sender, EventArgs e)
        {
            if (isPlayingIntro)
            {
                if (timeSinceLoad == 20)
                {
                    homeMusicPlayer.PlayLooping();
                }

                if (timeSinceLoad == 390)
                {
                    StopIntro();
                }

                if (timeSinceLoad >= 30 && picSerniGames.Left < (picTitleScreen.Width / 2) - picSerniGames.Width / 2)
                {
                    picSerniGames.Left += 5;
                }

                if (timeSinceLoad > 200 && picPresents.Left < picTitleScreen.Width)
                {
                    picPresents.Left += 8;
                }

                timeSinceLoad++;

            }

        }


        private void StopIntro()
        {
            isPlayingIntro = false;
            tmrIntro.Enabled = false;
            timeSinceLoad = 0;

            hbtnExit.Visible = true;
            hbtnHelp.Visible = true;
            hbtnStart.Visible = true;
            picTitleScreen.Visible = true;
            picFloorModelAvatar.Visible = true;
            floorModelChest1.Visible = true;
            floorModelChest2.Visible = true;

            floorModelChest1.BringToFront();
            floorModelChest2.BringToFront();
            picFloorModelAvatar.BringToFront();
        }

        private void LoadLevelSelect()
        {
            LevelSelect levelselect = new LevelSelect();
            levelselect.Show();
        }

        private void hbtnStart_Click(object sender, EventArgs e)
        {
            floorModelChest1.Unlock();
            floorModelChest2.Unlock();
            LoadLevelSelect();
        }

        private void hbtnExit_Click_1(object sender, EventArgs e)
        {
            ExitDialogue form = new ExitDialogue();
            form.Show();
        }
    }

}
