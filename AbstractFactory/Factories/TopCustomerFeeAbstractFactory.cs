using AbstractFactory.Interfaces;
using AbstractFactory.ValueObjects;

namespace AbstractFactory.Factories.Concrete
{
    public class TopCustomerFeeAbstractFactory : ICustomerFeeAbstractFactory
    {
        public ICustomerFee CreateAccountFee()
        {
            return new TopCustomerFee();
        }
    }
}
