using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayLine();
        Address address1 = new Address("123 Sesame St", "Houston", "TX", "USA");
        Customer customer1 = new Customer("Benny", address1);
        Product o1Product1 = new Product("XBOX Series X", "VG5025", 299.99, 3);
        Product o1Product2 = new Product("Gaming Controller", "XC7465", 45.99, 2);
        Product o1Product3 = new Product("Headset", "HD9021", 129.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(o1Product1);
        order1.AddProduct(o1Product2);
        order1.AddProduct(o1Product3);

        Address address2 = new Address("456 Calle Pico Broad", "Monterrey", "NL", "Mexico");
        Customer customer2 = new Customer("Chepe", address2);
        Product o2Product1 = new Product("Jerseys", "JR7986", 85.67, 5);
        Product o2Product2 = new Product("Soccer Cleats", "SC5028", 219.99, 2);
        Product o2Product3 = new Product("Game Tickets", "GT3245", 95.50, 8);

        Order order2 = new Order(customer2);
        order2.AddProduct(o2Product1);
        order2.AddProduct(o2Product2);
        order2.AddProduct(o2Product3);

        DisplayOrderDetails(order1);
        DisplayLine();
        DisplayOrderDetails(order2);
    }
    static void DisplayLine()
    {
        Console.WriteLine("--------------------------------------------------");
    }
    static void DisplayOrderDetails(Order order)
    {
        order.DisplayPackingLabel();
        Console.WriteLine();
        order.DisplayShippingLabel();
        Console.WriteLine();
        double totalCost = order.CalculateTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost}");
    }
}