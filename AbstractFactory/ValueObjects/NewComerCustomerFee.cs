using AbstractFactory.Enums;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ValueObjects
{
    public class NewComerCustomerFee : ICustomerFee
    {
        private const double BASE_FEE = Globals.BASE_FEE;
        public double CalculateFee(IncomeBracket incomeBracket)
        {
            return incomeBracket switch
            {
                IncomeBracket.Low => 1.4 * BASE_FEE,
                IncomeBracket.Medium => 1.25 * BASE_FEE,
                IncomeBracket.High => 0.9 * BASE_FEE,
                _ => 1.4 * BASE_FEE
            };
        }
    }
}
