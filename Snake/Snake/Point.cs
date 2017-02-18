using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
       public int x;
       public int y;
       public char sym;

        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.sym);
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    x = x -  offset;
                    break;

                case Direction.RIGTH:
                    x = x + offset;
                    break;

                case Direction.UP:
                    y = y - offset;
                    break;

                case Direction.DOWN:
                    y = y + offset;
                    break;

            }

        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
