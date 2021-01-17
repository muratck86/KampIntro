using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        private static int idCounter = 10251523;

        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }

        public int BirthYear { get; set; }

        public string Phone { get; set; }

        public Account[] Accounts { get; set; }

        public void setID()
        {
            this.CustomerID = ++idCounter;
        }

    }
}
