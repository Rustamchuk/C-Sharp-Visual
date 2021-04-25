using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _6
    {
        static void Main6(string[] args)
        {
            float rub;
            float euro;
            float dollar;
            int moneyCount;
            int rubToDollar = 70;
            int rubToEuro = 80;
            int dollarToEuro = 2;
            string continueAnswer ="да";
            string operationNumber;
                Console.WriteLine("Добро пожаловать! Здесь вы можете обменять рубли, доллары и евро.");
                Console.WriteLine("1 доллар = 70 рублей");
                Console.WriteLine("1 евро = 80 рублей");
                Console.WriteLine("1 увро = 2 доллара");
                Console.WriteLine("Введите количество");
                Console.Write("Рублей:");
                rub = Convert.ToInt32(Console.ReadLine());
                Console.Write("Долларов:");
                dollar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Евро:");
                euro = Convert.ToInt32(Console.ReadLine());
                while (continueAnswer != "нет")
                {
                Console.WriteLine("1 - обменять рубли на доллары.");
                Console.WriteLine("2 - обменять рубли на евро.");
                Console.WriteLine("3 - обменять евро на доллары.");
                Console.WriteLine("4 - обменять доллары на евро.");
                Console.WriteLine("5 - обменять доллары на рубли.");
                Console.WriteLine("6 - обменять евро на рубли.");
                Console.Write("Введите номер операции:");
                operationNumber = Console.ReadLine();
                switch (operationNumber)
                {
                    case "1":
                        Console.WriteLine("Обмен рублей на доллары.");
                        Console.WriteLine("Сколько рублей хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (rub >= moneyCount)
                        {
                            rub -= moneyCount;
                            dollar += moneyCount / rubToDollar;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Обмен рублей на евро.");
                        Console.WriteLine("Сколько рублей хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (rub >= moneyCount)
                        {
                            rub -= moneyCount;
                            euro += moneyCount / rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Обмен евро на доллары.");
                        Console.WriteLine("Сколько евро хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (euro >= moneyCount)
                        {
                            euro -= moneyCount;
                            dollar += moneyCount * dollarToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Обмен долларов на евро.");
                        Console.WriteLine("Сколько долларов хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (dollar >= moneyCount)
                        {
                            dollar -= moneyCount;
                            euro += moneyCount / dollarToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Обмен долларов на рубли.");
                        Console.WriteLine("Сколько долларов хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (dollar >= moneyCount)
                        {
                            dollar -= moneyCount;
                            rub += moneyCount * rubToDollar;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Обмен евро на рубли.");
                        Console.WriteLine("Сколько евро хотите обменять?");
                        moneyCount = Convert.ToInt32(Console.ReadLine());
                        if (euro >= moneyCount)
                        {
                            euro -= moneyCount;
                            rub += moneyCount * rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько денег.");
                        }
                        break;
                }
                Console.WriteLine("Ваш баланс: " + rub + " рублей, " + dollar + " долларов, " + euro + " евро.");

                Console.WriteLine("Вы хотите еще что-нибудь обменять?");
                continueAnswer = Console.ReadLine();
            }
            Console.WriteLine("Спасибо, приходите снова!");
        }
    }
}
