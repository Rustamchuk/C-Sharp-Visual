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
            int number = 0;
            bool playing = true;
            string userInput;

            Console.WriteLine("Здравствуйте! Дальше я буду просить вас вводить числа до тех пор, пока вы не напишите:\n" +
                "sum - суммирование всех чисел\n" +
                "exit - выход\n");

            while (playing)
            {
                Console.WriteLine("Введите " + (number += 1) + " число.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "sum":
                        Sum(numbers);
                        break;
                    case "exit":
                        playing = false;
                        break;
                    default:
                        AddNumber(numbers, userInput);
                        break;
                }
            }
        }

        static void Sum(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Сумма равняется " + sum);
        }

        static void AddNumber(List<int> numbers, string userAnswer)
        {
            if (int.TryParse(userAnswer, out int number))
                numbers.Add(number);
        }
    }
}
