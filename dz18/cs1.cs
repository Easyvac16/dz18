using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{

    internal class cs1
    {
        public static void task_1()
        {
            Console.WriteLine("---------Task 1---------");

            int[] numbers = { 121, 75, 87 };

            var sortedNumbers = numbers.OrderByDescending(n => GetDigitSum(n));

            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static int GetDigitSum(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
