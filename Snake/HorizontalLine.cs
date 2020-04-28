
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xStart, int xEnd, int y, char symbol)
        {
            Points = new List<Point>();
            for (int i = xStart; i <= xEnd; i++)
            {
                Points.Add(new Point(i, y, symbol));
            }
        }
    }
}
