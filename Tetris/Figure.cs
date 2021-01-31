using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public abstract class Figure
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
                Clear();
                point.Move(direction);
                Draw();
            }
        }

        public void Clear()
        {
            foreach (Point point in points)
            {
                point.Clear();
            }
        }

        public abstract void Rotate();
    }
}
