using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class HealthBar
    {
        static void Main(string[] args)
        {
            string health = "100%";
            string mana = "100%";

            Console.WriteLine("Введите максимальное значение");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            bool isPlaying = true;

            while (isPlaying)
            {
                ShowBar(health, 0, ConsoleColor.Red, maxValue);
                ShowBar(mana, 1, ConsoleColor.Blue, maxValue);

                Console.SetCursorPosition(0, 7);

                Console.WriteLine("Введите сколько процентов от шкалы жизней останется");
                health =  Console.ReadLine();
                Console.WriteLine("Введите сколько процентов от шкалы магии останется");
                mana = Console.ReadLine();

                Console.WriteLine("\n\n\n\n\n\n\n\nДля остановки напишите - stop");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "stop")
                    isPlaying = false;

                if (!health.Contains("%"))
                {
                    health += "%";
                }

                if (!mana.Contains("%"))
                {
                    mana += "%";
                }

                Console.Clear();
            }
        }

        static void ShowBar (string extraValue, int y, ConsoleColor color, float max)
        {
            float value = Convert.ToInt32(extraValue[..(extraValue.Length - 1)]);
            value *= 0.01f;

            if (value > 1)
                value = 1;

            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.SetCursorPosition(0, y);
            
            Console.Write("[");

            Console.BackgroundColor = color;
            for (int i = 0; i < max * value; i++)
            {
                Console.Write("#");
            }
            for (int i = 0; i < max - max * value; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = defaultColor;

            Console.WriteLine("]");
        }
    }
}
