namespace Assign1PROG30000.Models.Repository
{
    public interface IEquipmentRepository
    {
        IEnumerable<Equipment> GetAll();
        IEnumerable<Equipment> GetAvailable();
        Equipment? FindById(int id);       
        void Add(Equipment equipment);
        void Update(Equipment equipment);
    }
}