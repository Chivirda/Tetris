using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);


            Figure square = new Stick(3, 4, '#');
            square.Draw();
            Thread.Sleep(500);
            square.Clear();
            square.Rotate();
            square.Draw();

            Thread.Sleep(500);
            square.Clear();
            square.Move(Direction.DOWN);
            square.Draw();

            Thread.Sleep(500);
            square.Clear();
            square.Move(Direction.DOWN);
            square.Draw();

            Thread.Sleep(500);
            square.Clear();
            square.Rotate();
            square.Draw();



            //Square s2 = new Square(2, 2, '*');
            //s2.Draw();

            //Stick stick = new Stick(10, 4, '*');
            //stick.Draw();

            Console.ReadLine();
        }
    }
}
