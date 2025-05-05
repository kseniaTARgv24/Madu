using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class Walls
    {
        List<Figure> walllist;
        public Walls (int mapWidth, int mapHeight)
        {
            walllist = new List<Figure> ();

            HorizontalLine upline = new HorizontalLine(0, mapWidth-2, 0, "+");
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, "+");
            VerticalLine leftline= new VerticalLine(0, mapHeight - 1,0, "+");
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapWidth - 2, "+");

            walllist.Add (upline);
            walllist.Add (downline);
            walllist.Add (leftline);
            walllist.Add (rightline);

            internal bool IsHit (Figure figure)
            {
                foreach(var wall  in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
                return false;
            }

        }
    }
}
