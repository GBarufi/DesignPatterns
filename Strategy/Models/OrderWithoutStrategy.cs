namespace Strategy.Models
{
    public class OrderWithoutStrategy
    {
        public Dictionary<ItemWithoutStrategy, int> LineItems { get; } = [];

        public IList<Payment> SelectedPayments { get; } = [];

        public IList<Payment> FinalizedPayments { get; } = [];

        public decimal AmountDue => TotalPrice - FinalizedPayments.Sum(payment => payment.Amount);

        public decimal TotalPrice => LineItems.Sum(item => item.Key.Price * item.Value);

        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

        public ShippingDetails ShippingDetails { get; set; }

        public decimal GetTax()
        {
            var destination = ShippingDetails.DestinationCountry.ToLowerInvariant();

            if (destination == "sweden")
            {
                if (destination == ShippingDetails.OriginCountry.ToLowerInvariant())
                {
                    return TotalPrice * 0.25m;
                }

                #region Tax per item
                //if (destination == ShippingDetails.OriginCountry.ToLowerInvariant())
                //{
                //    decimal totalTax = 0m;
                //    foreach (var item in LineItems)
                //    {
                //        switch (item.Key.ItemType)
                //        {
                //            case ItemType.Food:
                //                totalTax += (item.Key.Price * 0.06m) * item.Value;
                //                break;

                //            case ItemType.Literature:
                //                totalTax += (item.Key.Price * 0.08m) * item.Value;
                //                break;

                //            case ItemType.Service:
                //            case ItemType.Hardware:
                //                totalTax += (item.Key.Price * 0.25m) * item.Value;
                //                break;
                //        }
                //    }

                //    return totalTax;
                //}
                #endregion

                return 0;
            }

            if (destination == "us")
            {
                switch (ShippingDetails.DestinationState.ToLowerInvariant())
                {
                    case "la":
                        return TotalPrice * 0.095m;
                    case "ny":
                        return TotalPrice * 0.04m;
                    case "nyc":
                        return TotalPrice * 0.045m;
                    default:
                        return 0m;
                }
            }

            return 0m;
        }
    }

    public class ItemWithoutStrategy
    {
        public string Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public ItemType ItemType { get; set; }

        public decimal GetTax()
        {
            switch (ItemType)
            {
                case ItemType.Service:
                case ItemType.Food:
                case ItemType.Hardware:
                case ItemType.Literature:
                default:
                    return 0m;
            }
        }

        public ItemWithoutStrategy(string id, string name, decimal price, ItemType type)
        {
            Id = id;
            Name = name;
            Price = price;
            ItemType = type;
        }
    }

    public enum ItemType
    {
        Service,
        Food,
        Hardware,
        Literature
    }
}