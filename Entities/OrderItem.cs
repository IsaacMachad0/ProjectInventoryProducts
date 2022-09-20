using System.Globalization;

namespace InventoryProducts.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"Description: {Product.NameProduct}, Quantity: {Quantity}, Price: {Price:C2}, SubTotal: {SubTotal().ToString("C2")}";
        }
    }
}