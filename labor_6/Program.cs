using System;
using System.Collections.Generic;

namespace labor_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {

                dict.TryGetValue(value, out int count);
                dict[value] = count - 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();
        }

    }
}