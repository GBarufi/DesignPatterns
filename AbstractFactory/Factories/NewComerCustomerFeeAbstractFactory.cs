using AbstractFactory.Interfaces;
using AbstractFactory.ValueObjects;

namespace AbstractFactory.Factories.Concrete
{
    public class NewComerCustomerFeeAbstractFactory : ICustomerFeeAbstractFactory
    {
        public ICustomerFee CreateAccountFee()
        {
            return new NewComerCustomerFee();
        }
    }
}
