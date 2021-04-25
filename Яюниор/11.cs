using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _11
    {
        static void Main11(string[] args)
        {
            int userInput;
            int login = 0;
            Console.WriteLine("Привет! Я буду твоим ассистентом на протяжении твоей работы!\n" +
                "Вот список доступных команд:\n" +
                "1 - Придумывание имени\n" +
                "2 - Калькулятор\n" +
                "3 - Изменение цветов\n" +
                "4 - Вход в личный кабинет\n" +
                "5 - Бой с боссом (тест на стойкость)\n" +
                "6 - Выход");
            userInput = Convert.ToInt32(Console.ReadLine());
            while (userInput != 6)
            {
                switch (Convert.ToString(userInput))
                {
                    case "1":
                        string name;
                        string simbol;
                        int length;
                        login = 1;
                        Console.Write("Итак сейчас ты придумаешь себе имя, а я сделаю ему рамку.\n" +
                            "Введи свое имя:");
                        name = Console.ReadLine();
                        Console.Write("Введи символ, из которого будет состоять рамка:");
                        simbol = Console.ReadLine();
                        length = name.Length;
                        for (int i = 0; i <= (length + 2); i++)
                        {
                            Console.Write(simbol);
                        }
                        Console.WriteLine(" ");
                        Console.Write(simbol);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(name);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine(simbol);
                        for (int i = 0; i <= (length + 2); i++)
                        {
                            Console.Write(simbol);
                        }
                        Console.WriteLine(" ");
                        break;
                    case "2":
                        float numberOne = 0;
                        float numberTwo = 0;
                        string userInput2;
                        float result = 0;
                        int degree = 1;
                        Console.WriteLine("Это калькулятор, здесь ты можешь складывать, вычитать, умножать, делить и возводить в степень.\n" +
                            "Введите знак: " +
                            "+, -, *, /, ^");
                        userInput2 = Console.ReadLine();
                        if (userInput2 != "^") 
                        {
                            Console.WriteLine("Введи первое число: ");
                            numberOne = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введи второе число: ");
                            numberTwo = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Введи число: ");
                            numberOne = Convert.ToInt32(Console.ReadLine());
                        }
                        switch (userInput2)
                        {
                            case "+":
                                result = numberOne + numberTwo;
                                break;
                            case "-":
                                result = numberOne - numberTwo;
                                break;
                            case "*":
                                result = numberOne * numberTwo;
                                break;
                            case "/":
                                result = numberOne / numberTwo;
                                break;
                            case "^":
                                Console.WriteLine("Введи степень, в которую хочешь возвести число: ");
                                degree = Convert.ToInt32(Console.ReadLine());
                                result += numberOne;
                                for (int n = 1; n < degree; n++)
                                {
                                    result *= numberOne;
                                }
                                break;
                        }
                        Console.WriteLine("Ответ: " + result);
                        break;
                    case "3":
                        string topic;
                        string text;
                        while (true)
                        {
                            Console.Write("Сейчас мы будем менять цвета шрифта и фона\n" +
                                "Давай начнем с фона, введи цвет(желтый, зеленый, красный, синий, белый, пурпурный, черный): ");
                            topic = Console.ReadLine();
                            if (topic == "желтый")
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                break;
                            }
                            else if (topic == "зеленый")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            }
                            else if (topic == "красный")
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                break;
                            }
                            else if (topic == "синий")
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                break;
                            }
                            else if (topic == "белый")
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            }
                            else if (topic == "пурпурный")
                            {
                                Console.BackgroundColor = ConsoleColor.Magenta;
                                break;
                            }
                            else if (topic == "черный")
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Нет такого цвета я не знаю.");
                            }
                        }
                        while (true)
                        {
                            Console.Write("Теперь займемся шрифтом, введите цвет(желтый, зеленый, красный, сииний, белый, пурпурный, черный): ");
                            text = Console.ReadLine();
                            if (text == "желтый")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            }
                            else if (text == "зеленый")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            }
                            else if (text == "красный")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            }
                            else if (text == "синий")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            }
                            else if (text == "белый")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else if (text == "пурпурный")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            }
                            else if (text == "черный")
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Нет такого цвета я не знаю.");
                            }
                        }
                        break;
                    case "4":
                        string password;
                        string chance;
                        string nickName;
                        if (login == 0)
                        {
                            Console.WriteLine("Нет, сначала придумайте имя.");
                            userInput = 1;
                        }
                        else
                        {
                            while (true)
                            {
                                Console.Write("Что-то я подзабыл, напомни свое имя из 1 команды пожалуйста: ");
                                name = Console.ReadLine();
                                Console.Write("Давай придумаем пароль: ");
                                password = Console.ReadLine();
                                Console.Write("Еще раз, пожалуйста: ");
                                chance = Console.ReadLine();
                                if (password == chance)
                                {
                                    Console.Clear();
                                    while (true)
                                    {
                                        Console.Write("Итак, все почти сделано, теперь зайди в свой личный кабинет.\n" +
                                            "Введи свое имя: ");
                                        nickName = Console.ReadLine();
                                        Console.Write("Теперь пароль: ");
                                        chance = Console.ReadLine();
                                        if (nickName == name && chance == password)
                                        {
                                            Console.WriteLine("Вход разрешен, ваш счет составляет 10 копеек.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("НЕПРАВИЛЬНО! КТО ТЫ ТАКОЙ?\n" +
                                                "Ладно, дам вам еще шанс...");
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Хмм, что-то не сходятся...");
                                }
                            }
                        }
                        break;
                    case "5":
                        int heroHealth = 150;
                        int bossHealth = 1000000000;
                        int fireBall = 80;
                        int scarlanta = 50;
                        int shild = 1;
                        int move = 0;
                        string userInput3;
                        string[] speach = { "Атакуй!", "Быстрее!Быстрее!", "От тебя зависит судьба жителей!", "Давай, я верю в тебя", "У тебя все получится!" };
                        string[] bossSpeach = { "И это все, щекотно не более", "Тут я даже ничего не почувствовал", "Если те до сих пор думаешь, что сможешь меня победить, то ты очень ошибаешься" };
                        Console.WriteLine("На нас надвигается король демонов!\n" +
                            "Убить его ты не сможешь.\n" +
                            "Но, чтобы жители успели спастись, сражайся до конца!");
                        Console.WriteLine("У вас 150 здоровья.\n" +
                            "1 - Огненный шар - 80 урона.\n" +
                            "2 - Скарланта - +50 здоровья вам и 50 урона.\n" +
                            "3 - Непробиваемый щит - защищает от любых атак один раз за два хода.\n" +
                            "Король демонов - 1000000000000 здоровья и 99999999 урона.\n" +
                            "Приступим?");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Что? Ты хочешь сказать, что ты собираешься победить меня? Ладно, дам тебе шанс, не буду бить очень больно.");
                        while (heroHealth > 0)
                        {
                            shild++;
                            Console.WriteLine(speach[new Random().Next(0, speach.Length)]);
                            userInput3 = Console.ReadLine();
                            switch (userInput3)
                            {
                                case"1":
                                    bossHealth -= fireBall;
                                    break;
                                case "2":
                                    heroHealth += scarlanta;
                                    bossHealth -= scarlanta;
                                    break;
                                case "3":
                                    if (shild != 1)
                                    {
                                        shild = 0;
                                    }
                                        break;
                            }
                            Console.WriteLine("Здоровье босса - " + bossHealth);
                            Console.WriteLine(bossSpeach[new Random().Next(0, bossSpeach.Length)]);
                            if (shild != 0)
                            {
                                heroHealth -= new Random().Next(0, 150);
                            }
                            Console.WriteLine("У вас " + heroHealth + "здоровья");
                            move++;
                        }
                        Console.WriteLine("Ты смогли продержаться " + move + " ходов. Благодаря тебе многие смогли спастись, спасибо!");
                        break;
                }
                Console.WriteLine("Что будем делать дальше?\n" +
                    "Напомню команды:\n" +
                    "1 - Придумывание имени\n" +
                "2 - Калькулятор\n" +
                "3 - Изменение цветов\n" +
                "4 - Вход в личный кабинет\n" +
                "5 - Бой с армией гоблинов (тест на стойкость)\n" +
                "6 - Выход");
                userInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
