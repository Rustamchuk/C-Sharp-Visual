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

            second = second.Union(first.Where(soldier => soldier.StartsWith("Б"))).ToList<string>();
            first = first.OrderBy(first => first).SkipWhile(first => first.StartsWith("Б")).ToList<string>();

            foreach (var item in second)
            {
                Console.WriteLine(item);
            }
        }
    }
}
