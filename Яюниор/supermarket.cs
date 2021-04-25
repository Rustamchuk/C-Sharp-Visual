using System;
using System.Collections.Generic;
using System.Text;

namespace Яюниор
{
    class Program
    {
        static void Main(string[] args)
        {
            Product bread = new Product("bread", 250);
            Product butter = new Product("butter", 100);
            Product cheese = new Product("cheese", 200);
            Product chicken = new Product("chicken", 500);
            Product soda = new Product("soda", 70);
            Product milk = new Product("milk", 120);
            Product meet = new Product("meet", 600);
            Product water = new Product("water", 90);
            Product sweets = new Product("sweets", 300);

            List<Product> rustamBuy = new List<Product> { bread, butter, milk };
            List<Product> sinarBuy = new List<Product> { sweets, meet, cheese };
            List<Product> davidBuy = new List<Product> { chicken, soda, water };
            List<Product> polinaBuy = new List<Product> { bread, meet, water, sweets, cheese, soda, milk };

            Visitor rustam = new Visitor("Rustam", 1000, rustamBuy);
            Visitor sinar = new Visitor("Sinar", 600, sinarBuy);
            Visitor david = new Visitor("David", 500, davidBuy);
            Visitor polina = new Visitor("Polina", 1000, polinaBuy);

            List<Visitor> visitors = new List<Visitor> { rustam, sinar, david, polina };

            Supermarket work = new Supermarket(visitors);
            work.ServeVisitors();
        }
    }
    
    class Supermarket
    {
        private Queue<Visitor> _queue = new Queue<Visitor>();

        public Supermarket(List<Visitor> visitors)
        {
            foreach (Visitor visitor in visitors)
            {
                _queue.Enqueue(visitor);
            }
        }

        public void ServeVisitors()
        {
            Visitor visitor;

            while (_queue.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Кассир ты тут?");
                Console.ReadKey();

                visitor = _queue.Dequeue();

                visitor.ShowMoney();
                visitor.ShowCheck();
                visitor.Pay();

                Console.ReadKey();
            }
        }
    }

    class Visitor
    {
        public int Money { get; private set; }
        public string Name { get; private set; }
        private List<Product> _products;
        public int Count { get; private set; }
        private int _moneyForPay;

        public Visitor(string name, int money, List<Product> products)
        {
            Name = name;
            Money = money;
            _products = products;
            Count = _products.Count;
        }

        public void Pay()
        {
            while (true)
            {
                if (_moneyForPay <= Money)
                {
                    Money -= _moneyForPay;

                    Console.WriteLine($"\n{Name} должен {_moneyForPay} рублей\n");
                    Console.WriteLine($"У него осталось {Money}\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{Name} не имеет столько рублей!\n");

                    DeleteProduct();

                    ShowCheck();
                }
            }
        }

        public void ShowCheck()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(_products[i].Name + " ");
                _moneyForPay += _products[i].Cost;
            }
            Console.WriteLine("- " + _moneyForPay);
        }

        private void DeleteProduct()
        {
            Random rand = new Random();
            int productForTrash = rand.Next(0, Count);

            Console.WriteLine($"Был удален {_products[productForTrash].Name}\n\n");
            Count--;
            _products.RemoveAt(productForTrash);
            _moneyForPay = 0;
        }

        public void ShowMoney()
        {
            Console.WriteLine($"\n\n{Name} имеет {Money} рублей\n\n");
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
