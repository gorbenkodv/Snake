
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList = new List<Point>();
        public HorizontalLine(int xStart, int xEnd, int y, char symbol)
        {
            for (int i = xStart; i <= xEnd; i++)
            {
                pList.Add(new Point(i, y, symbol));
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
