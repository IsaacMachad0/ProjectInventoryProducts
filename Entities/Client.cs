namespace InventoryProducts.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}