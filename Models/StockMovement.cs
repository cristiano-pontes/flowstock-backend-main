namespace FlowStock_Backend.Models
{
    public class StockMovement
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public string Type { get; set; } = string.Empty; // IN, OUT, LOSS

        public int Quantity { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Reason { get; set; } = string.Empty;

        public int? UserId { get; set; }

        public User? User { get; set; }

        public int? LotId { get; set; }

        public Lot? Lot { get; set; }
    }
}