using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Gage Smith", address1);
        Product product1 = new Product("Phone", 1, 1000, 1);
        Product product2 = new Product("Laptop", 2, 3000, 1);
        List<Product> products1 = new List<Product> {product1, product2};
        Order order1 = new Order(customer1,products1);
        
        Address address2 = new Address("321 1st St", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Jennifer Victoria", address2);
        Product product3 = new Product("TV", 3, 2000, 1);
        Product product4 = new Product("Pillow", 4, 50, 1);
        List<Product> products2 = new List<Product> {product3, product4};
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        
        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine(order1.CalculateTotalCost());

        Console.WriteLine("\n" + new string('=', 40) +"\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        
        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine(order2.CalculateTotalCost());

    }
}