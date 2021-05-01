using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class GamersDataBase
    {
        static void Main(string[] args)
        {
            GamersData gamerDataBase = new GamersData();
            int level;
            int number = 1;
            string nick;
            int place = 0;

            bool working = true;
            while (working)
            {
                Console.WriteLine("1 - Add\n2 - Ban\n3 - Unlock\n4 - Show\n5 - kick\n\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Parts for new gamer - name, level");

                        nick = Console.ReadLine();
                        Int32.TryParse(Console.ReadLine(), out level);

                        Gamer gamer = new Gamer(number++, nick, level);
                        gamerDataBase.AddGamer(gamer);
                        break;
                    case "2":
                        place = GetPlace();
                        gamerDataBase.BanGamer(place);

                        Console.WriteLine();
                        break;
                    case "3":
                        place = GetPlace();
                        gamerDataBase.UnlockGamer(place);

                        Console.WriteLine();
                        break;
                    case "4":
                        gamerDataBase.ShowGamers();
                        break;
                    case "5":
                        place = GetPlace();
                        gamerDataBase.KickGamer(place);

                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("\n\n");
            }
        }

        static int GetPlace()
        {
            int place;
            Console.Write("Number - ");

            Int32.TryParse(Console.ReadLine(), out place);
            return place;
        }
    }

    class GamersData
    {
        private List<Gamer> _gamerList = new List<Gamer>();
        private int _position;

        public void AddGamer(Gamer gamer)
        {
            _gamerList.Add(gamer);
        }

        public void BanGamer(int number)
        {
            _position = FindNumber(number);
            _gamerList[_position].Ban();
        }

        public void UnlockGamer(int number)
        {
            _position = FindNumber(number);
            _gamerList[_position].Unban();
        }

        public void KickGamer(int number)
        {
            _position = FindNumber(number);
            _gamerList.Remove(_gamerList[_position]);
        }

        public void ShowGamers()
        {
            foreach (var gamer in _gamerList)
            {
                Console.WriteLine($"{gamer.Number}-{gamer.Nick}-{gamer.Level} Level-status {gamer.Legal}");
            }
        }

        private int FindNumber(int number)
        {
            for (int i = 0; i < _gamerList.Count; i++)
            {
                if (_gamerList[i].Number == number)
                    return i;
            }
            return 0;
        }
    }

    class Gamer
    {
        public int Number { get; private set; }
        public string Nick { get; private set; }
        public int Level { get; private set; }
        public bool Legal { get; private set; }

        public Gamer(int number, string nick, int level)
        {
            Number = number;
            Nick = nick;
            Level = level;
            Legal = true;
        }

        public void Ban()
        {
            Legal = false;
        }
        
        public void Unban()
        {
            Legal = true;
        }
    }
}
