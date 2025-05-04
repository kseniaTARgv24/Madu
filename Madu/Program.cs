using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(79, 25);
            Console.SetBufferSize(80, 25);

            Console.OutputEncoding = System.Text.Encoding.UTF8;



            HorizontalLine Line1 = new HorizontalLine(1,  78 , 1, "+");
            HorizontalLine Line2 = new HorizontalLine(1, 78, 24, "+");
            VerticalLine Line3 = new VerticalLine(1, 24, 1, "+");
            VerticalLine Line4 = new VerticalLine(1, 24, 78, "+");
            Line1.Draw();
            Line2.Draw();
            Line3.Draw();
            Line4.Draw();

            

            Point p = new Point(22, 22, "*");
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, "$");
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


        }

    }

}
