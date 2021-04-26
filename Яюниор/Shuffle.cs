using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Shuffle
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            ShowArray(array);

            Shufle(ref array);

            ShowArray(array);
        }

        static void Shufle(ref int[] array)
        {
            List<int> usedNumbers = new List<int>();
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int number = GetRandom(ref usedNumbers, array.Length);

                newArray[i] = array[number];
            }
            array = newArray;
        }

        static int GetRandom(ref List<int> used, int len)
        {
            int number = 0;
            bool isWrong = true;

            while (isWrong)
            {
                number = new Random().Next(len);

                if (used.Contains(number))
                {
                    continue;
                }

                used.Add(number);

                isWrong = false;
            }

            return number;
        }

        static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
