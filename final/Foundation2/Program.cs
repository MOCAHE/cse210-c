using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();

        var address1 = new Address("50 N West Temple", "Salt Lake City", "UT", "USA");
        var address2 = new Address("9802 Rocky Ridge Rd NW", "Calgary", "AB", "Canada");
        var address3 = new Address("Escuadron 201 540", "GAM", "CDMX", "México");

        var customer1 = new Customer("Elijah Lindstrom", address1);
        var customer2 = new Customer("John Padilla", address2);
        var customer3 = new Customer("Moisés Cano H", address3);

        var laptop = new Product("Dell Inspiron 15", 1001, 650.99, 1);
        var monitor = new Product("Samsung 27-inch LED Monitor", 1002, 229.49, 1);
        var keyboard = new Product("Logitech Wireless Keyboard", 1003, 34.99, 1);
        var mouse = new Product("HP Wireless Mouse", 1004, 15.49, 1);
        var externalDrive = new Product("Seagate 1TB External Hard Drive", 1005, 54.99, 1);
        var ram = new Product("Corsair 16GB DDR4 RAM", 1006, 79.99, 1);
        var printer = new Product("Canon PIXMA MG3620 Printer", 1007, 89.99, 1);
        var webcam = new Product("Logitech C922 Pro Stream Webcam", 1008, 99.99, 1);
        var cpu = new Product("AMD Ryzen 7 3700X", 1009, 329.99, 1);
        var gpu = new Product("NVIDIA GeForce RTX 3070", 1010, 499.99, 1);

        var order1 = new Order(new List<Product> { laptop, monitor, keyboard, mouse, mouse, externalDrive }, customer1);
        var order2 = new Order(new List<Product> { ram, printer, webcam, cpu, gpu }, customer2);
        var order3 = new Order(new List<Product> { mouse, mouse }, customer3);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"TOTAL: ${order1.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"TOTAL: ${order1.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Order 3");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"TOTAL: ${order3.CalculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("----------------------------------------");

    }
}