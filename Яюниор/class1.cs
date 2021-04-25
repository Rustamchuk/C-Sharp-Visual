using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class class1
    {
        static void Main(string[] args)
        {
            Information user1 = new Information("Rustam", 35);
            Information user2 = new Information("Vitalya", 11);
            Information user3 = new Information("Pasha", 55);

            user1.SayStats();
            user2.SayStats();
            user3.SayStats();
        }

        class Information
        {
            private string _name;
            private int _level;

            public Information(string name, int level)
            {
                _name = name;
                _level = level;
            }

            public void SayStats()
            {
                Console.WriteLine($"Здравствуйте, {_name}, ваш уровень - {_level}.");
            }
        }
    }
}
