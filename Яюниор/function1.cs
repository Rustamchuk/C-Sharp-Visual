using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class function1
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            string[] statuses = new string[0];
            string userInput = "";

            while (userInput != "5")
            {
                Console.WriteLine("1 - добавить досье\n" +
                    "2 - вывести все досье\n" +
                    "3 - удалить досье\n" +
                    "4 - поиск по фамилии\n" +
                    "5 - выход");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddPasport(ref names, ref statuses);
                        break;
                    case "2":
                        WritePasport(names, statuses);
                        break;
                    case "3":
                        DeletePasport(ref names, ref statuses);
                        break;
                    case "4":
                        SearchPasport(names, statuses);
                        break;
                }
            }
        }

        static void AddPasport(ref string[] names, ref string[] statuses)
        {
            Console.WriteLine("Write full name");
            string newName = Console.ReadLine();
            Console.WriteLine("Write status");
            string newStatus = Console.ReadLine();

            GrowArray(ref names, newName);
            GrowArray(ref statuses, newStatus);
        }

        static void WritePasport(string[] names, string[] statuses)
        {
            int length = names.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine((i + 1) + " " + names[i] + "-" + statuses[i]);
            }
        }

        static void DeletePasport(ref string[] names, ref string[] statuses)
        {
            Console.WriteLine("Какой по счету этот человек?");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0 || number >= names.Length)
            {
                Console.WriteLine("Ошибка...");
                return;
            }

            CutArray(ref names, number);
            CutArray(ref statuses, number);
        }

        static void GrowArray(ref string[] array, string newPasport)
        {
            int length = array.Length + 1;
            string[] extraArray = new string[length];

            extraArray[length - 1] = newPasport;

            for (int i = 0; i < array.Length; i++)
            {
                extraArray[i] = array[i];
            }

            array = extraArray;
        }

        static void CutArray(ref string[] array, int number)
        {
            int length = array.Length;
            string[] extraArray = new string[length - 1];

            for (int i = 0; i < number - 1; i++)
            {
                extraArray[i] = array[i];
            }
            
            for (int i = number; i < extraArray.Length + 1; i++)
            {
                extraArray[i - 1] = array[i];
            }

            array = extraArray;
        }

        static void SearchPasport(string[] names, string[] statuses)
        {
            int length = names.Length;

            Console.WriteLine("Введите фамилию");
            string targetName = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                if (names[i] != null)
                {
                    string[] currentName = names[i].Split(new char[] { ' ' });
                    for (int j = 0; j < currentName.Length; j++)
                    {
                        if (currentName[j] == targetName)
                        {
                            Console.WriteLine("Это " + (i + 1) + " человек в досье.");
                            Console.WriteLine(names[i] + "-" + statuses[i]);
                        }
                    }
                }
            }
        }
    }
}