


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
            Point p1 = new Point();
            Point p2 = new Point();


            p1.x = 3;
            p1.y = 3;
            p1.sym = '*';
            p1.DrawPoint();

            p2.x = 4;
            p2.y = 4;
            p2.sym = '@';
            p2.DrawPoint();


            Console.ReadLine();

        }


        static void DrawPoint(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
