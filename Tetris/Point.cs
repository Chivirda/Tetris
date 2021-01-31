using System;

namespace Tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char symbol;
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        internal void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.DOWN:
                    y += 1;
                    break;
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGTH:
                    x += 1;
                    break;
            }
        }

        internal void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
