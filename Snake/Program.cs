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
            Console.SetWindowSize(80, 25);
            var topLine = new HorizontalLine(1, 78, 0, '-');
            topLine.Draw();
            var bottomLine = new HorizontalLine(1, 78, 24, '-');
            bottomLine.Draw();
            var leftLine = new VerticalLine(0, 1, 23, '|');
            leftLine.Draw();
            var rightLine = new VerticalLine(79, 1, 23, '|');
            rightLine.Draw();

            var tail = new Point(10, 10, '*');
            var snake = new Snake(tail, 10, Direction.Right);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
