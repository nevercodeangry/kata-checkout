using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckoutKata.Models;
namespace CheckoutKata.Factory
{
    public static class ProductFactory
    {
        public static List<Product> GetAvailableProducts()
        {
           return new List<Product>
            { { new Product("A", 50, new ProductDiscount("A", 3, 20)) },
                {new Product("B", 30, new ProductDiscount("B", 2, 15)) },
                { new Product("C", 20, null)},
                {new Product("D", 15, null) }
            };
            
        }
    }
}