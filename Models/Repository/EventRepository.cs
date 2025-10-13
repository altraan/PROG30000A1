using Microsoft.EntityFrameworkCore;

namespace Assign1PROG30000.Models.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly EventDbContext _context;
        
        public EventRepository(EventDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Event> GetAllEvents()
        {
            return _context.Events
                          .Include(e => e.Rsvps)
                          .OrderBy(e => e.EventDate)
                          .ToList();
        }
        
        public Event? GetEventById(int id)
        {
            return _context.Events
                          .Include(e => e.Rsvps)
                          .FirstOrDefault(e => e.EventId == id);
        }
        
        public void AddEvent(Event eventItem)
        {
            _context.Events.Add(eventItem);
        }
        
        public void UpdateEvent(Event eventItem)
        {
            _context.Events.Update(eventItem);
        }
        
        public void DeleteEvent(int id)
        {
            var eventItem = _context.Events.Find(id);
            if (eventItem != null)
            {
                _context.Events.Remove(eventItem);
            }
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}