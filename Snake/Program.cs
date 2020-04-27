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
            var p1 = new Point() { X = 1, Y = 3, Symbol = '*' };
            p1.Draw();
            var p2 = new Point() { X = 4, Y = 5, Symbol = '#' };
            p2.Draw();

            Console.ReadKey();
        }
    }
}
