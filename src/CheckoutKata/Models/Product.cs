using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckoutKata.Models
{
    public class Product
    {
        public Product() { }
        public Product(string name,int price,ProductDiscount discount) : base()
        {
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductDiscount Discount { get; set; }
    }
    public class ProductDiscount
    {
        public ProductDiscount() { }
        public ProductDiscount(string name, int quantity, int discount) : base()
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Discount = discount;
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}