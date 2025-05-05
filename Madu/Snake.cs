﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Madu
{
    class Snake : Figure
    {

        public Directions direction;

        public Snake(Point tail, int lenght, Directions _direction)
        {

            direction = _direction;

            plist = new List<Point>();
            for (int i = 0; i < lenght; i++) {
                Point p = new Point (tail);
                p.Move(i, direction);
                plist.Add (p);
            }
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();

            //throw new NotImplementedException();
        }

        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit (food))
            {
                food.sym = head.sym;
                plist.Add(food);
              return true;
            }
                return false;
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move( 1, direction );
            return nextPoint;
        }

        public void HandleKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Directions.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Directions.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Directions.UP;
        }

        public override void Draw()
        {
            base.Draw();
        }

        internal bool IsHitTail()
        {
            var head = plist.Last();
            for (int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
