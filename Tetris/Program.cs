using System;
using System.Threading;

namespace Tetris
{
    class Program
    {
        static FigureGenerator figureGenerator;
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.Width, Field.Height);
            Console.SetBufferSize(Field.Width, Field.Height);

            figureGenerator = new FigureGenerator('#');
            Figure currentFigure = figureGenerator.GetNewFigure();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    var result = HandleKey(currentFigure, key.Key);
                    ProcessResult(result, ref currentFigure);
                }
            }
        }

        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STIRKE || result == Result.DOW_BORDER_STRIKE)
            {
                Field.AddFigure(currentFigure);
                currentFigure = figureGenerator.GetNewFigure();
                return true;
            }
            else
                return false;
        }

        private static Result HandleKey(Figure figure, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    return figure.TryMove(Direction.LEFT);
                case ConsoleKey.RightArrow:
                    return figure.TryMove(Direction.RIGTH);
                case ConsoleKey.DownArrow:
                    return figure.TryMove(Direction.DOWN);
                case ConsoleKey.Spacebar:
                    return figure.TryRotate();
            }

            return Result.SUCCESS;
        }
    }
}
