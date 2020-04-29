using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int maxWidth;
        int maxHeight;
        char symbol;

        Random random = new Random();

        public FoodCreator(int maxWidth, int maxHeight, char symbol)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.symbol = symbol;
        }

        public Point CreateFood()
        {
            var point = new Point(random.Next(2, maxWidth - 2), random.Next(2, maxHeight - 2), symbol);
            point.Draw();
            return point;
        }
    }
}
