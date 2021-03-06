﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;
        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        }
        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        }

        private static bool[][] _heap;

        static Field()
        {
            _heap = new bool[Height][];
            for (var i = 0; i < Height; i++)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point point)
        {
            return _heap[point.Y][point.X];
        }

        public static void AddFigure(Figure figure)
        {
            foreach (var p in figure.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }
    }
}
