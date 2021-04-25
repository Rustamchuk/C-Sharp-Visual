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
            bool exit = false;
            string userInput;

            Console.WriteLine("Здравствуйте! Дальше я буду просить вас вводить числа до тех пор, пока вы не напишите:\n" +
                "sum - суммирование всех чисел\n" +
                "exit - выход\n");
            Console.WriteLine("Нажмие любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            while (exit == false)
            {
                Console.WriteLine("Введите " + (number += 1) + " число.");
                userInput = Console.ReadLine();

                exit = Manager(userInput, ref numbers);
            }
        }

        static bool Manager(string command, ref List<int> numbers)
        {
            if (command == "exit")
            {
                return Exit();
            }
            else if (command == "sum")
            {
                Sum(ref numbers);
                return false;
            }
            else
            {
                AddNumber(ref numbers, command);
                return false;
            }
        }

        static void Sum(ref List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Сумма равняется " + sum);
        }

        static bool Exit()
        {
            return true;
        }

        static void AddNumber(ref List<int> numbers, string number)
        {
            numbers.Add(Convert.ToInt32(number));
        }
    }
}
