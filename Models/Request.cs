using System.ComponentModel.DataAnnotations;
using Assign1PROG30000.Models;

namespace Assign1PROG30000.Models
{
    public class Request
    {
        [Required]
        public string? Name { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required, Phone]
        public string? Phone { get; set; }

        [Required]
        public string? Role { get; set; }

        [Required]
        public int EquipmentId { get; set; }

        public string? EquipmentType { get; set; }

        public string? RequestDetails { get; set; }

        public int DurationDays { get; set; }

        public DateTime CreatedAt { get; set; }
        
        public string? Status { get; set; }
    }
}
