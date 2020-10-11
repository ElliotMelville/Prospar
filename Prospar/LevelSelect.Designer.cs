namespace Prospar
{
    partial class LevelSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelSelect));
            this.chest1 = new Prospar.Properties.Chest();
            ((System.ComponentModel.ISupportInitialize)(this.chest1)).BeginInit();
            this.SuspendLayout();
            // 
            // chest1
            // 
            this.chest1.Image = ((System.Drawing.Image)(resources.GetObject("chest1.Image")));
            this.chest1.Location = new System.Drawing.Point(398, 424);
            this.chest1.Name = "chest1";
            this.chest1.Size = new System.Drawing.Size(100, 50);
            this.chest1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chest1.TabIndex = 0;
            this.chest1.TabStop = false;
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.chest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelSelect";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chest1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Properties.Chest chest1;
    }
}