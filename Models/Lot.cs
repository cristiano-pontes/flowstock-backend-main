namespace FlowStock_Backend.Models
{
    public class Lot
    {
        public int Id { get; set; }

        public string Number { get; set; } = string.Empty;

        public DateTime ExpirationDate { get; set; }

        public int Quantity { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public List<StockMovement> StockMovements { get; set; } = new();
    }
}