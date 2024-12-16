using AbstractFactory.Enums;

namespace AbstractFactory.Models
{
    public class BankAccountWithoutPattern
    {
        public CustomerRelationship Relationship { get; set; }
        public IncomeBracket IncomeBracket { get; set; }

        public double CalculateFee()
        {
            double fee;

            switch (Relationship)
            {
                case CustomerRelationship.NewComer:
                    fee = IncomeBracket switch
                    {
                        IncomeBracket.Low => 1.4 * Globals.BASE_FEE,
                        IncomeBracket.Medium => 1.25 * Globals.BASE_FEE,
                        IncomeBracket.High => 0.9 * Globals.BASE_FEE,
                        _ => 1.4 * Globals.BASE_FEE
                    };
                    
                    break;
                case CustomerRelationship.Top:
                    fee = IncomeBracket switch
                    {
                        IncomeBracket.Low => 1.3 * Globals.BASE_FEE,
                        IncomeBracket.Medium => 1.15 * Globals.BASE_FEE,
                        IncomeBracket.High => Globals.BASE_FEE,
                        _ => Globals.BASE_FEE
                    };

                    break;
                default:
                    throw new ArgumentException("Customer relationship not supported");
            }

            return fee;
        }
    }
}
