using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------------------------------------------
        // Order 1: Domestic Customer (USA)
        // -------------------------------------------------------------
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product p1 = new Product("Wireless Mouse", "M102", 25.50, 2);
        Product p2 = new Product("Mechanical Keyboard", "K504", 75.00, 1);
        Product p3 = new Product("HDMI Cable", "C009", 8.99, 3);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        // -------------------------------------------------------------
        // Order 2: International Customer (Canada)
        // -------------------------------------------------------------
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);

        Product p4 = new Product("Gaming Monitor", "MON7", 299.99, 1);
        Product p5 = new Product("USB-C Hub", "HUB3", 45.00, 2);

        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // -------------------------------------------------------------
        // Display Results
        // -------------------------------------------------------------
        Console.WriteLine("========================================");
        Console.WriteLine("DISPLAYING ORDER 1 (USA)");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("========================================");
        Console.WriteLine("DISPLAYING ORDER 2 (International)");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("========================================");
    }
}
 