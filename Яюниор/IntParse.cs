using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class IntParse
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TakeNumber());
        }

        static int TakeNumber()
        {
            string userString;
            int number;

            bool isUsing = true;
            while (isUsing)
            {
                Console.WriteLine("Введите число");
                userString = Console.ReadLine();

                bool check = int.TryParse(userString, out number);

                if (check)
                {
                    return number;
                }
            }

            return 0;
        }
    }
}
