using Strategy.Models;
using Strategy.Strategies.SalesTax;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderWithoutStrategy = new OrderWithoutStrategy
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            var orderWithStrategy = new OrderWithStrategy
            {
                ShippingDetails = new ShippingDetails
                {
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                },
                SalesTaxStrategy = new SwedenSalesTaxStrategy()
            };

            orderWithoutStrategy.LineItems.Add(new ItemWithoutStrategy("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
            orderWithStrategy.LineItems.Add(new ItemWithStrategy("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

            Console.WriteLine(orderWithoutStrategy.GetTax());
            Console.WriteLine(orderWithStrategy.GetTax());
        }
    }
}