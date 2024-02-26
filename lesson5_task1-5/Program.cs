using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5_task1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача1
            Console.WriteLine("Введите целое число N > 0");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine("среднее арифметическое - {0} ", ((float)sum / N));
            #endregion

            #region Задача5
            Console.WriteLine("Введите размерность целое число M > 0");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((i % 2 == 1 && j % 2 == 1) || (i % 2 == 0 && j % 2 == 0))
                        arr[i, j] = 1;
                    Console.Write("{0}", arr[i, j]);
                }
                Console.WriteLine("");
            }


            #endregion
            Console.Write("Нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
