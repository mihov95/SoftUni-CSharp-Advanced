using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            

            while (input[0] != "Revision")
            {
                var shop = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, 0);
                }

                shops[shop][product] = price;

                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");

                }
            }
        }
    }
}
