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
            HorizontalLine hLine = new HorizontalLine(5,20,6,'=');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(7,5,14,'=');
            vLine.Draw();
            
            Console.ReadLine();
        }
    }
}

