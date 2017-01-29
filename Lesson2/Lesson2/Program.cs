using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK1");
            task1 task1 = new task1();
            Console.WriteLine(task1.getMinValue(1,8,10));

            Console.WriteLine("TASK2");
            task2 task2 = new task2();
            Console.WriteLine(task2.getLengthValue(544323252));

            /*Console.WriteLine("TASK3");
            task3 task3 = new task3();
            Console.WriteLine(task3.getSum());

            Console.WriteLine("TASK4");
            

            task4 task4 = new task4();
            task4.imitateUserAction();*/

            Console.WriteLine("TASK6");
            task6 task6 = new task6();
            Console.WriteLine(task6.getCountGoodNumber());

            Console.WriteLine("TASK7");
            task7 task7 = new task7();
            Console.WriteLine(task7.getIntervalOfNumber(1, 10));


            Console.ReadLine();
        }
    }
}
