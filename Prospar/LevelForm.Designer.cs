namespace Prospar
{
    partial class LevelForm
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
            this.tmrScroll = new System.Windows.Forms.Timer(this.components);
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.picAvatar = new Prospar.Properties.AnimatedImage();
            this.gameCanvas = new Prospar.GameCanvas();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrScroll
            // 
            this.tmrScroll.Interval = 10;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 16;
            this.tmrMovement.Tick += new System.EventHandler(this.tmrMovement_Tick);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(462, 287);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(130, 100);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // gameCanvas
            // 
            this.gameCanvas.Location = new System.Drawing.Point(0, 0);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(1000, 750);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(158, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 600);
            this.panel1.TabIndex = 2;
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.gameCanvas);
            this.DoubleBuffered = true;
            this.Name = "LevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LevelForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GameCanvas gameCanvas;
        private System.Windows.Forms.Timer tmrScroll;
        private System.Windows.Forms.Timer tmrMovement;
        private Properties.AnimatedImage picAvatar;
        private System.Windows.Forms.Panel panel1;
    }
}