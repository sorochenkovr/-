using System;

namespace labor_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы:");
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, M];
            Random rand = new Random();
            int[] summ = new int[M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rand.Next(0, 10);

                }
            }
            Console.WriteLine("Матрица");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {

                    Console.Write(matrix[i, j]); 
                    summ[i] += matrix[j, i];  
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (double elem in summ)
            {

                Console.WriteLine(elem / M); 
            }

        }
    }
}
