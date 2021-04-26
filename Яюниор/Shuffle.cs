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
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                int rand = new Random().Next(array.Length);
                array[i] = array[rand];
                array[rand] = key;
            }
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
