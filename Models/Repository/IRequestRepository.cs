namespace Assign1PROG30000.Models.Repository;
{
    puclic interface IRequestRepository
    {
        IEnumerable<Equipment> GetAll();
        IEnumerable<Equipment> GetPending();
        void Add(Equipment equipment);
        void UpdateStatus(Equipment equipment);
    }
}