using System;
using System.Collections.Generic;
using System.Text;

namespace Mod7InheritanceDemo
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        protected decimal minimumBalance; // to hide it from clinet code but make it accessible to dervied classes.

    }


}
