using System.Collections.Generic;
using System.Text;

namespace OnlineOrderingSystem
{
    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(List<Product> products, Customer customer)
        {
            this.products = products;
            this.customer = customer;
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.GetTotalCost();
            }
            double shippingCost = customer.LivesInUSA() ? 5 : 35;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder();
            foreach (var product in products)
            {
                packingLabel.AppendLine($"{product.Name} (ID: {product.ProductId})");
            }
            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.Name}\n{customer.Address.GetFullAddress()}";
        }
    }
}
