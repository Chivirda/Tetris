using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris
{
    public class FigureGenerator
    {
        private int _x = Field.WIDTH / 2;
        private int _y = 0;
        private char _symbol;

        private Random _rand = new Random();
        private int _countOfigures = 2;

        public FigureGenerator(char symbol)
        {
            _symbol = symbol;
        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, _countOfigures) == 0)
            {
                return new Square(_x, _y, _symbol);
            }
            else
            {
                return new Stick(_x, _y, _symbol);
            }
        }
    }
}
