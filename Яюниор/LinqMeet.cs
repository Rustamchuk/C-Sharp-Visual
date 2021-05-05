using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Яюниор
{
    class LinqMeet
    {
        static void Main(string[] args)
        {
            int currentYear = DateTime.Now.Year;
            List<Product> products = new List<Product>
            {
                new Product("говядина", 2019, 2020),
                new Product("медведятина", 2020, 2021),
                new Product("курятина", 2021, 2022),
                new Product("рыба", 2010, 2011),
                new Product("утка", 2011, 2012),
                new Product("свинина", 2021, 2024),
            };

            ShowProducts(products);

            List<Product> exitProducts = products.Where(products => products.ExitYear < currentYear).ToList<Product>();
            ShowProducts(exitProducts);
        }

        static void ShowProducts(List<Product> products)
        {
            foreach (var product in products)
                Console.WriteLine($"{product.Name} - {product.Release} - {product.ExitYear}");
            Console.WriteLine();
        }
    }

    class Product
    {
        public string Name { get; private set; }
        public int Release { get; private set; }
        public int ExitYear { get; private set; }

        public Product(string name, int release, int exitYear)
        {
            Name = name;
            Release = release;
            ExitYear = exitYear;
        }
    }
}
