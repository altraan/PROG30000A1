namespace Assign1PROG30000.Models
{
    public static class Request
    {
        public int Id { get; set; } // Unique identifier for the request

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }   // User's email address

        [Required]
        public string? Phone { get; set; }

        public EnumRole Role {get;set;}

        [Required]
        public int? DurationDays { get; set; }  // Duration in days

        [Required]
        public int? EquipmentId { get; set; }

        [Required]
        public EnumStatus Status { get; set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now; // User's role (Admin, User, etc.)
    }
}
