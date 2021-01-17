using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.Name = "Apple";
            prod1.Price = 6;
            prod1.Description = "Amasya Apple";

            Product prod2 = new Product();
            prod2.Name = "Watermelone";
            prod2.Price = 55;
            prod2.Description = "This is a watermelone..";

            Product[] products = new Product[] { prod1, prod2 };

            foreach (Product prod in products)
            {
                Console.WriteLine(prod.Name + " " + prod.Price + " " + prod.Description);
            }

            Console.WriteLine("-------------------Methods----------------------");

            //instantiations 
            CartManager cartManager = new CartManager();
            cartManager.AddToCart(prod1);
            cartManager.AddToCart(prod2);

            cartManager.Add2("")

        }
    }
}

//Do not repeat yourself!...
// DRY!
//Clean Code
// Best Practice
