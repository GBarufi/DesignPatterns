using Strategy.Models;
namespace Strategy.Strategies.SalesTax
{
    public interface ISalesTaxStrategy
    {
        public decimal GetTaxFor(OrderWithStrategy order);
    }

}
