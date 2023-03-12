using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace labor_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, List<int>> lambda = t =>
            {
                int k = 6;
                int n = 4;
                int[] result = new int[n];
                    ;
            };
            Console.WriteLine("Ввод кол-ва элементов массива");
            int N = Convert.ToInt32(Console.ReadLine());
            IAsyncResult ar = lambda.BeginInvoke(N, null, null);
            while (!ar.IsCompleted)
            {
                Console.WriteLine("\n Идет вычисление");
            }
            List<int> list = lambda.EndInvoke(ar);
            Console.WriteLine("\n");
            if (list.Count != 0)
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(result[i - 1] = k * i);
                }
            Console.ReadLine();
        }
    }
}