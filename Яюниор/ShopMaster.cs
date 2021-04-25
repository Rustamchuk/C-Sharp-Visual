using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class ShopMaster
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЗДРАВСТВУЙ МОЙ ДРУГ!");
            Console.WriteLine("Что ж ты зашел ко мне в магазин оружий, что же ты хочешь сегодня?");

            while (true)
            {
                Console.WriteLine("");
            }
        }
    }

    class Visitor
    {

    }

    class Product
    {
        public string Name; 
        public int Cost;

        public Product(string name, int money)
        {
            Name = name;
            Cost = money;
        }
    }
}
