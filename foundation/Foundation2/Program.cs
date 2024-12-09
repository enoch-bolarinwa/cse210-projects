using System;
class Program
    {        static void Main(string[] args)
        {
            var usaAddress = new Address ("453 Brown St", "Oklahoma", "OK", "USA");
            var canadaAddress = new Address ("56 Williams Rd", "Hawaii", "HW", "Canada");

            var customer1 = new Customer ("David Esau", usaAddress);
            var customer2 = new Customer ("Joshua Caleb", canadaAddress);

            var product1 = new Product("Fridge", "FRG321", 1m, 3);
            var product2 = new Product("Radio", "RAD546", 2m, 4);
            var product3 = new Product("Iphone", "IP987", 3m, 2);

            var product4 = new Product("Nokia", "NK436", 4m, 5);
            var product5 = new Product("Samsung", "SG967", 5m, 3);


            var order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            var order2 = new Order(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);


            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}");
        }
    }
