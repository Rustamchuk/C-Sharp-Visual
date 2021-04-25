using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Яюниор
{
    class LinqWar
    {
        static void Main(string[] args)
        {
            List<string> first = new List<string> { "Никита", "Борис", "Рустам", "Виктор", "Боб", "Бернальт", "Вова", "Саша" };
            List<string> second = new List<string> { "Виктор", "Сергей", "Владимир", "Марк"};
            List<string> filtered = new List<string>(second.Union(first.Where(soldier => soldier.StartsWith("Б"))));

            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }
    }
}
