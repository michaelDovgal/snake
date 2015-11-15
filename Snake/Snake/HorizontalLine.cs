using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xBegin, int xEnd, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xBegin; x <= xEnd; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }       
   
    }



}
