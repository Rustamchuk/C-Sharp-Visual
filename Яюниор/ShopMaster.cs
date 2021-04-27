using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class ShopMaster
    {
        static void Main(string[] args)
        {
            Product cucumber = new Product("Огурец", 200);
            Product tomato = new Product("Помидор", 150);
            Product apple = new Product("Яблоко", 250);
            Product meet = new Product("Мясо", 500);
            Product bread = new Product("Хлеб", 400);
            Product fish = new Product("Рыба", 450);
            Product sweets = new Product("Конфеты", 350);
            Product lemon = new Product("Лимон", 100);
            List<Product> products = new List<Product> { cucumber, tomato, apple, meet, bread, fish, sweets, lemon };

            int money = 1500;

            Seller seller = new Seller(products);
            Visitor visitor = new Visitor(money);

            bool buying = true;


            Console.WriteLine("ЗДРАВСТВУЙ МОЙ ДРУГ!");
            Console.WriteLine("Что ж ты зашел ко мне в магазин, что же ты хочешь сегодня?");

            while (buying)
            {
                Console.WriteLine("1 - купить что-то\n2 - показать что у тебя есть\n3 - выйти");

                switch (Console.ReadLine())
                {
                    case "1":
                        Product product = seller.Sell();

                        if (product.Cost <= visitor.Money)
                        {
                            seller.GiveProduct(product);
                            visitor.AddProduct(product);

                            if (product.Name == "Гнилой помидор")
                                Console.WriteLine("Вы где-то ошиблись, вот вам гнилой помидор");
                        }
                        else
                        {
                            Console.WriteLine("У тебя не хватает денег!");
                        }
                        break;
                    case "2":
                        visitor.ShowBag();
                        break;
                    case "3":
                        buying = false;
                        break;
                }
            }
        }
    }

    class Seller
    {
        private List<Product> _products = new List<Product>();

        public Seller(List<Product> products)
        {
            _products = products;
        }

        public Product Sell()
        {
            string visitorAnswer;

            ShowProducts();

            Console.WriteLine("Напиши назавание продукта и мы посмотрим можешь ли ты это купить");
            visitorAnswer = Console.ReadLine();

            foreach (var product in _products)
            {
                if (product.Name == visitorAnswer)
                    return product;
            }
            return new Product("Гнилой помидор", 0);
        }

        public void GiveProduct(Product product)
        {
            _products.Remove(product);
        }

        private void ShowProducts()
        {
            Console.WriteLine();

            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Name}-{product.Cost}");
            }

            Console.WriteLine();
        }
    }

    class Visitor
    {
        private List<Product> _products = new List<Product>();
        public int Money { get; private set; }

        public Visitor(int money)
        {
            Money = money;
        }

        public void AddProduct(Product product)
        {
            Money -= product.Cost;
            _products.Add(product);
        }

        public void ShowBag()
        {
            Console.WriteLine($"\n\nДеньги - {Money}\n\n");
            foreach (var product in _products)
            {
                Console.Write($"-{product.Name}-");
            }
            Console.WriteLine();
        }
    }

    class Product
    {
        public string Name { get; private set; } 
        public int Cost { get; private set; }

        public Product(string name, int money)
        {
            Name = name;
            Cost = money;
        }
    }
}
