using System.ComponentModel.DataAnnotations;
using Assign1PROG30000.Models.Enum;

namespace Assign1PROG30000.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; } 

        [Required]
        public string? Phone { get; set; }

        [Required]
        public EnumRole Role {get;set;}

        [Required]
        public int? DurationDays { get; set; } 

        [Required]
        public int? EquipmentId { get; set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        [Required]
        public EnumStatus Status {get;set;} = EnumStatus.Pending;
    }
}
