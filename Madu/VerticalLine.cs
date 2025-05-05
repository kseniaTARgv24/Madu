using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, string sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            foreach (Point p in plist)
            {
                p.Draw();
            }

            //Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
