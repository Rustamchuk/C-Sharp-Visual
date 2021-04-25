using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _155
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string answer;
            int number;
            int sum = 0;

            Console.WriteLine("Вводите числа. Для остановки напишите exit");

            while (true)
            {
                answer = Console.ReadLine();

                int.TryParse(answer, out number);

                if (answer == "exit")
                {
                    sum = numbers.ToArray().sum();
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    numbers.Add(number);
                }
            }
        }
    }
}
