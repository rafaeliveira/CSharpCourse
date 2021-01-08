using System;
using System.Collections.Generic;
using System.Globalization;
using PriceTag.Entities;

namespace PriceTag
{
    class Program
    {
        static void Main(string[] args)
        {
            int iProductNnum = 0;

            char cType;

            string sName = "";

            double dPrice = 0d;
            double dCustomFee = 0d;

            DateTime dtManufDate;

            List<Product> products = new List<Product>();


            Console.WriteLine("Enter the number of products: ");
            iProductNnum = int.Parse(Console.ReadLine());

            if(iProductNnum > 0)
            {
                for (int i = 1; i <= iProductNnum; i++)
                {
                    Console.WriteLine($"Product #{i} data:");

                    Console.WriteLine("Commom, used or imported (c/u/i)? ");
                    cType = char.Parse(Console.ReadLine());

                    Console.WriteLine("Name: ");
                    sName = Console.ReadLine();

                    Console.WriteLine("Price: ");
                    dPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if(cType == 'i')
                    {
                        Console.WriteLine("Custom Fee: ");
                        dCustomFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        products.Add(new ImportedProduct(sName, dPrice, dCustomFee));
                    }
                    else if (cType == 'u')
                    {
                        Console.WriteLine("Manufacture Date (DD/MM/YYYY): ");
                        dtManufDate = DateTime.Parse(Console.ReadLine());

                        products.Add(new UsedProduct(sName, dPrice, dtManufDate));
                    }
                    else
                    {
                        products.Add(new Product(sName, dPrice));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("PRICE TAGS: ");
                Console.WriteLine();

                foreach (Product prod in products)
                {
                    Console.WriteLine(prod.priceTag());
                }
            }
        }
    }
}