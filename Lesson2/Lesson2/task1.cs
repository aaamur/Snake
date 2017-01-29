/*
 * Ивашкевич Артём
 * 1.	Написать метод возвращающий минимальное из трех чисел;
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{   
    

    class task1
    {


        public int getMinValue(int a, int b, int c)
        {
            int[] array = { a, b, c };

            int smallest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }

            return smallest;

        }


    }
}
