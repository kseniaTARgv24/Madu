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


            Walls walls = new Walls(80, 25);
            walls.Draw();

            

            Point p = new Point(22, 22, "*");
            Snake snake = new Snake(p, 4, Directions.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(30, 30, "К");
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }


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
                Thread.Sleep(300);
                snake.Move();
            }


        }

    }

}
