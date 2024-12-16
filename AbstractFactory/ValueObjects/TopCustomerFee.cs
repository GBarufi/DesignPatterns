using AbstractFactory.Enums;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ValueObjects
{
    public class TopCustomerFee : ICustomerFee
    {
        private const double BASE_FEE = Globals.BASE_FEE;
        public double CalculateFee(IncomeBracket incomeBracket)
        {
            return incomeBracket switch
            {
                IncomeBracket.Low => 1.3 * BASE_FEE,
                IncomeBracket.Medium => 1.15 * BASE_FEE,
                IncomeBracket.High => BASE_FEE,
                _ => BASE_FEE
            };
        }
    }
}
