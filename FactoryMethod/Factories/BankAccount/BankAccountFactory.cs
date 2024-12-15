using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod.Factories.BankAccount
{
    public static class BankAccountFactory
    {
        public static IBankAccount CreateAccount(AccountType type)
        {
            return type switch
            {
                AccountType.CurrentAccount => new CurrentAccount(),
                AccountType.SavingsAccount => new SavingsAccount(),
                _ => throw new ArgumentException("Account type not supported.")
            };
        }
    }
}
