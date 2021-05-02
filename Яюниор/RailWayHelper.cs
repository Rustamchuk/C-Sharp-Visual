using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class RailWayHelper
    {
        static void Main(string[] args)
        {
            Carriage carriage = new Carriage(10);
            bool open = true;

            while (open)
            {
                Console.WriteLine("Write start and target points");

                WayController wayController = new WayController(Console.ReadLine(), Console.ReadLine(), carriage);

                wayController.FillTrain();
                wayController.ShowInformation();

                Console.WriteLine("Click to send train");
                
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class WayController
    {
        private List<Carriage> _carriages = new List<Carriage>();
        private int _passengers;
        private int _distribution;
        private string _start;
        private string _target;
        private Random _random = new Random();
        private Carriage _carriageKind;
        private int _carriageCount;
        private int _cursorX;
        private int _cursorY;
        
        public WayController(string start, string target, Carriage carriage)
        {
            _start = start;
            _target = target;
            _carriageKind = carriage;
        }

        public void FillTrain()
        {
            _passengers = _random.Next(1, 81);

            if (_passengers % _carriageKind.Capacity == 0)
                _carriageCount = _passengers / _carriageKind.Capacity;
            else
                _carriageCount = _passengers / _carriageKind.Capacity + 1;

            for (int i = 0; i < _carriageCount; i++)
            {
                Carriage carriage = new Carriage(_carriageKind.Capacity);
                _carriages.Add(carriage);
            }

            _distribution = _passengers;
            
            foreach (var carriage in _carriages)
            {
                if (carriage.Capacity <= _distribution)
                {
                    carriage.Fill(carriage.Capacity);
                    _distribution -= carriage.Capacity;
                }
                else
                {
                    carriage.Fill(_distribution);
                    _distribution = 0;
                }
            }
        }

        public void ShowInformation()
        {
            _cursorX = Console.CursorLeft;
            _cursorY = Console.CursorTop + 2;

            Console.SetCursorPosition(100, 0);
            Console.WriteLine($"{_start}-{_target}");

            Console.SetCursorPosition(100, 1);
            Console.WriteLine($"Passengers - {_passengers}");

            Console.SetCursorPosition(100, 2);
            foreach (var carriage in _carriages)
            {
                carriage.Draw();
                Console.SetCursorPosition(Console.CursorLeft - 12, 2);
            }
            Console.WriteLine();

            Console.SetCursorPosition(_cursorX, _cursorY);
        }
    } 

    class Carriage
    {
        public int Capacity { get; private set; }
        public int Passengers { get; private set; }
        private List<string> _carriage;
        private int _cursorX;

        public Carriage(int capacity)
        {
            Capacity = capacity;
        }

        public void Fill(int passengers)
        {
            Passengers = passengers;
            _carriage = new List<string>
            {
                "____________\n",
                $"|    {Passengers}    |\n",
                "-----------"
            };
        }

        public void Draw()
        {
            _cursorX = Console.CursorLeft;

            foreach (var part in _carriage)
            {
                Console.Write(part);
                Console.CursorLeft = _cursorX;
            }
        }
    }
}
