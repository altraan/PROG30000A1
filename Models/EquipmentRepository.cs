using Microsoft.EntityFrameworkCore;
namespace Assign1PROG30000.Models.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly FastEquipmentContext _context;

        public EquipmentRepository(FastEquipmentContext context)
        {
            _context = context;
        }

        public IEnumerable<Equipment> GetAll()
        {
            return _context.Equipments.ToList();
        }

        public IEnumerable<Equipment> GetAvailable()
        {
            return _context.Equipments.Where(e => e.IsAvailable);
        }

        public Equipment? FindById(int id)
        {
            return _context.Equipments.Find(id);
        }

        public void Add(Equipment equipment)
        {
            _context.Equipments.Add(equipment);
            _context.SaveChanges();
        }

        public void Update(Equipment equipment)
        {
            _context.Equipments.Update(equipment);
            _context.SaveChanges();
        }
    }   
}