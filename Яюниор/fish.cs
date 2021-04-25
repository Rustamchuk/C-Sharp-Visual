using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Program
    {
        static void Main(string[] args)
        {
            Aquarium aquarium = new Aquarium();
            while (true)
            {
                aquarium.AskUser();
            }
        }
    }

    class Aquarium
    {
        private int _maxFish  = 7;
        private List<Fish> _fishes = new List<Fish>();

        public void AskUser()
        {
            ShowInfo();

            Console.WriteLine("1 - добавить рыбу\n" +
                "2 - вытащить рыбу\n" +
                "3 - ничего не делать");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    AddFish();
                    break;
                case 2:
                    Console.WriteLine("Под каким номером?");
                    DeleteFish(Convert.ToInt32(Console.ReadLine()));
                    break;
            }

            for (int i = 0; i < _fishes.Count; i++)
            {
                if (_fishes[i].ChangeAge())
                {
                    DeleteFish(i + 1);
                    i--;
                }
            }

                Console.WriteLine("\n\nНажми любую клавишу");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine();
        }

        private void AddFish()
        {
            if (_fishes.Count + 1 <= _maxFish)
            {
                Fish fish = new Fish();
                _fishes.Add(fish);
            }
            else
            {
                Console.WriteLine("Слишком много рыб!");
            }
        }

        private void DeleteFish(int number)
        {
            Console.WriteLine("Умерла рыба");
            _fishes.RemoveAt(number - 1);
        }

        private void ShowInfo()
        {
            Console.SetCursorPosition(0, 15);

            for (int i = 0; i < _fishes.Count; i++)
            {
                Console.WriteLine($"{i+1} рыба - {_fishes[i].Years} лет из {_fishes[i].MaxYears} возможных.");
            }
            Console.SetCursorPosition(0, 0);
        }
    }

    class Fish
    {
        public int MaxYears { get; private set; } = 10;
        public int Years { get; private set; } = 0;

        public bool ChangeAge()
        {
            if (Years++ >= MaxYears)
                return true;
            return false;
        }
    }
}
 