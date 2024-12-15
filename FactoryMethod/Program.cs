using FactoryMethod.Factories.BankAccount;
using FactoryMethod.Models;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountType = AccountType.CurrentAccount;

            var bankAccountWithoutPattern = new BankAccount { Type = accountType };
            bankAccountWithoutPattern.Deposit(100m);

            var bankAccountWithPattern = BankAccountFactory.CreateAccount(accountType);
            bankAccountWithPattern.Deposit(100m);
        }
    }
}