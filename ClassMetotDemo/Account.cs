using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Account
    {
        private static int accountNoGenerator = 1832465;
        public Customer Owner { get; set; }
        public int AccountNo { get; set; }
        public Currencies Currency { get; set; }

        public double Balance { get; set; }

        public void createAccountNo()
        {
            this.AccountNo = ++accountNoGenerator;
        }

        public void setOwner(Customer owner)
        {
            this.Owner = owner;
        }
    }

    enum Currencies
    {
        Pound,
        ABD_Dollar,
        TR_Lira,
        Euro
    }
}
