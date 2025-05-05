using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Figure
    {
        protected List<Point> plist;

        public virtual void Draw()
        {
            Console.ForegroundColor = ConsoleColor.White;

            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
