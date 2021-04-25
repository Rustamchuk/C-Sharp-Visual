using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class UpgradeFunction
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> nameStatus = new Dictionary<string, string>();
            string name1, status1;
            int userInput = 0;

            while (userInput != 4)
            {
                Console.WriteLine("1 - добавить досье\n" +
                    "2 - вывести все досье\n" +
                    "3 - удалить досье\n" +
                    "4 - выход");

                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Write full name");
                        name1 = Console.ReadLine();
                        Console.WriteLine("Write status");
                        status1 = Console.ReadLine();
                        AddPasport(nameStatus, name1, status1);
                        break;
                    case 2:
                        WritePasport(nameStatus);
                        break;
                    case 3:
                        Console.Clear();

                        Console.WriteLine("Какой по счету этот человек?");
                        DeletePasport(nameStatus, number: Convert.ToInt32(Console.ReadLine()));
                        break;
                }
            }
        }

        static void AddPasport(Dictionary<string, string> nameStatus, string name1, string status1)
        {
            nameStatus.Add(name1, status1);

            Console.WriteLine();
            Console.WriteLine();
        }

        static void WritePasport(Dictionary<string, string> nameStatus)
        {
            int i = 1;

            Console.Clear();
            
            foreach (var namesAndStatus in nameStatus)
            {
                Console.WriteLine($"{i} - {namesAndStatus.Key} - {namesAndStatus.Value}");
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void DeletePasport(Dictionary<string, string> nameStatus, int number)
        {
            int i = 0;

            foreach (var name in nameStatus)
            {
                i++;

                if (i == number)
                {
                    nameStatus.Remove(name.Key);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
