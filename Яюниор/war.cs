using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class War
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int> { 10, 25, 100 };
            List<int> second = new List<int> { 15, 15, 120 };
 
            Army war1 = new Army(first, second);

            war1.Attack();
        }
    }

    class Army
    {
        private Team _one;
        private Team _two;

        public Army(List<int> first, List<int> second)
        {
            _one = new Team(first[0], first[1], first[2]);
            _two = new Team(second[0], second[1], second[2]);

            Console.WriteLine($"Первая армия - {_one.Health} hp, {_one.Damage} damage\n\n" +
                $"{first[0]} танков, {first[1]} самолетов, {first[2]} солдат\n\n\n");

            Console.WriteLine($"Вторая армия - {_two.Health} hp, {_two.Damage} damage\n\n" +
                $"{second[0]} танков, {second[1]} самолетов, {second[2]} солдат");
        }

        public void Attack()
        {
            Random damage = new Random();
            int randomDamage;
            int maxFirst = _one.Health;
            int maxSecond = _two.Health;

            while (_one.Health > 0 && _two.Health > 0)
            {
                ShowBar(_one.Health, 16, ConsoleColor.Green, maxFirst, 1);
                ShowBar(_two.Health, 18, ConsoleColor.Blue, maxSecond, 2);

                Console.ReadKey();
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                randomDamage = damage.Next(_two.Damage / 2, _two.Damage);
                _one.GetDamage(randomDamage);

                Console.WriteLine($"Первый получает {randomDamage} урона от вражеских сил\n\n" +
                    $"{_one.Health} hp");

                randomDamage = damage.Next(_one.Damage / 2, _one.Damage);
                _two.GetDamage(randomDamage);

                Console.WriteLine($"Второй получает {randomDamage} урона от вражеских сил\n\n" +
                    $"{_two.Health} hp");
            }

            if (_one.Health > _two.Health)
            {
                Console.WriteLine("Первая армия победила!");
            }
            else if (_one.Health < _two.Health)
            {
                Console.WriteLine("Вторая армия победила!");
            }
            else if (_one.Health == _two.Health)
            {
                Console.WriteLine("Ничья");
            }
        }

        private void ShowBar(int value, int y, ConsoleColor color, int maxValue, int number)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.SetCursorPosition(0, y);

            Console.Write($"{number} -  ");

            Console.Write("[");

            Console.BackgroundColor = color;
            for (int i = 0; i < value / 150; i++)
            {
                Console.Write("#");
            }
            for (int i = 0; i < maxValue / 150 - value / 150; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = defaultColor;

            Console.WriteLine("]");
        }
    }

    class Team
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }
        private Force _force = new Force();

        public Team(int tank, int plane, int soldier)
        {
            Health = 500;
            Damage = 500;

            AddForce(tank, _force.GetTank().Health, _force.GetTank().Damage);
            AddForce(plane, _force.GetPlane().Health, _force.GetPlane().Damage);
            AddForce(soldier, _force.GetSoldier().Health, _force.GetSoldier().Damage);
        }

        private void AddForce(int number, int health, int damage)
        {
            for (int i = 0; i < number; i++)
            {
                Health += health;
                Damage += damage;
            }
        }

        public void GetDamage(int damage)
        {
            Health -= damage;
        }
    }

    class Force
    {
        public Unit GetTank()
        {
            Unit unit = new Unit(250, 25);
            return unit;
        }

        public Unit GetPlane()
        {
            Unit unit = new Unit(150, 50);
            return unit;
        }

        public Unit GetSoldier()
        {
            Unit unit = new Unit(25, 5);
            return unit;
        }
    }

    class Unit
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }

        public Unit(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
    }
}
