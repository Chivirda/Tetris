using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    class Figure
    {
        public Point[] points = new Point[4];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Move(Direction direction)
        {
            foreach (Point point in points)
            {
                point.Move(direction);
            }
        }

        public void Clear()
        {
            foreach (Point point in points)
            {
                point.Clear();
            }
        }
    }
}
