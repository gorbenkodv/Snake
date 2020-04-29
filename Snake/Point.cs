using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x { get; set; }
        int y { get; set; }
        public char symbol { get; set; }

        public Point() { }

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        internal void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up: { y = y - offset; break; }
                case Direction.Down: { y = y + offset; break; }
                case Direction.Right: { x = x + offset; break; }
                case Direction.Left: { x = x - offset; break; }
            }
        }

        /// <summary>
        /// Служит для очистки точки на консоли
        /// </summary>
        internal void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public override string ToString()
        {
            return $"{x}, {y}, {symbol}";
        }

        internal bool IsHit(Point food)
        {
            return food.x == x & food.y == y;
        }
    }
}
