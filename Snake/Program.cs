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

            var walls = new Barrier(80, 25, '*');
            walls.Draw();

            var tail = new Point(10, 10, '*');
            var snake = new Snake(tail, 10, Direction.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();

            ConsoleKeyInfo input = new ConsoleKeyInfo();
            while (true)
            {
                if (snake.IsHit(walls) || snake.IsHitTail()) GameOver();                
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

        static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var i = 0; i < 3; i++) ShowGameOverMessage();
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        static void ShowGameOverMessage()
        {
            Console.Clear();
            Thread.Sleep(200);
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(29, 12);
            Console.WriteLine("И Г Р А   О К О Н Ч Е Н А");
            Console.SetCursorPosition(28, 14);
            Console.WriteLine("===========================");
            Thread.Sleep(300);
        }
    }
}
