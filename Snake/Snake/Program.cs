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
            int x1 = 3;
            int y1 = 4;
            char SymPoint1 = '%';


            int x2 = 5;
            int y2 = 4;
            char SymPoint2 = '*';

            DrawPoint(x1,y1,SymPoint1);

            DrawPoint(x2, y2, SymPoint2);

            Console.ReadLine();
        }


        static void DrawPoint(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
