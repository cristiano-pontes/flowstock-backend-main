namespace FlowStock_Backend.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Barcode { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int MinimumStock { get; set; }

        public int? SupplierId { get; set; }

        public Supplier? Supplier { get; set; }

        public List<Lot> Lots { get; set; } = new List<Lot>();

        public List<StockMovement> StockMovements { get; set; } = new List<StockMovement>();

        public List<Alert> Alerts { get; set; } = new List<Alert>();
    }
}

/*O Fornecedor representa as empresas que fornecem produtos para o sistema de inventário.
O estoque varia ao longo do tempo.
      Devemos registrar entrada de ações saída de ações*/

