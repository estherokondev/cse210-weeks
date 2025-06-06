
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Create first order
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "P001", 3.50, 5));
        order1.AddProduct(new Product("Pen", "P002", 1.25, 10));

        // Create second order
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB Cable", "P010", 5.99, 2));
        order2.AddProduct(new Product("Mouse Pad", "P011", 7.49, 1));
        order2.AddProduct(new Product("Webcam", "P012", 29.99, 1));

        // Display for Order 1
        Console.WriteLine("ORDER 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display for Order 2
        Console.WriteLine("ORDER 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
