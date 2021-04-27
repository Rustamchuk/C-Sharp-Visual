using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Shuffle
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            ShowArray(numbers);

            Shufle(numbers);

            ShowArray(numbers);
        }

        static void Shufle(int[] numbers)
        {
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int position = rand.Next(numbers.Length);
                numbers[i] = numbers[position];
                numbers[position] = key;
            }
        }

        static void ShowArray(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
