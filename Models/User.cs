namespace FlowStock_Backend.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public bool Active { get; set; } = true;

        public int AccessProfileId { get; set; }

        public AccessProfile? AccessProfile { get; set; }

        public List<StockMovement> StockMovements { get; set; } = new();

        public List<Alert> Alerts { get; set; } = new();
    }
}