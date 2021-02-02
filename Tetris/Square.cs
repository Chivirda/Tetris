using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Square : Figure
    {
        public Square(int x, int y, char symbol)
        {
            points[0] = new Point(x, y, symbol);
            points[1] = new Point(x, y + 1, symbol);
            points[2] = new Point(x + 1, y, symbol);
            points[3] = new Point(x + 1, y + 1, symbol);
            Draw();
        }

        public override void Rotate(Point[] pList)
        {
            
        }
    }
}
