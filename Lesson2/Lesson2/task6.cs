using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class task6
    {
        
        
        public int getSumDigitOfNumber(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }

            return sum;
        }

        public int getCountGoodNumber()
        {
            int k = 0;
            int sumOfDigit;
            DateTime start = DateTime.Now;
            Console.WriteLine(start);

            for (int i = 1; i <= 1000000; i++)
            {
                sumOfDigit = getSumDigitOfNumber(i);

                if (i % sumOfDigit == 0)
                {
                    k++;
                }
            }
            Console.WriteLine(DateTime.Now - start);

            return k;

        }
      
    }
}
