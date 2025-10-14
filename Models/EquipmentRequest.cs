using System.ComponentModel.DataAnnotations;

namespace Assign1PROG30000.Models
{
    public class EquipmentRequest
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public string Status { get; set; } = "";

        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Role is required.")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Please select an equipment type.")]
        [Display(Name = "Equipment Type")]
        public string? EquipmentType { get; set; }

        [Required(ErrorMessage = "Request details are required.")]
        [Display(Name = "Request Details")]
        public string? RequestDetails { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than zero.")]
        public int Duration { get; set; }

        public EquipmentRequest()
        {
            Id = _nextId++;
        }
        
        public int EquipmentId { get; set; }
    }
}