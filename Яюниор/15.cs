using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _15
    {
        static void Main15(string[] args)
        {
            int[] numbers = new int[1];
            int[] newNumbers = new int[numbers.Length + 1];
            int number = 0;
            int sum = 0;
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
                userInput =Console.ReadLine();
                if (userInput == "exit")
                {
                    exit = true;
                }
                else if (userInput == "sum") 
                {
                    if (numbers.Length >= 2)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                    }
                    else
                    {
                        exit = true;
                    }
                    Console.WriteLine("Сумма равняется " + sum);
                    exit = true;
                }

                else
                {
                    numbers[numbers.Length - 1] = Convert.ToInt32(userInput);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        newNumbers[i] = numbers[i];
                    }
                    numbers = newNumbers;
                    newNumbers = new int[numbers.Length + 1];
                }
            }
        }
    }
}
