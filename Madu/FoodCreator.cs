using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madu
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        string sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, string sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        public Point CreateFood(List<Point> snakePoints, List<Point> wallPoints)
        {
            Point p;
            do
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                p = new Point(x, y, sym);
            }
            while (snakePoints.Any(sp => sp.IsHit(p)) || wallPoints.Any(wp => wp.IsHit(p)));

            return p;
        }

    }
}