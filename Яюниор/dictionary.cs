using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> peopleContent = new Dictionary<string, string>{ { "Vlad", "Boss" }, { "Sasha", "Cleaner"}, { "Alexandr", "Teacher"}, { "Misha", "Student"} };
            string answer;
            
            Console.WriteLine("Наличие кого вы хотите проверить?");
            answer = Console.ReadLine();

            if (peopleContent.ContainsKey(answer))
            {
                Console.WriteLine(peopleContent[answer]);
            }
            else
            {
                Console.WriteLine("Такого нет");
            }
        }
    }
}
