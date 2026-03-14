namespace FlowStock_Backend.Models
{
    public class Alert
    {
        public int Id { get; set; }

        public string Type { get; set; } = string.Empty; // LowStock, Expiration

        public string Message { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public bool IsRead { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }
    }
}