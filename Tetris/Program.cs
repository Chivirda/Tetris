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


            FigureGenerator figureGenerator = new FigureGenerator('#');
            Figure figure = figureGenerator.GetNewFigure();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    HandleKey(figure, key);
                }
            }
        }

        private static void HandleKey(Figure figure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    figure.Move(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    figure.Move(Direction.RIGTH);
                    break;
                case ConsoleKey.DownArrow:
                    figure.Move(Direction.DOWN);
                    break;
            }
        }
    }
}
