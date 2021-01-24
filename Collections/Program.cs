using System;
using Tetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[3];
            //points[0] = new Point(2, 3, '*');
            //points[1] = new Point(3, 5, '*');
            //points[2] = new Point(7, 7, '#');

            //foreach (Point p in points)
            //{
            //    p.Draw();
            //}

            int[] x = new int[3] { 1, 2, 3 };

            foreach(int i in x)
            {
                Console.WriteLine(i);
            }


            char[][] field = new char[3][];
            field[0] = new char[3];
            field[1] = new char[3];
            field[2] = new char[3];

            field[0][0] = 'X';
            field[0][1] = ' ';
            field[0][2] = ' ';
            field[1][0] = ' ';
            field[1][1] = ' ';
            field[1][2] = ' ';
            field[2][0] = ' ';
            field[2][1] = ' ';
            field[2][2] = '0';

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
