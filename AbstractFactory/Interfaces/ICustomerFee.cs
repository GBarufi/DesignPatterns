using AbstractFactory.Enums;

namespace AbstractFactory.Interfaces
{
    public interface ICustomerFee
    {
        double CalculateFee(IncomeBracket incomeBracket);
    }
}
