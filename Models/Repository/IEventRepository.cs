namespace Assign1PROG30000.Models.Repository
{
    public interface IEventRepository
    {
        IEnumerable<Event> GetAllEvents();
        Event? GetEventById(int id);
        void AddEvent(Event eventItem);
        void UpdateEvent(Event eventItem);
        void DeleteEvent(int id);
        void SaveChanges();
    }
}