using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _14
    {
        static void Main14(string[] args)
        {
            int[,] A = new int[10, 10];
            Random rand = new Random();
            int max = int.MinValue;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rand.Next(10, 100);
                    Console.Write(A[i, j] + " ");
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nМаксимальное число = " + max + ".\n\n");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == max)
                    {
                        A[i, j] = 0;
                    }
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
