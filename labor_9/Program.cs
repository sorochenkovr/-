using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace labor_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int[,] matrix = new int[N, N];
            Task tBase = new Task(
                () =>
                {
                    Console.WriteLine("Вывод матрицы");

                    Random rnd = new Random();
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            matrix[i, j] = rnd.Next(10000);
                            Console.Write(matrix[i, j] + "   ");
                        }
                        Console.WriteLine("\n");
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine("Основная задача");
                });
            Task tContine1 = tBase.ContinueWith(
                base_task =>
                {
                    Console.WriteLine("Задача продолжения.");
                    int res1 = 0;
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (((i * 10 + j) % 2 != 0) && (matrix[i, j] % 7 == 0))
                                res1 += matrix[i, j];
                        }
                    }
                    Thread.Sleep(3000);
                    Console.WriteLine("Расчет суммы нечетных элементов, делящихся на 7 = {0}.", res1);
                    Console.WriteLine("Задача продолжения");
                });
            Task tContine2 = tBase.ContinueWith(
               base_task =>
               {
                   Console.WriteLine("Задача продолжения");
                   int max = matrix[0, 0];
                   for (int i = 0; i < N; i++)
                   {
                       for (int j = 0; j < N; j++)
                       {
                           if (matrix[i, j] % 2 == 0)
                               max = matrix[i, j];
                       }
                   }
                   Thread.Sleep(3000);
                   Console.WriteLine("Расчет поиск максимума", max);
                   Console.WriteLine("Задача продолжения");
               });
            tBase.Start();
            Console.ReadKey();
        }
    }
}