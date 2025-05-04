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

            Point p1 = new Point(1, 2, 'x');
            Point p2 = new Point(2, 3, 't');

            p1.Draw();

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);

            p1 = plist[0];
            p2 = plist[1];

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

        }

    }

}
