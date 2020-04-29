using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }

        public Point() { }

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Symbol = p.Symbol;
        }

        internal void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up: { Y = Y - offset; break; }
                case Direction.Down: { Y = Y + offset; break; }
                case Direction.Right: { X = X + offset; break; }
                case Direction.Left: { X = X - offset; break; }
            }
        }

        internal void Clear()
        {
            Symbol = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public override string ToString()
        {
            return $"{X}, {Y}, {Symbol}";
        }
    }
}
