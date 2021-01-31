using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
        internal void TryMove(Direction direction)
        {
            Clear();

            var clone = Clone();
            Move(clone, direction);

            if (VerifyPosition(clone))
                points = clone;

            Draw();
        }

        private bool VerifyPosition(Point[] clone)
        {
            foreach (var p in clone)
            {
                if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 30)
                    return false;
            }

            return true;
        }

        private void Move(Point[] clone, Direction direction)
        {
            foreach (var p in clone)
            {
                p.Move(direction);
            }
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];

            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(points[i]);
            }

            return newPoints;
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
