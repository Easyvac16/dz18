using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    internal class cs2
    {
        public static void task_2()
        {
            Console.WriteLine("---------Task 2---------");
            Console.OutputEncoding = Encoding.Unicode;

            string[] countries1 = { "Україна", "США", "Німеччина", "Франція", "США" };
            string[] countries2 = { "США", "Італія", "Україна" };

            //Виведення 1 масиву країн 
            Console.WriteLine("Countries 1:" + string.Join(",", countries1));

            //Виведення 2 масиву країн 
            Console.WriteLine("Countries 2:" + string.Join(",", countries2));

            Console.WriteLine();

            // Різниця двох масивів (елементи першого масиву, яких немає у другому)
            var difference = countries1.Except(countries2);
            Console.WriteLine("Різниця двох масивів:");
            foreach (string country in difference)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine();

            // Перетин масивів (спільні елементи для обох масивів)
            var intersection = countries1.Intersect(countries2);
            Console.WriteLine("Перетин масивів:");
            foreach (string country in intersection)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine();

            // Об'єднання масивів (елементи обох масивів без дублікатів)
            var union = countries1.Union(countries2);
            Console.WriteLine("Об'єднання масивів:");
            foreach (string country in union)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine();

            // Вміст першого масиву без повторень
            var distinct = countries1.Distinct();
            Console.WriteLine("Вміст першого масиву без повторень:");
            foreach (string country in distinct)
            {
                Console.WriteLine(country);
            }
        }
    }
}
