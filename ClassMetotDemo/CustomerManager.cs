using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public static Customer createCustomer(string name, string lastName, int birth)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.LastName = lastName;
            customer.setID();
            customer.BirthYear = 1975;
            Console.WriteLine("New customer created: \nCustomer ID: " + customer.CustomerID + "\nCustomer name: " + customer.Name + " " + customer.LastName);
            return customer;
        }


        public static void Deposit(Account acc, int amount)
        {
            double current = acc.Balance;
            acc.Balance += amount;
            Console.WriteLine("Deposit complete, new balance: " + acc.Balance);
        }

        public static bool Withdraw(Account acc, int amount)
        {
            double current = acc.Balance;
            if (current < amount)
            {
                Console.WriteLine("Insufficent balance, you have " + acc.Balance + " " + acc.Currency + " in your account.");
                return false;
            }
            acc.Balance -= amount;

            bool answer = GetBalance(acc) == current - amount;
            if (answer)
            {
                Console.WriteLine("New balance: " + acc.Balance + " " + acc.Currency + " thank you for choosing us...");
                return answer;
            }
            Console.WriteLine("Error");
            return answer;
        }

        public static double GetBalance(Account account)
        {
            Console.WriteLine("You have :" + account.Balance + " " + account.Currency + " in your account.");
            return account.Balance;
        }

        public static Account OpenAccount(Customer customer, Currencies cur, double amount = 0)
        {
            Account acc = new Account();
            acc.createAccountNo();
            acc.setOwner(customer);
            acc.Balance = amount;
            acc.Currency = cur;
            if (customer.Accounts == null)
            {
                customer.Accounts = new Account[10];
                customer.Accounts[0] = acc;
            }
            else
            {
                for (int i = 0; i < customer.Accounts.Length; i++)
                {
                    if (customer.Accounts[i] == null)
                        customer.Accounts[i] = acc;
                }
            }
            Console.WriteLine("New account succesfuly created. Account number: " + acc.AccountNo + "\nBalance : " + acc.Balance + " " + acc.Currency);
            return acc;
            //Console.WriteLine("Error: Maximum account number reached. A customer can have a maximum of 10 accounts..");
            //return null;
        }

        public static Account CloseAccount(Account account)
        {
            if (account.Balance > 0)
            {
                Console.WriteLine("The account has balance, can't close account.");
                return null;
            }
            for (int i = 0; i < account.Owner.Accounts.Length; i++)
            {
                if (account.Owner.Accounts[i] != null )
                {
                    Account respond = account.Owner.Accounts[i];
                    account.Owner.Accounts[i] = null;
                    return respond;
                }
            }

            Console.WriteLine("Error: There is no such customer has this account...");
            return null;
        }
    }
}
