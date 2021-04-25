using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class _3
    {
        static void Main2(string[] args)
        {
            int cristalPrice = 50;
            int goldCount;
            int cristalCount;
            bool enoughGold;

            Console.WriteLine("Приветствуем тебя в нашем заведении! Сегодня кристаллы стоят по 50 монет.");
            Console.WriteLine("Сколько у тебя золота?");
            goldCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько ты хочешь сегодня купить?");
            cristalCount = Convert.ToInt32(Console.ReadLine());

            enoughGold = goldCount >= cristalCount * cristalPrice;

            cristalCount *= Convert.ToInt32(enoughGold);
            goldCount -= cristalCount * cristalPrice;
            Console.WriteLine("Хэй вот тебе " + cristalCount + " кристалла, правда у тебя осталось всего " + goldCount + " золота");

        }
    }
}
