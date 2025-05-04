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
            //Console.SetBufferSize(110, 25);
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(1, 2, "v");
            Point p2 = new Point(2, 3, "b");


            HorizontalLine Line1 = new HorizontalLine(5,  110 , 5, "+");
            HorizontalLine Line2 = new HorizontalLine(5, 110, 25, "+");
            VerticalLine Line3 = new VerticalLine(5, 25, 5, "+");
            VerticalLine Line4 = new VerticalLine(5, 25, 110, "+");
            Line1.Draw();
            Line2.Draw();
            Line3.Draw();
            Line4.Draw();

        }

    }

}
