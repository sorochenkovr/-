using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Action<int, int>, bool> func = (Max) =>
            {
                return true;
            };
        }
        static void Max(int x, int y)
        {
            Console.WriteLine(x > y);
        }
    }
}