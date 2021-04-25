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
            List<Criminal> criminals = new List<Criminal> 
            { new Criminal(true, "Nazarov Rustam R.", "Russian", 185, 85), new Criminal(false, "Kataev Deni Y.", "Russian", 140, 45),
             new Criminal(false, "Popkin Vanya V.", "Chinese", 165, 100), new Criminal(false, "Makarov Sasha A.", "Russian", 185, 85),
             new Criminal(true, "Kondrashkin Alexey L.", "Chinese", 170, 65), new Criminal(true, "Dryagina Polina D.", "American", 200, 85),
             new Criminal(false, "Vovkin Vova V.", "American", 200, 45), new Criminal(false, "Belov Danil D.", "Japanese", 190, 75),
             new Criminal(false, "Nazarov Nazar N.", "Japanese", 160, 90), new Criminal(false, "Putilov David S.", "Russian", 185, 90),};

            string userAnswer;
            string name = "";
            string nationality = "";
            int length = 0;
            int weight = 0;
            
            Console.Write("Name - ");
            userAnswer = Console.ReadLine();
            if (userAnswer != "")
                name = userAnswer;

            Console.Write("\nNationality - ");
            userAnswer = Console.ReadLine();
            if (userAnswer != "")
                nationality = userAnswer;

            Console.Write("\nLength - ");
            userAnswer = Console.ReadLine();
            if (userAnswer != "")
                length = Convert.ToInt32(userAnswer);

            Console.Write("\nWeight - ");
            userAnswer = Console.ReadLine();
            if (userAnswer != "")
                weight = Convert.ToInt32(userAnswer);

            var filteredCriminals = criminals.Where(criminal => criminal.IsPrisoner == false 
            && criminal.Name.Contains(name) 
            && criminal.Nationality.StartsWith(nationality) 
            && (criminal.Length - length == 0 || criminal.Length - length == criminal.Length) 
            && (criminal.Weight - weight == 0 || criminal.Weight - weight == criminal.Weight));

            foreach (var criminal in filteredCriminals)
            {
                Console.WriteLine($"{criminal.Name} - {criminal.Nationality} - {criminal.Length} - {criminal.Weight}");
            }
        }
    }

    class Criminal
    {
        public bool IsPrisoner { get; private set; }
        public string Name { get; private set; }
        public string Nationality { get; private set; }
        public int Length { get; private set; }
        public int Weight { get; private set; }

        public Criminal(bool isprisoner, string name, string nationality, int length, int weight)
        {
            IsPrisoner = isprisoner;
            Name = name;
            Nationality = nationality;
            Length = length;
            Weight = weight;
        }
    }
}
