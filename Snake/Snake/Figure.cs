﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<Point> pList = new List<Point>();
        
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.DrawPoint();
            }
        }

    }
}
