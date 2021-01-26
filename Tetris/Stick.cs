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

        public override void Rotate()
        {
            if (points[0].x == points[1].x)
            {
                SetHorizontal();
            }
            else
            {
                SetVertical();
            }
        }

        private void SetHorizontal()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
        }

        private void SetVertical()
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
        }
    }
}
