using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Яюниор
{
    class LinqGamers
    {
        static void Main(string[] args)
        {
            List<Gamer> gamers = new List<Gamer>
            {
                new Gamer("Pop", 10, 100),
                new Gamer("Bob", 12, 90),
                new Gamer("Kok", 11, 10),
                new Gamer("Gog", 2, 80),
                new Gamer("Mom", 14, 110),
                new Gamer("Non", 9, 130),
                new Gamer("Dod", 20, 70),
                new Gamer("Sos", 19, 50),
                new Gamer("Wow", 15, 40),
                new Gamer("Zoz", 5, 150),
            };

            List<Gamer> topLevel = gamers.OrderByDescending(gamers => gamers.Level).Take(3).ToList<Gamer>();
            ShowGamers(topLevel);

            List<Gamer> topPower = gamers.OrderByDescending(gamers => gamers.Power).Take(3).ToList<Gamer>();
            ShowGamers(topPower);
        }

        static void ShowGamers(List<Gamer> gamers)
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine($"{gamer.Name} - {gamer.Level} - {gamer.Power}");
            }
            Console.WriteLine();
        }
    }

    class Gamer
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Gamer(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }
    }
}
