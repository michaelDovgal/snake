﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char sym;
        Random random = new Random();
        
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth  = mapWidth;
            this.sym = sym;
        }


        public Point CreateFood()
        {
            int x = this.random.Next(2, this.mapWidth - 2);
            int y = this.random.Next(2, this.mapHeight - 2);
            return new Point(x, y, this.sym);

        }


    }
}
