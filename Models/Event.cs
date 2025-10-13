using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assign1PROG30000.Models
{
    public class Event
    {
        public int EventId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public DateTime EventDate { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Location { get; set; } = string.Empty;
        
        [Range(1, 1000)]
        public int MaxAttendees { get; set; }
        
        // Navigation property for related RSVPs
        public List<Rsvp> Rsvps { get; set; } = new List<Rsvp>();
    }
}