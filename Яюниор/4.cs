using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _4
    {
        static void Main4(string[] args)
        {
            string name;
            string age;
            string sex;
            string children;
            string money;
            string zodiac;
            string job;
            Console.Write("Ваше имя ");
            name = Console.ReadLine();
            Console.Write("Ваш возраст ");
            age = Console.ReadLine();
            Console.Write("Ваш пол ");
            sex = Console.ReadLine();
            Console.Write("У вас детей ");
            children = Console.ReadLine();
            Console.Write("Ваш заработок составляет ");
            money = Console.ReadLine();
            Console.Write("Ваш знак зодиака ");
            zodiac = Console.ReadLine();
            Console.Write("Вы работаете ");
            job = Console.ReadLine();

            Console.WriteLine("Итак после завершения анкеты, мы с радостью приветсвуем вас в нашем клубе!" +
                " Вот что мы получили:" +
                "Вы " + name + ", " + age + " лет. Вы " + sex + ", у вас " + children + " детей. " +
                "Знак ваш " + zodiac + ", работаете вы " + job + " с зарплатой " + money + " монет." +
                "Спасибо, что выбрали нашу компанию, удачи в работе!");

        }
    }
}
