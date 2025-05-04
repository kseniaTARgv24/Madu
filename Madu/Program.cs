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

            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            

            HorizontalLine Line1 = new HorizontalLine(1,  78 , 1, "+");
            HorizontalLine Line2 = new HorizontalLine(1, 78, 24, "+");
            VerticalLine Line3 = new VerticalLine(1, 24, 1, "+");
            VerticalLine Line4 = new VerticalLine(1, 24, 78, "+");
            Line1.Draw();
            Line2.Draw();
            Line3.Draw();
            Line4.Draw();

            

            Point p = new Point(5, 10, "*");
            Snake snake = new Snake(p, 10, Directions.RIGHT);
            snake.Draw();

            Console.ReadLine();

        }

    }

}
