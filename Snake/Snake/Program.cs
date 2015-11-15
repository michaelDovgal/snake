


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            Freq Frequensy = new Freq(150);

            Walls walls = new Walls(80, 25);
            walls.Draw();


   


            Point pTale = new Point(5, 5, '*');

            Snake snake = new Snake(pTale, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.DrawPoint();
            

            while (true)
            {

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.WriteLine("Жека ЛОХ");
                    Console.ReadLine();
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.DrawPoint();

                    Frequensy.Frequensy -= 10;
                    if (Frequensy.Frequensy == 70)
                    {
                        Console.Clear();
                        Console.WriteLine("Жека не ЛОХ");
                        Console.ReadLine();
                        break;
                    }
                }
                else{
                    snake.Move();
                }



                Thread.Sleep(Frequensy.Frequensy);
                
                //отслеживаем нажатие клавиши
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }

            }
         
 

        }


        static void DrawPoint(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}
