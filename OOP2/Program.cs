using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Murat Can";
            customer1.LastName = "Kurt";
            customer1.NationalIdNo = "22222222222222225";
            customer1.CustomerNo = "123456789";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "5265421";
            customer2.CompanyName = "BlaBla Inc.";
            customer2.TaxNo = "82654265665";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}
