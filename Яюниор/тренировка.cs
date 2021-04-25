using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class тренировка
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Number please");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 5)
            {
                Console.WriteLine("Bigger then 5");
            }
            else if (a < 5)
            {
                Console.WriteLine("Less then 5");
            }
            else
            {
                Console.WriteLine("Is 5");
            }

            a = 5;

            while (a == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
                a = 5;
            }

            int[] b = new int[20];
            Random rand = new Random();
            int lenB = b.Length;

            for (int i = 0; i < lenB; i++)
            {
                b[i] = rand.Next(0, 30);
            }
            Console.WriteLine(b);

            for (int i = 0; i < lenB; i++)
            {
                switch (b[i])
                {
                    case 10:
                        Console.WriteLine("There is 10");
                        break;
                    case 11:
                        Console.WriteLine("There is 11");
                        break;
                    case 9:
                        Console.WriteLine("There is 9");
                        break;
                    case 8:
                        Console.WriteLine("There is 8");
                        break;
                    case 12:
                        Console.WriteLine("There is 12");
                        break;
                    case 7:
                        Console.WriteLine("There is 7");
                        break;
                }
            }

        }
    }
}
