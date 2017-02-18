using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {

        public Snake(Point tail,int length, Direction direction)
        {
            pList = new List<Point>();

            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i,direction);
                pList.Add( p );
            }
        }

        public void move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = new Point();
            head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction.RIGTH);
            return nextPoint;
        }
    }
}
