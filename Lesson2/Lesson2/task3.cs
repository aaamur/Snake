/*
 * Ивашкевич Артём
 * 3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел;
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class task3
    {
        public int getSum()
        {
            int sum = 0;
            int value;

            do {
                value = int.Parse(Console.ReadLine());

                bool isOdd = value % 2 == 0;

                if (!isOdd && value > 0) {
                    sum += value;
                }


            } while (value != 0);

            return sum;
        }
    }
}
