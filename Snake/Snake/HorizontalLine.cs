using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {


        List<Point> pList = new List<Point>();

        public HorizontalLine(int xBegin, int xEnd, int y, char sym)
        {
            for (int x = xBegin; x <= xEnd; x++)
            {
                Point p = new Point(x, y, '#');
                pList.Add(p);
            }


        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.DrawPoint();
            }
        }
    
    }



}
