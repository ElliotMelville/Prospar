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
    class GameCanvas : PictureBox
    {
        private GameLevel level;

        private int visibleCellsWide;
        private int visibleCellsHigh;

        private GameCell[,] cellsIndex;
        private List<GameCell> cells = new List<GameCell>();

        private const int cellOverflow = 3;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (Globals.game == null)
            {
                   //in the form designer?
                return;
            }
            this.level = Globals.game.level;

            DoubleBuffered = true;

            Globals.game.canvas = this;

            Initialise();
        }

        protected void Initialise()
        {
            Random random = new Random();

            int x = 1;
            int y = 1;

            visibleCellsWide = 14;
            visibleCellsHigh = 11;
            cellsIndex = new GameCell[this.level.GetWidth(), this.level.GetHeight()];

            while(y < visibleCellsHigh + cellOverflow)
            {
                x = 1;
                while(x < visibleCellsWide + cellOverflow)
                {
                    if (random.Next(1, 4) == 3)
                    {
                        CreateCell(x, y);
                    }

                    x++;
                }

                y++;
            }
        }

        private void CreateCell(int x, int y)
        {
            var cell = new GameCell
            {
                Name = "cell" + x.ToString() + "_" + y.ToString(),
                Size = new Size(this.level.cellSize, this.level.cellSize),
                Location = new Point(this.level.cellSize * (x - 1), this.level.cellSize * (y - 1)),
                position = new Point(x, y),
                contents = 0,
                Image = Properties.Resources.Walls
            };

            cellsIndex[x, y] = cell;
            cells.Add(cell);
            this.Controls.Add(cell);
        }

        public void ScrollRight(int amount)
        {
            foreach(GameCell cell in cells)
            {
                
                cell.Left -= amount;
            }
        }
        public void ScrollLeft(int amount)
        {
            foreach (GameCell cell in cells)
            {
                cell.Left += amount;
            }
        }
    }
}
