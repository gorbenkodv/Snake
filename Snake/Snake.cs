using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            Points = new List<Point>();
            for (var i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                Points.Add(p);
            }
        }
    }
}
