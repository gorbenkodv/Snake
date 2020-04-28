using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point() { X = 1, Y = 3, Symbol = '*' };
            var p2 = new Point() { X = 4, Y = 5, Symbol = '#' };
            var p3 = new Point(4, 4, '*');

            var pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);

            foreach (var p in pointList)
            {
                p.Draw();
            }

            Console.ReadKey();
        }
    }
}
