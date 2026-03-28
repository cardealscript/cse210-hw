using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ========================================================

        // Order 1 - USA customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A101", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B202", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "C303", 45.00, 1));

        // Order 2 - International customer
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Silva", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "D404", 350.00, 1));
        order2.AddProduct(new Product("Webcam", "E505", 79.99, 1));

        // Display orders
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine();
        }
    }
}