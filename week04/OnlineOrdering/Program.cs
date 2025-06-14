using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("23 Wayne Gretzky Drive", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 3);
        Product product3 = new Product("Keyboard", 103, 45.00, 2);

        List<Product> products = new List<Product> { product1, product2, product3 };

        Order order1 = new Order(customer1, products);
        Order order2 = new Order(customer2, products);

        Console.WriteLine($"Order for {customer1.GetName()}:\n{order1.GetPackLabel()}\n{order1.GetShipLabel()}\n\nTotal: {order1.GetTotal():C}\n");
        Console.WriteLine($"Order for {customer2.GetName()}:\n{order2.GetPackLabel()}\n{order2.GetShipLabel()}\n\nTotal: {order2.GetTotal():C}");
    }
}