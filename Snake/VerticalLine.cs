using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList = new List<Point>();
        public VerticalLine(int x, int yStart, int yEnd, char symbol)
        {
            for (var i = yStart; i <= yEnd; i++)
            {
                pList.Add(new Point(x, i, symbol));
            }
        }
        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}
