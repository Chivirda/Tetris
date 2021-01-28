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
            figure.Draw();

            Console.ReadLine();
        }
    }
}
