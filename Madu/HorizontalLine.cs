using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
     class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, string sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Point p in plist)
            {
                p.Draw();
            }

            Console.ForegroundColor= ConsoleColor.Red;
        }

    }
}
