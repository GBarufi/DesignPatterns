namespace FactoryMethod.Models
{
    public class BankAccount
    {
        public AccountType Type { get; set; }

        public void Deposit(decimal amount)
        {
            switch (Type)
            {
                case AccountType.CurrentAccount:
                    //Process deposit for current account
                    break;
                case AccountType.SavingsAccount:
                    //Process deposit for savings account
                    break;
                default:
                    break;
            }
        }
    }

    public enum AccountType
    {
        CurrentAccount,
        SavingsAccount
    }
}
