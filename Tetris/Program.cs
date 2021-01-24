using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            //Point p1 = new Point(3, 5, '*');
            //p1.Draw();

            Square square = new Square(3, 4, '#');
            square.Draw();

            Square s2 = new Square(2, 2, '*');
            s2.Draw();

            Stick stick = new Stick(10, 4, '*');
            stick.Draw();

            Console.ReadLine();
        }
    }
}
