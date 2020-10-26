using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospar
{
    class Game
    {
        public GameLevel level;
        public GameCanvas canvas;

        public void NewLevel()
        {
            this.level = new GameLevelTest();
        }

        public void OnScrollingDown()
        {
            this.canvas.ScrollDown(5);
        }
        public void OnScrollingUp()
        {
            this.canvas.ScrollUp(5);
        }
        public void OnScrollingLeft()
        {
            this.canvas.ScrollLeft(5);
        }
        public void OnScrollingRight()
        {
            this.canvas.ScrollRight(5);
        }

    }
}