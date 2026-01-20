using System;
using System.Collections.Generic;
using System.Text;

namespace Mod7InheritanceDemo
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            this.minimumBalance = 500; //Accesing protected member from base class
        }

        
    }
}
