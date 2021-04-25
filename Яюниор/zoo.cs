using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            zoo.Welcome();
        }
    }

    class Zoo
    {
        private List<Cage> _cages = new List<Cage> {
            new Cage(10, "wolf"),
            new Cage(3, "tiger"),
            new Cage(5, "elephant"),
            new Cage(30, "monkey"),
            new Cage(20, "cow")};

        public void Welcome()
        {
            Boy boy = new Boy();
            string userAnswer;

            while (true)
            {
                Console.WriteLine("Hello, welcome to our zoo!");

                for (int i = 0; i < _cages.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - go to {_cages[i].CageName}");
                }
                Console.WriteLine("'exit' - exit");

                userAnswer = Console.ReadLine();

                if (userAnswer == "exit")
                    break;

                boy.VisitZoo(_cages[Convert.ToInt32(userAnswer) - 1]);
            }
        }
    }

    class Cage
    {
        private int _number;
        public string CageName { get; private set; }
        private string _nameAnimal = "";
        private string _voice = "";

        public Cage(int number, string cageName)
        {
            CageName = cageName;
            _number = number;
            
            switch (cageName)
            {
                case "wolf":
                    Wolf wolf = new Wolf();
                    _nameAnimal = wolf.GetName();
                    _voice = wolf.GetVoice();
                    break;
                case "tiger":
                    Tiger tiger = new Tiger();
                    _nameAnimal = tiger.GetName();
                    _voice = tiger.GetVoice();
                    break;
                case "elephant":
                    Elephant elephant = new Elephant();
                    _nameAnimal = elephant.GetName();
                    _voice = elephant.GetVoice();
                    break;
                case "monkey":
                    Monkey monkey = new Monkey();
                    _nameAnimal = monkey.GetName();
                    _voice = monkey.GetVoice();
                    break;
                case "cow":
                    Cow cow = new Cow();
                    _nameAnimal = cow.GetName();
                    _voice = cow.GetVoice();
                    break;
            }
        }

        public void VisitAnimal()
        {
            Console.WriteLine($"It is a {_nameAnimal} and there are {_number} animals like him\n" +
                $"Soo that's all, if you want go away klick botton");
            Console.ReadKey();
            Console.WriteLine($"Goodbye! {_voice}");
            Console.ReadKey();
            
            Console.Clear();
        }
    }

    abstract class Animal
    {
        protected string Name;
        protected string Voice;

        public string GetName()
        {
            return Name;
        }

        public string GetVoice()
        {
            return $"{Voice}-{Voice}-{Voice}";
        }
    }

    class Wolf : Animal
    {
        public Wolf()
        {
            Name = "wolf";
            Voice = "woof";
        }
    }

    class Tiger : Animal
    {
        public Tiger()
        {
            Name = "tiger";
            Voice = "rrrr";
        }
    }

    class Elephant : Animal
    {
        public Elephant()
        {
            Name = "elephant";
            Voice = "tooth";
        }
    }

    class Monkey : Animal
    {
        public Monkey()
        {
            Name = "monkey";
            Voice = "eee";
        }
    }

    class Cow : Animal
    {
        public Cow()
        {
            Name = "cow";
            Voice = "moo";
        }
    }

    class Boy
    {
        public void VisitZoo(Cage animal)
        {
            Console.Clear();

            Console.WriteLine("Oh there are too many people! Because this animal is very unusual and interesting\n\n" +
                "We should wait a little");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("A little more");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("A little more again");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("And a little more again\n\n");
            System.Threading.Thread.Sleep(2000);

            Console.Clear();

            animal.VisitAnimal();
        }
    }
}
