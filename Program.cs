using System;
using InventoryProducts.Entities;
using InventoryProducts.Entities.Enum;

namespace InventoryProducts
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("ENTER CLIENT DATA");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client {
                Name = name == null ? "" : name, 
                Email = email == null ? "" : email, 
                BirthDate = birthDate
            };

            Console.WriteLine("ENTER ORDER DATA");

            Console.Write("Order status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(
                DateTime.Now, 
                status,
                client
            );

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product product = new Product
                {
                    NameProduct = nameProduct == null ? "" : nameProduct,
                    PriceProduct = price
                };

                OrderItem item = new OrderItem(quant, price, product);

                order.AddItem(item);
            }
            Console.WriteLine(order);
        }
    }
}