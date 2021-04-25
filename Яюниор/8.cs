using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _8
    {
        static void Main8(string[] args)
        {
            string rightPassword;
            string falsePassword;
            int chance = 1;
            int command;
            Console.Write("Здравствуйте, для продолжения вам необходимо зарегистрироваться. Придумайте пароль:");
            rightPassword = Console.ReadLine();
            Console.WriteLine("Мы рады приветствовать вас в нашей фирме, нажмите '1' для входа в личный кабинет.");
            command = Convert.ToInt32(Console.ReadLine());
            if (command == 1)
            {
                while (chance <= 3)
                {
                    Console.Write("Введите пароль:");
                    falsePassword = Console.ReadLine();
                    if (rightPassword == falsePassword)
                    {
                        Console.WriteLine("Добро пожаловать в личный кабинет. Ваш счет составляет 9.999.999 миллионов $, хотите их обналичить?");
                        chance += 4;
                    }
                    else
                    {
                        chance++;
                    }
                    if (chance == 4)
                    {
                        Console.WriteLine("Ваши попытки иссякли, мы вынуждены попросить вас уйти.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Такой комманды нет.");
            }
        }   
    }
}
