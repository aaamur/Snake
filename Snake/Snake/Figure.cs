using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

        public bool isHit(Figure figure)
        {
            foreach (Point p in pList)
            {
                if (figure.isHit(p))
                {
                    return true;
                }
            }

            return false;
        }

        private bool isHit(Point point)
        {
            foreach (Point p in pList)
            {
                if (p.isHit(point))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
