using System.ComponentModel.DataAnnotations;
using Assign1PROG30000.Models.Repository;


namespace Assign1PROG30000.Models
{
    public class EquipmentRequest
    {
        public int Id { get; set; }
        public IEnumerable<Equipment?>? Equipments { get; set; }

        [Required]
        public Request Request { get; set; } = new Request();
        public string Status { get; set; } = "Pending";
        public EquipmentRequest()
    {
        Equipments = new List<Equipment>(); 
    }
    }
}