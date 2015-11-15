


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,1,'*');
            Point p2 = new Point(2,2,'/');


            p1.DrawPoint();
            p2.DrawPoint();


            List<int> numP = new List<int>();
            numP.Add(0);
            numP.Add(1);
            numP.Add(2);


            int x = numP[0];
            int y = numP[1];
            int z = numP[2];

            foreach (int i in numP)
            {
                Console.WriteLine(i);
            }

            List<Point> lPoint = new List<Point>();
            lPoint.Add(p1);
            lPoint.Add(p2);




            Console.ReadLine();

        }


        static void DrawPoint(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
