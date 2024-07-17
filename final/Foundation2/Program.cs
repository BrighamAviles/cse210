using System;
using System.Collections.Generic;

namespace OnlineOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Laptop", "P001", 1000.00, 1);
            Product product2 = new Product("Mouse", "P002", 25.00, 2);
            Product product3 = new Product("Keyboard", "P003", 45.00, 1);

            Product product4 = new Product("Monitor", "P004", 150.00, 2);
            Product product5 = new Product("Desk Chair", "P005", 85.00, 1);
            Product product6 = new Product("USB Cable", "P006", 10.00, 3);

            // Create orders
            Order order1 = new Order(new List<Product> { product1, product2, product3 }, customer1);
            Order order2 = new Order(new List<Product> { product4, product5, product6 }, customer2);

            // Display order details
            DisplayOrderDetails(order1);
            DisplayOrderDetails(order2);
        }

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}\n");
        }
    }
}
