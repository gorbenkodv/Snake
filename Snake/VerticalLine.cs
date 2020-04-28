using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {        
        public VerticalLine(int x, int yStart, int yEnd, char symbol)
        {
            Points = new List<Point>();
            for (var i = yStart; i <= yEnd; i++)
            {
                Points.Add(new Point(x, i, symbol));
            }
        }
    }
}
