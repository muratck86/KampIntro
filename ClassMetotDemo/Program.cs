using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("............Create customer...............");
            Customer c001 = CustomerManager.createCustomer("murat can","kurt", 1900);

            //open a few accounts for customer
            Console.WriteLine("\n............Open accounts...............");
            Account dollarAcc;
            Account TRYAcc;
            dollarAcc = CustomerManager.OpenAccount(c001, Currencies.ABD_Dollar, 500);
            TRYAcc = CustomerManager.OpenAccount(c001, Currencies.TR_Lira);


            //Deposit some money
            Console.WriteLine("\n............Deposit money...............");
            CustomerManager.Deposit(dollarAcc, 250);
            CustomerManager.Deposit(TRYAcc, 1200);


            //Withdraw attempts
            Console.WriteLine("\n............Withdraw money...............");
            CustomerManager.Withdraw(dollarAcc, 1000);
            CustomerManager.Withdraw(dollarAcc, 450);
            CustomerManager.Withdraw(TRYAcc, 1200);

            //Close account attempts
            Console.WriteLine("\n............close account...............");
            CustomerManager.CloseAccount(dollarAcc);
            CustomerManager.CloseAccount(TRYAcc);


        }
    }
}
