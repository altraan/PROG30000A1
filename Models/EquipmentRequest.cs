using System.ComponentModel.DataAnnotations;

namespace Assign1PROG30000.Models
{
    public class EquipmentRequest
    {
        public IEnumerable<Equipment?>? Equipments {get;set;}
        public Request? Request;

    }
}