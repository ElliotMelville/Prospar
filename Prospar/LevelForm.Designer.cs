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
            this.gameCanvas1 = new Prospar.GameCanvas();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrScroll
            // 
            this.tmrScroll.Interval = 10;
            this.tmrScroll.Tick += new System.EventHandler(this.tmrScroll_Tick);
            // 
            // gameCanvas1
            // 
            this.gameCanvas1.Location = new System.Drawing.Point(0, 0);
            this.gameCanvas1.Name = "gameCanvas1";
            this.gameCanvas1.Size = new System.Drawing.Size(1000, 750);
            this.gameCanvas1.TabIndex = 0;
            this.gameCanvas1.TabStop = false;
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.gameCanvas1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelForm";
            this.Text = "LevelForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LevelForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GameCanvas gameCanvas1;
        private System.Windows.Forms.Timer tmrScroll;
    }
}