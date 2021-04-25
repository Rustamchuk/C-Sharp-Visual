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
            List<Patient> patients = new List<Patient> {
                new Patient("Ivan", 50, "cancer"),
                new Patient("Sergey", 30, "bronchitis"),
                new Patient("Vova", 70, "concussion"),
                new Patient("Sasha", 15, "tuberculosis"),
                new Patient("Ron", 40, "bronchitis"),
                new Patient("Dima", 22, "concussion"),
                new Patient("Leonid", 44, "bronchitis"),
                new Patient("Bob", 80, "concussion"),
                new Patient("Vitya", 65, "cancer"),
                new Patient("Senya", 47, "tuberculosis") };

            while (true)
            {
                Console.WriteLine("1 - отсортировать по имени\n" +
                    "2 - отсортировать по возрасту\n" +
                    "3 - найти по болезни");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        var filtered1 = patients.OrderBy(patient => patient.Name);
                        foreach (var patient in filtered1)
                        {
                            Console.WriteLine(patient.Name + " " + patient.Ill + " " + patient.Age);
                        }
                        break;
                    case 2:
                        var filtered2 = patients.OrderBy(patient => patient.Age);
                        foreach (var patient in filtered2)
                            Console.WriteLine(patient.Name + " " + patient.Ill + " " + patient.Age);
                        break;
                    case 3:
                        Console.WriteLine("Введите болезнь");

                        string userAnswer = Console.ReadLine();
                        var filtered3 = patients.Where(patient => patient.Ill == userAnswer);
                        foreach (var patient in filtered3)
                            Console.WriteLine(patient.Name + " " + patient.Ill + " " + patient.Age);
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class Patient
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Ill { get; private set; }

        public Patient(string name, int age, string ill)
        {
            Name = name;
            Age = age;
            Ill = ill;
        }
    }
}
