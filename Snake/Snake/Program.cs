using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,2,'*');
            p1.Draw();

            Point p2 = new Point(10,12,'#');
            p2.Draw();

            Point p3 = new Point(8, 20, '$');
            p2.Draw();

            Point p4 = new Point(19, 30, '&');
            p2.Draw();

            List<Point> pList = new List<Point> ();

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.WriteLine();
            foreach (Point i in pList)
            {
                Console.WriteLine(i.x);
            }


            Console.ReadLine();
        }
    }
}

