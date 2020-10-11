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
    class GameLevelTest : GameLevel
    {
        override public int GetWidth()
        {
            return 40;
        }
        override public int GetHeight()
        {
            return 40;
        }

        public override string GetName()
        {
            return "Test level";
        }

        public override Point GetStartPoint()
        {
            return new Point(20, 20);   
        }
    }
}
