using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class task7
    {
        public int getIntervalOfNumber(int a, int b)
        {
            int sum = 0;
            if (a <= b)
            {
                Console.WriteLine(a);
                sum = getIntervalOfNumber(a + 1, b) + a;
            }

            return sum;
        }
    }
}
