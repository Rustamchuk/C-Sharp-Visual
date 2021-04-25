using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Fight
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> special = new Dictionary<string, int> 
            { { "addHealth", 0 }, { "damage", 10 }, { "coolDown", 5 }, { "periodDamage", 3 }, { "shield", 0 }, { "myselfDamage", 0 } };
            Fighter Jon = new Fighter("Jon", 200, 25, 40, "FIRE", special);

            special = new Dictionary<string, int>{ { "addHealth", 40 }, { "damage", 40 }, { "coolDown", 6 }, { "periodDamage", 0 }, { "shield", 0 }, { "myselfDamage", 0 } };
            Fighter Nick = new Fighter("Nick", 350, 20, 35, "EATING", special);

            special = new Dictionary<string, int> { { "addHealth", 0 }, { "damage", 0 }, { "coolDown", 4 }, { "periodDamage", 0 }, { "shield", 3 }, { "myselfDamage", 0 } };
            Fighter Ron = new Fighter("Ron", 250, 20, 35, "PROTECTION", special);

            special = new Dictionary<string, int> { { "addHealth", 0 }, { "damage", 60 }, { "coolDown", 6 }, { "periodDamage", 0 }, { "shield", 0 }, { "myselfDamage", 20 } };
            Fighter Sam = new Fighter("Sam", 300, 15, 25, "DRACULA", special);

            special = new Dictionary<string, int> { { "addHealth", 100 }, { "damage", 0 }, { "coolDown", 3 }, { "periodDamage", 0 }, { "shield", 0 }, { "myselfDamage", 0 } };
            Fighter Bob = new Fighter("Bob", 250, 25, 30, "UPGRADE", special);

            Jon.ShowStats();
            Nick.ShowStats();
            Ron.ShowStats();
            Sam.ShowStats();
            Bob.ShowStats();

            List<Fighter> fighters = new List<Fighter> { Jon, Nick, Ron, Sam, Bob};

            special = new Dictionary<string, int> 
            { { "addHealth", 0 }, { "damage", 0 }, { "coolDown", 0 }, { "periodDamage", 0 }, { "shield", 0 }, { "myselfDamage", 0 } };
            Process fight = new Process();

            Console.WriteLine("Выберите первого бойца");
            Fighter first = ChooseFighter(fighters);
            Console.WriteLine("Выберите второго бойца");
            Fighter second = ChooseFighter(fighters);

            fight.Fight(first, second);
        }

        static Fighter ChooseFighter(List<Fighter> fighters)
        {
            string userAnswer;

            userAnswer = Console.ReadLine();

            for (int i = 0; i < fighters.Count; i++)
            {
                if (userAnswer == fighters[i].Name)
                {
                    return fighters[i];
                }
            }
            return null;
        }
    }

    class Fighter
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int StandartDamage { get; private set; }
        public int BigDamage { get; private set; }
        public bool CoolDownDamage { get; private set; }
        public SpecialAttack SpecialPower { get; private set; }

        public Fighter(string name, int health, int standartDamage, int bigDamage, string nameAttack, Dictionary<string, int> specialPower)
        {
            Name = name;
            Health = health;
            StandartDamage = standartDamage;
            BigDamage = bigDamage;

            SpecialPower = new SpecialAttack(nameAttack, specialPower);

            CoolDownDamage = false;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Боец - {Name}, " +
                $"здоровье - {Health}, " +
                $"обычный удар - {StandartDamage}, " +
                $"сильный удар - {BigDamage} с 1 ходом кулдауна,\n" +
                $"Специальная атака - {SpecialPower.NameAttack}:\n" +
                $"Плюс к здоровью - {SpecialPower.AddHealth}\n" +
                $"Атака противнику - {SpecialPower.Damage}\n" +
                $"Кул даун - {SpecialPower.CoolDown} ходов\n" +
                $"Время получения урона - {SpecialPower.PeriodDamage}\n" +
                $"Щит - {SpecialPower.Shield} ходов\n" +
                $"Урон себе - {SpecialPower.MyselfDamage}\n\n\n");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeCoolDawn(bool coolDown)
        {
            CoolDownDamage = coolDown;
        }

        public void TakeHealth(int health)
        {
            Health += health;
        }
    }

    class SpecialAttack
    {
        public string NameAttack { get; private set; }
        public int AddHealth { get; private set; }
        public int Damage { get; private set; }
        public int CoolDown { get; private set; }
        public int PeriodDamage { get; private set; }
        public int Shield { get; private set; }
        public int MyselfDamage { get; private set; }

        public SpecialAttack(string name, Dictionary<string, int> specialAttack)
        {
            NameAttack = name;
            AddHealth = specialAttack["addHealth"];
            Damage = specialAttack["damage"];
            CoolDown = specialAttack["coolDown"];
            PeriodDamage = specialAttack["periodDamage"];
            Shield = specialAttack["shield"];
            MyselfDamage = specialAttack["myselfDamage"];
        }
    }

    class Process
    {
        private int _motion = 0;
        private int _shield = 0;
        private int _timeDamage = 0;
        private bool _periodDamage = true;

        public void Fight(Fighter one, Fighter two)
        {
            Random attack = new Random();
            int number;
            bool isShield = true;

            Console.Clear();

            Console.WriteLine($"Бой {one.Name} против {two.Name}\n\n\n");

            while (one.Health > 0 && two.Health > 0)
            {
                number = attack.Next(1, 5);
                MakeAttack(one, two, number, ref isShield);

                number = attack.Next(1, 5);
                MakeAttack(two, one, number, ref isShield);

                System.Threading.Thread.Sleep(1000);
            }

            if (one.Health > two.Health)
            {
                Console.WriteLine("Первый победил!");
            }
            else if (one.Health < two.Health)
            {
                Console.WriteLine("Второй победил!");
            }
            else if (one.Health == two.Health)
            {
                Console.WriteLine("Ничья");
            }
        }

        private void MakeAttack(Fighter first, Fighter second, int number, ref bool isShield)
        {

            if (isShield == false)
            {
                number = 5;

                _shield--;

                isShield = true;
            }
            else if (isShield == true && _shield != 0)
            {
                isShield = false;
            }

            switch (number)
            {
                case 1:
                    second.TakeDamage(first.StandartDamage);

                    Console.WriteLine($"Обычная атака\n" +
                        $"Урон - {first.StandartDamage}\n" +
                        $"Собственное здоровье - {first.Health}\n\n");
                    break;
                case 2:
                    if (first.CoolDownDamage == true)
                    {
                        MakeAttack(first, second, 1, ref isShield);
                        first.TakeCoolDawn(false);
                    }
                    else
                    {
                        second.TakeDamage(first.BigDamage);

                        Console.WriteLine($"Мощная атака\n" +
                        $"Урон - {first.BigDamage}\n" +
                        $"Собственное здоровье - {first.Health}\n\n");

                        first.TakeCoolDawn(true);
                    }
                    break;
                case 3:
                    if (_motion == 0)
                    {
                        Console.WriteLine(first.SpecialPower.NameAttack);

                        first.TakeHealth(first.SpecialPower.AddHealth);
                        second.TakeDamage(first.SpecialPower.Damage);
                        first.TakeDamage(first.SpecialPower.MyselfDamage);

                        _timeDamage = first.SpecialPower.PeriodDamage;

                        if (first.SpecialPower.Shield != 0)
                        {
                            _shield = first.SpecialPower.Shield;
                            isShield = false;
                        }
                        _motion = first.SpecialPower.CoolDown * 2;

                        Console.WriteLine($"Урон - {first.SpecialPower.Damage}\n" +
                        $"Собственное здоровье - {first.Health}\n\n");
                    }
                    else
                    {
                        MakeAttack(first, second, 1, ref isShield);
                    }
                    break;
                case 4:
                    Console.WriteLine("Промах!\n");
                    break;
                case 5:
                    Console.WriteLine("У него щит!\n");
                    break;
            }

            if (_motion != 0)
            {
                _motion--;
            }

            if (_timeDamage != 0 && _periodDamage == false)
            {
                second.TakeDamage(first.SpecialPower.Damage);
                _timeDamage--;
                _periodDamage = true;
            }
            else if (_timeDamage != 0 && _periodDamage == true)
            {
                _periodDamage = false;
            }
        }
    }
}
