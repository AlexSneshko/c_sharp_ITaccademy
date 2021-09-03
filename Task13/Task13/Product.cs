using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Task13
{
    public struct Product : IComparable<Product>
    {
        public string Name { get; }
        public string ShopName { get; }

        public Product(string name, string shopName)
        {
            Name = name;
            ShopName = shopName;
        }

        public static Product[] GetProductFromShop(Product[] products, string name)
        {
            List<Product> neddedProducts = new List<Product>();

            foreach (var product in products)
                if (product.ShopName.Equals(name))
                    neddedProducts.Add(product);

            if (neddedProducts.Count == 0) throw new CustomException(name);
            return neddedProducts.ToArray();
        }

        public int CompareTo(Product other)
        {
            return ShopName.CompareTo(other.ShopName);
        }

        public override string ToString()
        {
            return $"Product Name: {Name}, Shop name {ShopName}";
        }
    }
}
