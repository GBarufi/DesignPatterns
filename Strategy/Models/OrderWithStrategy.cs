using Strategy.Strategies.SalesTax;

namespace Strategy.Models
{
    public class OrderWithStrategy
    {
        public Dictionary<ItemWithStrategy, int> LineItems { get; } = [];

        public IList<Payment> SelectedPayments { get; } = [];

        public IList<Payment> FinalizedPayments { get; } = [];

        public decimal AmountDue => TotalPrice - FinalizedPayments.Sum(payment => payment.Amount);

        public decimal TotalPrice => LineItems.Sum(item => item.Key.Price * item.Value);

        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

        public ShippingDetails ShippingDetails { get; set; }

        public ISalesTaxStrategy SalesTaxStrategy { get; set; }

        public decimal GetTax()
        {
            if (SalesTaxStrategy == null)
            {
                return 0m;
            }

            return SalesTaxStrategy.GetTaxFor(this);
        }
    }

    public class ItemWithStrategy
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ItemType ItemType { get; set; }

        public ItemWithStrategy(string id, string name, decimal price, ItemType type)
        {
            Id = id;
            Name = name;
            Price = price;
            ItemType = type;
        }
    }
}
