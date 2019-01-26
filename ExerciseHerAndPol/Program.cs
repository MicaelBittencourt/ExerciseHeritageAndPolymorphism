using System;
using System.Collections.Generic;
using System.Globalization;
using ExerciseHerAndPol.Entities;
namespace ExerciseHerAndPol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the numbers of Products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customF = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customF));
                }else if(type == 'u')
                {
                    Console.Write("Manufatured Date: ");
                    DateTime manuDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manuDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
