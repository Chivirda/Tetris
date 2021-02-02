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
            Draw();
        }

        public override void Rotate(Point[] pList)
        {
            if (pList[0].x == pList[1].x)
            {
                SetHorizontal(pList);
            }
            else
            {
                SetVertical(pList);
            }
        }

        private void SetHorizontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                pList[i].y = pList[0].y;
                pList[i].x = pList[0].x + i;
            }
        }

        private void SetVertical(Point[] pList)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                pList[i].x = pList[0].x;
                pList[i].y = pList[0].y + i;
            }
        }
    }
}
