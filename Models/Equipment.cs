using System.ComponentModel.DataAnnotations;
using Assign1PROG30000.Models.Enum;

namespace Assign1PROG30000.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required]
        public EnumType? Type { get; set; } 

        [Required]
        public string? Description { get; set; }

        [Required]
        public bool IsAvailable { get; set; }
    }
}