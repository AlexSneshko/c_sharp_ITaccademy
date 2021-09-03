using System;

namespace Task13
{
    class Program
    {
        static void Print(Product[] products)
        {
            Console.WriteLine("Products:");
            foreach (var product in products)
                Console.WriteLine(product);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product("product1", "shop1"),
                new Product("product2", "shop5"),
                new Product("product3", "shop2"),
                new Product("product4", "shop3"),
                new Product("product5", "shop2")
            };

            Print(products);
            Array.Sort(products);
            Print(products);
            try
            {
                Print(Product.GetProductFromShop(products, "shop1"));
                Print(Product.GetProductFromShop(products, "shop2"));
                Print(Product.GetProductFromShop(products, "shop"));
            }
            catch(CustomException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
