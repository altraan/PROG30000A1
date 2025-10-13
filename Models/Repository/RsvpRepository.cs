using Microsoft.EntityFrameworkCore;

namespace Assign1PROG30000.Models.Repository
{
    public class RsvpRepository : IRsvpRepository
    {
        private readonly EventDbContext _context;
        
        public RsvpRepository(EventDbContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Rsvp> GetAllRsvps()
        {
            return _context.Rsvps
                          .Include(r => r.Event)
                          .OrderBy(r => r.RsvpDate)
                          .ToList();
        }
        
        public IEnumerable<Rsvp> GetRsvpsByEventId(int eventId)
        {
            return _context.Rsvps
                          .Include(r => r.Event)
                          .Where(r => r.EventId == eventId)
                          .OrderBy(r => r.RsvpDate)
                          .ToList();
        }
        
        public Rsvp? GetRsvpById(int id)
        {
            return _context.Rsvps
                          .Include(r => r.Event)
                          .FirstOrDefault(r => r.RsvpId == id);
        }
        
        public void AddRsvp(Rsvp rsvp)
        {
            _context.Rsvps.Add(rsvp);
        }
        
        public void UpdateRsvp(Rsvp rsvp)
        {
            _context.Rsvps.Update(rsvp);
        }
        
        public void DeleteRsvp(int id)
        {
            var rsvp = _context.Rsvps.Find(id);
            if (rsvp != null)
            {
                _context.Rsvps.Remove(rsvp);
            }
        }
        
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}