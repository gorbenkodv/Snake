using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Barrier
    {
        public List<Figure> Figures;
        public Barrier(int width, int height, char symbol)
        {
            Figures = new List<Figure>();
            Figures.Add(new HorizontalLine(0, width - 1, 0, symbol));
            Figures.Add(new HorizontalLine(0, width - 1, height - 1, symbol));
            Figures.Add(new VerticalLine(0, 0, height - 1, symbol));
            Figures.Add(new VerticalLine(width - 1, 0, height - 1, symbol));
        }

        internal void Draw()
        {
            foreach (var figure in Figures) figure.Draw();
        }
    }
}
