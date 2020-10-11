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

        }
        public void OnScrollingUp()
        {

        }
        public void OnScrollingLeft()
        {
            this.canvas.ScrollLeft(10);
        }
        public void OnScrollingRight()
        {
            this.canvas.ScrollRight(10);
        }

    }
}