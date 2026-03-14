namespace FlowStock_Backend.Models
{
    public class AccessProfile
    {
        public int Id { get; set; }

        public string ProfileName { get; set; } = string.Empty;

        public List<User> Users { get; set; } = new();
    }
}