using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class SavingsAccount : IBankAccount
    {
        public void Deposit(decimal amount)
        {
            //Process deposit for savings account
        }
    }
}
