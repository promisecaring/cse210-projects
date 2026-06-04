using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== CUSTOMER 1 (USA) =====
        Address address1 = new Address("12 Broadway Ave", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product p1 = new Product("Laptop", "P1001", 800, 1);
        Product p2 = new Product("Mouse", "P1002", 25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order1.GetTotalPrice()}\n");

        // ===== CUSTOMER 2 (NON-USA) =====
        Address address2 = new Address("45 King Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Mary Johnson", address2);

        Product p3 = new Product("Phone", "P2001", 600, 1);
        Product p4 = new Product("Case", "P2002", 20, 3);
        Product p5 = new Product("Charger", "P2003", 15, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"TOTAL PRICE: ${order2.GetTotalPrice()}");
    }
}