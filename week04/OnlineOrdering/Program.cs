using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

         Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        // Second Customer
        Address addr2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Emily Johnson", addr2);

        // Order 1
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "L001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M101", 25.50, 2));

        // Order 2
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "H202", 80.00, 1));
        order2.AddProduct(new Product("Webcam", "W303", 45.75, 1));
        order2.AddProduct(new Product("Microphone", "M404", 59.99, 1));

        // Print both orders
        PrintOrderDetails(order1);
        Console.WriteLine();
        PrintOrderDetails(order2);
    }

    static void PrintOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order.GetTotalPrice().ToString("0.00"));
    }
    
}

