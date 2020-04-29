﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> Points;
        public virtual void Draw()
        {
            foreach (var point in Points)
            {
                point.Draw();
            }
        }
    }
}
