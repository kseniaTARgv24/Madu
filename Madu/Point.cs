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

        public Point(Point p)
        {
            x= p.x;
            y= p.y;
            sym = p.sym;
        }

        public void Move(int offset, Directions direction)
        {
            if (direction == Directions.RIGHT)
            {
                x += offset;
            }
            else if (direction == Directions.LEFT)
            {
                x -= offset;
            }
            else if (direction == Directions.UP)
            {
                y -= offset;
            }
            else if (direction == Directions.DOWN)
            {
                y += offset;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = "      ";
            Draw();
        }

    }
}
