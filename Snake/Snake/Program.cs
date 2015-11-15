


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

            Console.SetBufferSize(80, 25);
           
            HorizontalLine LineTop = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine LineBot = new HorizontalLine(0, 78, 24, '#');
            VerticalLine LineLeft = new VerticalLine(0, 24, 0, '#');
            VerticalLine LineRight = new VerticalLine(0, 24, 78, '#');


            LineTop.Draw();
            LineBot.Draw();
            LineRight.Draw();
            LineLeft.Draw();



            Console.ReadLine();

        }


        static void DrawPoint(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
