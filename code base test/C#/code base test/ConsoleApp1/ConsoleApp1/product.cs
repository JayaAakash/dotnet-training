using System;
using System.Collections.Generic;

namespace code_base_test
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter details for product {i}:");
                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Product product = new Product
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price
                };

                products.Add(product);
            }

            products.Sort((x, y) => x.Price.CompareTo(y.Price));

            Console.WriteLine("Sorted Products:");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");

            }

            Console.WriteLine("==============Student grades program=============");

            Undergraduate undergraduate = new Undergraduate
            {
                Name = "Banu Rekha",
                StudentId = 0001,
                Grade = 72
            };

            Console.WriteLine($"{undergraduate.Name} (ID: {undergraduate.StudentId}) passed the course: {undergraduate.IsPassed(undergraduate.Grade)}");

            // Test with Graduate
            Graduate graduate = new Graduate
            {
                Name = "Aakash",
                StudentId = 0002,
                Grade = 72
            };

            Console.WriteLine($"{graduate.Name} (ID: {graduate.StudentId}) passed the course: {graduate.IsPassed(graduate.Grade)}");
        

        Console.ReadLine();
        }
    }
}
