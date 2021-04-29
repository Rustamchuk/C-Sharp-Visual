using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class FixCar
    {
        static void Main(string[] args)
        {
            DamageKind engine = new DamageKind("engine");
            DamageKind wheel = new DamageKind("wheel");
            DamageKind window = new DamageKind("window");
            DamageKind lamp = new DamageKind("lamp");
            DamageKind chair = new DamageKind("chair");
            List<DamageKind> damages = new List<DamageKind> { engine, wheel, window, lamp, chair};

            bool isopen = true;
            Random randDamage = new Random();
            CarService service = new CarService();

            while (isopen)
            {
                Car car = new Car(damages[randDamage.Next(damages.Count)]);

                car.ShowCar();

                service.WorkService(car);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class CarService
    {
        private Dictionary<string, int> _chest = new Dictionary<string, int> { { "engine", 40000}, { "wheel", 20000}, { "window", 30000}, { "lamp", 15000}, { "chair", 10000 } };
        private int _money = 150000;
        private bool _isOpen = true;
        
        public void WorkService(Car car)
        {
            if (_money <= 0 || _isOpen == false)
            {
                Console.WriteLine("No Money!");
                return;
            }

            int fine = TakeCost(car);
            int reward = TakeCost(car) * 2;

            Console.WriteLine($"Purse - {_money}\n\n");

            if (fine == 0)
            {
                Console.WriteLine("У вас нет нужной запчасти...");
                fine = 10000;
                Console.WriteLine($"-{fine}");
                _money -= fine;
            }
            else
            {
                Console.WriteLine($"Reward - {reward}");
                Console.WriteLine($"Fine for wrong - {fine}\n");

                if (FixCar(car))
                {
                    Console.WriteLine($"+{reward}");
                    _money += reward;
                }
                else
                {
                    Console.WriteLine($"-{fine}");
                    _money -= fine;
                }
            }
        }

        private bool FixCar(Car car)
        {
            Console.WriteLine($"Write name of detail");

            foreach (var detail in _chest)
            {
                Console.Write($"-{detail.Key}-");
            }
            Console.WriteLine();

            string answer = Console.ReadLine();

            if (answer == car.CurrentDamage.Name)
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.Write(i);
                    System.Threading.Thread.Sleep(70);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(70);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(70);
                    Console.Write(".");
                    System.Threading.Thread.Sleep(70);
                }
                _chest.Remove(answer);
                Console.WriteLine("Success!");

                return true;
            }
            else
            {
                Console.WriteLine("WRONG");
                return false;
            }
        }

        private int TakeCost(Car car)
        {
            foreach (var detail in _chest)
            {
                if (detail.Key == car.CurrentDamage.Name)
                    return detail.Value;
            }
            return 0;
        }
    }

    class Car
    {
        public DamageKind CurrentDamage { get; private set; }
        private string[] _car = { 
            "        __      ",
            " ______|  |_____",
            "(______________)",
            "  (_)      (_)"
        };

        public Car(DamageKind damage)
        {
            CurrentDamage = damage;
        }

        public void ShowCar()
        {
            foreach (var detail in _car)
            {
                Console.WriteLine(detail);
            }

            Console.WriteLine($"\n!{CurrentDamage.Name}!\n");
        }
    }

    class DamageKind
    {
        public string Name { get; private set; }

        public DamageKind(string name)
        {
            Name = name;
        }
    }
}
