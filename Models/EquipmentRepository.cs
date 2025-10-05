using System.Collections.Generic;

namespace Assign1PROG30000.Models
{
    public static class EquipmentRepository
    {
        private static List<Equipment> _equipmentList = new List<Equipment>
        {
            new Equipment { Id = 1, Type = "Laptop", Description = "Dell XPS 13", IsAvailable = true },
            new Equipment { Id = 2, Type = "Phone", Description = "iPhone 12", IsAvailable = false },
            new Equipment { Id = 3, Type = "Tablet", Description = "iPad Air", IsAvailable = true },
            new Equipment { Id = 4, Type = "Another", Description = "Wireless Keyboard", IsAvailable = true }
        };

        public static IEnumerable<Equipment> GetAll()
        {
            return _equipmentList;
        }
    }
}
