using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-101", 29.99, 2));
        order1.AddProduct(new Product("USB Hub", "UH-202", 15.50, 1));
        order1.AddProduct(new Product("Keyboard", "KB-303", 49.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Order Total: $" + order1.GetTotalCost());

        Console.WriteLine();

        // Order 2 - International customer
        Address address2 = new Address("45 Queen St", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Chen", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB-401", 8.99, 3));
        order2.AddProduct(new Product("Pen Set", "PS-502", 12.49, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Order Total: $" + order2.GetTotalCost());
    }
}
