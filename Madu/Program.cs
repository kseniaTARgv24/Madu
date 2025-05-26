using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Madu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> extraWalls = new List<Figure>();
            int So = 100;
            Sounds sounds = new Sounds(So);
            sounds.PlayMusicLoop();

            while (true) 
            {


                Menu menu = new Menu();
                List<int> a = menu.ShowOptions();
                bool DM = Menu.GetDrunkMode(a);
                int Sp = Menu.GetSpeed(a);
                string Sy = Menu.GetSymbol(a);
                So = Menu.GetSoundVolume(a);
                sounds.SetVolume(So / 100f);
                Console.Clear();


                Console.Write("Name: ");
                string Name = Console.ReadLine();
                int score = 0;

                Console.SetWindowSize(80, 25);
                Console.SetBufferSize(80, 25);
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Walls walls = new Walls(80, 25);
                walls.Draw();

                Point p = new Point(4, 5, Sy);
                Snake snake = new Snake(p, 4, Directions.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(80, 25, "@");
                Point food = foodCreator.CreateFood(snake.GetPoints(), walls.GetPoints());
                food.Draw();

                bool isGameOver = false;

                while (!isGameOver) 
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        sounds.StopMusic();
                        isGameOver = true;
                        continue;
                    }

                    bool hitExtraWall = false;
                    foreach (var wall in extraWalls)
                    {
                        if (wall.IsHit(snake))
                        {
                            hitExtraWall = true;
                            break;
                        }
                    }
                    if (hitExtraWall)
                        break;



                    if (snake.Eat(food))
                    {
                        score++;
                        sounds.PlayEat();
                        if (score % 3 == 0)
                        {
                            // wall!
                            Random rnd = new Random();
                            int x = rnd.Next(2, 74); // map 
                            int y = rnd.Next(2, 23); // map

                            HorizontalLine newWall = new HorizontalLine(x, x + 4, y, "#");
                            extraWalls.Add(newWall);
                            newWall.Draw();
                        }

                        do
                        {
                            food = foodCreator.CreateFood(snake.GetPoints(), walls.GetPoints());
                        } while (snake.IsHit(food) || walls.GetPoints().Any(p => p.IsHit(food)));

                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }

                    Console.SetCursorPosition(0, 0);
                    Console.Write($"Player: {Name} | Score: {score} | Drunk Mode: {DM} ");

                    Thread.Sleep(Sp);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);
                        snake.HandleKey(key.Key, DM); //DRUNK MODE OR NOT!

                    }
                }

                sounds.StopMusic();
                sounds.PlayDie();
                Console.Clear();
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("DEAD. Your score: " + score);

                string path = "scores.txt";
                

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(Name + " - " + score+ "  Drunk Mode: "+ DM);
                }

                Console.WriteLine("\n                          Press any key");
                Console.ReadKey();
                Console.Clear();
            }
        }


    }
}
