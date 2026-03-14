namespace FlowStock_Backend.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Cnpj { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Contact { get; set; } = string.Empty;

        public int DeliveryTimeDays { get; set; }

        public List<Product> Products { get; set; } = new();
    }
}
