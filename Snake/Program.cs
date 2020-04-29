using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.CursorVisible = false;
            var topLine = new HorizontalLine(0, 79, 0, '+');
            topLine.Draw();
            var bottomLine = new HorizontalLine(0, 79, 24, '+');
            bottomLine.Draw();
            var leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Draw();
            var rightLine = new VerticalLine(79, 0, 24, '+');
            rightLine.Draw();

            var tail = new Point(10, 10, '*');
            var snake = new Snake(tail, 10, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();

            ConsoleKeyInfo input = new ConsoleKeyInfo();
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.Escape) break;
                    snake.HandleKey(input.Key);
                }                
            }
        }
    }
}
