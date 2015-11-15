using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        private Direction direction;
       
        public Snake(Point tail, int Lenght, Direction _direction)
        {
            pList = new List<Point>();
            direction = _direction;
            for (int i = 0; i < Lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            }
        }


        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point Head = GetNextHeadPoint();
            pList.Add(Head);

            tail.clear();
            Head.DrawPoint();

        }

        public Point GetNextHeadPoint()
        {
            Point CurrentHead = pList.Last();
            Point NewPointHead = new Point(CurrentHead);
            NewPointHead.Move(1,direction);
            return NewPointHead; 
        }

    }
}
