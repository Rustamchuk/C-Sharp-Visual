using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Яюниор
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier> {
                new Soldier("Ivan", "general", "pistol", 36),
                new Soldier("Sasha", "cleaner", "broom", 3),
                new Soldier("Rustam", "lieutenant", "rifle", 10),
                new Soldier("Vova", "president", "bomb", 99),
                new Soldier("Sergey", "lieutenant-colonel", "gun", 9) };

            var soldierAndTitle = soldiers.Select(soldier => new { Name = soldier.Name, Title = soldier.Title});

            foreach (var soldier in soldierAndTitle)
            {
                Console.WriteLine(soldier.Name + " - " + soldier.Title);
            }
        }
    }

    class Soldier
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        private string _ammunition;
        private int _time;

        public Soldier(string name, string title, string ammunition, int time)
        {
            Name = name;
            Title = title;
            _ammunition = ammunition;
            _time = time;
        }


    }
}
