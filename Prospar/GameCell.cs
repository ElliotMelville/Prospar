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
    class GameCell : PictureBox
    {
        public Point position;
        public int contents;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Paint += new PaintEventHandler(this.OnPaint);
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(position.X.ToString() + "-" + position.Y.ToString(), Font, Brushes.Black, new Point(20, 20));
        }
    }
}
