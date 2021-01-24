using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick (int x, int y, char symbol)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(x, y + i, symbol);
            }
        }
    }
}
