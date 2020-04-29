using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            Points = new List<Point>();
            for (var i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, direction);
                Points.Add(p);
            }
        }

        public void Move()
        {
            ClearTail();
            DrawNewHead();
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow: { direction = Direction.Up; break; }
                case ConsoleKey.DownArrow: { direction = Direction.Down; break; }
                case ConsoleKey.RightArrow: { direction = Direction.Right; break; }
                case ConsoleKey.LeftArrow: { direction = Direction.Left; break; }
            }
        }

        void ClearTail()
        {
            var tail = Points.First();
            tail.Clear();
            Points.Remove(tail);
        }
        void DrawNewHead()
        {
            var head = new Point(Points.Last());
            head.Move(1, direction);
            head.Draw();
            Points.Add(head);
        }
    }
}
