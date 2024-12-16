using AbstractFactory.Enums;
using AbstractFactory.Factories.Concrete;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class BankAccountWithPattern
    {
        public CustomerRelationship Relationship { get; set; }
        public IncomeBracket IncomeBracket { get; set; }

        public double CalculateFee()
        {
            ICustomerFeeAbstractFactory? factory = Relationship switch
            {
                CustomerRelationship.NewComer => new NewComerCustomerFeeAbstractFactory(),
                CustomerRelationship.Top => new TopCustomerFeeAbstractFactory(),
                _ => null
            };

            if (factory is null)
                throw new ArgumentException("Customer relationship not supported");


            var customerFee = factory.CreateAccountFee();
            double fee = customerFee.CalculateFee(IncomeBracket);

            return fee;
        }
    }
}
