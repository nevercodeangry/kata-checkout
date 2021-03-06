﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CheckoutKata.Models;
using CheckoutKata.Repository;
namespace CheckoutKata.Services
{
    interface IProductService
    {
        int Checkout(string items);
    }
    public class ProductService:IProductService
    {
        private IRepository _repository;
        public ProductService()
        {
            _repository = new ProductRepository();
        }
        public int Checkout(string items)
        {
            var availableProducts = _repository.GetAll();
            var total = 0;

            foreach (var p in availableProducts)
            {
                var currentItems = items.ToCharArray();
                total += GetTotal(p, currentItems.Count(x => x.ToString().ToLower() == p.Name.ToLower()));
            }
            return total;   
        }
        private int GetTotal(Product p,int quantity)
        {
            if (quantity == 0)
                return 0;

            if (p.Discount == null)
                return p.Price * quantity;

            //calculate offer
            if (p.Discount.Quantity > quantity)
                return p.Price * quantity;

            if (p.Discount.Quantity == quantity)
                return (p.Price * quantity) - p.Discount.Discount;

            
            var total =  (p.Price * p.Discount.Quantity) - p.Discount.Discount;
            var leftOver = quantity - p.Discount.Quantity;
            if (leftOver > 0)
                total += GetTotal(p, leftOver);
            
            return total;
            
            
        }
    }
}