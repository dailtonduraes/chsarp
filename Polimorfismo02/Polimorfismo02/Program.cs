using Polimorfismo02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter de number of products");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product {i} data: ");
                Console.Write("Common, used or imported (c/u/i)?");
                char tp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tp == 'u' || tp == 'U')
                {
                    Console.Write("Manufacture date: (DD/MM/YYYY) ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if(tp == 'i' || tp == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product prd in list)
            {
                Console.WriteLine(prd.PriceTag());
            }
        }
    }
}
