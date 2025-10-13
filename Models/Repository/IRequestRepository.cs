namespace Assign1PROG30000.Models.Repository
{
    public interface IRequestRepository
    {
        IEnumerable<EquipmentRequest> GetAll();
        IEnumerable<EquipmentRequest> GetPending();
        void Add(EquipmentRequest request);
        void UpdateStatus(EquipmentRequest request);
    }
}