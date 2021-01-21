using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 8
            product1.CategoryId = 5;
            product1.ProductName = "Çokomel";
            product1.UnitPrice = 2.75;
            product1.UnitsInStock = 54;

            Product product2 = new Product
            {
                Id = 8,
                CategoryId = 5,
                ProductName = "GofGof Gofret",
                UnitPrice = 1.25,
                UnitsInStock = 126
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
