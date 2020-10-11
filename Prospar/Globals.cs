using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospar
{
    static class Globals
    {
        public static Game game;

        public static void NewGame()
        {
            game = new Game();
        }
    }
}
