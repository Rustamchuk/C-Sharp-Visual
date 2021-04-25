using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _13
    {
        static void Main(string[] args)
        {
            int[,] number = new int[5, 7];
            Random rand = new Random();
            int sum = 0;
            int multi = 0;

            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    number[i, j] = rand.Next(10, 51);
                    Console.Write(number[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < number.GetLength(1); j++)
            {
                sum += number[1, j];
            }
            Console.WriteLine("Сумма 2 строки = " + sum);

            for (int i = 0; i < number.GetLength(0); i++)
            {
                multi += number[i, 0];
            }
            Console.WriteLine("Произведение 1 столбца = " + multi);
        }
    }
}
