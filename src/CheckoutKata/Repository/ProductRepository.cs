using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckoutKata.Models;

namespace CheckoutKata.Repository
{
    interface IRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(string name);
    }
    public class ProductRepository:IRepository
    { 
        public IEnumerable<Product> GetAll()
        {
            return Factory.ProductFactory.GetAvailableProducts();
        }
        public Product Get(string name)
        {
            var availableProducts = Factory.ProductFactory.GetAvailableProducts();
            var item = availableProducts.SingleOrDefault(x => x.Name.ToLower() == name.ToLower());
            return item;
        }
    }
}