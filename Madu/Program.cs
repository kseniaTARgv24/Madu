using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Program
    {
        static void Main(string[] args) {

            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point p1 = new Point(1, 2, "v");
            Point p2 = new Point(2, 3, "b");

            HorizontalLine Line = new HorizontalLine(2,  20 , 5, "0");
            Line.Draw();

        }

    }

}
