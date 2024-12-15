using FactoryMethod.Interfaces;

namespace FactoryMethod.Models
{
    public class CurrentAccount : IBankAccount
    {
        public void Deposit(decimal amount)
        {
            //Process deposit for current account
        }
    }
}
