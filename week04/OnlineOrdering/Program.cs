using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Smith St.", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "P001", 2.50, 4));
        order1.AddProduct(new Product("Pen", "P002", 1.25, 6));

        Address address2 = new Address("1 Rosal St.", "Taguig", "Metro Manila", "Philippines");
        Customer customer2 = new Customer("Jyn Carlos Banaña", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Backpack", "P010", 25.00, 1));
        order2.AddProduct(new Product("Water Bottle", "P011", 10.00, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}