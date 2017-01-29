/*
 * Ивашкевич Артём
 * 2.	Написать метод подсчета количества цифр числа;
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class task2
    {
        
        public int getLengthValue(int value)
        {
            string str = Convert.ToString(value);
            return str.Length;
        }
        
    }
}
