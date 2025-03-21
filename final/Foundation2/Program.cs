using System;

class Program
{
    static void Main(string[] args)
    {
        Products p1 = new Products("Laptop", "LP100", 10.00, 1);
        Products p2 = new Products("Headphones", "HP003", 10.00, 1);

        Address usAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address internationAddress = new Address("456 Elm St", "Othertown", "ON", "Canada");

        Customer usCustomer = new Customer("John Doe", usAddress);
        Customer internationalCustomer = new Customer("Jane Smith", internationAddress);

        List<Products> productsForOrder1 = new List<Products> { p1 };
        Order order1 = new Order(usCustomer, productsForOrder1);

        List<Products> productsForOrder2 = new List<Products> { p1, p2 };
        Order order2 = new Order(internationalCustomer, productsForOrder2);

        Console.WriteLine("1st ORDER");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");
        Console.WriteLine();

        Console.WriteLine("2nd ORDER");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");   
    }
}