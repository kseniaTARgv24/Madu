using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    internal class Point
    {
        public int x;
        public int y;
        public string sym;

        public Point(int _x,int _y, string _sym)
        {
            x= _x;
            y= _y;
            sym = _sym;

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
