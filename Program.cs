namespace Mod7InheritanceDemo
{
    // CI-CD 
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            SavingsAccount savings = new SavingsAccount();
            savings.AccountNumber = 222344;
            savings.AccountHolder = "John Doe";
            savings.Balance = 2000.00m;
            Console.WriteLine($"Account number:{savings.AccountNumber}, Account Holder:{savings.AccountHolder},  Balance of {savings.Balance}");
            

            CheckingAccount checking = new CheckingAccount();
            checking.AccountNumber = 223546;
            checking.AccountHolder = "Annie Chimer";
            checking.Balance = 120.00m;
            Console.WriteLine($"Account number:{checking.AccountNumber}, Account Holder:{checking.AccountHolder}, Balance of {checking.Balance}");

        
        }
    }
}
