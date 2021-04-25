using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class RandomSuffle
    {
        static void Main(string[] args)
        {
            string[] array = {"a", "b", "c", "d", "e", "f", "g", "h"};
            string[] newArray;

            newArray = Shuffle(array);
            
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                Console.Write($"{newArray[i]} ");
            }
        }

        static string[] Shuffle(string[] array)
        {
            string[] array1 = new string[array.GetLength(0)];
            int i = 0;
            Random rand = new Random();
            
            while (true)
            {
                array1[i] = array[rand.Next(0, array.GetLength(0))];

                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array1[i] == array1[j])
                    {
                        i--;
                    }
                }
                
                i++;

                if (i >= array.GetLength(0))
                    break;
            }
            
            return array1;
        }
    }
}
