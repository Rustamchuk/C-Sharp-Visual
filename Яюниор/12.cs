using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _12
    {
        static void Main12(string[] args)
        {
            int[] number = new int[30];
            Random rand = new Random();
            int lastNumber = number.Length;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = rand.Next(0, 100);
                Console.Write(number[i] + " ");
            }

            Console.WriteLine("\nЛокальные максимумы:\n");

            if (number[0] > number[1])
            {
                Console.WriteLine(number[0]);
            }

            for (int i = 1; i < number.Length - 1; i++)
            {
                if (number[i] > number[i + 1] && number[i] > number[i-1]) 
                { Console.WriteLine(number[i]); }
            }

            if (number[lastNumber - 1] > number[lastNumber - 2])
            {
                Console.WriteLine(number[lastNumber - 1]);
            }

            Console.ReadKey();
        }
    }
}
