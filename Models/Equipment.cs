namespace Assign1PROG30000.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string? Type { get; set; }   // Laptop, Phone, Tablet, etc.
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
