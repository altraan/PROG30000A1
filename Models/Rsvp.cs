using System.ComponentModel.DataAnnotations;

namespace Assign1PROG30000.Models
{
    public class Rsvp
    {
        public int RsvpId { get; set; }
        
        [Required]
        public int EventId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
        
        [Phone]
        [StringLength(20)]
        public string Phone { get; set; } = string.Empty;
        
        public DateTime RsvpDate { get; set; } = DateTime.Now;
        
        // Navigation property to related Event
        public Event? Event { get; set; }
    }
}