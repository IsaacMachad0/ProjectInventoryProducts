using System.Text;
using InventoryProducts.Entities.Enum;

namespace InventoryProducts.Entities
{
    public class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }
        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem (OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder bd  = new StringBuilder();
            bd.AppendLine("ORDER SUMMARY:");
            bd.AppendLine("Order moment: " + Date);
            bd.AppendLine("Order status: " + Status);
            bd.AppendLine($"Client => Name: {Client.Name}, Birth: {Client.BirthDate}, E-mail: {Client.Email}");
            bd.AppendLine("Order items");
            foreach(OrderItem item in Items)
            {
                bd.AppendLine(item.ToString());
            }
            bd.AppendLine("Total price: " + Total().ToString("C2"));
            return bd.ToString();
        }
    }
}