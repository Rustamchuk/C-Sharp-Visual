using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _9
    {
        static void Main9(string[] args)
        {
            int bossHealth = 50000;
            int bossDamage = 300; //после потери половины хп атака удвоется
            int heroHealth = 5000;
            int heroArmour = 50;
            int halatir = 100; //призыв магичееской птицы
            int avinyatar = 3000; //дополнительная усиленная атака птиц
            int scarlanta = 1000; //великий дождь эльфов восстанавливает вас и атакует врага  можно использовать раз в 3 хода
            int formansil = 8000; //сильнейшая атака северное сияние луч поражающий все но герой теряет 150
            int magicBird = 0;
            int coolDown = 0;
            int penalty = 150;
            int harakiri = 5000;
            string userInput;
            int move = 1;

            Console.WriteLine("Ваш разведчик вернулся с миссии.\n" +
                "-Вот вы и добрались до Акхаломэ - последнего Босса этого подземелья!\n" +
                "Я смог разузнать его характеристики:\n" +
                "здоровье - 50000\n" +
                "атака - 300\n" +
                "Это будет нелегкий бой! Итак, напомню ваши характеристики:\n" +
                "здоровье - 5000\n" +
                "броня - 50\n" +
                "Халатир(призаыв 2 птиц, максимум 10) - по 50 урона (команда - 1)\n" +
                "Эвиньятар(дополнительная усиленная атака птиц, после чего они умирают) - по 3000 урона (команда - 2)\n" +
                "Скарланта(Забытое заклинание - Великий дождь эльфов) - 1000 урона +1000 здоровья (раз в 3 хода)(команда - 3)\n" +
                "Формансиль(великое северное сияние) - 8000 урона (-150 здоровья) (команда - 4)\n" +
                "Харакири - -5000 здоровья (команда - 5)\n" +
                "Что ж я верю, у вас, сильнейшего мага всех эльфов, получится защитить наши земли!\n" +
                "Дальше я не пойду, если вы все запомнили и готовы идти скажите 'да'");
            userInput = Console.ReadLine();
            if (userInput == "да")
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine("У вас нет другого выбора!");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("*инструкция*\n" +
                "!когда у Акхаломэ будет менье 30000 здоровье его атака начнет удваиваться!" +
                "Для атаки вводите номер команды.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("AХАХАХАХАХАХАХА ВОТ ТЫ И ЗДЕСЬ МЕЛКИЙ ЭЛЬФ!\n" +
                "Я, ВЕЛИКИЙ АКХАЛОМЭ, СЕЙЧАС СРАВНЯЮ ТЕБЯ С ЗЕМЛЕЙ И ПОТОМ НАКОНЕЦ УНИЧТОЖУ ВСЮ ВАШУ РАСУ!\n" +
                "НАЧНЕМ ЖЕ НАШУ БИТВУ!");
            while(bossHealth >= 0 && heroHealth >= 0)
            {
                if (bossHealth < 30000)
                {
                    bossDamage *= 2;
                    string[] speech = { "ТЕБЕ КОНЕЕЦ!", "НУ ВСЕ ТЕПЕРЬ Я РАЗОЗЛИЛСЯ!", "ПРИШЛО ВРЕМЯ УМИРАТЬ!", "БЫЛО ВЕСЕЛО, А ТЕПЕРЬ Я ТЕБЯ УБЬЮ!",
                        "СМЕРТЬ!СМЕРТЬ!СМЕЕЕЕЕРТЬ!", "ХВАТИТ СОПРОТИВЛЯТЬСЯ!"};
                    Console.WriteLine(speech[new Random().Next(0, speech.Length)]);
                }
                heroHealth -= bossDamage/100 * heroArmour;
                Console.WriteLine("Ваше здоровье - " + heroHealth + " единиц.");
                Convert.ToInt32(userInput = Console.ReadLine());
                if (bossHealth >= 30000)
                {
                    string[] speach2 = { "БЫЛО ВЕСЕЛО, НО СЕЙЧАС Я ТЕБЯ УБЬЮ", "ВЫ ЭЛЬФЫ ТАКИЕ УПОРНЫЕ", "А У ТЕБЯ ИНТЕРЕСНЫЕ ПРИЕМЫ",
                        "ИЗ-ЗА ТЕБЯ МНОГО МОИХ ВОЙНОВ ПАЛО", "НУ ЧТО? ДУМАЮ ПОРА С ТОБОЙ КОНЧАТЬ", "ЭТИ МУХИ ТЕБЕ НЕ ПОМОГУТ!"};
                    Console.WriteLine(speach2[new Random().Next(0, speach2.Length)]);
                }
                switch (userInput)
                {
                    case "1":
                        bossHealth -= halatir;
                        magicBird += 2;
                        if (magicBird > 10)
                        {
                            magicBird = 10;
                        }
                        coolDown += 1;
                        Console.WriteLine("У вас - " + magicBird + " птиц");
                        break;
                    case "2":
                        bossHealth -= avinyatar * magicBird;
                        magicBird = 0;
                        coolDown += 1;
                        break;
                    case "3":
                        if (coolDown >= 3)
                        {
                            bossHealth -= scarlanta;
                            heroHealth += scarlanta;
                            coolDown = 0;
                        }
                        break;
                    case "4":
                        bossHealth -= formansil;
                        heroHealth -= penalty;
                        coolDown += 1;
                        break;
                    case "5":
                        heroHealth -= harakiri;
                        coolDown += 1;
                        break;
                }
                Console.WriteLine("здоровье Акхаломэ - " + bossHealth + " единиц");
                Console.WriteLine("ход " + (move++));
            }
            if (bossHealth <= 0 && heroHealth <= 0)
            {
                Console.WriteLine("Вы спасли всех эльфов, но к своей семье вы вернуться уже не сможете");
            }
            else if (bossHealth > heroHealth)
            {
                Console.WriteLine("АХАХАХАХАХАХА ЗНАТНО ТЫ МЕНЯ ПОВЕСЕЛИЛ, А ТЕПЕРЬ ПОЙДУ УНИЧТОЖАТЬ ЭЛЬФОВ");
            }
            else if (bossHealth < heroHealth)
            {
                Console.WriteLine("Вы спасли всех эльфов! Теперь вы можете вернуться к своей семье.");
            }
        }
    }
}
