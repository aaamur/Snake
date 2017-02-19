using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {

        List<Figure> wallList; 

        public Walls(int mapWidht, int mapHight, char sym)
        {
            HorizontalLine upLine = new HorizontalLine(0, mapWidht - 2 , 0, sym);
            HorizontalLine downLine = new HorizontalLine(0, mapWidht - 2, mapHight - 1, sym);
            VerticalLine leftLine = new VerticalLine(0, mapHight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHight - 1, mapWidht - 2, sym);

            wallList = new List<Figure>();
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            foreach(Figure wall in wallList)
            {
                wall.Draw();
            }
        }

        public bool isHit(Figure figure)
        {
            foreach (Figure wall in wallList)
            {
                if (wall.isHit(figure))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
