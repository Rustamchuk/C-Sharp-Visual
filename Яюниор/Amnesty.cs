using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Яюниор
{
    class Amnesty
    {
        static void Main(string[] args)
        {
            Criminal andrey = new Criminal("Andrey", "political");
            Criminal bob = new Criminal("Bob", "kill");
            Criminal victor = new Criminal("Victor", "political");
            Criminal leonardo = new Criminal("Leonardo", "thief");
            Criminal misha = new Criminal("Misha", "kill");
            Criminal nikita = new Criminal("Nikita", "political");

            List<Criminal> criminals = new List<Criminal> { andrey, bob, victor, leonardo, misha, nikita};

            ShowCriminals(criminals);

            criminals = criminals.OrderBy(criminals => criminals.Reason).TakeWhile(criminals => criminals.Reason != "political").Union(criminals.OrderByDescending(criminals => criminals.Reason).TakeWhile(criminals => criminals.Reason != "political")).ToList<Criminal>();

            ShowCriminals(criminals);
        }

        static void ShowCriminals(List<Criminal> criminals)
        {
            foreach (var criminal in criminals)
            {
                Console.WriteLine($"{criminal.Name} - {criminal.Reason}");
            }
            Console.WriteLine();
        }
    }

    class Criminal
    {
        public string Name { get; private set; }
        public string Reason { get; private set; }

        public Criminal(string name, string reason)
        {
            Name = name;
            Reason = reason;
        }
    }
}
