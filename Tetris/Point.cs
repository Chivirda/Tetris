using System;

namespace Tetris
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char SYMBOL { get; set; }
        public Point(int x, int y, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.SYMBOL = symbol;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            SYMBOL = point.SYMBOL;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(SYMBOL);
            Console.CursorVisible = false;
        }

        internal void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.DOWN:
                    Y += 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGTH:
                    X += 1;
                    break;
            }
        }

        internal void Clear()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
