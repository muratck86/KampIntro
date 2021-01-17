using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void AddToCart(Product product)
        {
            Console.WriteLine("Product " + product.Name + " added to your cart");
        }

        public void Add(string prodName, string desc, double price)
        {
            Console.WriteLine("Product " + prodName + " added to your cart.");
        }
    }
}
