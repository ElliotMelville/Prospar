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
    abstract class GameLevel
    {
        public int cellSize = 96;

        abstract public int GetWidth();
        abstract public int GetHeight();
        abstract public string GetName();
        abstract public Point GetStartPoint();
    }
}
