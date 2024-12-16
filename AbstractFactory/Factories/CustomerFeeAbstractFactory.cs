using AbstractFactory.Enums;
using AbstractFactory.Factories.Concrete;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class CustomerFeeAbstractFactory
    {
        public static ICustomerFeeAbstractFactory CreateCustomerFee(CustomerRelationship customerRelationship)
        {
            return customerRelationship switch
            {
                CustomerRelationship.NewComer => new NewComerCustomerFeeAbstractFactory(),
                CustomerRelationship.Top => new TopCustomerFeeAbstractFactory(),
                _ => throw new ArgumentException("Customer relationship not supported.")
            };
        }
    }
}
