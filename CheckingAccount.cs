using System;
using System.Collections.Generic;
using System.Text;

namespace Mod7InheritanceDemo
{
    internal class CheckingAccount:BankAccount
    {
        public CheckingAccount()
        {
            this.minimumBalance = 100;
        }
    }
}
