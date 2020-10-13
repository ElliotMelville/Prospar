namespace Prospar
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tmrIntro = new System.Windows.Forms.Timer(this.components);
            this.floorModelChest1 = new Prospar.Properties.Chest();
            this.floorModelChest2 = new Prospar.Properties.Chest();
            this.picFloorModelAvatar = new System.Windows.Forms.PictureBox();
            this.hbtnExit = new Prospar.HoverButton();
            this.hbtnHelp = new Prospar.HoverButton();
            this.hbtnStart = new Prospar.HoverButton();
            this.picTitleScreen = new System.Windows.Forms.PictureBox();
            this.picSerniGames = new System.Windows.Forms.PictureBox();
            this.picPresents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floorModelChest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorModelChest2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloorModelAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSerniGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPresents)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrIntro
            // 
            this.tmrIntro.Interval = 10;
            this.tmrIntro.Tick += new System.EventHandler(this.tmrIntro_Tick);
            // 
            // floorModelChest1
            // 
            this.floorModelChest1.Image = ((System.Drawing.Image)(resources.GetObject("floorModelChest1.Image")));
            this.floorModelChest1.Location = new System.Drawing.Point(194, 310);
            this.floorModelChest1.Name = "floorModelChest1";
            this.floorModelChest1.Size = new System.Drawing.Size(50, 50);
            this.floorModelChest1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.floorModelChest1.TabIndex = 10;
            this.floorModelChest1.TabStop = false;
            // 
            // floorModelChest2
            // 
            this.floorModelChest2.Image = ((System.Drawing.Image)(resources.GetObject("floorModelChest2.Image")));
            this.floorModelChest2.Location = new System.Drawing.Point(754, 310);
            this.floorModelChest2.Name = "floorModelChest2";
            this.floorModelChest2.Size = new System.Drawing.Size(50, 50);
            this.floorModelChest2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.floorModelChest2.TabIndex = 9;
            this.floorModelChest2.TabStop = false;
            // 
            // picFloorModelAvatar
            // 
            this.picFloorModelAvatar.Image = global::Prospar.Properties.Resources.Hero_idle_big;
            this.picFloorModelAvatar.Location = new System.Drawing.Point(432, 69);
            this.picFloorModelAvatar.Name = "picFloorModelAvatar";
            this.picFloorModelAvatar.Size = new System.Drawing.Size(150, 134);
            this.picFloorModelAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFloorModelAvatar.TabIndex = 3;
            this.picFloorModelAvatar.TabStop = false;
            // 
            // hbtnExit
            // 
            this.hbtnExit.BackColor = System.Drawing.Color.Transparent;
            this.hbtnExit.BackgroundImage = global::Prospar.Properties.Resources.ExitButton;
            this.hbtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnExit.FlatAppearance.BorderSize = 0;
            this.hbtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hbtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnExit.Location = new System.Drawing.Point(369, 650);
            this.hbtnExit.MaximumGrowingSize = 60;
            this.hbtnExit.Name = "hbtnExit";
            this.hbtnExit.Size = new System.Drawing.Size(271, 53);
            this.hbtnExit.Speed = 16;
            this.hbtnExit.TabIndex = 2;
            this.hbtnExit.UseVisualStyleBackColor = false;
            this.hbtnExit.Click += new System.EventHandler(this.hbtnExit_Click_1);
            // 
            // hbtnHelp
            // 
            this.hbtnHelp.BackColor = System.Drawing.Color.Transparent;
            this.hbtnHelp.BackgroundImage = global::Prospar.Properties.Resources.HelpButton1;
            this.hbtnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hbtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnHelp.FlatAppearance.BorderSize = 0;
            this.hbtnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hbtnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hbtnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnHelp.Location = new System.Drawing.Point(379, 530);
            this.hbtnHelp.MaximumGrowingSize = 60;
            this.hbtnHelp.Name = "hbtnHelp";
            this.hbtnHelp.Size = new System.Drawing.Size(252, 51);
            this.hbtnHelp.Speed = 16;
            this.hbtnHelp.TabIndex = 1;
            this.hbtnHelp.UseVisualStyleBackColor = false;
            // 
            // hbtnStart
            // 
            this.hbtnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hbtnStart.BackColor = System.Drawing.Color.Transparent;
            this.hbtnStart.BackgroundImage = global::Prospar.Properties.Resources.StartButton1;
            this.hbtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hbtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hbtnStart.FlatAppearance.BorderSize = 0;
            this.hbtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hbtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hbtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnStart.Location = new System.Drawing.Point(379, 406);
            this.hbtnStart.MaximumGrowingSize = 60;
            this.hbtnStart.Name = "hbtnStart";
            this.hbtnStart.Size = new System.Drawing.Size(252, 74);
            this.hbtnStart.Speed = 16;
            this.hbtnStart.TabIndex = 0;
            this.hbtnStart.UseVisualStyleBackColor = false;
            this.hbtnStart.Click += new System.EventHandler(this.hbtnStart_Click);
            // 
            // picTitleScreen
            // 
            this.picTitleScreen.BackColor = System.Drawing.Color.Transparent;
            this.picTitleScreen.Image = global::Prospar.Properties.Resources.ProsparTitle;
            this.picTitleScreen.Location = new System.Drawing.Point(0, 0);
            this.picTitleScreen.Name = "picTitleScreen";
            this.picTitleScreen.Size = new System.Drawing.Size(1000, 750);
            this.picTitleScreen.TabIndex = 0;
            this.picTitleScreen.TabStop = false;
            // 
            // picSerniGames
            // 
            this.picSerniGames.BackColor = System.Drawing.Color.Transparent;
            this.picSerniGames.Image = global::Prospar.Properties.Resources.SerniGames;
            this.picSerniGames.Location = new System.Drawing.Point(12, 12);
            this.picSerniGames.Name = "picSerniGames";
            this.picSerniGames.Size = new System.Drawing.Size(600, 459);
            this.picSerniGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSerniGames.TabIndex = 7;
            this.picSerniGames.TabStop = false;
            // 
            // picPresents
            // 
            this.picPresents.BackColor = System.Drawing.Color.Transparent;
            this.picPresents.Image = global::Prospar.Properties.Resources._Presents_;
            this.picPresents.Location = new System.Drawing.Point(112, 449);
            this.picPresents.Name = "picPresents";
            this.picPresents.Size = new System.Drawing.Size(355, 245);
            this.picPresents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPresents.TabIndex = 8;
            this.picPresents.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.floorModelChest1);
            this.Controls.Add(this.floorModelChest2);
            this.Controls.Add(this.picFloorModelAvatar);
            this.Controls.Add(this.hbtnExit);
            this.Controls.Add(this.hbtnHelp);
            this.Controls.Add(this.hbtnStart);
            this.Controls.Add(this.picTitleScreen);
            this.Controls.Add(this.picSerniGames);
            this.Controls.Add(this.picPresents);
            this.Name = "Home";
            this.Text = "Prospar - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.floorModelChest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floorModelChest2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloorModelAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSerniGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPresents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HoverButton hbtnStart;
        private HoverButton hbtnHelp;
        private System.Windows.Forms.PictureBox picTitleScreen;
        private HoverButton hbtnExit;
        private System.Windows.Forms.PictureBox picFloorModelAvatar;
        private System.Windows.Forms.Timer tmrIntro;
        private System.Windows.Forms.PictureBox picSerniGames;
        private System.Windows.Forms.PictureBox picPresents;
        private Properties.Chest floorModelChest2;
        private Properties.Chest floorModelChest1;
    }
}

