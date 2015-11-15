using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    class Walls
    {
        List<Figure>wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine LineTop = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine LineBot = new HorizontalLine(0, 78, 24, '#');
            VerticalLine LineLeft = new VerticalLine(0, 24, 0, '#');
            VerticalLine LineRight = new VerticalLine(0, 24, 78, '#');

            wallList.Add(LineTop);
            wallList.Add(LineBot);
            wallList.Add(LineLeft);
            wallList.Add(LineRight);

        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }

        }

        internal bool IsHit(Figure figure)
        {

            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
