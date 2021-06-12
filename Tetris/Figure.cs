using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }
        internal Result TryMove(Direction direction)
        {
            Clear();

            var clone = Clone();
            Move(clone, direction);

            var result = VerifyPosition(clone);
            if(result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        internal Result TryRotate()
        {
            Clear();

            var clone = Clone();
            Rotate(clone);

            var result = VerifyPosition(clone);
            if (result == Result.SUCCESS)
                Points = clone;

            Draw();
            return result;
        }

        private Result VerifyPosition(Point[] newPoints)
        {
            foreach (var p in newPoints)
            {
                if (p.Y >= Field.Height)
                    return Result.DOW_BORDER_STRIKE;
                if (p.X >= Field.Width || p.X < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STIRKE;
            }

            return Result.SUCCESS;
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
                newPoints[i] = new Point(Points[i]);
            }

            return newPoints;
        }

        public void Clear()
        {
            foreach (Point point in Points)
            {
                point.Clear();
            }
        }

        public abstract void Rotate(Point[] pList);

    }
}
