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
            set
            { 
                if(value >= minimumBalance)
                {
                    balance = value; 
                }
                else
                {
                    Console.WriteLine($"alance cannot be less than {minimumBalance}");
                }
            }
        }
        protected decimal minimumBalance;
    }
}




