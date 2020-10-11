namespace Prospar
{
    partial class ExitDialogue
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
            this.tmrDeathAnimation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.picAreYouSure = new System.Windows.Forms.PictureBox();
            this.picExiting = new System.Windows.Forms.PictureBox();
            this.hoverButton1 = new Prospar.HoverButton();
            this.hbtnYes = new Prospar.HoverButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAreYouSure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExiting)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrDeathAnimation
            // 
            this.tmrDeathAnimation.Interval = 20;
            this.tmrDeathAnimation.Tick += new System.EventHandler(this.tmrDeathAnimation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Prospar.Properties.Resources.Disclaimer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::Prospar.Properties.Resources.Hero_idle_big;
            this.picAvatar.Location = new System.Drawing.Point(297, 184);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(79, 90);
            this.picAvatar.TabIndex = 3;
            this.picAvatar.TabStop = false;
            // 
            // picAreYouSure
            // 
            this.picAreYouSure.BackColor = System.Drawing.Color.Transparent;
            this.picAreYouSure.Image = global::Prospar.Properties.Resources.ExitQuestion;
            this.picAreYouSure.Location = new System.Drawing.Point(-21, -19);
            this.picAreYouSure.Name = "picAreYouSure";
            this.picAreYouSure.Size = new System.Drawing.Size(726, 170);
            this.picAreYouSure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAreYouSure.TabIndex = 1;
            this.picAreYouSure.TabStop = false;
            // 
            // picExiting
            // 
            this.picExiting.BackColor = System.Drawing.Color.Transparent;
            this.picExiting.Image = global::Prospar.Properties.Resources.Exiting2;
            this.picExiting.Location = new System.Drawing.Point(188, 280);
            this.picExiting.Name = "picExiting";
            this.picExiting.Size = new System.Drawing.Size(283, 46);
            this.picExiting.TabIndex = 5;
            this.picExiting.TabStop = false;
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.BackgroundImage = global::Prospar.Properties.Resources.No_;
            this.hoverButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hoverButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hoverButton1.FlatAppearance.BorderSize = 0;
            this.hoverButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hoverButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton1.Location = new System.Drawing.Point(75, 247);
            this.hoverButton1.MaximumGrowingSize = 60;
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(126, 50);
            this.hoverButton1.Speed = 16;
            this.hoverButton1.TabIndex = 2;
            this.hoverButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hoverButton1.UseVisualStyleBackColor = false;
            this.hoverButton1.Click += new System.EventHandler(this.hoverButton1_Click);
            // 
            // hbtnYes
            // 
            this.hbtnYes.BackColor = System.Drawing.Color.Transparent;
            this.hbtnYes.BackgroundImage = global::Prospar.Properties.Resources.Yes___;
            this.hbtnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hbtnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnYes.FlatAppearance.BorderSize = 0;
            this.hbtnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hbtnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hbtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnYes.Location = new System.Drawing.Point(475, 247);
            this.hbtnYes.MaximumGrowingSize = 60;
            this.hbtnYes.Name = "hbtnYes";
            this.hbtnYes.Size = new System.Drawing.Size(126, 50);
            this.hbtnYes.Speed = 16;
            this.hbtnYes.TabIndex = 0;
            this.hbtnYes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hbtnYes.UseVisualStyleBackColor = false;
            this.hbtnYes.Click += new System.EventHandler(this.hbtnYes_Click);
            // 
            // ExitDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.hoverButton1);
            this.Controls.Add(this.picAreYouSure);
            this.Controls.Add(this.hbtnYes);
            this.Controls.Add(this.picExiting);
            this.Name = "ExitDialogue";
            this.Text = "Exit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAreYouSure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExiting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButton hbtnYes;
        private System.Windows.Forms.PictureBox picAreYouSure;
        private HoverButton hoverButton1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrDeathAnimation;
        private System.Windows.Forms.PictureBox picExiting;
    }
}