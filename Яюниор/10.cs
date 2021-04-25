using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _10
    {
        static void Main10(string[] args)
        {
            string name;
            string simbol;
            int length;

            Console.WriteLine("Здравствуйте! Введите свое имя, чтобы мы сделали для него рамку.");
            name = Console.ReadLine();
            length = name.Length;
            Console.WriteLine("Введите символ, из которого будет состоять рамка.");
            simbol = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i <= (length + 2); i++)
            {
                Console.Write(simbol);
            }
            Console.WriteLine(" ");
            Console.Write(simbol);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(simbol);
            for (int i = 0; i <= (length + 2); i++)
            {
                Console.Write(simbol);
            }
        }
    }
}
