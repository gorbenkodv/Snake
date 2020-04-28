using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var hLine = new HorizontalLine(5, 10, 3, '*');
            hLine.Draw();

            var vLine = new VerticalLine(3, 4, 8, '#');
            vLine.Draw();

            Console.ReadKey();
        }
    }
}
