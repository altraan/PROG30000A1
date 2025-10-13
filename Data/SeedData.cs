using Assign1PROG30000.Models;
using Microsoft.EntityFrameworkCore;
using Assign1PROG30000.Models.Enum;

namespace Assign1PROG30000.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FastEquipmentContext(
                serviceProvider.GetRequiredService<DbContextOptions<FastEquipmentContext>>());
                
            // Look for any equipment.
            if (context.Equipments.Any())
            {
                return; // DB has been seeded
            }
            
            var equipment = new Equipment[]
            {
                new Equipment { Type = EnumType.Phone, Description = "Samsung S24", IsAvailable = true },
                new Equipment { Type = EnumType.Laptop, Description = "Dell XPS 15", IsAvailable = true },
                new Equipment { Type = EnumType.Tablet, Description = "Apple iPad Air", IsAvailable = false },
                new Equipment { Type = EnumType.Phone, Description = "Google Pixel 9", IsAvailable = true },
                new Equipment { Type = EnumType.Laptop, Description = "MacBook Pro 14-inch", IsAvailable = false },
                new Equipment { Type = EnumType.Another, Description = "Microsoft Surface Studio", IsAvailable = true },
            };

            context.Equipments.AddRange(equipment);
            context.SaveChanges();
        }
    }
}