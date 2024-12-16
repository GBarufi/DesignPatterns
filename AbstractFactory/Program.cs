using AbstractFactory.Enums;
using AbstractFactory.Models;

namespace AbstractFactory
{
    public static class Globals
    {
        public const double BASE_FEE = 0.8;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customerRelationship = CustomerRelationship.NewComer;

            var bankAccountWithoutPattern = new BankAccountWithoutPattern { Relationship = customerRelationship };
            var bankAccountWithPattern = new BankAccountWithPattern { Relationship = customerRelationship };

            Console.WriteLine(bankAccountWithoutPattern.CalculateFee());
            Console.WriteLine(bankAccountWithPattern.CalculateFee());
        }
    }
}