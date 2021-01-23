using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            var x1 = 3;
            var y1 = 2;
            var c1 = '*';

            Draw(x1, y1, c1);

            var x2 = 8;
            var y2 = 5;
            var c2 = '#';

            Draw(x2, y2, c2);


            Console.ReadLine();
        }

        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
