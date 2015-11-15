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

        public void HandleKey(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    this.direction = Direction.RIGHT;
                    break;

                case ConsoleKey.LeftArrow:
                    this.direction = Direction.LEFT;
                    break;

                case ConsoleKey.DownArrow:
                    this.direction = Direction.DOWN;
                    break;

                case ConsoleKey.UpArrow:
                    this.direction = Direction.UP;
                    break;

                default: break;

            }
        }


        public bool Eat(Point food)
        {
            Point head = this.GetNextHeadPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.DrawPoint();
                pList.Add(food);
                return true;

            }
            else{
                return false;
            }

        }


        internal bool IsHitTail()
        {
            Point head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
