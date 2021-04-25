using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class цикл
    {
        static void Main(string[] args)
        {
            string userAnswer = "start";

            while (userAnswer != "exit")
            {
                Console.WriteLine("Write word please. Write 'exit' for stop");
                userAnswer = Console.ReadLine();
                Console.WriteLine("Your word is " + userAnswer + " with " + userAnswer.Length + " symbols");
            }
        }
    }
}
