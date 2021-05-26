using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Square  : Figure
    {
        private readonly double _side;

        public Square(double side) => _side = side;
        public double CalcPerimiter()
        {
            Perimeter = 4 * _side;
            return Perimeter;
        }
        public double CalcArea()
        {
            Area = _side * _side;
            return Area;
        }
    }
}
